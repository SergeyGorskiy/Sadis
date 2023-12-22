function startPage(model) {
    let regionSelector = document.getElementById("regionSelector");
    let regions = model.map(m => [ m.C_REGION, m.N_REGION ]);
    let uniqueRegions = getDistinct(regions);
    createOptions(regionSelector, uniqueRegions)

    let roadSelector = document.getElementById("roadSelector");
    let roads = model.map(m => [m.C_ROAD, m.N_ROAD]);
    let uniqueRoads = getDistinct(roads);
    createOptions(roadSelector, uniqueRoads)
}

//document.addEventListener('DOMContentLoaded', function () {
//    let myBtn = document.getElementById('customBtn');
//    myBtn.addEventListener('click', () => {
//        console.log("работает");
//    })
//    const myModal = document.getElementById("modalCreate")
//    myModal.addEventListener('shown.bs.modal', () => {
//        console.log("видим модал");
//    })
//});

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
    fillTable(filtered)
}

function onChangeRoad(id, model) {
    let roadId = parseInt(id.value);
    let regionId = parseInt(regionSelector.value);
    let filterByRegion = model;
    if (regionId > 0) {
        filterByRegion = filterByRegion.filter((m) => m.C_REGION === regionId);
    }
    let filterByRoad = filterByRegion.filter((m) => m.C_ROAD === roadId);
    fillTable(filterByRoad)
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

function fillTable(filteredModel) {
    $('#roadObjectsTable > tbody > tr').remove();
    filteredModel.forEach(function (element) {
        let tr = roadObjectsBody.insertRow(-1);
        let tabCell = tr.insertCell(-1);
        tabCell.innerHTML =
            '<div class="w-75 btn-group" role="group">'
               +'<a asp-area="Operator" asp-controller="RoadObjects" asp-action="Edit" asp-route-id="@obj.C_OBJECT" class="btn btn-primary mx-2">Изм</a>'
               +'<a asp-area="Operator" asp-controller="RoadObjects" asp-action="Delete" asp-route-id="@obj.C_OBJECT" class="btn btn-danger mx-2">Удал</a>'
            +'</div>';
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
}
