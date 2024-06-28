$(function () {
    roadObjectsTable.style.display = "block";
    new DataTable("#roadObjectsTable");
});

function createObjectOnClick() {
    objIdInput.value = null;
    modalTypeObjSelector.value = "-1";
    modalEnableJournalCheck.checked = false;
    modalRegionSelector.value = "-1";
    modalRoadSelector.value = "-1";
    modalNameObjectInput.value = null;
    modalCodeObjectInput.value = null;
    modalDateLeadIn.value = null;
    modalDateLeadOut.value = null;
    modalExplCategorySelector.value = "-1";
    modalStatusSelector.value = "-1";
    modalObjectLength.value = null;
    modalClimateZone.value = null;
    modalBridgeCard.style.display = "none";
    modalBridgeType.value = "-1";
    modalBridgeMaterial.value = "-1";
    modalBridgeBarrier.value = null;
    modalBridgeGabarit.value = null;
    modalBegKmStolb.value = null;
    modalEndKmStolb.value = null;
    modalBegKm.value = null;
    modalEndKm.value = null;
    createBtn.style.display = "inline";
    updateBtn.style.display = "none";
}

function deleteObjectOnClick(objId, model) {
    let obj = model.find((m) => m.C_OBJECT === objId);
    modalDeleteLabel.innerHTML = "Вы действительно хотите удалить объект: " + obj.CODE + " " + obj.N_OBJECT + "?";
}

function updateObjectOnClick(objId, model) {
    let obj = model.find((m) => m.C_OBJECT === objId);
    objIdInput.value = objId;
    modalTypeObjSelector.value = obj.C_TYPE_OBJECT;
    modalEnableJournalCheck.checked = obj.ENABLED_FOR_JORNAL;
    modalRegionSelector.value = obj.C_REGION;
    modalRoadSelector.value = obj.C_ROAD;
    modalNameObjectInput.value = obj.N_OBJECT;
    modalCodeObjectInput.value = obj.CODE;
    modalDateLeadIn.value = obj.DATE_LEAD_IN;
    modalDateLeadOut.value = obj.DATE_LEAD_OUT;
    modalExplCategorySelector.value = obj.C_EXPL_CATEGORY;
    modalStatusSelector.value = obj.C_STATUS_OBJECT;
    modalObjectLength.value = obj.LENGTH;
    modalClimateZone.value = obj.MP;
    if (obj.C_TYPE_OBJECT === 2) {
        modalBridgeCard.style.display = "block";
        modalBridgeType.value = obj.C_TYPE_BRIDGE;
        modalBridgeMaterial.value = obj.C_BRIDGE_MATERIAL;
        modalBridgeBarrier.value = obj.BARRIER;
        modalBridgeGabarit.value = obj.GABARIT;
    } else {
        modalBridgeCard.style.display = "none";
        modalBridgeType.value = "-1";
        modalBridgeMaterial.value = "-1";
        modalBridgeBarrier.value = "";
        modalBridgeGabarit.value = "";
    }
    modalBegKmStolb.value = obj.BEGKM_STOLB;
    modalEndKmStolb.value = obj.ENDKM_STOLB;
    modalBegKm.value = obj.BEGKM;
    modalEndKm.value = obj.ENDKM;
    createBtn.style.display = "none";
    updateBtn.style.display = "inline";
}

function modalRegionOnChange(id, model) {
    let regionId = parseInt(id.value);
    let filtered = model.filter((m) => m.C_REGION === regionId);
    let roads = filtered.map(m => [m.C_ROAD, m.NAME_ROAD]);
    let uniqueRoads = getDistinct(roads);
    removeOptions(modalRoadSelector);
    createOptions(modalRoadSelector, uniqueRoads);
    modalRoadSelector.value = "-1";

    let climatZone = filtered.map(m => [m.NAME_CLIMAT_ZONE])[0];
    modalClimateZone.value = climatZone;
}

function onChangeRegion(id, model) {
    let regionId = parseInt(id.value);
    let filtered = model;
    if (regionId > 0) {
        filtered = filtered.filter((m) => m.C_REGION === regionId);
    }
    let roads = filtered.map(m => [m.C_ROAD, m.NAME_ROAD]);
    let uniqueRoads = getDistinct(roads);
    removeOptions(roadSelector);
    createOptions(roadSelector, uniqueRoads);
    roadSelector.value = "-1";
    createTable(filtered)
}

function onChangeRoad(id, model) {
    let roadId = parseInt(id.value);
    let regionId = parseInt(regionSelector.value);
    let filterByRegion = model;
    if (regionId > 0) {
        filterByRegion = filterByRegion.filter((m) => m.C_REGION === regionId);
    }
    let filterByRoad = filterByRegion.filter((m) => m.C_ROAD === roadId);
    createTable(filterByRoad)
}

function onChangeTypeObject(id) {
    let typeId = parseInt(id.value);
    if (typeId === 2) {
        modalBridgeCard.style.display = "block";
    } else {
        modalBridgeCard.style.display = "none";
    }
}

function getDistinct(array) {
    let seen = new Set();
    let filtered = array.filter(entry => {
        const key = entry[0] + "\u0000" + entry[1];
        const keep = !seen.has(key);
        if (keep) {
            seen.add(key);
        }
        return keep;
    });
    return filtered;
}

function createOptions(selector, array) {
    array.forEach(function (element) {
        let opt = document.createElement('option');
        opt.value = element[0];
        opt.innerHTML = element[1];
        selector.appendChild(opt);
    })
}

function removeOptions(selector) {
    let options = selector.getElementsByTagName('option');
    for (let i = options.length; i--;) {
        if (options[i].value !== "-1") {
            selector.removeChild(options[i]);
        }
    }
}

function createTable(model) {
    var table = new DataTable("#roadObjectsTable");
    table.destroy();
    $("#roadObjectsTable > tbody > tr").remove();

    model.forEach(function (element) {
        let tr = roadObjectsBody.insertRow(-1);
        let tabCell = tr.insertCell(-1);
        let div = document.createElement("div");
        div.classList.add("w-75", "btn-group");
        div.role = "group";
        let btnUpdate = document.createElement("button");
        btnUpdate.classList.add("btn", "btn-primary");
        btnUpdate.setAttribute("type", "button");
        btnUpdate.setAttribute("data-bs-toggle", "modal");
        btnUpdate.setAttribute("data-bs-target", "#modalCreate");
        btnUpdate.setAttribute("onclick", "updateObjectOnClick(" + element.C_OBJECT + ", model)");
        btnUpdate.innerText = "Изм";
        div.appendChild(btnUpdate);
        let btnDelete = document.createElement("button");
        btnDelete.classList.add("btn", "btn-danger");
        btnDelete.setAttribute("type", "button");
        btnDelete.setAttribute("data-bs-toggle", "modal");
        btnDelete.setAttribute("data-bs-target", "#modalDelete");
        btnDelete.setAttribute("onclick", "deleteObjectOnClick(" + element.C_OBJECT + ", model)");
        btnDelete.innerText = "Удал";
        div.appendChild(btnDelete);
        tabCell.appendChild(div);
        tabCell = tr.insertCell(-1);
        tabCell.innerHTML = element.N_TYPE_OBJECT;
        tabCell = tr.insertCell(-1);
        tabCell.innerHTML = element.N_REGION;
        tabCell = tr.insertCell(-1);
        tabCell.innerHTML = element.N_ROAD;
        tabCell = tr.insertCell(-1);
        tabCell.innerHTML = element.N_OBJECT;
        tabCell = tr.insertCell(-1);
        tabCell.innerHTML = element.CODE;
        tabCell = tr.insertCell(-1);
        tabCell.innerHTML = element.BEGKM;
        tabCell = tr.insertCell(-1);
        tabCell.innerHTML = element.ENDKM;
        tabCell = tr.insertCell(-1);
        tabCell.innerHTML = element.N_EXPL_CATEGORY;
        tabCell = tr.insertCell(-1);
        tabCell.innerHTML = element.ENABLED_FOR_JORNAL_STR;
    })
    new DataTable("#roadObjectsTable");
}

function fillDataTable(model) {
    var table = new DataTable("#roadObjectsTable");
    table.clear().draw();

    model.forEach(function (element) {
        table.row.add({
            "инструменты": "Кнопки",
            "тип объекта": element.N_TYPE_OBJECT,
            "район": element.N_REGION,
            "автомобильная дорога": element.N_ROAD,
            "наименование объекта содержания": element.N_OBJECT,
            "код объекта": element.CODE,
            "начало, км": element.BEGKM,
            "конец, км": element.ENDKM,
            "экспл. категория": element.N_EXPL_CATEGORY,
            "в журнале": element.ENABLED_FOR_JORNAL_STR
        }).draw();
    })
}
