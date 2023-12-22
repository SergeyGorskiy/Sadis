using Microsoft.EntityFrameworkCore;
using Sadis.Entities.Models;

namespace Sadis.DAL.Data;

public class SmetaContext : DbContext
{
    public SmetaContext(DbContextOptions<SmetaContext> options) : base(options) {}

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


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DAct>(entity =>
        {
            entity.HasKey(e => e.CAct);

            entity.ToTable("D_ACT");

            entity.HasIndex(e => e.CContract, "INDEX_D_ACT_C_CONTRACT");

            entity.Property(e => e.CAct).HasColumnName("C_ACT");
            entity.Property(e => e.CContract).HasColumnName("C_CONTRACT");
            entity.Property(e => e.CMonth).HasColumnName("C_MONTH");
            entity.Property(e => e.DateAct)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_ACT");
            entity.Property(e => e.DateBegin)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_BEGIN");
            entity.Property(e => e.DateCreate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATE");
            entity.Property(e => e.DateEnd)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_END");
            entity.Property(e => e.DateUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_UPDATE");
            entity.Property(e => e.NAct)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("N_ACT");
            entity.Property(e => e.Number)
                .HasDefaultValueSql("((1))")
                .HasColumnName("NUMBER");

            entity.HasOne(d => d.CContractNavigation).WithMany(p => p.DActs)
                .HasForeignKey(d => d.CContract)
                .HasConstraintName("FK_D_ACT_D_CONTRACT");

            entity.HasOne(d => d.CMonthNavigation).WithMany(p => p.DActs)
                .HasForeignKey(d => d.CMonth)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_ACT_D_MONTH");
        });

        modelBuilder.Entity<DActDocument>(entity =>
        {
            entity.HasKey(e => e.CActDocument).HasName("PK__D_ACT_DO__675C25ED11F56A37");

            entity.ToTable("D_ACT_DOCUMENT");

            entity.Property(e => e.CActDocument).HasColumnName("C_ACT_DOCUMENT");
            entity.Property(e => e.ActSum).HasColumnName("ACT_SUM");
            entity.Property(e => e.CAct).HasColumnName("C_ACT");
            entity.Property(e => e.CUser).HasColumnName("C_USER");
            entity.Property(e => e.DateCreate)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATE");
            entity.Property(e => e.DateUpdate)
                .HasColumnType("datetime")
                .HasColumnName("DATE_UPDATE");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<DActPlan>(entity =>
        {
            entity.HasKey(e => e.CActPlan);

            entity.ToTable("D_ACT_PLAN");

            entity.Property(e => e.CActPlan).HasColumnName("C_ACT_PLAN");
            entity.Property(e => e.CAct).HasColumnName("C_ACT");
            entity.Property(e => e.Cost).HasColumnName("COST");
            entity.Property(e => e.DateCreate)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATE");
            entity.Property(e => e.DateUpdate)
                .HasColumnType("datetime")
                .HasColumnName("DATE_UPDATE");

            entity.HasOne(d => d.CActNavigation).WithMany(p => p.DActPlans)
                .HasForeignKey(d => d.CAct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_ACT_PLAN_D_ACT");
        });

        modelBuilder.Entity<DActRegistration>(entity =>
        {
            entity.HasKey(e => e.CActRegistration);

            entity.ToTable("D_ACT_REGISTRATION");

            entity.Property(e => e.CActRegistration).HasColumnName("C_ACT_REGISTRATION");
            entity.Property(e => e.CAct).HasColumnName("C_ACT");
            entity.Property(e => e.CUser).HasColumnName("C_USER");
            entity.Property(e => e.DateRegistration)
                .HasColumnType("datetime")
                .HasColumnName("DATE_REGISTRATION");
            entity.Property(e => e.IsRegistration).HasColumnName("IS_REGISTRATION");
            entity.Property(e => e.UserDisplayName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("USER_DISPLAY_NAME");

            entity.HasOne(d => d.CActNavigation).WithMany(p => p.DActRegistrations)
                .HasForeignKey(d => d.CAct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_ACT_REGISTRATION_D_ACT");
        });

        modelBuilder.Entity<DActRegistrationFile>(entity =>
        {
            entity.HasKey(e => e.CActRegistrationFile);

            entity.ToTable("D_ACT_REGISTRATION_FILE");

            entity.Property(e => e.CActRegistrationFile).HasColumnName("C_ACT_REGISTRATION_FILE");
            entity.Property(e => e.CAct).HasColumnName("C_ACT");
            entity.Property(e => e.CUser).HasColumnName("C_USER");
            entity.Property(e => e.ContentLengthKb).HasColumnName("CONTENT_LENGTH_KB");
            entity.Property(e => e.ServerFileName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SERVER_FILE_NAME");
            entity.Property(e => e.ServerFilePath)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("SERVER_FILE_PATH");
            entity.Property(e => e.UploadedFileName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UPLOADED_FILE_NAME");
            entity.Property(e => e.UserDisplayName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("USER_DISPLAY_NAME");

            entity.HasOne(d => d.CActNavigation).WithMany(p => p.DActRegistrationFiles)
                .HasForeignKey(d => d.CAct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_ACT_REGISTRATION_FILE_D_ACT");
        });

        modelBuilder.Entity<DActSanction>(entity =>
        {
            entity.HasKey(e => e.CActSanction);

            entity.ToTable("D_ACT_SANCTION");

            entity.Property(e => e.CActSanction).HasColumnName("C_ACT_SANCTION");
            entity.Property(e => e.CAct).HasColumnName("C_ACT");
            entity.Property(e => e.CUser).HasColumnName("C_USER");
            entity.Property(e => e.DateCreate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATE");
            entity.Property(e => e.DateUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_UPDATE");
            entity.Property(e => e.NActSanction)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("N_ACT_SANCTION");
            entity.Property(e => e.UserDisplayName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("USER_DISPLAY_NAME");

            entity.HasOne(d => d.CActNavigation).WithMany(p => p.DActSanctions)
                .HasForeignKey(d => d.CAct)
                .HasConstraintName("FK_D_ACT_SANCTION_D_ACT");
        });

        modelBuilder.Entity<DActSanctionDetail>(entity =>
        {
            entity.HasKey(e => e.CDetail);

            entity.ToTable("D_ACT_SANCTION_DETAIL", tb =>
            {
                tb.HasTrigger("TRIG_INS_D_ACT_SANCTION_DETAIL");
                tb.HasTrigger("TR_DELETE_ACT_SANCTION_DETAIL");
            });

            entity.HasIndex(e => e.AisSanctionId, "D_ACT_SANCTION_DETAIL_INDEX");

            entity.Property(e => e.CDetail).HasColumnName("C_DETAIL");
            entity.Property(e => e.AisAmount)
                .HasDefaultValueSql("((1))")
                .HasColumnName("AIS_AMOUNT");
            entity.Property(e => e.AisSanctionId).HasColumnName("AIS_SANCTION_ID");
            entity.Property(e => e.CActSanction).HasColumnName("C_ACT_SANCTION");
            entity.Property(e => e.CDefect).HasColumnName("C_DEFECT");
            entity.Property(e => e.CKurator).HasColumnName("C_KURATOR");
            entity.Property(e => e.CObject).HasColumnName("C_OBJECT");
            entity.Property(e => e.CObjectElement).HasColumnName("C_OBJECT_ELEMENT");
            entity.Property(e => e.CSanction).HasColumnName("C_SANCTION");
            entity.Property(e => e.DateCreate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATE");
            entity.Property(e => e.DateUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_UPDATE");
            entity.Property(e => e.KuratorName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("KURATOR_NAME");
            entity.Property(e => e.NomerPred)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMER_PRED");
            entity.Property(e => e.SanctionComments)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("SANCTION_COMMENTS");
            entity.Property(e => e.SanctionValue).HasColumnName("SANCTION_VALUE");

            entity.HasOne(d => d.CDefectNavigation).WithMany(p => p.DActSanctionDetails)
                .HasForeignKey(d => d.CDefect)
                .HasConstraintName("FK_D_ACT_SANCTION_DETAIL_D_DEFECT");

            entity.HasOne(d => d.CObjectNavigation).WithMany(p => p.DActSanctionDetails)
                .HasForeignKey(d => d.CObject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_ACT_SANCTION_DETAIL_D_OBJECT");

            entity.HasOne(d => d.CObjectElementNavigation).WithMany(p => p.DActSanctionDetails)
                .HasForeignKey(d => d.CObjectElement)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_D_ACT_SANCTION_DETAIL_D_OBJECT_ELEMENT");

            entity.HasOne(d => d.CSanctionNavigation).WithMany(p => p.DActSanctionDetails)
                .HasForeignKey(d => d.CSanction)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_ACT_SANCTION_DETAIL_S_SANCTION");
        });

        modelBuilder.Entity<DApiToken>(entity =>
        {
            entity.HasKey(e => e.CApiToken);

            entity.ToTable("D_API_TOKEN");

            entity.Property(e => e.CApiToken)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("C_API_TOKEN");
            entity.Property(e => e.CContractor).HasColumnName("C_CONTRACTOR");
            entity.Property(e => e.CUser).HasColumnName("C_USER");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(36)
                .HasColumnName("DEVICE_ID");
            entity.Property(e => e.EntityContracts)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ENTITY_CONTRACTS");
            entity.Property(e => e.EntityElements)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ENTITY_ELEMENTS");
            entity.Property(e => e.EntityGps)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ENTITY_GPS");
            entity.Property(e => e.EntityMakers)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ENTITY_MAKERS");
            entity.Property(e => e.EntityObjectElements)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ENTITY_OBJECT_ELEMENTS");
            entity.Property(e => e.EntityObjects)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ENTITY_OBJECTS");
            entity.Property(e => e.EntityRoads)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ENTITY_ROADS");
            entity.Property(e => e.EntityUnits)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ENTITY_UNITS");
            entity.Property(e => e.EntityWorks)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ENTITY_WORKS");
            entity.Property(e => e.LastActivity)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("LAST_ACTIVITY");

            entity.HasOne(d => d.CContractorNavigation).WithMany(p => p.DApiTokens)
                .HasForeignKey(d => d.CContractor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_API_TOKEN_D_CONTRACTOR");
        });

        modelBuilder.Entity<DComment>(entity =>
        {
            entity.HasKey(e => e.CComment).HasName("PK__D_COMMEN__C67F2D2A1506E10C");

            entity.ToTable("D_COMMENT");

            entity.Property(e => e.CComment).HasColumnName("C_COMMENT");
            entity.Property(e => e.CommentKurator)
                .IsUnicode(false)
                .HasColumnName("COMMENT_KURATOR");
            entity.Property(e => e.CommentUser)
                .IsUnicode(false)
                .HasColumnName("COMMENT_USER");
            entity.Property(e => e.DateCreate)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATE");
            entity.Property(e => e.DateUpdate)
                .HasColumnType("datetime")
                .HasColumnName("DATE_UPDATE");
        });

        modelBuilder.Entity<DContract>(entity =>
        {
            entity.HasKey(e => e.CContract);

            entity.ToTable("D_CONTRACT", tb =>
            {
                tb.HasTrigger("TRIG_INS_D_CONTRACT");
                tb.HasTrigger("TR_WEB_API_D_CONTRACT");
            });

            entity.HasIndex(e => new { e.CContractor, e.CGeneralContract }, "IX_D_CONTRACT");

            entity.Property(e => e.CContract).HasColumnName("C_CONTRACT");
            entity.Property(e => e.CContractor).HasColumnName("C_CONTRACTOR");
            entity.Property(e => e.CGeneralContract).HasColumnName("C_GENERAL_CONTRACT");
            entity.Property(e => e.CTypeBlock).HasColumnName("C_TYPE_BLOCK");
            entity.Property(e => e.DayCanRedactJournal)
                .HasDefaultValueSql("((5))")
                .HasColumnName("DAY_CAN_REDACT_JOURNAL");
            entity.Property(e => e.Deflator).HasColumnName("DEFLATOR");
            entity.Property(e => e.NBlock)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("N_BLOCK");
            entity.Property(e => e.NBlockUser)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("N_BLOCK_USER");
            entity.Property(e => e.NContract)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("N_CONTRACT");
            entity.Property(e => e.NContractUser)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("N_CONTRACT_USER");
            entity.Property(e => e.UniqueValue)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UNIQUE_VALUE");

            entity.HasOne(d => d.CContractorNavigation).WithMany(p => p.DContracts)
                .HasForeignKey(d => d.CContractor)
                .HasConstraintName("FK_D_CONTRACT_D_CONTRACTOR");

            entity.HasOne(d => d.CGeneralContractNavigation).WithMany(p => p.DContracts)
                .HasForeignKey(d => d.CGeneralContract)
                .HasConstraintName("FK_D_CONTRACT_D_GENERAL_CONTRACT");
        });

        modelBuilder.Entity<DContractor>(entity =>
        {
            entity.HasKey(e => e.CContractor);

            entity.ToTable("D_CONTRACTOR");

            entity.Property(e => e.CContractor).HasColumnName("C_CONTRACTOR");
            entity.Property(e => e.AicContractor).HasColumnName("AIC_CONTRACTOR");
            entity.Property(e => e.Coef).HasColumnName("COEF");
            entity.Property(e => e.Department)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.EnabledDocExcel).HasColumnName("ENABLED_DOC_EXCEL");
            entity.Property(e => e.GeneratedUserId).HasColumnName("GENERATED_USER_ID");
            entity.Property(e => e.NContractor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("N_CONTRACTOR");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Nds).HasColumnName("NDS");
            entity.Property(e => e.Patronymic)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PATRONYMIC");
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PHONE");
            entity.Property(e => e.Post)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("POST");
            entity.Property(e => e.ReportExcel)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("REPORT_EXCEL");
            entity.Property(e => e.Surname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SURNAME");
        });

        modelBuilder.Entity<DContractorDetail>(entity =>
        {
            entity.HasKey(e => e.CContractorDetail);

            entity.ToTable("D_CONTRACTOR_DETAIL");

            entity.Property(e => e.CContractorDetail).HasColumnName("C_CONTRACTOR_DETAIL");
            entity.Property(e => e.CContractor).HasColumnName("C_CONTRACTOR");
            entity.Property(e => e.UniqueValue).HasColumnName("UNIQUE_VALUE");

            entity.HasOne(d => d.CContractorNavigation).WithMany(p => p.DContractorDetails)
                .HasForeignKey(d => d.CContractor)
                .HasConstraintName("FK_D_CONTRACTOR_DETAIL_D_CONTRACTOR");
        });

        modelBuilder.Entity<DContractorRegion>(entity =>
        {
            entity.HasKey(e => e.CContractorRegion);

            entity.ToTable("D_CONTRACTOR_REGION");

            entity.Property(e => e.CContractorRegion).HasColumnName("C_CONTRACTOR_REGION");
            entity.Property(e => e.CContractor).HasColumnName("C_CONTRACTOR");
            entity.Property(e => e.CRegion).HasColumnName("C_REGION");
            entity.Property(e => e.UniqueValue).HasColumnName("UNIQUE_VALUE");

            entity.HasOne(d => d.CContractorNavigation).WithMany(p => p.DContractorRegions)
                .HasForeignKey(d => d.CContractor)
                .HasConstraintName("FK_D_CONTRACTOR_REGION_D_CONTRACTOR");

            entity.HasOne(d => d.CRegionNavigation).WithMany(p => p.DContractorRegions)
                .HasForeignKey(d => d.CRegion)
                .HasConstraintName("FK_D_CONTRACTOR_REGION_S_REGION");
        });

        modelBuilder.Entity<DDefect>(entity =>
        {
            entity.HasKey(e => e.CDefect).HasName("PK_C_DEVICE");

            entity.ToTable("D_DEFECT", tb => tb.HasTrigger("TR_DELETE_DEFECT"));

            entity.Property(e => e.CDefect)
                .ValueGeneratedNever()
                .HasColumnName("C_DEFECT");
            entity.Property(e => e.Begkm).HasColumnName("BEGKM");
            entity.Property(e => e.CDeviceSession).HasColumnName("C_DEVICE_SESSION");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("DATE");
            entity.Property(e => e.DateCreate)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATE");
            entity.Property(e => e.Endkm).HasColumnName("ENDKM");
            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ERROR_MESSAGE");
            entity.Property(e => e.Group).HasColumnName("GROUP");
            entity.Property(e => e.IsLinked).HasColumnName("IS_LINKED");
            entity.Property(e => e.Type).HasColumnName("TYPE");

            entity.HasOne(d => d.CDeviceSessionNavigation).WithMany(p => p.DDefects)
                .HasForeignKey(d => d.CDeviceSession)
                .HasConstraintName("FK_D_DEFECT_D_DEVICE_SESSION");
        });

        modelBuilder.Entity<DDeflator>(entity =>
        {
            entity.HasKey(e => e.CDeflator);

            entity.ToTable("D_DEFLATOR");

            entity.HasIndex(e => new { e.Year, e.CContract }, "IX_D_DEFLATOR").IsUnique();

            entity.Property(e => e.CDeflator).HasColumnName("C_DEFLATOR");
            entity.Property(e => e.CContract).HasColumnName("C_CONTRACT");
            entity.Property(e => e.Deflator)
                .HasDefaultValueSql("((1))")
                .HasColumnName("DEFLATOR");
            entity.Property(e => e.Year).HasColumnName("YEAR");

            entity.HasOne(d => d.CContractNavigation).WithMany(p => p.DDeflators)
                .HasForeignKey(d => d.CContract)
                .HasConstraintName("FK_D_DEFLATOR_D_GENERAL_CONTRACT");
        });

        modelBuilder.Entity<DDeflatorUser>(entity =>
        {
            entity.HasKey(e => e.CDeflatorUser);

            entity.ToTable("D_DEFLATOR_USER");

            entity.Property(e => e.CDeflatorUser).HasColumnName("C_DEFLATOR_USER");
            entity.Property(e => e.CContract).HasColumnName("C_CONTRACT");
            entity.Property(e => e.Deflator)
                .HasDefaultValueSql("((1))")
                .HasColumnName("DEFLATOR");
            entity.Property(e => e.Year).HasColumnName("YEAR");

            entity.HasOne(d => d.CContractNavigation).WithMany(p => p.DDeflatorUsers)
                .HasForeignKey(d => d.CContract)
                .HasConstraintName("FK_D_DEFLATOR_USER_D_CONTRACT");
        });

        modelBuilder.Entity<DDevice>(entity =>
        {
            entity.HasKey(e => e.CDevice);

            entity.ToTable("D_DEVICE");

            entity.Property(e => e.CDevice)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("C_DEVICE");
            entity.Property(e => e.CUser).HasColumnName("C_USER");
        });

        modelBuilder.Entity<DDeviceSession>(entity =>
        {
            entity.HasKey(e => e.CDeviceSession);

            entity.ToTable("D_DEVICE_SESSION");

            entity.Property(e => e.CDeviceSession)
                .ValueGeneratedNever()
                .HasColumnName("C_DEVICE_SESSION");
            entity.Property(e => e.CDevice)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("C_DEVICE");
            entity.Property(e => e.CRoad).HasColumnName("C_ROAD");
            entity.Property(e => e.DateEnd)
                .HasColumnType("datetime")
                .HasColumnName("DATE_END");
            entity.Property(e => e.DateStart)
                .HasColumnType("datetime")
                .HasColumnName("DATE_START");
            entity.Property(e => e.Json)
                .IsUnicode(false)
                .HasColumnName("JSON");

            entity.HasOne(d => d.CDeviceNavigation).WithMany(p => p.DDeviceSessions)
                .HasForeignKey(d => d.CDevice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_DEVICE_SESSION_D_DEVICE");

            entity.HasOne(d => d.CRoadNavigation).WithMany(p => p.DDeviceSessions)
                .HasForeignKey(d => d.CRoad)
                .HasConstraintName("FK_D_DEVICE_SESSION_D_ROAD");
        });

        modelBuilder.Entity<DDopcontract>(entity =>
        {
            entity.HasKey(e => e.CDopcontract).HasName("PK__D_DOPCON__E149EC6B1360266A");

            entity.ToTable("D_DOPCONTRACT");

            entity.Property(e => e.CDopcontract).HasColumnName("C_DOPCONTRACT");
            entity.Property(e => e.CContract).HasColumnName("C_CONTRACT");
            entity.Property(e => e.CContractDel).HasColumnName("C_CONTRACT_DEL");
            entity.Property(e => e.CContractOld).HasColumnName("C_CONTRACT_OLD");
            entity.Property(e => e.CDopcontractOld).HasColumnName("C_DOPCONTRACT_OLD");
            entity.Property(e => e.DateBegin)
                .HasColumnType("date")
                .HasColumnName("DATE_BEGIN");
            entity.Property(e => e.DateCreate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATE");
            entity.Property(e => e.DateEnd)
                .HasColumnType("date")
                .HasColumnName("DATE_END");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.NDopcontract)
                .IsUnicode(false)
                .HasColumnName("N_DOPCONTRACT");
            entity.Property(e => e.Number)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NUMBER");
        });

        modelBuilder.Entity<DGeneralContract>(entity =>
        {
            entity.HasKey(e => e.CGeneralContract).HasName("PK_D_GENERAL_CONTRACT_1");

            entity.ToTable("D_GENERAL_CONTRACT");

            entity.Property(e => e.CGeneralContract).HasColumnName("C_GENERAL_CONTRACT");
            entity.Property(e => e.CGeneralContractor).HasColumnName("C_GENERAL_CONTRACTOR");
            entity.Property(e => e.CMonthBegin).HasColumnName("C_MONTH_BEGIN");
            entity.Property(e => e.CMonthEnd).HasColumnName("C_MONTH_END");
            entity.Property(e => e.DateBegin)
                .HasColumnType("datetime")
                .HasColumnName("DATE_BEGIN");
            entity.Property(e => e.DeflatorMode).HasColumnName("DEFLATOR_MODE");
            entity.Property(e => e.NGeneralContract)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("N_GENERAL_CONTRACT");
            entity.Property(e => e.Number)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NUMBER");

            entity.HasOne(d => d.CGeneralContractorNavigation).WithMany(p => p.DGeneralContracts)
                .HasForeignKey(d => d.CGeneralContractor)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_D_GENERAL_CONTRACT_D_GENERAL_CONTRACTOR");

            entity.HasOne(d => d.CMonthBeginNavigation).WithMany(p => p.DGeneralContractCMonthBeginNavigations)
                .HasForeignKey(d => d.CMonthBegin)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_GENERAL_CONTRACT_D_MONTH_BEGIN");

            entity.HasOne(d => d.CMonthEndNavigation).WithMany(p => p.DGeneralContractCMonthEndNavigations)
                .HasForeignKey(d => d.CMonthEnd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_GENERAL_CONTRACT_D_MONTH_END");
        });

        modelBuilder.Entity<DGeneralContractor>(entity =>
        {
            entity.HasKey(e => e.CGeneralContractor);

            entity.ToTable("D_GENERAL_CONTRACTOR");

            entity.Property(e => e.CGeneralContractor).HasColumnName("C_GENERAL_CONTRACTOR");
            entity.Property(e => e.CContractor).HasColumnName("C_CONTRACTOR");
            entity.Property(e => e.Department)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.NGeneralContractor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("N_GENERAL_CONTRACTOR");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Nds).HasColumnName("NDS");
            entity.Property(e => e.Patronymic)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PATRONYMIC");
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PHONE");
            entity.Property(e => e.Post)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("POST");
            entity.Property(e => e.Surname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SURNAME");

            entity.HasOne(d => d.CContractorNavigation).WithMany(p => p.DGeneralContractors)
                .HasForeignKey(d => d.CContractor)
                .HasConstraintName("FK_D_GENERAL_CONTRACTOR_D_CONTRACTOR");
        });

        modelBuilder.Entity<DGp>(entity =>
        {
            entity.HasKey(e => e.CGps);

            entity.ToTable("D_GPS");

            entity.HasIndex(e => e.CRoad, "INDEX_GPS");

            entity.Property(e => e.CGps)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("C_GPS");
            entity.Property(e => e.CRoad).HasColumnName("C_ROAD");
            entity.Property(e => e.Course).HasColumnName("COURSE");
            entity.Property(e => e.Goodness).HasColumnName("GOODNESS");
            entity.Property(e => e.Height).HasColumnName("HEIGHT");
            entity.Property(e => e.Km).HasColumnName("KM");

            entity.HasOne(d => d.CRoadNavigation).WithMany(p => p.DGps)
                .HasForeignKey(d => d.CRoad)
                .HasConstraintName("FK_D_GPS_D_ROAD");
        });

        modelBuilder.Entity<DHistoryChange>(entity =>
        {
            entity.HasKey(e => e.CHistoryChange);

            entity.ToTable("D_HISTORY_CHANGE");

            entity.Property(e => e.CHistoryChange).HasColumnName("C_HISTORY_CHANGE");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("DATE");
            entity.Property(e => e.DateCreate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATE");
            entity.Property(e => e.ShowOnLoginPage).HasColumnName("SHOW_ON_LOGIN_PAGE");
            entity.Property(e => e.Text).HasColumnName("TEXT");
        });

        modelBuilder.Entity<DJournal>(entity =>
        {
            entity.HasKey(e => e.CJournal);

            entity.ToTable("D_JOURNAL", tb =>
            {
                tb.HasTrigger("TRIG_INS_D_JOURNAL");
                tb.HasTrigger("TRIG_UPD_JOURNAL");
            });

            entity.HasIndex(e => e.CAct, "D_JOURNAL_INDEX_ACT");

            entity.HasIndex(e => new { e.CObjectContract, e.Date }, "INDEX_JOURNAL");

            entity.HasIndex(e => e.Date, "INDEX_JOURNAL_DATE");

            entity.HasIndex(e => e.CAct, "INDEX_JOURNAL_DATE_ACT");

            entity.HasIndex(e => e.ControlledCAct, "INDEX_JOURNAL_DATE_CONTROLLED_ACT");

            entity.HasIndex(e => new { e.CObjectElement, e.CWork }, "INDEX_JOURNAL_OBJECT_ELEMENT_WORK");

            entity.Property(e => e.CJournal).HasColumnName("C_JOURNAL");
            entity.Property(e => e.AisTemperature).HasColumnName("AIS_TEMPERATURE");
            entity.Property(e => e.Begkm).HasColumnName("BEGKM");
            entity.Property(e => e.CAct).HasColumnName("C_ACT");
            entity.Property(e => e.CComment).HasColumnName("C_COMMENT");
            entity.Property(e => e.CKurator).HasColumnName("C_KURATOR");
            entity.Property(e => e.CMaker).HasColumnName("C_MAKER");
            entity.Property(e => e.CMonth).HasColumnName("C_MONTH");
            entity.Property(e => e.CObjectContract).HasColumnName("C_OBJECT_CONTRACT");
            entity.Property(e => e.CObjectElement).HasColumnName("C_OBJECT_ELEMENT");
            entity.Property(e => e.COverworkDetail).HasColumnName("C_OVERWORK_DETAIL");
            entity.Property(e => e.CUser).HasColumnName("C_USER");
            entity.Property(e => e.CWeather).HasColumnName("C_WEATHER");
            entity.Property(e => e.CWork).HasColumnName("C_WORK");
            entity.Property(e => e.CWorkType).HasColumnName("C_WORK_TYPE");
            entity.Property(e => e.ControlledCAct).HasColumnName("CONTROLLED_C_ACT");
            entity.Property(e => e.CostoneworkNow)
                .HasDefaultValueSql("((0))")
                .HasColumnName("COSTONEWORK_NOW");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("DATE");
            entity.Property(e => e.DateCreate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATE");
            entity.Property(e => e.DateUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_UPDATE");
            entity.Property(e => e.Endkm).HasColumnName("ENDKM");
            entity.Property(e => e.FotValueNow)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FOT_VALUE_NOW");
            entity.Property(e => e.IsAis).HasColumnName("IS_AIS");
            entity.Property(e => e.IsControlled).HasColumnName("IS_CONTROLLED");
            entity.Property(e => e.IsDenied).HasColumnName("IS_DENIED");
            entity.Property(e => e.KuratorName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("KURATOR_NAME");
            entity.Property(e => e.PlanIsCalc).HasColumnName("PLAN_IS_CALC");
            entity.Property(e => e.PlanValueMonth).HasColumnName("PLAN_VALUE_MONTH");
            entity.Property(e => e.PlanValueYear).HasColumnName("PLAN_VALUE_YEAR");
            entity.Property(e => e.Value).HasColumnName("VALUE");
            entity.Property(e => e.Weather).HasColumnName("WEATHER");

            entity.HasOne(d => d.CActNavigation).WithMany(p => p.DJournals)
                .HasForeignKey(d => d.CAct)
                .HasConstraintName("FK_D_JOURNAL_D_ACT");

            entity.HasOne(d => d.CCommentNavigation).WithMany(p => p.DJournals)
                .HasForeignKey(d => d.CComment)
                .HasConstraintName("FK_D_JOURNAL_D_COMMENT");

            entity.HasOne(d => d.CMakerNavigation).WithMany(p => p.DJournals)
                .HasForeignKey(d => d.CMaker)
                .HasConstraintName("FK_D_JOURNAL_D_MAKER");

            entity.HasOne(d => d.CObjectContractNavigation).WithMany(p => p.DJournals)
                .HasForeignKey(d => d.CObjectContract)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_JOURNAL_D_OBJECT_CONTRACT");

            entity.HasOne(d => d.CObjectElementNavigation).WithMany(p => p.DJournals)
                .HasForeignKey(d => d.CObjectElement)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_JOURNAL_D_OBJECT_ELEMENT");

            entity.HasOne(d => d.CWeatherNavigation).WithMany(p => p.DJournals)
                .HasForeignKey(d => d.CWeather)
                .HasConstraintName("FK_D_JOURNAL_D_WEATHER");

            entity.HasOne(d => d.CWorkNavigation).WithMany(p => p.DJournals)
                .HasForeignKey(d => d.CWork)
                .HasConstraintName("FK_D_JOURNAL_S_WORK");
        });

        modelBuilder.Entity<DJournalConnection>(entity =>
        {
            entity.HasKey(e => e.CJournalConnection);

            entity.ToTable("D_JOURNAL_CONNECTION");

            entity.Property(e => e.CJournalConnection).HasColumnName("C_JOURNAL_CONNECTION");
            entity.Property(e => e.CJournal)
                .HasDefaultValueSql("((0))")
                .HasColumnName("C_JOURNAL");
            entity.Property(e => e.CJournalWork)
                .HasDefaultValueSql("((0))")
                .HasColumnName("C_JOURNAL_WORK");
            entity.Property(e => e.CWorkWork).HasColumnName("C_WORK_WORK");
            entity.Property(e => e.Edited).HasColumnName("EDITED");
            entity.Property(e => e.JournalRatio)
                .HasDefaultValueSql("((1))")
                .HasColumnName("JOURNAL_RATIO");
            entity.Property(e => e.Ratio)
                .HasDefaultValueSql("((1))")
                .HasColumnName("RATIO");
        });

        modelBuilder.Entity<DJournalDetail>(entity =>
        {
            entity.HasKey(e => e.CJournalDetail).HasName("PK__D_JOURNA__EBC399F74FD36C76");

            entity.ToTable("D_JOURNAL_DETAIL");

            entity.Property(e => e.CJournalDetail).HasColumnName("C_JOURNAL_DETAIL");
            entity.Property(e => e.Begkm).HasColumnName("BEGKM");
            entity.Property(e => e.CJournal).HasColumnName("C_JOURNAL");
            entity.Property(e => e.Comment)
                .IsUnicode(false)
                .HasColumnName("COMMENT");
            entity.Property(e => e.Endkm).HasColumnName("ENDKM");
            entity.Property(e => e.Value).HasColumnName("VALUE");

            entity.HasOne(d => d.CJournalNavigation).WithMany(p => p.DJournalDetails)
                .HasForeignKey(d => d.CJournal)
                .HasConstraintName("D_JOURNAL_DETAIL_D_JOURNAL");
        });

        modelBuilder.Entity<DJournalImage>(entity =>
        {
            entity.HasKey(e => e.Guid);

            entity.ToTable("D_JOURNAL_IMAGES", tb => tb.HasTrigger("TRIG_DEL_JOURNAL_IMAGES"));

            entity.Property(e => e.Guid)
                .ValueGeneratedNever()
                .HasColumnName("GUID");
            entity.Property(e => e.CJournal).HasColumnName("C_JOURNAL");
            entity.Property(e => e.Data).HasColumnName("DATA");
            entity.Property(e => e.Filename)
                .HasMaxLength(256)
                .HasColumnName("FILENAME");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Type)
                .HasMaxLength(127)
                .HasColumnName("TYPE");

            entity.HasOne(d => d.CJournalNavigation).WithMany(p => p.DJournalImages)
                .HasForeignKey(d => d.CJournal)
                .HasConstraintName("FK_D_JOURNAL_IMAGES_D_JOURNAL");
        });

        modelBuilder.Entity<DJournalMessage>(entity =>
        {
            entity.HasKey(e => e.CJournalMessage);

            entity.ToTable("D_JOURNAL_MESSAGE");

            entity.Property(e => e.CJournalMessage).HasColumnName("C_JOURNAL_MESSAGE");
            entity.Property(e => e.CJournal).HasColumnName("C_JOURNAL");
            entity.Property(e => e.CTypeMessage).HasColumnName("C_TYPE_MESSAGE");
            entity.Property(e => e.DateCreate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATE");
            entity.Property(e => e.DateUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_UPDATE");
            entity.Property(e => e.ImageGuid).HasColumnName("IMAGE_GUID");
            entity.Property(e => e.MessageText)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("MESSAGE_TEXT");

            entity.HasOne(d => d.CJournalNavigation).WithMany(p => p.DJournalMessages)
                .HasForeignKey(d => d.CJournal)
                .HasConstraintName("FK_D_JOURNAL_MESSAGE_D_JOURNAL");

            entity.HasOne(d => d.CTypeMessageNavigation).WithMany(p => p.DJournalMessages)
                .HasForeignKey(d => d.CTypeMessage)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_JOURNAL_MESSAGE_S_TYPE_MESSAGE");
        });

        modelBuilder.Entity<DJournalVehicle>(entity =>
        {
            entity.HasKey(e => e.CJournalVehicle);

            entity.ToTable("D_JOURNAL_VEHICLE");

            entity.Property(e => e.CJournalVehicle).HasColumnName("C_JOURNAL_VEHICLE");
            entity.Property(e => e.CJournal).HasColumnName("C_JOURNAL");
            entity.Property(e => e.VehicleId).HasColumnName("VEHICLE_ID");
            entity.Property(e => e.VehicleName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("VEHICLE_NAME");
            entity.Property(e => e.VehicleType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("VEHICLE_TYPE");

            entity.HasOne(d => d.CJournalNavigation).WithMany(p => p.DJournalVehicles)
                .HasForeignKey(d => d.CJournal)
                .HasConstraintName("FK_D_JOURNAL_VEHICLE_D_JOURNAL");
        });

        modelBuilder.Entity<DJournalWebApi>(entity =>
        {
            entity.HasKey(e => new { e.CJournal, e.Guid });

            entity.ToTable("D_JOURNAL_WEB_API");

            entity.Property(e => e.CJournal).HasColumnName("C_JOURNAL");
            entity.Property(e => e.Guid).HasColumnName("GUID");

            entity.HasOne(d => d.CJournalNavigation).WithMany(p => p.DJournalWebApis)
                .HasForeignKey(d => d.CJournal)
                .HasConstraintName("FK_D_JOURNAL_WEB_API_D_JOURNAL");
        });

        modelBuilder.Entity<DMaker>(entity =>
        {
            entity.HasKey(e => e.CMaker);

            entity.ToTable("D_MAKER", tb => tb.HasTrigger("TR_WEB_API_D_MAKER"));

            entity.Property(e => e.CMaker).HasColumnName("C_MAKER");
            entity.Property(e => e.CContractor).HasColumnName("C_CONTRACTOR");
            entity.Property(e => e.CSubcontractor).HasColumnName("C_SUBCONTRACTOR");
            entity.Property(e => e.DateCreate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATE");
            entity.Property(e => e.DateUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_UPDATE");
            entity.Property(e => e.Department)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("DISPLAY_NAME");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("((1))")
                .HasColumnName("IS_ACTIVE");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Patronymic)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PATRONYMIC");
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PHONE");
            entity.Property(e => e.Post)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("POST");
            entity.Property(e => e.Surname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SURNAME");

            entity.HasOne(d => d.CContractorNavigation).WithMany(p => p.DMakers)
                .HasForeignKey(d => d.CContractor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_MAKER_D_CONTRACTOR");

            entity.HasOne(d => d.CSubcontractorNavigation).WithMany(p => p.DMakers)
                .HasForeignKey(d => d.CSubcontractor)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_D_SUBCONTRACTOR");
        });

        modelBuilder.Entity<DMonth>(entity =>
        {
            entity.HasKey(e => e.CMonth);

            entity.ToTable("D_MONTH");

            entity.Property(e => e.CMonth)
                .ValueGeneratedNever()
                .HasColumnName("C_MONTH");
            entity.Property(e => e.MonthNum).HasColumnName("MONTH_NUM");
            entity.Property(e => e.NMonth)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("N_MONTH");
            entity.Property(e => e.Number).HasColumnName("NUMBER");
            entity.Property(e => e.Year).HasColumnName("YEAR");
        });

        modelBuilder.Entity<DNakrutki>(entity =>
        {
            entity.HasKey(e => e.CNakrutki);

            entity.ToTable("D_NAKRUTKI");

            entity.Property(e => e.CNakrutki).HasColumnName("C_NAKRUTKI");
            entity.Property(e => e.NNakrutki)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("N_NAKRUTKI");
            entity.Property(e => e.PercentValue).HasColumnName("PERCENT_VALUE");
            entity.Property(e => e.Sort).HasColumnName("SORT");
        });

        modelBuilder.Entity<DObject>(entity =>
        {
            entity.HasKey(e => e.CObject);

            entity.ToTable("D_OBJECT", tb =>
            {
                tb.HasTrigger("TRIG_UPD_OBJECT");
                tb.HasTrigger("TR_WEB_API_D_OBJECT");
            });

            entity.Property(e => e.CObject)
                .ValueGeneratedNever()
                .HasColumnName("C_OBJECT");
            entity.Property(e => e.Barrier)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("BARRIER");
            entity.Property(e => e.Begkm).HasColumnName("BEGKM");
            entity.Property(e => e.BegkmStolb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BEGKM_STOLB");
            entity.Property(e => e.CBridgeMaterial).HasColumnName("C_BRIDGE_MATERIAL");
            entity.Property(e => e.CBridgeObject).HasColumnName("C_BRIDGE_OBJECT");
            entity.Property(e => e.CExplCategory).HasColumnName("C_EXPL_CATEGORY");
            entity.Property(e => e.CRegion).HasColumnName("C_REGION");
            entity.Property(e => e.CRoad).HasColumnName("C_ROAD");
            entity.Property(e => e.CStatusObject).HasColumnName("C_STATUS_OBJECT");
            entity.Property(e => e.CTypeBridge).HasColumnName("C_TYPE_BRIDGE");
            entity.Property(e => e.CTypeObject).HasColumnName("C_TYPE_OBJECT");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.Coef)
                .HasDefaultValueSql("((1))")
                .HasColumnName("COEF");
            entity.Property(e => e.DateLeadIn)
                .HasColumnType("datetime")
                .HasColumnName("DATE_LEAD_IN");
            entity.Property(e => e.DateLeadOut)
                .HasColumnType("datetime")
                .HasColumnName("DATE_LEAD_OUT");
            entity.Property(e => e.EnabledForJornal)
                .HasDefaultValueSql("((1))")
                .HasColumnName("ENABLED_FOR_JORNAL");
            entity.Property(e => e.Endkm).HasColumnName("ENDKM");
            entity.Property(e => e.EndkmStolb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENDKM_STOLB");
            entity.Property(e => e.Gabarit)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("GABARIT");
            entity.Property(e => e.Length).HasColumnName("LENGTH");
            entity.Property(e => e.Mp).HasColumnName("MP");
            entity.Property(e => e.NBridgeLet)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("N_BRIDGE_LET");
            entity.Property(e => e.NObject)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("N_OBJECT");
            entity.Property(e => e.UniqueValue).HasColumnName("UNIQUE_VALUE");

            entity.HasOne(d => d.CBridgeMaterialNavigation).WithMany(p => p.DObjects)
                .HasForeignKey(d => d.CBridgeMaterial)
                .HasConstraintName("FK_D_OBJECT_S_BRIDGE_MATERIAL");

            entity.HasOne(d => d.CBridgeObjectNavigation).WithMany(p => p.InverseCBridgeObjectNavigation)
                .HasForeignKey(d => d.CBridgeObject)
                .HasConstraintName("FK_D_OBJECT_D_OBJECT");

            entity.HasOne(d => d.CExplCategoryNavigation).WithMany(p => p.DObjects)
                .HasForeignKey(d => d.CExplCategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_OBJECT_S_EXPL_CATEGORY");

            entity.HasOne(d => d.CRegionNavigation).WithMany(p => p.DObjects)
                .HasForeignKey(d => d.CRegion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_OBJECT_S_REGION");

            entity.HasOne(d => d.CRoadNavigation).WithMany(p => p.DObjects)
                .HasForeignKey(d => d.CRoad)
                .HasConstraintName("FK_D_OBJECT_D_ROAD");

            entity.HasOne(d => d.CStatusObjectNavigation).WithMany(p => p.DObjects)
                .HasForeignKey(d => d.CStatusObject)
                .HasConstraintName("FK_D_OBJECT_S_STATUS_OBJECT");

            entity.HasOne(d => d.CTypeBridgeNavigation).WithMany(p => p.DObjects)
                .HasForeignKey(d => d.CTypeBridge)
                .HasConstraintName("FK_D_OBJECT_S_TYPE_BRIDGE");

            entity.HasOne(d => d.CTypeObjectNavigation).WithMany(p => p.DObjects)
                .HasForeignKey(d => d.CTypeObject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_OBJECT_S_TYPE_OBJECT");
        });

        modelBuilder.Entity<DObjectContract>(entity =>
        {
            entity.HasKey(e => e.CObjectContract);

            entity.ToTable("D_OBJECT_CONTRACT");

            entity.HasIndex(e => new { e.CObject, e.IsActive }, "INDEX_OBJECT_CONTRACT_ACTIVE");

            entity.HasIndex(e => e.IsActive, "INDEX_OBJECT_CONTRACT_INCLUDE");

            entity.Property(e => e.CObjectContract).HasColumnName("C_OBJECT_CONTRACT");
            entity.Property(e => e.CContract).HasColumnName("C_CONTRACT");
            entity.Property(e => e.CContractor).HasColumnName("C_CONTRACTOR");
            entity.Property(e => e.CDopcontract).HasColumnName("C_DOPCONTRACT");
            entity.Property(e => e.CGeneralContract).HasColumnName("C_GENERAL_CONTRACT");
            entity.Property(e => e.CGeneralContractor).HasColumnName("C_GENERAL_CONTRACTOR");
            entity.Property(e => e.CObject).HasColumnName("C_OBJECT");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("IS_ACTIVE");
            entity.Property(e => e.LastCObjectContract).HasColumnName("LAST_C_OBJECT_CONTRACT");
            entity.Property(e => e.MonthBeg).HasColumnName("MONTH_BEG");
            entity.Property(e => e.MonthEnd).HasColumnName("MONTH_END");

            entity.HasOne(d => d.CContractNavigation).WithMany(p => p.DObjectContracts)
                .HasForeignKey(d => d.CContract)
                .HasConstraintName("FK_D_OBJECT_CONTRACT_D_CONTRACT");

            entity.HasOne(d => d.CDopcontractNavigation).WithMany(p => p.DObjectContracts)
                .HasForeignKey(d => d.CDopcontract)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_D_OBJECT_CONTRACT_D_DOPCONTRACT");

            entity.HasOne(d => d.CObjectNavigation).WithMany(p => p.DObjectContracts)
                .HasForeignKey(d => d.CObject)
                .HasConstraintName("FK_D_OBJECT_CONTRACT_D_OBJECT");

            entity.HasOne(d => d.MonthBegNavigation).WithMany(p => p.DObjectContractMonthBegNavigations)
                .HasForeignKey(d => d.MonthBeg)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_OBJECT_CONTRACT_D_MONTH_BEG");

            entity.HasOne(d => d.MonthEndNavigation).WithMany(p => p.DObjectContractMonthEndNavigations)
                .HasForeignKey(d => d.MonthEnd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_OBJECT_CONTRACT_D_MONTH_END");
        });

        modelBuilder.Entity<DObjectElement>(entity =>
        {
            entity.HasKey(e => e.CObjectElement);

            entity.ToTable("D_OBJECT_ELEMENT", tb =>
            {
                tb.HasTrigger("TRIG_DEL_D_OBJECT_ELEMENT");
                tb.HasTrigger("TR_WEB_API_D_OBJECT_ELEMENT");
            });

            entity.HasIndex(e => new { e.CElement, e.CObject }, "INDEX_OBJECT_ELEMENT");

            entity.HasIndex(e => e.CObject, "INDEX_OBJECT_ELEMENT_INCLUDE");

            entity.Property(e => e.CObjectElement).HasColumnName("C_OBJECT_ELEMENT");
            entity.Property(e => e.AddedAfterAnalysis).HasColumnName("ADDED_AFTER_ANALYSIS");
            entity.Property(e => e.Begkm).HasColumnName("BEGKM");
            entity.Property(e => e.BegkmStolb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BEGKM_STOLB");
            entity.Property(e => e.CElement).HasColumnName("C_ELEMENT");
            entity.Property(e => e.CObject).HasColumnName("C_OBJECT");
            entity.Property(e => e.Count).HasColumnName("COUNT");
            entity.Property(e => e.DateBegin)
                .HasColumnType("datetime")
                .HasColumnName("DATE_BEGIN");
            entity.Property(e => e.DateTransit)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TRANSIT");
            entity.Property(e => e.Endkm).HasColumnName("ENDKM");
            entity.Property(e => e.EndkmStolb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENDKM_STOLB");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.Length).HasColumnName("LENGTH");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Notes)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.UniqueValue).HasColumnName("UNIQUE_VALUE");
            entity.Property(e => e.UseInJournal)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("USE_IN_JOURNAL");
            entity.Property(e => e.Width).HasColumnName("WIDTH");

            entity.HasOne(d => d.CElementNavigation).WithMany(p => p.DObjectElements)
                .HasForeignKey(d => d.CElement)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_OBJECT_ELEMENT_S_ELEMENT");

            entity.HasOne(d => d.CObjectNavigation).WithMany(p => p.DObjectElements)
                .HasForeignKey(d => d.CObject)
                .HasConstraintName("FK_D_OBJECT_ELEMENT_D_OBJECT");
        });

        modelBuilder.Entity<DObjectHistory>(entity =>
        {
            entity.HasKey(e => e.CObjectHistory);

            entity.ToTable("D_OBJECT_HISTORY");

            entity.Property(e => e.CObjectHistory).HasColumnName("C_OBJECT_HISTORY");
            entity.Property(e => e.CObject).HasColumnName("C_OBJECT");
            entity.Property(e => e.CUser).HasColumnName("C_USER");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("DATE");

            entity.HasOne(d => d.CObjectNavigation).WithMany(p => p.DObjectHistories)
                .HasForeignKey(d => d.CObject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_OBJECT_HISTORY_D_OBJECT");
        });

        modelBuilder.Entity<DObjectKurator>(entity =>
        {
            entity.HasKey(e => e.CObjectKurator);

            entity.ToTable("D_OBJECT_KURATOR");

            entity.Property(e => e.CObjectKurator).HasColumnName("C_OBJECT_KURATOR");
            entity.Property(e => e.CMonthBegin).HasColumnName("C_MONTH_BEGIN");
            entity.Property(e => e.CMonthEnd).HasColumnName("C_MONTH_END");
            entity.Property(e => e.CObject).HasColumnName("C_OBJECT");
            entity.Property(e => e.CUser).HasColumnName("C_USER");
            entity.Property(e => e.DateBeg)
                .HasColumnType("datetime")
                .HasColumnName("DATE_BEG");
            entity.Property(e => e.DateEnd)
                .HasColumnType("datetime")
                .HasColumnName("DATE_END");

            entity.HasOne(d => d.CObjectNavigation).WithMany(p => p.DObjectKurators)
                .HasForeignKey(d => d.CObject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_OBJECT_KURATOR_D_OBJECT");
        });

        modelBuilder.Entity<DObjectTypePokr>(entity =>
        {
            entity.HasKey(e => e.CObjectTypePokr);

            entity.ToTable("D_OBJECT_TYPE_POKR");

            entity.Property(e => e.CObjectTypePokr).HasColumnName("C_OBJECT_TYPE_POKR");
            entity.Property(e => e.Begkm).HasColumnName("BEGKM");
            entity.Property(e => e.CObject).HasColumnName("C_OBJECT");
            entity.Property(e => e.CTypePokr).HasColumnName("C_TYPE_POKR");
            entity.Property(e => e.DateCreate)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATE");
            entity.Property(e => e.DateUpdate)
                .HasColumnType("datetime")
                .HasColumnName("DATE_UPDATE");
            entity.Property(e => e.Endkm).HasColumnName("ENDKM");

            entity.HasOne(d => d.CObjectNavigation).WithMany(p => p.DObjectTypePokrs)
                .HasForeignKey(d => d.CObject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_OBJECT_TYPE_POKR_D_OBJECT");

            entity.HasOne(d => d.CTypePokrNavigation).WithMany(p => p.DObjectTypePokrs)
                .HasForeignKey(d => d.CTypePokr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_OBJECT_TYPE_POKR_S_TYPE_POKR");
        });

        modelBuilder.Entity<DOverwork>(entity =>
        {
            entity.HasKey(e => new { e.CWork, e.CObjectElement });

            entity.ToTable("D_OVERWORK", tb =>
            {
                tb.HasTrigger("TRIG_DEL_D_OVERWORK");
                tb.HasTrigger("TRIG_INS_D_OVERWORK");
            });

            entity.HasIndex(e => e.CObjectElement, "INDEX_OVERWORK");

            entity.Property(e => e.CWork).HasColumnName("C_WORK");
            entity.Property(e => e.CObjectElement).HasColumnName("C_OBJECT_ELEMENT");
            entity.Property(e => e.COverwork)
                .ValueGeneratedOnAdd()
                .HasColumnName("C_OVERWORK");

            entity.HasOne(d => d.CObjectElementNavigation).WithMany(p => p.DOverworks)
                .HasForeignKey(d => d.CObjectElement)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_OVERWORK_D_OBJECT_ELEMENT");

            entity.HasOne(d => d.CWorkNavigation).WithMany(p => p.DOverworks)
                .HasForeignKey(d => d.CWork)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_OVERWORK_S_WORK");
        });

        modelBuilder.Entity<DOverworkDetail>(entity =>
        {
            entity.HasKey(e => new { e.COverwork, e.CMonth });

            entity.ToTable("D_OVERWORK_DETAIL");

            entity.HasIndex(e => e.COverwork, "INDEX_OVERWORK_DETAIL");

            entity.Property(e => e.COverwork).HasColumnName("C_OVERWORK");
            entity.Property(e => e.CMonth).HasColumnName("C_MONTH");
            entity.Property(e => e.COverworkDetail)
                .ValueGeneratedOnAdd()
                .HasColumnName("C_OVERWORK_DETAIL");
            entity.Property(e => e.Costonework).HasColumnName("COSTONEWORK");
            entity.Property(e => e.CostoneworkNow).HasColumnName("COSTONEWORK_NOW");

            entity.HasOne(d => d.CMonthNavigation).WithMany(p => p.DOverworkDetails)
                .HasForeignKey(d => d.CMonth)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_OVERWORK_DETAIL_D_MONTH");
        });

        modelBuilder.Entity<DReportTemplate>(entity =>
        {
            entity.HasKey(e => e.CTemplate);

            entity.ToTable("D_REPORT_TEMPLATE");

            entity.Property(e => e.CTemplate).HasColumnName("C_TEMPLATE");
            entity.Property(e => e.CReport).HasColumnName("C_REPORT");
            entity.Property(e => e.NTemplate)
                .HasMaxLength(1000)
                .HasColumnName("N_TEMPLATE");
            entity.Property(e => e.Settings).HasColumnName("SETTINGS");
        });

        modelBuilder.Entity<DRoad>(entity =>
        {
            entity.HasKey(e => e.CRoad);

            entity.ToTable("D_ROAD", tb => tb.HasTrigger("TR_WEB_API_D_ROAD"));

            entity.Property(e => e.CRoad).HasColumnName("C_ROAD");
            entity.Property(e => e.Begkm).HasColumnName("BEGKM");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.DateActualization)
                .HasColumnType("datetime")
                .HasColumnName("DATE_ACTUALIZATION");
            entity.Property(e => e.EnabledForJornal)
                .HasDefaultValueSql("((1))")
                .HasColumnName("ENABLED_FOR_JORNAL");
            entity.Property(e => e.Endkm).HasColumnName("ENDKM");
            entity.Property(e => e.NRoad)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("N_ROAD");
            entity.Property(e => e.SortIndex).HasColumnName("SORT_INDEX");
            entity.Property(e => e.UniqueValue)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("UNIQUE_VALUE");
        });

        modelBuilder.Entity<DSubcontractor>(entity =>
        {
            entity.HasKey(e => e.CSubcontractor);

            entity.ToTable("D_SUBCONTRACTOR");

            entity.Property(e => e.CSubcontractor).HasColumnName("C_SUBCONTRACTOR");
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .HasColumnName("EMAIL");
            entity.Property(e => e.NSubcontractor)
                .HasMaxLength(200)
                .HasColumnName("N_SUBCONTRACTOR");
            entity.Property(e => e.Phone)
                .HasMaxLength(200)
                .HasColumnName("PHONE");
        });

        modelBuilder.Entity<DSubcontractorWork>(entity =>
        {
            entity.HasKey(e => e.CSubcontractorWork);

            entity.ToTable("D_SUBCONTRACTOR_WORK");

            entity.Property(e => e.CSubcontractorWork).HasColumnName("C_SUBCONTRACTOR_WORK");
            entity.Property(e => e.CContractor).HasColumnName("C_CONTRACTOR");
            entity.Property(e => e.CElement).HasColumnName("C_ELEMENT");
            entity.Property(e => e.CObjectContract).HasColumnName("C_OBJECT_CONTRACT");
            entity.Property(e => e.CSubcontractor).HasColumnName("C_SUBCONTRACTOR");
            entity.Property(e => e.CWork).HasColumnName("C_WORK");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("IS_ACTIVE");

            entity.HasOne(d => d.CContractorNavigation).WithMany(p => p.DSubcontractorWorks)
                .HasForeignKey(d => d.CContractor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_SUBCONTRACTOR_WORK_D_CONTRACTOR");

            entity.HasOne(d => d.CElementNavigation).WithMany(p => p.DSubcontractorWorks)
                .HasForeignKey(d => d.CElement)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_SUBCONTRACTOR_WORK_S_ELEMENT");

            entity.HasOne(d => d.CObjectContractNavigation).WithMany(p => p.DSubcontractorWorks)
                .HasForeignKey(d => d.CObjectContract)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_SUBCONTRACTOR_WORK_D_OBJECT_CONTRACT");

            entity.HasOne(d => d.CSubcontractorNavigation).WithMany(p => p.DSubcontractorWorks)
                .HasForeignKey(d => d.CSubcontractor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_SUBCONTRACTOR_WORK_D_SUBCONTRACTOR");

            entity.HasOne(d => d.CWorkNavigation).WithMany(p => p.DSubcontractorWorks)
                .HasForeignKey(d => d.CWork)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_SUBCONTRACTOR_WORK_S_WORK");
        });

        modelBuilder.Entity<DVirtualObject>(entity =>
        {
            entity.HasKey(e => e.CVirtualObject);

            entity.ToTable("D_VIRTUAL_OBJECT", tb => tb.HasTrigger("TRIG_INS_D_VIRTUAL_OBJECT_COST"));

            entity.Property(e => e.CVirtualObject).HasColumnName("C_VIRTUAL_OBJECT");
            entity.Property(e => e.CUnit).HasColumnName("C_UNIT");
            entity.Property(e => e.CodeVirtualObject)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CODE_VIRTUAL_OBJECT");
            entity.Property(e => e.CountValue)
                .HasDefaultValueSql("((1))")
                .HasColumnName("COUNT_VALUE");
            entity.Property(e => e.DateLeadIn)
                .HasColumnType("datetime")
                .HasColumnName("DATE_LEAD_IN");
            entity.Property(e => e.DateLeadOut)
                .HasColumnType("datetime")
                .HasColumnName("DATE_LEAD_OUT");
            entity.Property(e => e.NVirtualObject)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("N_VIRTUAL_OBJECT");
            entity.Property(e => e.UniqueValue)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("UNIQUE_VALUE");
            entity.Property(e => e.UseFact)
                .HasDefaultValueSql("((1))")
                .HasColumnName("USE_FACT");
            entity.Property(e => e.UsePlan)
                .HasDefaultValueSql("((1))")
                .HasColumnName("USE_PLAN");

            entity.HasOne(d => d.CUnitNavigation).WithMany(p => p.DVirtualObjects)
                .HasForeignKey(d => d.CUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_VIRTUAL_OBJECT_S_UNIT");
        });

        modelBuilder.Entity<DVirtualObjectContract>(entity =>
        {
            entity.HasKey(e => e.CVirtualObjectContract);

            entity.ToTable("D_VIRTUAL_OBJECT_CONTRACT");

            entity.Property(e => e.CVirtualObjectContract).HasColumnName("C_VIRTUAL_OBJECT_CONTRACT");
            entity.Property(e => e.CContract).HasColumnName("C_CONTRACT");
            entity.Property(e => e.CVirtualObject).HasColumnName("C_VIRTUAL_OBJECT");
            entity.Property(e => e.MonthBeg).HasColumnName("MONTH_BEG");
            entity.Property(e => e.MonthEnd).HasColumnName("MONTH_END");

            entity.HasOne(d => d.CContractNavigation).WithMany(p => p.DVirtualObjectContracts)
                .HasForeignKey(d => d.CContract)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_VIRTUAL_OBJECT_CONTRACT_D_CONTRACT");

            entity.HasOne(d => d.CVirtualObjectNavigation).WithMany(p => p.DVirtualObjectContracts)
                .HasForeignKey(d => d.CVirtualObject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_VIRTUAL_OBJECT_CONTRACT_D_VIRTUAL_OBJECT_CONTRACT");
        });

        modelBuilder.Entity<DVirtualObjectCost>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("D_VIRTUAL_OBJECT_COST");

            entity.Property(e => e.CMonth).HasColumnName("C_MONTH");
            entity.Property(e => e.CVirtualObject).HasColumnName("C_VIRTUAL_OBJECT");
            entity.Property(e => e.CVirtualObjectCost)
                .ValueGeneratedOnAdd()
                .HasColumnName("C_VIRTUAL_OBJECT_COST");
            entity.Property(e => e.VirtualCost)
                .HasDefaultValueSql("((1))")
                .HasColumnName("VIRTUAL_COST");

            entity.HasOne(d => d.CMonthNavigation).WithMany()
                .HasForeignKey(d => d.CMonth)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_VIRTUAL_OBJECT_COST_D_MONTH");

            entity.HasOne(d => d.CVirtualObjectNavigation).WithMany()
                .HasForeignKey(d => d.CVirtualObject)
                .HasConstraintName("FK_D_VIRTUAL_OBJECT_COST_D_VIRTUAL_OBJECT");
        });

        modelBuilder.Entity<DVirtualObjectMonth>(entity =>
        {
            entity.HasKey(e => e.CVirtualObjectMonth).HasName("PK_C_VIRTUAL_OBJECT_MONTH");

            entity.ToTable("D_VIRTUAL_OBJECT_MONTH");

            entity.Property(e => e.CVirtualObjectMonth).HasColumnName("C_VIRTUAL_OBJECT_MONTH");
            entity.Property(e => e.CMonth).HasColumnName("C_MONTH");
            entity.Property(e => e.CVirtualObjectWork).HasColumnName("C_VIRTUAL_OBJECT_WORK");
            entity.Property(e => e.VirtualCost).HasColumnName("VIRTUAL_COST");

            entity.HasOne(d => d.CMonthNavigation).WithMany(p => p.DVirtualObjectMonths)
                .HasForeignKey(d => d.CMonth)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_VIRTUAL_OBJECT_MONTH_D_MONTH");

            entity.HasOne(d => d.CVirtualObjectWorkNavigation).WithMany(p => p.DVirtualObjectMonths)
                .HasForeignKey(d => d.CVirtualObjectWork)
                .HasConstraintName("FK_D_VIRTUAL_OBJECT_MONTH_D_VIRTUAL_OBJECT_WORK");
        });

        modelBuilder.Entity<DVirtualObjectWork>(entity =>
        {
            entity.HasKey(e => e.CVirtualObjectWork);

            entity.ToTable("D_VIRTUAL_OBJECT_WORK", tb => tb.HasTrigger("TRIG_INS_D_VIRTUAL_OBJECT_WORK"));

            entity.Property(e => e.CVirtualObjectWork).HasColumnName("C_VIRTUAL_OBJECT_WORK");
            entity.Property(e => e.CVirtualObject).HasColumnName("C_VIRTUAL_OBJECT");
            entity.Property(e => e.CWork).HasColumnName("C_WORK");

            entity.HasOne(d => d.CVirtualObjectNavigation).WithMany(p => p.DVirtualObjectWorks)
                .HasForeignKey(d => d.CVirtualObject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_VIRTUAL_OBJECT_WORK_D_VIRTUAL_OBJECT");

            entity.HasOne(d => d.CWorkNavigation).WithMany(p => p.DVirtualObjectWorks)
                .HasForeignKey(d => d.CWork)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_VIRTUAL_OBJECT_WORK_S_WORK");
        });

        modelBuilder.Entity<DVirtualWorkCost>(entity =>
        {
            entity.HasKey(e => e.CVirtualWorkCost).HasName("PK__D_VIRTUA__B87E62D217E4190E");

            entity.ToTable("D_VIRTUAL_WORK_COST");

            entity.Property(e => e.CVirtualWorkCost).HasColumnName("C_VIRTUAL_WORK_COST");
            entity.Property(e => e.CMonth).HasColumnName("C_MONTH");
            entity.Property(e => e.CVirtualWork).HasColumnName("C_VIRTUAL_WORK");
            entity.Property(e => e.VirtualCost).HasColumnName("VIRTUAL_COST");

            entity.HasOne(d => d.CVirtualWorkNavigation).WithMany(p => p.DVirtualWorkCosts)
                .HasForeignKey(d => d.CVirtualWork)
                .HasConstraintName("FK_D_VIRTUAL_WORK_COST_D_VIRTUAL_OBJECT_WORK");
        });

        modelBuilder.Entity<DWeather>(entity =>
        {
            entity.HasKey(e => e.CWeather);

            entity.ToTable("D_WEATHER");

            entity.HasIndex(e => new { e.CObject, e.Date }, "CONS_WEATHER").IsUnique();

            entity.Property(e => e.CWeather).HasColumnName("C_WEATHER");
            entity.Property(e => e.CObject).HasColumnName("C_OBJECT");
            entity.Property(e => e.CRegion).HasColumnName("C_REGION");
            entity.Property(e => e.CWeatherSession).HasColumnName("C_WEATHER_SESSION");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("DATE");
            entity.Property(e => e.Precipitation).HasColumnName("PRECIPITATION");
            entity.Property(e => e.Temperature).HasColumnName("TEMPERATURE");
            entity.Property(e => e.TemperatureMax).HasColumnName("TEMPERATURE_MAX");
            entity.Property(e => e.TemperatureMin).HasColumnName("TEMPERATURE_MIN");
            entity.Property(e => e.WeatherType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("WEATHER_TYPE");
            entity.Property(e => e.WindDirection)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("WIND_DIRECTION");

            entity.HasOne(d => d.CObjectNavigation).WithMany(p => p.DWeathers)
                .HasForeignKey(d => d.CObject)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_D_WEATHER_D_OBJECT");

            entity.HasOne(d => d.CRegionNavigation).WithMany(p => p.DWeathers)
                .HasForeignKey(d => d.CRegion)
                .HasConstraintName("FK_D_WEATHER_S_REGION");

            entity.HasOne(d => d.CWeatherSessionNavigation).WithMany(p => p.DWeathers)
                .HasForeignKey(d => d.CWeatherSession)
                .HasConstraintName("FK_D_WEATHER_D_WEATHER_SESSION");
        });

        modelBuilder.Entity<DWeatherSession>(entity =>
        {
            entity.HasKey(e => e.CWeatherSession);

            entity.ToTable("D_WEATHER_SESSION");

            entity.Property(e => e.CWeatherSession)
                .ValueGeneratedNever()
                .HasColumnName("C_WEATHER_SESSION");
            entity.Property(e => e.CObject).HasColumnName("C_OBJECT");
            entity.Property(e => e.CQuery).HasColumnName("C_QUERY");
            entity.Property(e => e.CRegion).HasColumnName("C_REGION");
            entity.Property(e => e.DateCreate)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATE");
            entity.Property(e => e.DateEnd)
                .HasColumnType("date")
                .HasColumnName("DATE_END");
            entity.Property(e => e.DateStart)
                .HasColumnType("date")
                .HasColumnName("DATE_START");
            entity.Property(e => e.Message)
                .IsUnicode(false)
                .HasColumnName("MESSAGE");
        });

        modelBuilder.Entity<DWebinar>(entity =>
        {
            entity.HasKey(e => e.CWebinar);

            entity.ToTable("D_WEBINAR");

            entity.Property(e => e.CWebinar).HasColumnName("C_WEBINAR");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("DATE");
            entity.Property(e => e.ImgPath)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("IMG_PATH");
            entity.Property(e => e.NWebinar)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("N_WEBINAR");
            entity.Property(e => e.VideoPath)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VIDEO_PATH");
        });

        modelBuilder.Entity<DWorkElement>(entity =>
        {
            entity.HasKey(e => new { e.CElement, e.CWorkGroup }).HasName("PK_D_WORK_ELEMENT_1");

            entity.ToTable("D_WORK_ELEMENT", tb => tb.HasTrigger("TRIG_INS_D_WORK_ELEMENT"));

            entity.Property(e => e.CElement).HasColumnName("C_ELEMENT");
            entity.Property(e => e.CWorkGroup).HasColumnName("C_WORK_GROUP");
            entity.Property(e => e.CWorkElement)
                .ValueGeneratedOnAdd()
                .HasColumnName("C_WORK_ELEMENT");

            entity.HasOne(d => d.CElementNavigation).WithMany(p => p.DWorkElements)
                .HasForeignKey(d => d.CElement)
                .HasConstraintName("FK_S_ELEMENT_D_WORK_ELEMENT");

            entity.HasOne(d => d.CWorkGroupNavigation).WithMany(p => p.DWorkElements)
                .HasForeignKey(d => d.CWorkGroup)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_WORK_ELEMENT_S_WORK_GROUP");
        });

        modelBuilder.Entity<DWorkWork>(entity =>
        {
            entity.HasKey(e => e.CWorkWork);

            entity.ToTable("D_WORK_WORK");

            entity.Property(e => e.CWorkWork).HasColumnName("C_WORK_WORK");
            entity.Property(e => e.CJournal).HasColumnName("C_JOURNAL");
            entity.Property(e => e.CWork).HasColumnName("C_WORK");
            entity.Property(e => e.CWorkMain).HasColumnName("C_WORK_MAIN");
            entity.Property(e => e.Edited).HasColumnName("EDITED");
            entity.Property(e => e.JournalRatio)
                .HasDefaultValueSql("((1))")
                .HasColumnName("JOURNAL_RATIO");
            entity.Property(e => e.Ratio)
                .HasDefaultValueSql("((1))")
                .HasColumnName("RATIO");
        });

        modelBuilder.Entity<Entities.Models.Object>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("objects$");

            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("code");
            entity.Property(e => e.Code1)
                .HasMaxLength(255)
                .HasColumnName("code1");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Name1)
                .HasMaxLength(255)
                .HasColumnName("name1");
        });

        modelBuilder.Entity<Pp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pp$");

            entity.Property(e => e.Block).HasColumnName("block");
            entity.Property(e => e.Mesto)
                .HasMaxLength(255)
                .HasColumnName("mesto");
            entity.Property(e => e.ObjectCode)
                .HasMaxLength(255)
                .HasColumnName("object_code");
            entity.Property(e => e.Region)
                .HasMaxLength(255)
                .HasColumnName("region");
            entity.Property(e => e.RoadName)
                .HasMaxLength(255)
                .HasColumnName("road_name");
            entity.Property(e => e.Start).HasColumnName("start");
        });

        modelBuilder.Entity<Road>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("roads$");

            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("code");
            entity.Property(e => e.Code1).HasColumnName("code1");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Name1)
                .HasMaxLength(255)
                .HasColumnName("name1");
        });

        modelBuilder.Entity<SBridgeMaterial>(entity =>
        {
            entity.HasKey(e => e.CBridgeMaterial);

            entity.ToTable("S_BRIDGE_MATERIAL");

            entity.Property(e => e.CBridgeMaterial).HasColumnName("C_BRIDGE_MATERIAL");
            entity.Property(e => e.NBridgeMaterial)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("N_BRIDGE_MATERIAL");
            entity.Property(e => e.ShortBridgeMaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHORT_BRIDGE_MATERIAL");
        });

        modelBuilder.Entity<SCiclic>(entity =>
        {
            entity.HasKey(e => e.CCiclic);

            entity.ToTable("S_CICLIC", tb => tb.HasTrigger("TRIG_INS_S_CICLIC"));

            entity.HasIndex(e => new { e.CWorkGroup, e.CWork, e.CExplCategory, e.CClimatZone }, "INDEX_S_CICLIC").IsUnique();

            entity.Property(e => e.CCiclic).HasColumnName("C_CICLIC");
            entity.Property(e => e.CClimatZone).HasColumnName("C_CLIMAT_ZONE");
            entity.Property(e => e.CExplCategory).HasColumnName("C_EXPL_CATEGORY");
            entity.Property(e => e.CWork).HasColumnName("C_WORK");
            entity.Property(e => e.CWorkGroup).HasColumnName("C_WORK_GROUP");
            entity.Property(e => e.CoefValueWork).HasColumnName("COEF_VALUE_WORK");

            entity.HasOne(d => d.CClimatZoneNavigation).WithMany(p => p.SCiclics)
                .HasForeignKey(d => d.CClimatZone)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_S_CICLIC_S_CLIMAT_ZONE");

            entity.HasOne(d => d.CExplCategoryNavigation).WithMany(p => p.SCiclics)
                .HasForeignKey(d => d.CExplCategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_S_CICLIC_S_EXPL_CATEGORY");

            entity.HasOne(d => d.CWorkNavigation).WithMany(p => p.SCiclics)
                .HasForeignKey(d => d.CWork)
                .HasConstraintName("FK_S_CICLIC_S_WORK");

            entity.HasOne(d => d.CWorkGroupNavigation).WithMany(p => p.SCiclics)
                .HasForeignKey(d => d.CWorkGroup)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_S_CICLIC_S_WORK_GROUP");
        });

        modelBuilder.Entity<SCiclicDetail>(entity =>
        {
            entity.HasKey(e => e.CCiclicDetail).HasName("PK_D_CICLIC_DETAIL");

            entity.ToTable("S_CICLIC_DETAIL");

            entity.HasIndex(e => new { e.CCiclic, e.CMonth }, "CONS_S_CICLIC_DETAIL_C_CICLIC_C_MONTH").IsUnique();

            entity.HasIndex(e => new { e.CCiclic, e.CMonth }, "INDEX_S_CICLIC_DETAIL").IsUnique();

            entity.HasIndex(e => e.CMonth, "INDEX_S_CICLIC_DETAIL_MONTH");

            entity.Property(e => e.CCiclicDetail).HasColumnName("C_CICLIC_DETAIL");
            entity.Property(e => e.CCiclic).HasColumnName("C_CICLIC");
            entity.Property(e => e.CMonth).HasColumnName("C_MONTH");
            entity.Property(e => e.CiclicValue).HasColumnName("CICLIC_VALUE");

            entity.HasOne(d => d.CCiclicNavigation).WithMany(p => p.SCiclicDetails)
                .HasForeignKey(d => d.CCiclic)
                .HasConstraintName("FK_D_CICLIC_DETAIL_S_CICLIC");

            entity.HasOne(d => d.CMonthNavigation).WithMany(p => p.SCiclicDetails)
                .HasForeignKey(d => d.CMonth)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_D_CICLIC_DETAIL_D_MONTH");
        });

        modelBuilder.Entity<SClimatZone>(entity =>
        {
            entity.HasKey(e => e.CClimatZone);

            entity.ToTable("S_CLIMAT_ZONE");

            entity.Property(e => e.CClimatZone).HasColumnName("C_CLIMAT_ZONE");
            entity.Property(e => e.NClimatZone)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("N_CLIMAT_ZONE");
            entity.Property(e => e.NameClimatZone)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME_CLIMAT_ZONE");
        });

        modelBuilder.Entity<SElement>(entity =>
        {
            entity.HasKey(e => e.CElement);

            entity.ToTable("S_ELEMENT", tb => tb.HasTrigger("TR_WEB_API_S_ELEMENT"));

            entity.Property(e => e.CElement).HasColumnName("C_ELEMENT");
            entity.Property(e => e.CTypeElement).HasColumnName("C_TYPE_ELEMENT");
            entity.Property(e => e.CTypeObject).HasColumnName("C_TYPE_OBJECT");
            entity.Property(e => e.CUnit).HasColumnName("C_UNIT");
            entity.Property(e => e.NElement)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("N_ELEMENT");
            entity.Property(e => e.UseInTranzit).HasColumnName("USE_IN_TRANZIT");

            entity.HasOne(d => d.CTypeElementNavigation).WithMany(p => p.SElements)
                .HasForeignKey(d => d.CTypeElement)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_S_ELEMENT_S_TYPE_ELEMENT");

            entity.HasOne(d => d.CTypeObjectNavigation).WithMany(p => p.SElements)
                .HasForeignKey(d => d.CTypeObject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_S_ELEMENT_S_TYPE_OBJECT");

            entity.HasOne(d => d.CUnitNavigation).WithMany(p => p.SElements)
                .HasForeignKey(d => d.CUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_S_ELEMENT_S_UNIT");
        });

        modelBuilder.Entity<SExplCategory>(entity =>
        {
            entity.HasKey(e => e.CExplCategory).HasName("PK_S_CLASS");

            entity.ToTable("S_EXPL_CATEGORY");

            entity.Property(e => e.CExplCategory).HasColumnName("C_EXPL_CATEGORY");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.NExplCategory)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("N_EXPL_CATEGORY");
            entity.Property(e => e.NameExplCategory)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME_EXPL_CATEGORY");
        });

        modelBuilder.Entity<SOkrug>(entity =>
        {
            entity.HasKey(e => e.COkrug);

            entity.ToTable("S_OKRUG");

            entity.Property(e => e.COkrug).HasColumnName("C_OKRUG");
            entity.Property(e => e.NOkrug)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("N_OKRUG");
        });

        modelBuilder.Entity<SRegion>(entity =>
        {
            entity.HasKey(e => e.CRegion);

            entity.ToTable("S_REGION", tb => tb.HasTrigger("TR_DELETE"));

            entity.Property(e => e.CRegion).HasColumnName("C_REGION");
            entity.Property(e => e.CClimatZone).HasColumnName("C_CLIMAT_ZONE");
            entity.Property(e => e.COkrug)
                .HasDefaultValueSql("((1))")
                .HasColumnName("C_OKRUG");
            entity.Property(e => e.CoefArea)
                .HasDefaultValueSql("((1))")
                .HasColumnName("COEF_AREA");
            entity.Property(e => e.CoefRegion)
                .HasDefaultValueSql("((1))")
                .HasColumnName("COEF_REGION");
            entity.Property(e => e.CoefSalary)
                .HasDefaultValueSql("((1))")
                .HasColumnName("COEF_SALARY");
            entity.Property(e => e.NRegion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("N_REGION");

            entity.HasOne(d => d.CClimatZoneNavigation).WithMany(p => p.SRegions)
                .HasForeignKey(d => d.CClimatZone)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_S_REGION_S_CLIMAT_ZONE");

            entity.HasOne(d => d.COkrugNavigation).WithMany(p => p.SRegions)
                .HasForeignKey(d => d.COkrug)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_S_REGION_S_OKRUG");
        });

        modelBuilder.Entity<SResMachinist>(entity =>
        {
            entity.HasKey(e => e.CResMachinist);

            entity.ToTable("S_RES_MACHINIST");

            entity.Property(e => e.CResMachinist).HasColumnName("C_RES_MACHINIST");
            entity.Property(e => e.CUnit).HasColumnName("C_UNIT");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CostBase).HasColumnName("COST_BASE");
            entity.Property(e => e.CostCalc).HasColumnName("COST_CALC");
            entity.Property(e => e.NResMachinist)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("N_RES_MACHINIST");

            entity.HasOne(d => d.CUnitNavigation).WithMany(p => p.SResMachinists)
                .HasForeignKey(d => d.CUnit)
                .HasConstraintName("FK_S_RES_MACHINIST_S_UNIT");
        });

        modelBuilder.Entity<SResMaterial>(entity =>
        {
            entity.HasKey(e => e.CResMaterial);

            entity.ToTable("S_RES_MATERIAL");

            entity.Property(e => e.CResMaterial).HasColumnName("C_RES_MATERIAL");
            entity.Property(e => e.CUnit).HasColumnName("C_UNIT");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CostBase).HasColumnName("COST_BASE");
            entity.Property(e => e.CostCalc).HasColumnName("COST_CALC");
            entity.Property(e => e.NResMaterial)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("N_RES_MATERIAL");

            entity.HasOne(d => d.CUnitNavigation).WithMany(p => p.SResMaterials)
                .HasForeignKey(d => d.CUnit)
                .HasConstraintName("FK_S_RES_MATERIAL_S_UNIT");
        });

        modelBuilder.Entity<SResMechanism>(entity =>
        {
            entity.HasKey(e => e.CResMechanism);

            entity.ToTable("S_RES_MECHANISM");

            entity.Property(e => e.CResMechanism).HasColumnName("C_RES_MECHANISM");
            entity.Property(e => e.CUnit).HasColumnName("C_UNIT");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CostBase).HasColumnName("COST_BASE");
            entity.Property(e => e.CostCalc).HasColumnName("COST_CALC");
            entity.Property(e => e.NResMechanism)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("N_RES_MECHANISM");

            entity.HasOne(d => d.CUnitNavigation).WithMany(p => p.SResMechanisms)
                .HasForeignKey(d => d.CUnit)
                .HasConstraintName("FK_S_RES_MECHANISM_S_UNIT");
        });

        modelBuilder.Entity<SResWorker>(entity =>
        {
            entity.HasKey(e => e.CResWorker);

            entity.ToTable("S_RES_WORKER");

            entity.Property(e => e.CResWorker).HasColumnName("C_RES_WORKER");
            entity.Property(e => e.CUnit).HasColumnName("C_UNIT");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CostBase).HasColumnName("COST_BASE");
            entity.Property(e => e.CostCalc).HasColumnName("COST_CALC");
            entity.Property(e => e.NResWorker)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("N_RES_WORKER");

            entity.HasOne(d => d.CUnitNavigation).WithMany(p => p.SResWorkers)
                .HasForeignKey(d => d.CUnit)
                .HasConstraintName("FK_S_RES_WORKER_S_UNIT");
        });

        modelBuilder.Entity<SSanction>(entity =>
        {
            entity.HasKey(e => e.CSanction);

            entity.ToTable("S_SANCTION");

            entity.Property(e => e.CSanction).HasColumnName("C_SANCTION");
            entity.Property(e => e.CSanctionGroup).HasColumnName("C_SANCTION_GROUP");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.Multiplicator)
                .HasDefaultValueSql("((1))")
                .HasColumnName("MULTIPLICATOR");
            entity.Property(e => e.NSanction)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("N_SANCTION");
            entity.Property(e => e.Penalty).HasColumnName("PENALTY");
            entity.Property(e => e.TypeDefect)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("TYPE_DEFECT");

            entity.HasOne(d => d.CSanctionGroupNavigation).WithMany(p => p.SSanctions)
                .HasForeignKey(d => d.CSanctionGroup)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_S_SANCTION_S_SANCTION_GROUP");
        });

        modelBuilder.Entity<SSanctionElement>(entity =>
        {
            entity.HasKey(e => e.CSanctionElement).HasName("PK_D_SANCTION_ELEMENT");

            entity.ToTable("S_SANCTION_ELEMENT");

            entity.Property(e => e.CSanctionElement).HasColumnName("C_SANCTION_ELEMENT");
            entity.Property(e => e.CElement).HasColumnName("C_ELEMENT");
            entity.Property(e => e.CSanction).HasColumnName("C_SANCTION");

            entity.HasOne(d => d.CElementNavigation).WithMany(p => p.SSanctionElements)
                .HasForeignKey(d => d.CElement)
                .HasConstraintName("FK_D_SANCTION_ELEMENT_S_ELEMENT");

            entity.HasOne(d => d.CSanctionNavigation).WithMany(p => p.SSanctionElements)
                .HasForeignKey(d => d.CSanction)
                .HasConstraintName("FK_D_SANCTION_ELEMENT_S_SANCTION");
        });

        modelBuilder.Entity<SSanctionGroup>(entity =>
        {
            entity.HasKey(e => e.CSanctionGroup);

            entity.ToTable("S_SANCTION_GROUP");

            entity.Property(e => e.CSanctionGroup).HasColumnName("C_SANCTION_GROUP");
            entity.Property(e => e.CSeason).HasColumnName("C_SEASON");
            entity.Property(e => e.CTypeObject).HasColumnName("C_TYPE_OBJECT");
            entity.Property(e => e.Claim)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("CLAIM");
            entity.Property(e => e.NSanctionGroup)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("N_SANCTION_GROUP");

            entity.HasOne(d => d.CSeasonNavigation).WithMany(p => p.SSanctionGroups)
                .HasForeignKey(d => d.CSeason)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_S_SANCTION_GROUP_S_SANCTION_GROUP");

            entity.HasOne(d => d.CTypeObjectNavigation).WithMany(p => p.SSanctionGroups)
                .HasForeignKey(d => d.CTypeObject)
                .HasConstraintName("FK_C_TYPE_OBJECT_S_TYPE_OBJECT");
        });

        modelBuilder.Entity<SSeason>(entity =>
        {
            entity.HasKey(e => e.CSeason);

            entity.ToTable("S_SEASON");

            entity.Property(e => e.CSeason).HasColumnName("C_SEASON");
            entity.Property(e => e.NSeason)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("N_SEASON");
        });

        modelBuilder.Entity<SStatusObject>(entity =>
        {
            entity.HasKey(e => e.CStatusObject);

            entity.ToTable("S_STATUS_OBJECT");

            entity.Property(e => e.CStatusObject).HasColumnName("C_STATUS_OBJECT");
            entity.Property(e => e.NStatusObject)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("N_STATUS_OBJECT");
        });

        modelBuilder.Entity<STypeBlock>(entity =>
        {
            entity.HasKey(e => e.CTypeBlock);

            entity.ToTable("S_TYPE_BLOCK");

            entity.Property(e => e.CTypeBlock).HasColumnName("C_TYPE_BLOCK");
            entity.Property(e => e.NTypeBlock)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("N_TYPE_BLOCK");
        });

        modelBuilder.Entity<STypeBridge>(entity =>
        {
            entity.HasKey(e => e.CTypeBridge);

            entity.ToTable("S_TYPE_BRIDGE");

            entity.Property(e => e.CTypeBridge).HasColumnName("C_TYPE_BRIDGE");
            entity.Property(e => e.NTypeBridge)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("N_TYPE_BRIDGE");
        });

        modelBuilder.Entity<STypeElement>(entity =>
        {
            entity.HasKey(e => e.CTypeElement);

            entity.ToTable("S_TYPE_ELEMENT");

            entity.Property(e => e.CTypeElement)
                .ValueGeneratedNever()
                .HasColumnName("C_TYPE_ELEMENT");
            entity.Property(e => e.NTypeElement)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("N_TYPE_ELEMENT");
        });

        modelBuilder.Entity<STypeMessage>(entity =>
        {
            entity.HasKey(e => e.CTypeMessage);

            entity.ToTable("S_TYPE_MESSAGE");

            entity.Property(e => e.CTypeMessage)
                .ValueGeneratedNever()
                .HasColumnName("C_TYPE_MESSAGE");
            entity.Property(e => e.NTypeMessage)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("N_TYPE_MESSAGE");
        });

        modelBuilder.Entity<STypeObject>(entity =>
        {
            entity.HasKey(e => e.CTypeObject);

            entity.ToTable("S_TYPE_OBJECT");

            entity.Property(e => e.CTypeObject)
                .ValueGeneratedNever()
                .HasColumnName("C_TYPE_OBJECT");
            entity.Property(e => e.NTypeObject)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("N_TYPE_OBJECT");
        });

        modelBuilder.Entity<STypePokr>(entity =>
        {
            entity.HasKey(e => e.CTypePokr);

            entity.ToTable("S_TYPE_POKR");

            entity.Property(e => e.CTypePokr)
                .ValueGeneratedNever()
                .HasColumnName("C_TYPE_POKR");
            entity.Property(e => e.NTypePokr)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("N_TYPE_POKR");
            entity.Property(e => e.TypeGroup).HasColumnName("TYPE_GROUP");
        });

        modelBuilder.Entity<SUnit>(entity =>
        {
            entity.HasKey(e => e.CUnit);

            entity.ToTable("S_UNIT", tb => tb.HasTrigger("TR_WEB_API_S_UNIT"));

            entity.Property(e => e.CUnit).HasColumnName("C_UNIT");
            entity.Property(e => e.Comma)
                .HasDefaultValueSql("((2))")
                .HasColumnName("COMMA");
            entity.Property(e => e.NUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("N_UNIT");
            entity.Property(e => e.NameUnit)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME_UNIT");
        });

        modelBuilder.Entity<SWork>(entity =>
        {
            entity.HasKey(e => e.CWork);

            entity.ToTable("S_WORK", tb => tb.HasTrigger("TR_WEB_API_S_WORK"));

            entity.Property(e => e.CWork).HasColumnName("C_WORK");
            entity.Property(e => e.AisWorkGroup).HasColumnName("AIS_WORK_GROUP");
            entity.Property(e => e.CUnit).HasColumnName("C_UNIT");
            entity.Property(e => e.CheckGroup).HasColumnName("CHECK_GROUP");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CostExpl)
                .HasDefaultValueSql("((0))")
                .HasColumnName("COST_EXPL");
            entity.Property(e => e.CostExplNow)
                .HasDefaultValueSql("((0))")
                .HasColumnName("COST_EXPL_NOW");
            entity.Property(e => e.CostMaterial)
                .HasDefaultValueSql("((0))")
                .HasColumnName("COST_MATERIAL");
            entity.Property(e => e.CostMaterialNow)
                .HasDefaultValueSql("((0))")
                .HasColumnName("COST_MATERIAL_NOW");
            entity.Property(e => e.GeneralSalary)
                .HasDefaultValueSql("((0))")
                .HasColumnName("GENERAL_SALARY");
            entity.Property(e => e.GeneralSalaryNow)
                .HasDefaultValueSql("((0))")
                .HasColumnName("GENERAL_SALARY_NOW");
            entity.Property(e => e.IsMinus).HasColumnName("IS_MINUS");
            entity.Property(e => e.Kind)
                .HasDefaultValueSql("((0))")
                .HasColumnName("KIND");
            entity.Property(e => e.MainWork).HasColumnName("MAIN_WORK");
            entity.Property(e => e.NWork)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("N_WORK");
            entity.Property(e => e.PeriodRepeat).HasColumnName("PERIOD_REPEAT");
            entity.Property(e => e.SalaryMachine)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SALARY_MACHINE");
            entity.Property(e => e.SalaryMachineNow)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SALARY_MACHINE_NOW");
            entity.Property(e => e.UseDetail)
                .HasDefaultValueSql("((0))")
                .HasColumnName("USE_DETAIL");
            entity.Property(e => e.UseInDetailsReport)
                .HasDefaultValueSql("((0))")
                .HasColumnName("USE_IN_DETAILS_REPORT");

            entity.HasOne(d => d.CUnitNavigation).WithMany(p => p.SWorks)
                .HasForeignKey(d => d.CUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_S_WORK_S_UNIT");
        });

        modelBuilder.Entity<SWorkDetail>(entity =>
        {
            entity.HasKey(e => new { e.CWork, e.CWorkGroup });

            entity.ToTable("S_WORK_DETAIL", tb =>
            {
                tb.HasTrigger("TRIG_DEL_S_WORK_DETAIL");
                tb.HasTrigger("TRIG_INS_S_WORK_DETAIL");
            });

            entity.Property(e => e.CWork).HasColumnName("C_WORK");
            entity.Property(e => e.CWorkGroup).HasColumnName("C_WORK_GROUP");
            entity.Property(e => e.CWorkDetail)
                .ValueGeneratedOnAdd()
                .HasColumnName("C_WORK_DETAIL");

            entity.HasOne(d => d.CWorkNavigation).WithMany(p => p.SWorkDetails)
                .HasForeignKey(d => d.CWork)
                .HasConstraintName("FK_S_WORK_DETAIL_S_WORK");

            entity.HasOne(d => d.CWorkGroupNavigation).WithMany(p => p.SWorkDetails)
                .HasForeignKey(d => d.CWorkGroup)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_S_WORK_DETAIL_S_WORK_GROUP");
        });

        modelBuilder.Entity<SWorkGroup>(entity =>
        {
            entity.HasKey(e => e.CWorkGroup);

            entity.ToTable("S_WORK_GROUP");

            entity.Property(e => e.CWorkGroup).HasColumnName("C_WORK_GROUP");
            entity.Property(e => e.Kind)
                .HasDefaultValueSql("((0))")
                .HasColumnName("KIND");
            entity.Property(e => e.NWorkGroup)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("N_WORK_GROUP");
        });

        modelBuilder.Entity<SWorkKind>(entity =>
        {
            entity.HasKey(e => e.CWorkKind).HasName("PK_WORK_KIND");

            entity.ToTable("S_WORK_KIND");

            entity.Property(e => e.CWorkKind)
                .ValueGeneratedNever()
                .HasColumnName("C_WORK_KIND");
            entity.Property(e => e.NWorkKind)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("N_WORK_KIND");
        });

        modelBuilder.Entity<SWorkResMachinist>(entity =>
        {
            entity.HasKey(e => e.CWorkResMachinist);

            entity.ToTable("S_WORK_RES_MACHINIST");

            entity.Property(e => e.CWorkResMachinist).HasColumnName("C_WORK_RES_MACHINIST");
            entity.Property(e => e.CResMachinist).HasColumnName("C_RES_MACHINIST");
            entity.Property(e => e.CWork).HasColumnName("C_WORK");
            entity.Property(e => e.DateCreate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATE");
            entity.Property(e => e.DateUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_UPDATE");
            entity.Property(e => e.Value).HasColumnName("VALUE");

            entity.HasOne(d => d.CResMachinistNavigation).WithMany(p => p.SWorkResMachinists)
                .HasForeignKey(d => d.CResMachinist)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_S_WORK_RES_MACHINIST_S_RES_MACHINIST");

            entity.HasOne(d => d.CWorkNavigation).WithMany(p => p.SWorkResMachinists)
                .HasForeignKey(d => d.CWork)
                .HasConstraintName("FK_S_WORK_RES_MACHINIST_S_WORK");
        });

        modelBuilder.Entity<SWorkResMaterial>(entity =>
        {
            entity.HasKey(e => e.CWorkResMaterial);

            entity.ToTable("S_WORK_RES_MATERIAL");

            entity.Property(e => e.CWorkResMaterial).HasColumnName("C_WORK_RES_MATERIAL");
            entity.Property(e => e.CResMaterial).HasColumnName("C_RES_MATERIAL");
            entity.Property(e => e.CWork).HasColumnName("C_WORK");
            entity.Property(e => e.DateCreate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATE");
            entity.Property(e => e.DateUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_UPDATE");
            entity.Property(e => e.Value).HasColumnName("VALUE");

            entity.HasOne(d => d.CResMaterialNavigation).WithMany(p => p.SWorkResMaterials)
                .HasForeignKey(d => d.CResMaterial)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_S_WORK_RES_MATERIAL_S_RES_MATERIAL");

            entity.HasOne(d => d.CWorkNavigation).WithMany(p => p.SWorkResMaterials)
                .HasForeignKey(d => d.CWork)
                .HasConstraintName("FK_S_WORK_RES_MATERIAL_S_WORK");
        });

        modelBuilder.Entity<SWorkResMechanism>(entity =>
        {
            entity.HasKey(e => e.CWorkResMechanism);

            entity.ToTable("S_WORK_RES_MECHANISM");

            entity.Property(e => e.CWorkResMechanism).HasColumnName("C_WORK_RES_MECHANISM");
            entity.Property(e => e.CResMechanism).HasColumnName("C_RES_MECHANISM");
            entity.Property(e => e.CWork).HasColumnName("C_WORK");
            entity.Property(e => e.DateCreate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATE");
            entity.Property(e => e.DateUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_UPDATE");
            entity.Property(e => e.Value).HasColumnName("VALUE");

            entity.HasOne(d => d.CResMechanismNavigation).WithMany(p => p.SWorkResMechanisms)
                .HasForeignKey(d => d.CResMechanism)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_S_WORK_RES_MECHANISM_S_RES_MECHANISM");

            entity.HasOne(d => d.CWorkNavigation).WithMany(p => p.SWorkResMechanisms)
                .HasForeignKey(d => d.CWork)
                .HasConstraintName("FK_S_WORK_RES_MECHANISM_S_WORK");
        });

        modelBuilder.Entity<SWorkResWorker>(entity =>
        {
            entity.HasKey(e => e.CWorkResWorker);

            entity.ToTable("S_WORK_RES_WORKER");

            entity.Property(e => e.CWorkResWorker).HasColumnName("C_WORK_RES_WORKER");
            entity.Property(e => e.CResWorker).HasColumnName("C_RES_WORKER");
            entity.Property(e => e.CWork).HasColumnName("C_WORK");
            entity.Property(e => e.DateCreate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATE");
            entity.Property(e => e.DateUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_UPDATE");
            entity.Property(e => e.Value).HasColumnName("VALUE");

            entity.HasOne(d => d.CResWorkerNavigation).WithMany(p => p.SWorkResWorkers)
                .HasForeignKey(d => d.CResWorker)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_S_WORK_RES_WORKER_S_RES_WORKER");

            entity.HasOne(d => d.CWorkNavigation).WithMany(p => p.SWorkResWorkers)
                .HasForeignKey(d => d.CWork)
                .HasConstraintName("FK_S_WORK_RES_WORKER_S_WORK");
        });

        modelBuilder.Entity<TablesApplication>(entity =>
        {
            entity.HasKey(e => e.CApplication);

            entity.ToTable("TABLES_APPLICATION");

            entity.Property(e => e.CApplication)
                .ValueGeneratedNever()
                .HasColumnName("C_APPLICATION");
            entity.Property(e => e.NApplication)
                .HasMaxLength(50)
                .HasColumnName("N_APPLICATION");
        });

        modelBuilder.Entity<TablesFieldType>(entity =>
        {
            entity.HasKey(e => e.CFieldType);

            entity.ToTable("TABLES_FIELD_TYPE");

            entity.Property(e => e.CFieldType)
                .ValueGeneratedNever()
                .HasColumnName("C_FIELD_TYPE");
            entity.Property(e => e.TName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("T_NAME");
        });

        modelBuilder.Entity<TablesInfo>(entity =>
        {
            entity.HasKey(e => e.CTablesInfo);

            entity.ToTable("TABLES_INFO");

            entity.Property(e => e.CTablesInfo).HasColumnName("C_TABLES_INFO");
            entity.Property(e => e.DateCreate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATE");
            entity.Property(e => e.DateUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_UPDATE");
            entity.Property(e => e.Info)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("INFO");
            entity.Property(e => e.Kind).HasColumnName("KIND");
            entity.Property(e => e.Notes)
                .HasColumnType("text")
                .HasColumnName("NOTES");
            entity.Property(e => e.UniqueValue).HasColumnName("UNIQUE_VALUE");
        });

        modelBuilder.Entity<TablesList>(entity =>
        {
            entity.HasKey(e => e.CTable);

            entity.ToTable("TABLES_LIST");

            entity.Property(e => e.CTable)
                .ValueGeneratedNever()
                .HasColumnName("C_TABLE");
            entity.Property(e => e.CGroup).HasColumnName("C_GROUP");
            entity.Property(e => e.CParent).HasColumnName("C_PARENT");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.IsSprav).HasColumnName("IS_SPRAV");
            entity.Property(e => e.NTable)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("N_TABLE");
            entity.Property(e => e.Notes)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.SpravType).HasColumnName("SPRAV_TYPE");
            entity.Property(e => e.UseImages).HasColumnName("USE_IMAGES");
            entity.Property(e => e.UseScheme).HasColumnName("USE_SCHEME");
        });

        modelBuilder.Entity<TablesLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TABLES_LOG");

            entity.Property(e => e.CApplication).HasColumnName("C_APPLICATION");
            entity.Property(e => e.CLog)
                .ValueGeneratedOnAdd()
                .HasColumnName("C_LOG");
            entity.Property(e => e.CObject).HasColumnName("C_OBJECT");
            entity.Property(e => e.CTable).HasColumnName("C_TABLE");
            entity.Property(e => e.CType).HasColumnName("C_TYPE");
            entity.Property(e => e.CUser).HasColumnName("C_USER");
            entity.Property(e => e.DateCreate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATE");
            entity.Property(e => e.NMessage).HasColumnName("N_MESSAGE");
            entity.Property(e => e.NUrl).HasColumnName("N_URL");
        });

        modelBuilder.Entity<TablesNews>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TABLES_NEWS");

            entity.Property(e => e.CNews)
                .ValueGeneratedOnAdd()
                .HasColumnName("C_NEWS");
            entity.Property(e => e.DateBegin)
                .HasColumnType("datetime")
                .HasColumnName("DATE_BEGIN");
            entity.Property(e => e.DateEnd)
                .HasColumnType("datetime")
                .HasColumnName("DATE_END");
            entity.Property(e => e.Enabled).HasColumnName("ENABLED");
            entity.Property(e => e.Image)
                .HasColumnType("image")
                .HasColumnName("IMAGE");
            entity.Property(e => e.NNews)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("N_NEWS");
            entity.Property(e => e.Text)
                .HasColumnType("text")
                .HasColumnName("TEXT");
        });

        modelBuilder.Entity<TablesParam>(entity =>
        {
            entity.HasKey(e => e.CParam);

            entity.ToTable("TABLES_PARAM");

            entity.Property(e => e.CParam)
                .ValueGeneratedNever()
                .HasColumnName("C_PARAM");
            entity.Property(e => e.ParamName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PARAM_NAME");
            entity.Property(e => e.ParamValue).HasColumnName("PARAM_VALUE");
            entity.Property(e => e.ParamValueStr)
                .IsUnicode(false)
                .HasColumnName("PARAM_VALUE_STR");
        });

        modelBuilder.Entity<TablesReport>(entity =>
        {
            entity.HasKey(e => e.CReport);

            entity.ToTable("TABLES_REPORTS");

            entity.Property(e => e.CReport)
                .ValueGeneratedNever()
                .HasColumnName("C_REPORT");
            entity.Property(e => e.DateBeg)
                .HasColumnType("datetime")
                .HasColumnName("DATE_BEG");
            entity.Property(e => e.DateEnd)
                .HasColumnType("datetime")
                .HasColumnName("DATE_END");
            entity.Property(e => e.IsFormed).HasColumnName("IS_FORMED");
            entity.Property(e => e.NReport)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("N_REPORT");
            entity.Property(e => e.ReportLink)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("REPORT_LINK");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<TablesReportsDetail>(entity =>
        {
            entity.HasKey(e => e.CReportDetail);

            entity.ToTable("TABLES_REPORTS_DETAIL");

            entity.Property(e => e.CReportDetail).HasColumnName("C_REPORT_DETAIL");
            entity.Property(e => e.CApplication).HasColumnName("C_APPLICATION");
            entity.Property(e => e.CReport).HasColumnName("C_REPORT");
            entity.Property(e => e.CUser).HasColumnName("C_USER");
            entity.Property(e => e.DateReport)
                .HasColumnType("datetime")
                .HasColumnName("DATE_REPORT");
            entity.Property(e => e.ParamsReport)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("PARAMS_REPORT");
            entity.Property(e => e.ReportLink)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("REPORT_LINK");
        });

        modelBuilder.Entity<TablesRole>(entity =>
        {
            entity.HasKey(e => e.CRole);

            entity.ToTable("TABLES_ROLES");

            entity.Property(e => e.CRole)
                .ValueGeneratedNever()
                .HasColumnName("C_ROLE");
            entity.Property(e => e.Block).HasColumnName("BLOCK");
            entity.Property(e => e.NRole)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("N_ROLE");
        });

        modelBuilder.Entity<TablesSetting>(entity =>
        {
            entity.HasKey(e => e.CSettings).HasName("PK_TEMP_SETTINGS");

            entity.ToTable("TABLES_SETTINGS");

            entity.Property(e => e.CSettings)
                .ValueGeneratedNever()
                .HasColumnName("C_SETTINGS");
            entity.Property(e => e.ActualBridge).HasColumnName("ACTUAL_BRIDGE");
            entity.Property(e => e.ActualObject).HasColumnName("ACTUAL_OBJECT");
            entity.Property(e => e.ActualReport)
                .HasColumnType("datetime")
                .HasColumnName("ACTUAL_REPORT");
            entity.Property(e => e.ActualReportComment)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ACTUAL_REPORT_COMMENT");
            entity.Property(e => e.ActualVirtualReport)
                .HasColumnType("datetime")
                .HasColumnName("ACTUAL_VIRTUAL_REPORT");
            entity.Property(e => e.PriceLevel)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PRICE_LEVEL");
            entity.Property(e => e.SmetaDateBegin)
                .HasColumnType("datetime")
                .HasColumnName("SMETA_DATE_BEGIN");
            entity.Property(e => e.SmetaDateEnd)
                .HasColumnType("datetime")
                .HasColumnName("SMETA_DATE_END");
            entity.Property(e => e.SmetaName)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("SMETA_NAME");
        });

        modelBuilder.Entity<TablesType>(entity =>
        {
            entity.HasKey(e => e.CType);

            entity.ToTable("TABLES_TYPE");

            entity.Property(e => e.CType).HasColumnName("C_TYPE");
            entity.Property(e => e.CFieldType).HasColumnName("C_FIELD_TYPE");
            entity.Property(e => e.Color).HasColumnName("COLOR");
            entity.Property(e => e.Enabled)
                .HasDefaultValueSql("((1))")
                .HasColumnName("ENABLED");
            entity.Property(e => e.NShort)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("N_SHORT");
            entity.Property(e => e.TName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("T_NAME");
            entity.Property(e => e.TValue).HasColumnName("T_VALUE");

            entity.HasOne(d => d.CFieldTypeNavigation).WithMany(p => p.TablesTypes)
                .HasForeignKey(d => d.CFieldType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TABLES_TYPE_TABLES_FIELD_TYPE");
        });

        modelBuilder.Entity<TablesUpdate>(entity =>
        {
            entity.HasKey(e => e.CUpdate);

            entity.ToTable("TABLES_UPDATES");

            entity.Property(e => e.CUpdate)
                .ValueGeneratedNever()
                .HasColumnName("C_UPDATE");
            entity.Property(e => e.Build)
                .HasDefaultValueSql("((0))")
                .HasColumnName("BUILD");
            entity.Property(e => e.Code).HasColumnName("CODE");
            entity.Property(e => e.DatePasp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_PASP");
            entity.Property(e => e.Description)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
        });

        modelBuilder.Entity<TablesUser>(entity =>
        {
            entity.HasKey(e => e.CUser);

            entity.ToTable("TABLES_USERS");

            entity.Property(e => e.CUser).HasColumnName("C_USER");
            entity.Property(e => e.CContractor).HasColumnName("C_CONTRACTOR");
            entity.Property(e => e.CGeneralContractor).HasColumnName("C_GENERAL_CONTRACTOR");
            entity.Property(e => e.CRole).HasColumnName("C_ROLE");
            entity.Property(e => e.DatePasp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_PASP");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DISPLAY_NAME");
            entity.Property(e => e.Enabled)
                .HasDefaultValueSql("((1))")
                .HasColumnName("ENABLED");
            entity.Property(e => e.Login)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LOGIN");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");

            entity.HasOne(d => d.CContractorNavigation).WithMany(p => p.TablesUsers)
                .HasForeignKey(d => d.CContractor)
                .HasConstraintName("FK_TABLES_USERS_D_CONTRACTOR");

            entity.HasOne(d => d.CGeneralContractorNavigation).WithMany(p => p.TablesUsers)
                .HasForeignKey(d => d.CGeneralContractor)
                .HasConstraintName("FK_TABLES_USERS_D_GENERAL_CONTRACTOR");

            entity.HasOne(d => d.CRoleNavigation).WithMany(p => p.TablesUsers)
                .HasForeignKey(d => d.CRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TABLES_USERS_TABLES_ROLES");
        });

        modelBuilder.Entity<TempForDelete>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_FOR_DELETE");

            entity.Property(e => e.CWork).HasColumnName("C_WORK");
            entity.Property(e => e.CWorkGroup).HasColumnName("C_WORK_GROUP");
        });

        modelBuilder.Entity<TempObject>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temp_objects");

            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("code");
            entity.Property(e => e.El1)
                .HasMaxLength(255)
                .HasColumnName("el1");
            entity.Property(e => e.El2).HasColumnName("el2");
            entity.Property(e => e.El3).HasColumnName("el3");
            entity.Property(e => e.El4).HasColumnName("el4");
            entity.Property(e => e.El5).HasColumnName("el5");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Road)
                .HasMaxLength(255)
                .HasColumnName("road");
            entity.Property(e => e.Start).HasColumnName("start");
            entity.Property(e => e.Width).HasColumnName("width");
        });

        modelBuilder.Entity<TempSelectedObject>(entity =>
        {
            entity.HasKey(e => e.CSelectedObjects);

            entity.ToTable("TEMP_SELECTED_OBJECTS");

            entity.Property(e => e.CSelectedObjects)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("C_SELECTED_OBJECTS");
            entity.Property(e => e.CClimatZone).HasColumnName("C_CLIMAT_ZONE");
            entity.Property(e => e.CContract).HasColumnName("C_CONTRACT");
            entity.Property(e => e.CExplCategory).HasColumnName("C_EXPL_CATEGORY");
            entity.Property(e => e.CMonthBegin).HasColumnName("C_MONTH_BEGIN");
            entity.Property(e => e.CMonthEnd).HasColumnName("C_MONTH_END");
            entity.Property(e => e.CObject).HasColumnName("C_OBJECT");
            entity.Property(e => e.CRegion).HasColumnName("C_REGION");
            entity.Property(e => e.CTypeObject).HasColumnName("C_TYPE_OBJECT");
            entity.Property(e => e.CoefArea).HasColumnName("COEF_AREA");
            entity.Property(e => e.CoefObject).HasColumnName("COEF_OBJECT");
            entity.Property(e => e.CoefRegion).HasColumnName("COEF_REGION");
            entity.Property(e => e.CoefSalary).HasColumnName("COEF_SALARY");

            entity.HasOne(d => d.CClimatZoneNavigation).WithMany(p => p.TempSelectedObjects)
                .HasForeignKey(d => d.CClimatZone)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TEMP_SELECTED_OBJECTS_S_CLIMAT_ZONE");

            entity.HasOne(d => d.CContractNavigation).WithMany(p => p.TempSelectedObjects)
                .HasForeignKey(d => d.CContract)
                .HasConstraintName("FK_TEMP_SELECTED_OBJECTS_D_CONTRACT");

            entity.HasOne(d => d.CExplCategoryNavigation).WithMany(p => p.TempSelectedObjects)
                .HasForeignKey(d => d.CExplCategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TEMP_SELECTED_OBJECTS_S_EXPL_CATEGORY");

            entity.HasOne(d => d.CMonthBeginNavigation).WithMany(p => p.TempSelectedObjectCMonthBeginNavigations)
                .HasForeignKey(d => d.CMonthBegin)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TEMP_SELECTED_OBJECTS_D_MONTH_BEGIN");

            entity.HasOne(d => d.CMonthEndNavigation).WithMany(p => p.TempSelectedObjectCMonthEndNavigations)
                .HasForeignKey(d => d.CMonthEnd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TEMP_SELECTED_OBJECTS_D_MONTH_END");

            entity.HasOne(d => d.CObjectNavigation).WithMany(p => p.TempSelectedObjects)
                .HasForeignKey(d => d.CObject)
                .HasConstraintName("FK_TEMP_SELECTED_OBJECTS_TEMP_SELECTED_OBJECTS");

            entity.HasOne(d => d.CRegionNavigation).WithMany(p => p.TempSelectedObjects)
                .HasForeignKey(d => d.CRegion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TEMP_SELECTED_OBJECTS_S_REGION");

            entity.HasOne(d => d.CTypeObjectNavigation).WithMany(p => p.TempSelectedObjects)
                .HasForeignKey(d => d.CTypeObject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TEMP_SELECTED_OBJECTS_S_TYPE_OBJECT");
        });

        modelBuilder.Entity<TempSmetaPlan>(entity =>
        {
            entity.HasKey(e => e.CSmeta);

            entity.ToTable("TEMP_SMETA_PLAN");

            entity.HasIndex(e => e.CObject, "INDEX_TEMP_SMETA_PLAN");

            entity.HasIndex(e => e.CContract, "INDEX_TEMP_SMETA_PLAN_C_CONTRACT");

            entity.HasIndex(e => e.KindWorkGroup, "INDEX_TEMP_SMETA_PLAN_KIND_WORK_GROUP");

            entity.HasIndex(e => e.KindWorkGroup, "INDEX_TEMP_SMETA_PLAN_KIND_WORK_GROUP_ANALYZE");

            entity.HasIndex(e => new { e.KindWorkGroup, e.CWork }, "INDEX_TEMP_SMETA_PLAN_KIND_WORK_GROUP_ANALYZE2");

            entity.HasIndex(e => new { e.KindWorkGroup, e.CMonthBegin, e.CMonthEnd }, "INDEX_TEMP_SMETA_PLAN_KIND_WORK_GROUP_ANALYZE3");

            entity.HasIndex(e => new { e.CContract, e.KindWorkGroup }, "INDEX_TEMP_SMETA_PLAN_KIND_WORK_GROUP_ANALYZE4");

            entity.Property(e => e.CSmeta)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("C_SMETA");
            entity.Property(e => e.CCiclic).HasColumnName("C_CICLIC");
            entity.Property(e => e.CClimatZone).HasColumnName("C_CLIMAT_ZONE");
            entity.Property(e => e.CContract).HasColumnName("C_CONTRACT");
            entity.Property(e => e.CElement).HasColumnName("C_ELEMENT");
            entity.Property(e => e.CExplCategory).HasColumnName("C_EXPL_CATEGORY");
            entity.Property(e => e.CKurator).HasColumnName("C_KURATOR");
            entity.Property(e => e.CMonthBegin).HasColumnName("C_MONTH_BEGIN");
            entity.Property(e => e.CMonthEnd).HasColumnName("C_MONTH_END");
            entity.Property(e => e.CObject).HasColumnName("C_OBJECT");
            entity.Property(e => e.CObjectElement).HasColumnName("C_OBJECT_ELEMENT");
            entity.Property(e => e.CRegion).HasColumnName("C_REGION");
            entity.Property(e => e.CRoad).HasColumnName("C_ROAD");
            entity.Property(e => e.CTypeObject).HasColumnName("C_TYPE_OBJECT");
            entity.Property(e => e.CVirtualObject).HasColumnName("C_VIRTUAL_OBJECT");
            entity.Property(e => e.CWork).HasColumnName("C_WORK");
            entity.Property(e => e.CWorkGroup).HasColumnName("C_WORK_GROUP");
            entity.Property(e => e.CoefContractor).HasColumnName("COEF_CONTRACTOR");
            entity.Property(e => e.CoefObject).HasColumnName("COEF_OBJECT");
            entity.Property(e => e.CoefRegion).HasColumnName("COEF_REGION");
            entity.Property(e => e.CoefSalary).HasColumnName("COEF_SALARY");
            entity.Property(e => e.CoefValueWork).HasColumnName("COEF_VALUE_WORK");
            entity.Property(e => e.Costonework).HasColumnName("COSTONEWORK");
            entity.Property(e => e.CostoneworkNow).HasColumnName("COSTONEWORK_NOW");
            entity.Property(e => e.CountValue).HasColumnName("COUNT_VALUE");
            entity.Property(e => e.DateActual)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_ACTUAL");
            entity.Property(e => e.FotValue).HasColumnName("FOT_VALUE");
            entity.Property(e => e.FotValueNow).HasColumnName("FOT_VALUE_NOW");
            entity.Property(e => e.KindWorkGroup).HasColumnName("KIND_WORK_GROUP");
            entity.Property(e => e.KuratorName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("KURATOR_NAME");

            entity.HasOne(d => d.CCiclicNavigation).WithMany(p => p.TempSmetaPlans)
                .HasForeignKey(d => d.CCiclic)
                .HasConstraintName("FK_TEMP_SMETA_PLAN_S_CICLIC");

            entity.HasOne(d => d.CClimatZoneNavigation).WithMany(p => p.TempSmetaPlans)
                .HasForeignKey(d => d.CClimatZone)
                .HasConstraintName("FK_TEMP_SMETA_PLAN_BOTH_S_CLIMAT_ZONE");

            entity.HasOne(d => d.CContractNavigation).WithMany(p => p.TempSmetaPlans)
                .HasForeignKey(d => d.CContract)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TEMP_SMETA_PLAN_BOTH_D_CONTRACT");

            entity.HasOne(d => d.CElementNavigation).WithMany(p => p.TempSmetaPlans)
                .HasForeignKey(d => d.CElement)
                .HasConstraintName("FK_TEMP_SMETA_PLAN_S_ELEMENT");

            entity.HasOne(d => d.CExplCategoryNavigation).WithMany(p => p.TempSmetaPlans)
                .HasForeignKey(d => d.CExplCategory)
                .HasConstraintName("FK_TEMP_SMETA_PLAN_BOTH_S_EXPL_CATEGORY");

            entity.HasOne(d => d.CMonthBeginNavigation).WithMany(p => p.TempSmetaPlanCMonthBeginNavigations)
                .HasForeignKey(d => d.CMonthBegin)
                .HasConstraintName("FK_TEMP_SMETA_PLAN_BOTH_D_MONTH_BEGIN");

            entity.HasOne(d => d.CMonthEndNavigation).WithMany(p => p.TempSmetaPlanCMonthEndNavigations)
                .HasForeignKey(d => d.CMonthEnd)
                .HasConstraintName("FK_TEMP_SMETA_PLAN_D_MONTH_END");

            entity.HasOne(d => d.CObjectNavigation).WithMany(p => p.TempSmetaPlans)
                .HasForeignKey(d => d.CObject)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TEMP_SMETA_PLAN_BOTH_D_OBJECT");

            entity.HasOne(d => d.CRoadNavigation).WithMany(p => p.TempSmetaPlans)
                .HasForeignKey(d => d.CRoad)
                .HasConstraintName("FK_TEMP_SMETA_PLAN_D_ROAD");

            entity.HasOne(d => d.CTypeObjectNavigation).WithMany(p => p.TempSmetaPlans)
                .HasForeignKey(d => d.CTypeObject)
                .HasConstraintName("FK_TEMP_SMETA_PLAN_S_TYPE_OBJECT");

            entity.HasOne(d => d.CVirtualObjectNavigation).WithMany(p => p.TempSmetaPlans)
                .HasForeignKey(d => d.CVirtualObject)
                .HasConstraintName("FK_TEMP_SMETA_PLAN_D_VIRTUAL_OBJECT");

            entity.HasOne(d => d.CWorkNavigation).WithMany(p => p.TempSmetaPlans)
                .HasForeignKey(d => d.CWork)
                .HasConstraintName("FK_TEMP_SMETA_PLAN_BOTH_S_WORK");

            entity.HasOne(d => d.CWorkGroupNavigation).WithMany(p => p.TempSmetaPlans)
                .HasForeignKey(d => d.CWorkGroup)
                .HasConstraintName("FK_TEMP_SMETA_PLAN_BOTH_S_WORK_GROUP");
        });

        modelBuilder.Entity<TempSmetum>(entity =>
        {
            entity.HasKey(e => e.CSmeta);

            entity.ToTable("TEMP_SMETA");

            entity.HasIndex(e => new { e.CContract, e.CWork }, "INDEX_TEMP_SMETA_INCLUDE");

            entity.HasIndex(e => e.CWork, "INDEX_TEMP_SMETA_INCLUDE_JOURNAL");

            entity.HasIndex(e => new { e.CWork, e.CCiclic }, "INDEX_TEMP_SMETA_INCLUDE_JOURNAL2");

            entity.HasIndex(e => new { e.CWork, e.CObjectElement }, "INDEX_TEMP_SMETA_WORK_OBJECT_ELEMENT");

            entity.HasIndex(e => new { e.CElement, e.CWork, e.CoefSalary, e.CClimatZone, e.CMonthBegin, e.CMonthEnd }, "IX_TEMP_SMETA");

            entity.Property(e => e.CSmeta)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("C_SMETA");
            entity.Property(e => e.CCiclic).HasColumnName("C_CICLIC");
            entity.Property(e => e.CClimatZone).HasColumnName("C_CLIMAT_ZONE");
            entity.Property(e => e.CContract).HasColumnName("C_CONTRACT");
            entity.Property(e => e.CElement).HasColumnName("C_ELEMENT");
            entity.Property(e => e.CExplCategory).HasColumnName("C_EXPL_CATEGORY");
            entity.Property(e => e.CKurator).HasColumnName("C_KURATOR");
            entity.Property(e => e.CMonthBegin).HasColumnName("C_MONTH_BEGIN");
            entity.Property(e => e.CMonthEnd).HasColumnName("C_MONTH_END");
            entity.Property(e => e.CObject).HasColumnName("C_OBJECT");
            entity.Property(e => e.CObjectElement).HasColumnName("C_OBJECT_ELEMENT");
            entity.Property(e => e.CRegion).HasColumnName("C_REGION");
            entity.Property(e => e.CRoad).HasColumnName("C_ROAD");
            entity.Property(e => e.CTypeObject).HasColumnName("C_TYPE_OBJECT");
            entity.Property(e => e.CVirtualObject).HasColumnName("C_VIRTUAL_OBJECT");
            entity.Property(e => e.CWork).HasColumnName("C_WORK");
            entity.Property(e => e.CWorkGroup).HasColumnName("C_WORK_GROUP");
            entity.Property(e => e.CoefContractor).HasColumnName("COEF_CONTRACTOR");
            entity.Property(e => e.CoefObject).HasColumnName("COEF_OBJECT");
            entity.Property(e => e.CoefRegion).HasColumnName("COEF_REGION");
            entity.Property(e => e.CoefSalary).HasColumnName("COEF_SALARY");
            entity.Property(e => e.CoefValueWork).HasColumnName("COEF_VALUE_WORK");
            entity.Property(e => e.Costonework).HasColumnName("COSTONEWORK");
            entity.Property(e => e.CostoneworkNow).HasColumnName("COSTONEWORK_NOW");
            entity.Property(e => e.CountValue).HasColumnName("COUNT_VALUE");
            entity.Property(e => e.DateActual)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_ACTUAL");
            entity.Property(e => e.FotValue).HasColumnName("FOT_VALUE");
            entity.Property(e => e.FotValueNow).HasColumnName("FOT_VALUE_NOW");
            entity.Property(e => e.KindWorkGroup).HasColumnName("KIND_WORK_GROUP");
            entity.Property(e => e.KuratorName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("KURATOR_NAME");

            entity.HasOne(d => d.CCiclicNavigation).WithMany(p => p.TempSmeta)
                .HasForeignKey(d => d.CCiclic)
                .HasConstraintName("FK_TEMP_SMETA_S_CICLIC");

            entity.HasOne(d => d.CClimatZoneNavigation).WithMany(p => p.TempSmeta)
                .HasForeignKey(d => d.CClimatZone)
                .HasConstraintName("FK_TEMP_SMETA_BOTH_S_CLIMAT_ZONE");

            entity.HasOne(d => d.CContractNavigation).WithMany(p => p.TempSmeta)
                .HasForeignKey(d => d.CContract)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TEMP_SMETA_BOTH_D_CONTRACT");

            entity.HasOne(d => d.CElementNavigation).WithMany(p => p.TempSmeta)
                .HasForeignKey(d => d.CElement)
                .HasConstraintName("FK_TEMP_SMETA_S_ELEMENT");

            entity.HasOne(d => d.CExplCategoryNavigation).WithMany(p => p.TempSmeta)
                .HasForeignKey(d => d.CExplCategory)
                .HasConstraintName("FK_TEMP_SMETA_BOTH_S_EXPL_CATEGORY");

            entity.HasOne(d => d.CMonthBeginNavigation).WithMany(p => p.TempSmetumCMonthBeginNavigations)
                .HasForeignKey(d => d.CMonthBegin)
                .HasConstraintName("FK_TEMP_SMETA_BOTH_D_MONTH_BEGIN");

            entity.HasOne(d => d.CMonthEndNavigation).WithMany(p => p.TempSmetumCMonthEndNavigations)
                .HasForeignKey(d => d.CMonthEnd)
                .HasConstraintName("FK_TEMP_SMETA_D_MONTH_END");

            entity.HasOne(d => d.CObjectNavigation).WithMany(p => p.TempSmeta)
                .HasForeignKey(d => d.CObject)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TEMP_SMETA_BOTH_D_OBJECT");

            entity.HasOne(d => d.CObjectElementNavigation).WithMany(p => p.TempSmeta)
                .HasForeignKey(d => d.CObjectElement)
                .HasConstraintName("FK_TEMP_SMETA_D_OBJECT_ELEMENT");

            entity.HasOne(d => d.CRoadNavigation).WithMany(p => p.TempSmeta)
                .HasForeignKey(d => d.CRoad)
                .HasConstraintName("FK_TEMP_SMETA_D_ROAD");

            entity.HasOne(d => d.CTypeObjectNavigation).WithMany(p => p.TempSmeta)
                .HasForeignKey(d => d.CTypeObject)
                .HasConstraintName("FK_TEMP_SMETA_S_TYPE_OBJECT");

            entity.HasOne(d => d.CVirtualObjectNavigation).WithMany(p => p.TempSmeta)
                .HasForeignKey(d => d.CVirtualObject)
                .HasConstraintName("FK_TEMP_SMETA_D_VIRTUAL_OBJECT");

            entity.HasOne(d => d.CWorkNavigation).WithMany(p => p.TempSmeta)
                .HasForeignKey(d => d.CWork)
                .HasConstraintName("FK_TEMP_SMETA_BOTH_S_WORK");

            entity.HasOne(d => d.CWorkGroupNavigation).WithMany(p => p.TempSmeta)
                .HasForeignKey(d => d.CWorkGroup)
                .HasConstraintName("FK_TEMP_SMETA_BOTH_S_WORK_GROUP");
        });

        modelBuilder.Entity<TempWork>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temp_works");

            entity.Property(e => e._1900).HasColumnName("19,00");
            entity.Property(e => e._2000).HasColumnName("20,00");
            entity.Property(e => e._2100).HasColumnName("21,00");
            entity.Property(e => e._2200).HasColumnName("22,00");
            entity.Property(e => e._2300).HasColumnName("23,00");
            entity.Property(e => e._2400).HasColumnName("24,00");
            entity.Property(e => e._2500).HasColumnName("25,00");
            entity.Property(e => e._2600).HasColumnName("26,00");
            entity.Property(e => e._2700).HasColumnName("27,00");
            entity.Property(e => e._2800).HasColumnName("28,00");
            entity.Property(e => e._2900).HasColumnName("29,00");
            entity.Property(e => e._3000).HasColumnName("30,00");
            entity.Property(e => e._3100).HasColumnName("31,00");
            entity.Property(e => e._3200).HasColumnName("32,00");
            entity.Property(e => e._3300).HasColumnName("33,00");
            entity.Property(e => e._3400).HasColumnName("34,00");
            entity.Property(e => e._3500).HasColumnName("35,00");
            entity.Property(e => e._3600).HasColumnName("36,00");
            entity.Property(e => e.НаименованиеРаботы)
                .HasMaxLength(255)
                .HasColumnName("наименование работы");
            entity.Property(e => e.НаименованиеЭлемента)
                .HasMaxLength(255)
                .HasColumnName("наименование элемента");
        });

        modelBuilder.Entity<TempWorks2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temp_works2");

            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("code");
            entity.Property(e => e.Value).HasColumnName("value");
            entity.Property(e => e.Work)
                .HasMaxLength(255)
                .HasColumnName("work");
            entity.Property(e => e._19).HasColumnName("19");
            entity.Property(e => e._20).HasColumnName("20");
            entity.Property(e => e._21).HasColumnName("21");
            entity.Property(e => e._22).HasColumnName("22");
            entity.Property(e => e._23).HasColumnName("23");
            entity.Property(e => e._24).HasColumnName("24");
            entity.Property(e => e._25).HasColumnName("25");
            entity.Property(e => e._26).HasColumnName("26");
            entity.Property(e => e._27).HasColumnName("27");
            entity.Property(e => e._28).HasColumnName("28");
            entity.Property(e => e._29).HasColumnName("29");
            entity.Property(e => e._30).HasColumnName("30");
            entity.Property(e => e._31).HasColumnName("31");
            entity.Property(e => e._32).HasColumnName("32");
            entity.Property(e => e._33).HasColumnName("33");
            entity.Property(e => e._34).HasColumnName("34");
            entity.Property(e => e._35).HasColumnName("35");
            entity.Property(e => e._36).HasColumnName("36");
        });

        modelBuilder.Entity<TestReportAnalisy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TEST_REP__3214EC27C4B82F15");

            entity.ToTable("TEST_REPORT_ANALISYS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CAcceptpay).HasColumnName("C_ACCEPTPAY");
            entity.Property(e => e.CControlledwork).HasColumnName("C_CONTROLLEDWORK");
            entity.Property(e => e.CDeniedwork).HasColumnName("C_DENIEDWORK");
            entity.Property(e => e.CInactwork).HasColumnName("C_INACTWORK");
            entity.Property(e => e.CNotcontrolledwork).HasColumnName("C_NOTCONTROLLEDWORK");
            entity.Property(e => e.CValuework).HasColumnName("C_VALUEWORK");
            entity.Property(e => e.Comment)
                .IsUnicode(false)
                .HasColumnName("COMMENT");
            entity.Property(e => e.Fail)
                .HasColumnType("datetime")
                .HasColumnName("FAIL");
            entity.Property(e => e.LevelDayBegin)
                .HasColumnType("datetime")
                .HasColumnName("LEVEL_DAY_BEGIN");
            entity.Property(e => e.LevelDayEnd)
                .HasColumnType("datetime")
                .HasColumnName("LEVEL_DAY_END");
            entity.Property(e => e.LevelMonthBeginId).HasColumnName("LEVEL_MONTH_BEGIN_ID");
            entity.Property(e => e.LevelMonthEndId).HasColumnName("LEVEL_MONTH_END_ID");
            entity.Property(e => e.LevelSelectData).HasColumnName("LEVEL_SELECT_DATA");
            entity.Property(e => e.LevelUseDaydate).HasColumnName("LEVEL_USE_DAYDATE");
            entity.Property(e => e.LevelYear).HasColumnName("LEVEL_YEAR");
            entity.Property(e => e.NClimatZone)
                .IsUnicode(false)
                .HasColumnName("N_CLIMAT_ZONE");
            entity.Property(e => e.NContractor)
                .IsUnicode(false)
                .HasColumnName("N_CONTRACTOR");
            entity.Property(e => e.NElement)
                .IsUnicode(false)
                .HasColumnName("N_ELEMENT");
            entity.Property(e => e.NExplCategory)
                .IsUnicode(false)
                .HasColumnName("N_EXPL_CATEGORY");
            entity.Property(e => e.NGeneralContract)
                .IsUnicode(false)
                .HasColumnName("N_GENERAL_CONTRACT");
            entity.Property(e => e.NGeneralContractor)
                .IsUnicode(false)
                .HasColumnName("N_GENERAL_CONTRACTOR");
            entity.Property(e => e.NKurator)
                .IsUnicode(false)
                .HasColumnName("N_KURATOR");
            entity.Property(e => e.NObject)
                .IsUnicode(false)
                .HasColumnName("N_OBJECT");
            entity.Property(e => e.NRegion)
                .IsUnicode(false)
                .HasColumnName("N_REGION");
            entity.Property(e => e.NReportLink)
                .HasMaxLength(1000)
                .HasColumnName("N_REPORT_LINK");
            entity.Property(e => e.NResourceType)
                .IsUnicode(false)
                .HasColumnName("N_RESOURCE_TYPE");
            entity.Property(e => e.NResources)
                .IsUnicode(false)
                .HasColumnName("N_RESOURCES");
            entity.Property(e => e.NRoad)
                .IsUnicode(false)
                .HasColumnName("N_ROAD");
            entity.Property(e => e.NSanction)
                .IsUnicode(false)
                .HasColumnName("N_SANCTION");
            entity.Property(e => e.NTypeObject)
                .IsUnicode(false)
                .HasColumnName("N_TYPE_OBJECT");
            entity.Property(e => e.NTypeWork)
                .IsUnicode(false)
                .HasColumnName("N_TYPE_WORK");
            entity.Property(e => e.NUserName)
                .HasMaxLength(100)
                .HasColumnName("N_USER_NAME");
            entity.Property(e => e.NWork)
                .IsUnicode(false)
                .HasColumnName("N_WORK");
            entity.Property(e => e.OptionsFactSanction).HasColumnName("OPTIONS_FACT_SANCTION");
            entity.Property(e => e.OptionsPrice).HasColumnName("OPTIONS_PRICE");
            entity.Property(e => e.OptionsUseFactsmeta).HasColumnName("OPTIONS_USE_FACTSMETA");
            entity.Property(e => e.OptionsUseItogo).HasColumnName("OPTIONS_USE_ITOGO");
            entity.Property(e => e.OptionsUseOverplan).HasColumnName("OPTIONS_USE_OVERPLAN");
            entity.Property(e => e.OptionsUseSanction).HasColumnName("OPTIONS_USE_SANCTION");
            entity.Property(e => e.Pass)
                .HasColumnType("datetime")
                .HasColumnName("PASS");
        });

        modelBuilder.Entity<TestReportResult>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEST_REPORT_RESULTS");

            entity.Property(e => e.CClimatZone).HasColumnName("C_CLIMAT_ZONE");
            entity.Property(e => e.CContractor).HasColumnName("C_CONTRACTOR");
            entity.Property(e => e.CElement).HasColumnName("C_ELEMENT");
            entity.Property(e => e.CExplCategory).HasColumnName("C_EXPL_CATEGORY");
            entity.Property(e => e.CGeneralContract).HasColumnName("C_GENERAL_CONTRACT");
            entity.Property(e => e.CGeneralContractor).HasColumnName("C_GENERAL_CONTRACTOR");
            entity.Property(e => e.CKurator).HasColumnName("C_KURATOR");
            entity.Property(e => e.CObject).HasColumnName("C_OBJECT");
            entity.Property(e => e.CRegion).HasColumnName("C_REGION");
            entity.Property(e => e.CResourceType).HasColumnName("C_RESOURCE_TYPE");
            entity.Property(e => e.CResources).HasColumnName("C_RESOURCES");
            entity.Property(e => e.CRoad).HasColumnName("C_ROAD");
            entity.Property(e => e.CSanction).HasColumnName("C_SANCTION");
            entity.Property(e => e.CSanctionGroup).HasColumnName("C_SANCTION_GROUP");
            entity.Property(e => e.CSeason).HasColumnName("C_SEASON");
            entity.Property(e => e.CTypeObject).HasColumnName("C_TYPE_OBJECT");
            entity.Property(e => e.CTypeWork).HasColumnName("C_TYPE_WORK");
            entity.Property(e => e.CUnit).HasColumnName("C_UNIT");
            entity.Property(e => e.CWork).HasColumnName("C_WORK");
            entity.Property(e => e.CostDifferent).HasColumnName("COST_DIFFERENT");
            entity.Property(e => e.CostPercentFact).HasColumnName("COST_PERCENT_FACT");
            entity.Property(e => e.CostPercentPlan).HasColumnName("COST_PERCENT_PLAN");
            entity.Property(e => e.CostValueFact).HasColumnName("COST_VALUE_FACT");
            entity.Property(e => e.CostValuePlan).HasColumnName("COST_VALUE_PLAN");
            entity.Property(e => e.CostValueSanction).HasColumnName("COST_VALUE_SANCTION");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Month10Fact).HasColumnName("MONTH_10_FACT");
            entity.Property(e => e.Month10Plan).HasColumnName("MONTH_10_PLAN");
            entity.Property(e => e.Month10Sanc).HasColumnName("MONTH_10_SANC");
            entity.Property(e => e.Month11Fact).HasColumnName("MONTH_11_FACT");
            entity.Property(e => e.Month11Plan).HasColumnName("MONTH_11_PLAN");
            entity.Property(e => e.Month11Sanc).HasColumnName("MONTH_11_SANC");
            entity.Property(e => e.Month12Fact).HasColumnName("MONTH_12_FACT");
            entity.Property(e => e.Month12Plan).HasColumnName("MONTH_12_PLAN");
            entity.Property(e => e.Month12Sanc).HasColumnName("MONTH_12_SANC");
            entity.Property(e => e.Month1Fact).HasColumnName("MONTH_1_FACT");
            entity.Property(e => e.Month1Plan).HasColumnName("MONTH_1_PLAN");
            entity.Property(e => e.Month1Sanc).HasColumnName("MONTH_1_SANC");
            entity.Property(e => e.Month2Fact).HasColumnName("MONTH_2_FACT");
            entity.Property(e => e.Month2Plan).HasColumnName("MONTH_2_PLAN");
            entity.Property(e => e.Month2Sanc).HasColumnName("MONTH_2_SANC");
            entity.Property(e => e.Month3Fact).HasColumnName("MONTH_3_FACT");
            entity.Property(e => e.Month3Plan).HasColumnName("MONTH_3_PLAN");
            entity.Property(e => e.Month3Sanc).HasColumnName("MONTH_3_SANC");
            entity.Property(e => e.Month4Fact).HasColumnName("MONTH_4_FACT");
            entity.Property(e => e.Month4Plan).HasColumnName("MONTH_4_PLAN");
            entity.Property(e => e.Month4Sanc).HasColumnName("MONTH_4_SANC");
            entity.Property(e => e.Month5Fact).HasColumnName("MONTH_5_FACT");
            entity.Property(e => e.Month5Plan).HasColumnName("MONTH_5_PLAN");
            entity.Property(e => e.Month5Sanc).HasColumnName("MONTH_5_SANC");
            entity.Property(e => e.Month6Fact).HasColumnName("MONTH_6_FACT");
            entity.Property(e => e.Month6Plan).HasColumnName("MONTH_6_PLAN");
            entity.Property(e => e.Month6Sanc).HasColumnName("MONTH_6_SANC");
            entity.Property(e => e.Month7Fact).HasColumnName("MONTH_7_FACT");
            entity.Property(e => e.Month7Plan).HasColumnName("MONTH_7_PLAN");
            entity.Property(e => e.Month7Sanc).HasColumnName("MONTH_7_SANC");
            entity.Property(e => e.Month8Fact).HasColumnName("MONTH_8_FACT");
            entity.Property(e => e.Month8Plan).HasColumnName("MONTH_8_PLAN");
            entity.Property(e => e.Month8Sanc).HasColumnName("MONTH_8_SANC");
            entity.Property(e => e.Month9Fact).HasColumnName("MONTH_9_FACT");
            entity.Property(e => e.Month9Plan).HasColumnName("MONTH_9_PLAN");
            entity.Property(e => e.Month9Sanc).HasColumnName("MONTH_9_SANC");
            entity.Property(e => e.NClimatZone)
                .HasMaxLength(100)
                .HasColumnName("N_CLIMAT_ZONE");
            entity.Property(e => e.NContractor)
                .HasMaxLength(100)
                .HasColumnName("N_CONTRACTOR");
            entity.Property(e => e.NElement)
                .HasMaxLength(100)
                .HasColumnName("N_ELEMENT");
            entity.Property(e => e.NExplCategory)
                .HasMaxLength(100)
                .HasColumnName("N_EXPL_CATEGORY");
            entity.Property(e => e.NGeneralContract)
                .HasMaxLength(100)
                .HasColumnName("N_GENERAL_CONTRACT");
            entity.Property(e => e.NGeneralContractor)
                .HasMaxLength(100)
                .HasColumnName("N_GENERAL_CONTRACTOR");
            entity.Property(e => e.NKurator)
                .HasMaxLength(250)
                .HasColumnName("N_KURATOR");
            entity.Property(e => e.NObject)
                .HasMaxLength(1000)
                .HasColumnName("N_OBJECT");
            entity.Property(e => e.NRegion)
                .HasMaxLength(100)
                .HasColumnName("N_REGION");
            entity.Property(e => e.NRes)
                .HasMaxLength(1000)
                .HasColumnName("N_RES");
            entity.Property(e => e.NResourceType)
                .HasMaxLength(100)
                .HasColumnName("N_RESOURCE_TYPE");
            entity.Property(e => e.NResources)
                .HasMaxLength(240)
                .HasColumnName("N_RESOURCES");
            entity.Property(e => e.NRoad)
                .HasMaxLength(1000)
                .HasColumnName("N_ROAD");
            entity.Property(e => e.NSanction)
                .HasMaxLength(1000)
                .HasColumnName("N_SANCTION");
            entity.Property(e => e.NSanctionGroup)
                .HasMaxLength(100)
                .HasColumnName("N_SANCTION_GROUP");
            entity.Property(e => e.NSeason)
                .HasMaxLength(100)
                .HasColumnName("N_SEASON");
            entity.Property(e => e.NTypeObject)
                .HasMaxLength(100)
                .HasColumnName("N_TYPE_OBJECT");
            entity.Property(e => e.NTypeWork)
                .HasMaxLength(100)
                .HasColumnName("N_TYPE_WORK");
            entity.Property(e => e.NUnit)
                .HasMaxLength(1000)
                .HasColumnName("N_UNIT");
            entity.Property(e => e.NUnitRes)
                .HasMaxLength(100)
                .HasColumnName("N_UNIT_RES");
            entity.Property(e => e.NWork)
                .HasMaxLength(400)
                .HasColumnName("N_WORK");
            entity.Property(e => e.ResValue).HasColumnName("RES_VALUE");
            entity.Property(e => e.RowBold).HasColumnName("ROW_BOLD");
            entity.Property(e => e.RowSort).HasColumnName("ROW_SORT");
            entity.Property(e => e.ValueWork).HasColumnName("VALUE_WORK");
        });

        modelBuilder.Entity<ViewAct>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_ACT");

            entity.Property(e => e.CAct).HasColumnName("C_ACT");
            entity.Property(e => e.CContract).HasColumnName("C_CONTRACT");
            entity.Property(e => e.CMonth).HasColumnName("C_MONTH");
            entity.Property(e => e.NAct)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("N_ACT");
            entity.Property(e => e.NMonth)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("N_MONTH");
            entity.Property(e => e.Year).HasColumnName("YEAR");
        });

        modelBuilder.Entity<ViewObject>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_OBJECT");

            entity.Property(e => e.CContract).HasColumnName("C_CONTRACT");
            entity.Property(e => e.CObject).HasColumnName("C_OBJECT");
            entity.Property(e => e.CRoad).HasColumnName("C_ROAD");
            entity.Property(e => e.Caption)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CAPTION");
        });

        modelBuilder.Entity<ViewObjectElement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_OBJECT_ELEMENT");

            entity.Property(e => e.AddedAfterAnalysis).HasColumnName("ADDED_AFTER_ANALYSIS");
            entity.Property(e => e.Begkm).HasColumnName("BEGKM");
            entity.Property(e => e.CContract).HasColumnName("C_CONTRACT");
            entity.Property(e => e.CElement).HasColumnName("C_ELEMENT");
            entity.Property(e => e.CObject).HasColumnName("C_OBJECT");
            entity.Property(e => e.CObjectElement).HasColumnName("C_OBJECT_ELEMENT");
            entity.Property(e => e.CRoad).HasColumnName("C_ROAD");
            entity.Property(e => e.Caption)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CAPTION");
            entity.Property(e => e.Endkm).HasColumnName("ENDKM");
            entity.Property(e => e.NUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("N_UNIT");
            entity.Property(e => e.SumCount).HasColumnName("SUM_COUNT");
            entity.Property(e => e.SumLength).HasColumnName("SUM_LENGTH");
        });

        modelBuilder.Entity<ViewObjectElementGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_OBJECT_ELEMENT_GROUP");

            entity.Property(e => e.CContract).HasColumnName("C_CONTRACT");
            entity.Property(e => e.CElement).HasColumnName("C_ELEMENT");
            entity.Property(e => e.CObject).HasColumnName("C_OBJECT");
            entity.Property(e => e.CRoad).HasColumnName("C_ROAD");
            entity.Property(e => e.Fact).HasColumnName("FACT");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.NElement)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("N_ELEMENT");
            entity.Property(e => e.NUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("N_UNIT");
            entity.Property(e => e.SumCount).HasColumnName("SUM_COUNT");
            entity.Property(e => e.SumLength).HasColumnName("SUM_LENGTH");
        });

        modelBuilder.Entity<ViewObjectJournal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_OBJECT_JOURNAL");

            entity.Property(e => e.Barrier)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("BARRIER");
            entity.Property(e => e.Begkm).HasColumnName("BEGKM");
            entity.Property(e => e.BegkmStolb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BEGKM_STOLB");
            entity.Property(e => e.CBridgeMaterial).HasColumnName("C_BRIDGE_MATERIAL");
            entity.Property(e => e.CBridgeObject).HasColumnName("C_BRIDGE_OBJECT");
            entity.Property(e => e.CExplCategory).HasColumnName("C_EXPL_CATEGORY");
            entity.Property(e => e.CObject).HasColumnName("C_OBJECT");
            entity.Property(e => e.CRegion).HasColumnName("C_REGION");
            entity.Property(e => e.CRoad).HasColumnName("C_ROAD");
            entity.Property(e => e.CStatusObject).HasColumnName("C_STATUS_OBJECT");
            entity.Property(e => e.CTypeBridge).HasColumnName("C_TYPE_BRIDGE");
            entity.Property(e => e.CTypeObject).HasColumnName("C_TYPE_OBJECT");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.Coef).HasColumnName("COEF");
            entity.Property(e => e.DateLeadIn)
                .HasColumnType("datetime")
                .HasColumnName("DATE_LEAD_IN");
            entity.Property(e => e.DateLeadOut)
                .HasColumnType("datetime")
                .HasColumnName("DATE_LEAD_OUT");
            entity.Property(e => e.EnabledForJornal).HasColumnName("ENABLED_FOR_JORNAL");
            entity.Property(e => e.Endkm).HasColumnName("ENDKM");
            entity.Property(e => e.EndkmStolb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENDKM_STOLB");
            entity.Property(e => e.Gabarit)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("GABARIT");
            entity.Property(e => e.Length).HasColumnName("LENGTH");
            entity.Property(e => e.Mp).HasColumnName("MP");
            entity.Property(e => e.NBridgeLet)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("N_BRIDGE_LET");
            entity.Property(e => e.NObject)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("N_OBJECT");
            entity.Property(e => e.UniqueValue).HasColumnName("UNIQUE_VALUE");
        });

        modelBuilder.Entity<ViewRoadByContract>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_ROAD_BY_CONTRACT");

            entity.Property(e => e.CContract).HasColumnName("C_CONTRACT");
            entity.Property(e => e.CRoad).HasColumnName("C_ROAD");
        });

        modelBuilder.Entity<ViewRoadJournal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_ROAD_JOURNAL");

            entity.Property(e => e.Begkm).HasColumnName("BEGKM");
            entity.Property(e => e.CRoad)
                .ValueGeneratedOnAdd()
                .HasColumnName("C_ROAD");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.DateActualization)
                .HasColumnType("datetime")
                .HasColumnName("DATE_ACTUALIZATION");
            entity.Property(e => e.EnabledForJornal).HasColumnName("ENABLED_FOR_JORNAL");
            entity.Property(e => e.Endkm).HasColumnName("ENDKM");
            entity.Property(e => e.NRoad)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("N_ROAD");
            entity.Property(e => e.UniqueValue).HasColumnName("UNIQUE_VALUE");
        });

        //OnModelCreatingPartial(modelBuilder);
    }

    //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
