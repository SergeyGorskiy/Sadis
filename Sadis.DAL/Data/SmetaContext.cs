using Microsoft.EntityFrameworkCore;
using Sadis.Entities.Models;

namespace Sadis.DAL.Data;

public class SmetaContext : DbContext
{
    public SmetaContext(DbContextOptions<SmetaContext> options) : base(options)
    {}

    public DbSet<DAct> DActs { get; set; }

    public DbSet<DActDocument> DActDocuments { get; set; }

    public DbSet<DActPlan> DActPlans { get; set; }

    public DbSet<DActRegistration> DActRegistrations { get; set; }

    public DbSet<DActRegistrationFile> DActRegistrationFiles { get; set; }

    public DbSet<DActSanction> DActSanctions { get; set; }

    public DbSet<DActSanctionDetail> DActSanctionDetails { get; set; }

    public DbSet<DApiToken> DApiTokens { get; set; }

    public DbSet<DComment> DComments { get; set; }

    public DbSet<DContract> DContracts { get; set; }

    public DbSet<DContractor> DContractors { get; set; }

    public DbSet<DContractorDetail> DContractorDetails { get; set; }

    public DbSet<DContractorRegion> DContractorRegions { get; set; }

    public DbSet<DDefect> DDefects { get; set; }

    public DbSet<DDeflator> DDeflators { get; set; }

    public DbSet<DDeflatorUser> DDeflatorUsers { get; set; }

    public DbSet<DDevice> DDevices { get; set; }

    public DbSet<DDeviceSession> DDeviceSessions { get; set; }

    public DbSet<DDopcontract> DDopcontracts { get; set; }

    public DbSet<DGeneralContract> DGeneralContracts { get; set; }

    public DbSet<DGeneralContractor> DGeneralContractors { get; set; }

    public DbSet<DGp> DGps { get; set; }

    public DbSet<DHistoryChange> DHistoryChanges { get; set; }

    public DbSet<DJournal> DJournals { get; set; }

    public DbSet<DJournalConnection> DJournalConnections { get; set; }

    public DbSet<DJournalDetail> DJournalDetails { get; set; }

    public DbSet<DJournalImage> DJournalImages { get; set; }

    public DbSet<DJournalMessage> DJournalMessages { get; set; }

    public DbSet<DJournalVehicle> DJournalVehicles { get; set; }

    public DbSet<DJournalWebApi> DJournalWebApis { get; set; }

    public DbSet<DMaker> DMakers { get; set; }

    public DbSet<DMonth> DMonths { get; set; }

    public DbSet<DNakrutki> DNakrutkis { get; set; }

    public DbSet<DObject> DObjects { get; set; }

    public DbSet<DObjectContract> DObjectContracts { get; set; }

    public DbSet<DObjectElement> DObjectElements { get; set; }

    public DbSet<DObjectHistory> DObjectHistories { get; set; }

    public DbSet<DObjectKurator> DObjectKurators { get; set; }

    public DbSet<DObjectTypePokr> DObjectTypePokrs { get; set; }

    public DbSet<DOverwork> DOverworks { get; set; }

    public DbSet<DOverworkDetail> DOverworkDetails { get; set; }

    public DbSet<DReportTemplate> DReportTemplates { get; set; }

    public DbSet<DRoad> DRoads { get; set; }

    public DbSet<DSubcontractor> DSubcontractors { get; set; }

    public DbSet<DSubcontractorWork> DSubcontractorWorks { get; set; }

    public DbSet<DVirtualObject> DVirtualObjects { get; set; }

    public DbSet<DVirtualObjectContract> DVirtualObjectContracts { get; set; }

    public DbSet<DVirtualObjectCost> DVirtualObjectCosts { get; set; }

    public DbSet<DVirtualObjectMonth> DVirtualObjectMonths { get; set; }

    public DbSet<DVirtualObjectWork> DVirtualObjectWorks { get; set; }

    public DbSet<DVirtualWorkCost> DVirtualWorkCosts { get; set; }

    public DbSet<DWeather> DWeathers { get; set; }

    public DbSet<DWeatherSession> DWeatherSessions { get; set; }

    public DbSet<DWebinar> DWebinars { get; set; }

    public DbSet<DWorkElement> DWorkElements { get; set; }

    public DbSet<DWorkWork> DWorkWorks { get; set; }

    public DbSet<Entities.Models.Object> Objects { get; set; }

    public DbSet<Pp> Pps { get; set; }

    public DbSet<Road> Roads { get; set; }

    public DbSet<SBridgeMaterial> SBridgeMaterials { get; set; }

    public DbSet<SCiclic> SCiclics { get; set; }

    public DbSet<SCiclicDetail> SCiclicDetails { get; set; }

    public DbSet<SClimatZone> SClimatZones { get; set; }

    public DbSet<SElement> SElements { get; set; }

    public DbSet<SExplCategory> SExplCategories { get; set; }

    public DbSet<SOkrug> SOkrugs { get; set; }

    public DbSet<SRegion> SRegions { get; set; }

    public DbSet<SResMachinist> SResMachinists { get; set; }

    public DbSet<SResMaterial> SResMaterials { get; set; }

    public DbSet<SResMechanism> SResMechanisms { get; set; }

    public DbSet<SResWorker> SResWorkers { get; set; }

    public DbSet<SSanction> SSanctions { get; set; }

    public DbSet<SSanctionElement> SSanctionElements { get; set; }

    public DbSet<SSanctionGroup> SSanctionGroups { get; set; }

    public DbSet<SSeason> SSeasons { get; set; }

    public DbSet<SStatusObject> SStatusObjects { get; set; }

    public DbSet<STypeBlock> STypeBlocks { get; set; }

    public DbSet<STypeBridge> STypeBridges { get; set; }

    public DbSet<STypeElement> STypeElements { get; set; }

    public DbSet<STypeMessage> STypeMessages { get; set; }

    public DbSet<STypeObject> STypeObjects { get; set; }

    public DbSet<STypePokr> STypePokrs { get; set; }

    public DbSet<SUnit> SUnits { get; set; }

    public DbSet<SWork> SWorks { get; set; }

    public DbSet<SWorkDetail> SWorkDetails { get; set; }

    public DbSet<SWorkGroup> SWorkGroups { get; set; }

    public DbSet<SWorkKind> SWorkKinds { get; set; }

    public DbSet<SWorkResMachinist> SWorkResMachinists { get; set; }

    public DbSet<SWorkResMaterial> SWorkResMaterials { get; set; }

    public DbSet<SWorkResMechanism> SWorkResMechanisms { get; set; }

    public DbSet<SWorkResWorker> SWorkResWorkers { get; set; }

    public DbSet<TablesApplication> TablesApplications { get; set; }

    public DbSet<TablesFieldType> TablesFieldTypes { get; set; }

    public DbSet<TablesInfo> TablesInfos { get; set; }

    public DbSet<TablesList> TablesLists { get; set; }

    public DbSet<TablesLog> TablesLogs { get; set; }

    public DbSet<TablesNews> TablesNews { get; set; }

    public DbSet<TablesParam> TablesParams { get; set; }

    public DbSet<TablesReport> TablesReports { get; set; }

    public DbSet<TablesReportsDetail> TablesReportsDetails { get; set; }

    public DbSet<TablesRole> TablesRoles { get; set; }

    public DbSet<TablesSetting> TablesSettings { get; set; }

    public DbSet<TablesType> TablesTypes { get; set; }

    public DbSet<TablesUpdate> TablesUpdates { get; set; }

    public DbSet<TablesUser> TablesUsers { get; set; }

    public DbSet<TempForDelete> TempForDeletes { get; set; }

    public DbSet<TempObject> TempObjects { get; set; }

    public DbSet<TempSelectedObject> TempSelectedObjects { get; set; }

    public DbSet<TempSmetaPlan> TempSmetaPlans { get; set; }

    public DbSet<TempSmetum> TempSmeta { get; set; }

    public DbSet<TempWork> TempWorks { get; set; }

    public DbSet<TempWorks2> TempWorks2s { get; set; }

    public DbSet<TestReportAnalisy> TestReportAnalisys { get; set; }

    public DbSet<TestReportResult> TestReportResults { get; set; }

    public DbSet<ViewAct> ViewActs { get; set; }

    public DbSet<ViewObject> ViewObjects { get; set; }

    public DbSet<ViewObjectElement> ViewObjectElements { get; set; }

    public DbSet<ViewObjectElementGroup> ViewObjectElementGroups { get; set; }

    public DbSet<ViewObjectJournal> ViewObjectJournals { get; set; }

    public DbSet<ViewRoadByContract> ViewRoadByContracts { get; set; }

    public DbSet<ViewRoadJournal> ViewRoadJournals { get; set; }

}
