using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Crud_Sqlite.Models;

public partial class JournalContext : DbContext
{
    public JournalContext()
    {
    }

    public JournalContext(DbContextOptions<JournalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Abnormality> Abnormalities { get; set; }

    public virtual DbSet<DbBackup> DbBackups { get; set; }

    public virtual DbSet<DbCAddr> DbCAddrs { get; set; }

    public virtual DbSet<DbCBase> DbCBases { get; set; }

    public virtual DbSet<DbCCard> DbCCards { get; set; }

    public virtual DbSet<DbCName> DbCNames { get; set; }

    public virtual DbSet<DbCSl> DbCSls { get; set; }

    public virtual DbSet<DbGDditm> DbGDditms { get; set; }

    public virtual DbSet<DbGDept> DbGDepts { get; set; }

    public virtual DbSet<DbGDptdtl> DbGDptdtls { get; set; }

    public virtual DbSet<DbIBcode> DbIBcodes { get; set; }

    public virtual DbSet<DbIBdttl> DbIBdttls { get; set; }

    public virtual DbSet<DbIBom> DbIBoms { get; set; }

    public virtual DbSet<DbIBomdtl> DbIBomdtls { get; set; }

    public virtual DbSet<DbIBuom> DbIBuoms { get; set; }

    public virtual DbSet<DbICond> DbIConds { get; set; }

    public virtual DbSet<DbIDir> DbIDirs { get; set; }

    public virtual DbSet<DbIItem> DbIItems { get; set; }

    public virtual DbSet<DbIIteml> DbIItemls { get; set; }

    public virtual DbSet<DbIItmao> DbIItmaos { get; set; }

    public virtual DbSet<DbIIuom> DbIIuoms { get; set; }

    public virtual DbSet<DbILevel> DbILevels { get; set; }

    public virtual DbSet<DbILevelg> DbILevelgs { get; set; }

    public virtual DbSet<DbIMatrix> DbIMatrices { get; set; }

    public virtual DbSet<DbIName> DbINames { get; set; }

    public virtual DbSet<DbINcond> DbINconds { get; set; }

    public virtual DbSet<DbINoun> DbINouns { get; set; }

    public virtual DbSet<DbINozzle> DbINozzles { get; set; }

    public virtual DbSet<DbIPmtrx> DbIPmtrxes { get; set; }

    public virtual DbSet<DbIPrcsch> DbIPrcsches { get; set; }

    public virtual DbSet<DbIPrice> DbIPrices { get; set; }

    public virtual DbSet<DbIPump> DbIPumps { get; set; }

    public virtual DbSet<DbIPumpport> DbIPumpports { get; set; }

    public virtual DbSet<DbIReason> DbIReasons { get; set; }

    public virtual DbSet<DbITank> DbITanks { get; set; }

    public virtual DbSet<DbIUom> DbIUoms { get; set; }

    public virtual DbSet<DbIUuom> DbIUuoms { get; set; }

    public virtual DbSet<DbMaster> DbMasters { get; set; }

    public virtual DbSet<DbPApiprm> DbPApiprms { get; set; }

    public virtual DbSet<DbPApiprm2> DbPApiprm2s { get; set; }

    public virtual DbSet<DbPButton> DbPButtons { get; set; }

    public virtual DbSet<DbPCurr> DbPCurrs { get; set; }

    public virtual DbSet<DbPError> DbPErrors { get; set; }

    public virtual DbSet<DbPForm> DbPForms { get; set; }

    public virtual DbSet<DbPGuide> DbPGuides { get; set; }

    public virtual DbSet<DbPHq> DbPHqs { get; set; }

    public virtual DbSet<DbPHrlyd> DbPHrlyds { get; set; }

    public virtual DbSet<DbPHrlyg> DbPHrlygs { get; set; }

    public virtual DbSet<DbPItemp> DbPItemps { get; set; }

    public virtual DbSet<DbPKboard> DbPKboards { get; set; }

    public virtual DbSet<DbPModi> DbPModis { get; set; }

    public virtual DbSet<DbPMsg> DbPMsgs { get; set; }

    public virtual DbSet<DbPMsg1> DbPMsg1s { get; set; }

    public virtual DbSet<DbPMsg123> DbPMsg123s { get; set; }

    public virtual DbSet<DbPName> DbPNames { get; set; }

    public virtual DbSet<DbPNmcode> DbPNmcodes { get; set; }

    public virtual DbSet<DbPPmap> DbPPmaps { get; set; }

    public virtual DbSet<DbPPromo> DbPPromos { get; set; }

    public virtual DbSet<DbPPromod> DbPPromods { get; set; }

    public virtual DbSet<DbPPromog> DbPPromogs { get; set; }

    public virtual DbSet<DbPPst> DbPPsts { get; set; }

    public virtual DbSet<DbPSdef> DbPSdefs { get; set; }

    public virtual DbSet<DbPSite> DbPSites { get; set; }

    public virtual DbSet<DbPSiteq> DbPSiteqs { get; set; }

    public virtual DbSet<DbPSmap> DbPSmaps { get; set; }

    public virtual DbSet<DbPTask> DbPTasks { get; set; }

    public virtual DbSet<DbPText> DbPTexts { get; set; }

    public virtual DbSet<DbPTextTest> DbPTextTests { get; set; }

    public virtual DbSet<DbPTlink> DbPTlinks { get; set; }

    public virtual DbSet<DbPUser> DbPUsers { get; set; }

    public virtual DbSet<DbPUserq> DbPUserqs { get; set; }

    public virtual DbSet<DbSBase> DbSBases { get; set; }

    public virtual DbSet<DbSCustom> DbSCustoms { get; set; }

    public virtual DbSet<DbSDlist> DbSDlists { get; set; }

    public virtual DbSet<DbSList> DbSLists { get; set; }

    public virtual DbSet<DbSPeriod> DbSPeriods { get; set; }

    public virtual DbSet<DbSTime> DbSTimes { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<FuelsWithPo> FuelsWithPos { get; set; }

    public virtual DbSet<XAddon> XAddons { get; set; }

    public virtual DbSet<XCard> XCards { get; set; }

    public virtual DbSet<XFunction> XFunctions { get; set; }

    public virtual DbSet<XItem> XItems { get; set; }

    public virtual DbSet<XModi> XModis { get; set; }

    public virtual DbSet<XOffline> XOfflines { get; set; }

    public virtual DbSet<XTicket> XTickets { get; set; }

    public virtual DbSet<XVip> XVips { get; set; }

    public virtual DbSet<XmlBButton> XmlBButtons { get; set; }

    public virtual DbSet<XmlBForm> XmlBForms { get; set; }

    public virtual DbSet<XmlBTask> XmlBTasks { get; set; }

    public virtual DbSet<XmlEmp> XmlEmps { get; set; }

    public virtual DbSet<XmlFvbal> XmlFvbals { get; set; }

    public virtual DbSet<XmlICogi> XmlICogis { get; set; }

    public virtual DbSet<XmlICogp> XmlICogps { get; set; }

    public virtual DbSet<XmlICogt> XmlICogts { get; set; }

    public virtual DbSet<XmlIIfifo> XmlIIfifos { get; set; }

    public virtual DbSet<XmlIWfifo> XmlIWfifos { get; set; }

    public virtual DbSet<XmlIXpldi> XmlIXpldis { get; set; }

    public virtual DbSet<XmlIXpldr> XmlIXpldrs { get; set; }

    public virtual DbSet<XmlSite> XmlSites { get; set; }

    public virtual DbSet<XmlSysUser> XmlSysUsers { get; set; }

    public virtual DbSet<XmlUserinfo> XmlUserinfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("DataSource=C:\\Crud-Sqlite\\journal.sqlite");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Abnormality>(entity =>
        {
            entity.Property(e => e.Abnormality1).HasColumnName("Abnormality");
            entity.Property(e => e.InvDate).HasColumnName("INV_DATE");
            entity.Property(e => e.Xpump).HasColumnName("XPump");
        });

        modelBuilder.Entity<DbBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_Backup");

            entity.Property(e => e.PosBitmap)
                .HasColumnType("CHAR(12)")
                .HasColumnName("POS_BITMAP");
            entity.Property(e => e.PosCode).HasColumnName("POS_CODE");
            entity.Property(e => e.PosColor).HasColumnName("POS_COLOR");
            entity.Property(e => e.PosFcode).HasColumnName("POS_FCODE");
            entity.Property(e => e.PosFlag).HasColumnName("POS_FLAG");
            entity.Property(e => e.PosFntcolor).HasColumnName("POS_FNTCOLOR");
            entity.Property(e => e.PosFntname)
                .HasColumnType("CHAR(31)")
                .HasColumnName("POS_FNTNAME");
            entity.Property(e => e.PosFntsize).HasColumnName("POS_FNTSIZE");
            entity.Property(e => e.PosFntstyle).HasColumnName("POS_FNTSTYLE");
            entity.Property(e => e.PosHeight).HasColumnName("POS_HEIGHT");
            entity.Property(e => e.PosLeft).HasColumnName("POS_LEFT");
            entity.Property(e => e.PosSecurity).HasColumnName("POS_SECURITY");
            entity.Property(e => e.PosSfcode).HasColumnName("POS_SFCODE");
            entity.Property(e => e.PosTaskcode)
                .HasColumnType("CHAR(17)")
                .HasColumnName("POS_TASKCODE");
            entity.Property(e => e.PosText)
                .HasColumnType("CHAR(40)")
                .HasColumnName("POS_TEXT");
            entity.Property(e => e.PosTop).HasColumnName("POS_TOP");
            entity.Property(e => e.PosWidth).HasColumnName("POS_WIDTH");
        });

        modelBuilder.Entity<DbCAddr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_c_addrs");

            entity.HasIndex(e => new { e.VipCode, e.VipHist }, "db_c_addrsNDX");

            entity.Property(e => e.VipBario)
                .HasColumnType("CHAR(30)")
                .HasColumnName("VIP_BARIO");
            entity.Property(e => e.VipCity)
                .HasColumnType("CHAR(30)")
                .HasColumnName("VIP_CITY");
            entity.Property(e => e.VipCode)
                .HasColumnType("CHAR(20)")
                .HasColumnName("VIP_CODE");
            entity.Property(e => e.VipHist).HasColumnName("VIP_HIST");
            entity.Property(e => e.VipHseno)
                .HasColumnType("CHAR(10)")
                .HasColumnName("VIP_HSENO");
            entity.Property(e => e.VipPhone)
                .HasColumnType("CHAR(15)")
                .HasColumnName("VIP_PHONE");
            entity.Property(e => e.VipStreet)
                .HasColumnType("CHAR(30)")
                .HasColumnName("VIP_STREET");
            entity.Property(e => e.VipZip)
                .HasColumnType("CHAR(10)")
                .HasColumnName("VIP_ZIP");
        });

        modelBuilder.Entity<DbCBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_c_base");

            entity.HasIndex(e => new { e.VipCode, e.VipHist }, "db_c_baseNDX");

            entity.Property(e => e.VipCode)
                .HasColumnType("CHAR(20)")
                .HasColumnName("VIP_CODE");
            entity.Property(e => e.VipDatemodi)
                .HasColumnType("CHAR(8)")
                .HasColumnName("VIP_DATEMODI");
            entity.Property(e => e.VipEmpid)
                .HasColumnType("CHAR(10)")
                .HasColumnName("VIP_EMPID");
            entity.Property(e => e.VipHist).HasColumnName("VIP_HIST");
            entity.Property(e => e.VipPincode)
                .HasColumnType("CHAR(6)")
                .HasColumnName("VIP_PINCODE");
            entity.Property(e => e.VipReason)
                .HasColumnType("INTEGER")
                .HasColumnName("VIP_REASON");
            entity.Property(e => e.VipSitecode)
                .HasColumnType("CHAR(10)")
                .HasColumnName("VIP_SITECODE");
            entity.Property(e => e.VipStatus)
                .HasColumnType("INTEGER")
                .HasColumnName("VIP_STATUS");
        });

        modelBuilder.Entity<DbCCard>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_c_card");

            entity.HasIndex(e => e.VipCardno, "db_c_cardNDX");

            entity.Property(e => e.VipCardno)
                .HasColumnType("CHAR(16)")
                .HasColumnName("VIP_CARDNO");
            entity.Property(e => e.VipCardsts).HasColumnName("VIP_CARDSTS");
            entity.Property(e => e.VipFlag).HasColumnName("VIP_FLAG");
        });

        modelBuilder.Entity<DbCName>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_c_name");

            entity.HasIndex(e => new { e.VipCode, e.VipHist }, "db_c_nameNDX");

            entity.Property(e => e.VipCode)
                .HasColumnType("CHAR(20)")
                .HasColumnName("VIP_CODE");
            entity.Property(e => e.VipFname)
                .HasColumnType("CHAR(20)")
                .HasColumnName("VIP_FNAME");
            entity.Property(e => e.VipHist).HasColumnName("VIP_HIST");
            entity.Property(e => e.VipLname)
                .HasColumnType("CHAR(20)")
                .HasColumnName("VIP_LNAME");
            entity.Property(e => e.VipMname)
                .HasColumnType("CHAR(20)")
                .HasColumnName("VIP_MNAME");
            entity.Property(e => e.VipSalute)
                .HasColumnType("INTEGER")
                .HasColumnName("VIP_SALUTE");
            entity.Property(e => e.VipTin)
                .HasColumnType("CHAR(20)")
                .HasColumnName("VIP_TIN");
        });

        modelBuilder.Entity<DbCSl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_c_sls");

            entity.HasIndex(e => new { e.VipCode, e.VipHist }, "db_c_slsNDX");

            entity.Property(e => e.VipCode)
                .HasColumnType("CHAR(20)")
                .HasColumnName("VIP_CODE");
            entity.Property(e => e.VipHist).HasColumnName("VIP_HIST");
            entity.Property(e => e.VipMvfc).HasColumnName("VIP_MVFC");
            entity.Property(e => e.VipPcode)
                .HasColumnType("INTEGER")
                .HasColumnName("VIP_PCODE");
        });

        modelBuilder.Entity<DbGDditm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_g_dditm");

            entity.HasIndex(e => new { e.DptCode, e.DptType, e.DptGroup, e.DptDatacode }, "db_g_dditmNDX");

            entity.Property(e => e.DptCode).HasColumnName("DPT_CODE");
            entity.Property(e => e.DptDatacode)
                .HasColumnType("CHAR(18)")
                .HasColumnName("DPT_DATACODE");
            entity.Property(e => e.DptGroup).HasColumnName("DPT_GROUP");
            entity.Property(e => e.DptType).HasColumnName("DPT_TYPE");
        });

        modelBuilder.Entity<DbGDept>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_g_dept");

            entity.HasIndex(e => new { e.DptCode, e.DptType }, "db_g_deptNDX");

            entity.Property(e => e.DptCode).HasColumnName("DPT_CODE");
            entity.Property(e => e.DptDescription)
                .HasColumnType("CHAR(40)")
                .HasColumnName("DPT_DESCRIPTION");
            entity.Property(e => e.DptType).HasColumnName("DPT_TYPE");
        });

        modelBuilder.Entity<DbGDptdtl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_g_dptdtl");

            entity.HasIndex(e => new { e.DptCode, e.DptType, e.DptGroup }, "db_g_dptdtlNDX");

            entity.Property(e => e.DptCode).HasColumnName("DPT_CODE");
            entity.Property(e => e.DptDescription)
                .HasColumnType("CHAR(40)")
                .HasColumnName("DPT_DESCRIPTION");
            entity.Property(e => e.DptGroup).HasColumnName("DPT_GROUP");
            entity.Property(e => e.DptLevel).HasColumnName("DPT_LEVEL");
            entity.Property(e => e.DptNode).HasColumnName("DPT_NODE");
            entity.Property(e => e.DptType).HasColumnName("DPT_TYPE");
        });

        modelBuilder.Entity<DbIBcode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_i_bcode");

            entity.HasIndex(e => new { e.InvItemcodex, e.InvBarcode }, "db_i_bcodeNDX");

            entity.Property(e => e.InvBarcode)
                .HasColumnType("CHAR(40)")
                .HasColumnName("INV_BARCODE");
            entity.Property(e => e.InvItemcodex)
                .HasColumnType("CHAR(18)")
                .HasColumnName("INV_ITEMCODEX");
        });

        modelBuilder.Entity<DbIBdttl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_i_bdttl");

            entity.HasIndex(e => new { e.InvCode, e.InvItemcodex, e.InvTtltype }, "db_i_bdttlNDX");

            entity.Property(e => e.InvCode)
                .HasColumnType("CHAR(18)")
                .HasColumnName("INV_CODE");
            entity.Property(e => e.InvItemcodex)
                .HasColumnType("CHAR(18)")
                .HasColumnName("INV_ITEMCODEX");
            entity.Property(e => e.InvTtltype).HasColumnName("INV_TTLTYPE");
        });

        modelBuilder.Entity<DbIBom>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_i_bom");

            entity.HasIndex(e => e.InvCode, "db_i_bomNDX");

            entity.Property(e => e.InvCode)
                .HasColumnType("CHAR(18)")
                .HasColumnName("INV_CODE");
            entity.Property(e => e.InvDescription)
                .HasColumnType("CHAR(40)")
                .HasColumnName("INV_DESCRIPTION");
            entity.Property(e => e.InvKind)
                .HasColumnType("CHAR(1)")
                .HasColumnName("INV_KIND");
            entity.Property(e => e.InvYield).HasColumnName("INV_YIELD");
        });

        modelBuilder.Entity<DbIBomdtl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_i_bomdtl");

            entity.HasIndex(e => new { e.InvCode, e.InvItemcodex }, "db_i_bomdtlNDX");

            entity.Property(e => e.InvCode)
                .HasColumnType("CHAR(18)")
                .HasColumnName("INV_CODE");
            entity.Property(e => e.InvFlag).HasColumnName("INV_FLAG");
            entity.Property(e => e.InvItemcodex)
                .HasColumnType("CHAR(18)")
                .HasColumnName("INV_ITEMCODEX");
            entity.Property(e => e.InvQty).HasColumnName("INV_QTY");
            entity.Property(e => e.InvUom).HasColumnName("INV_UOM");
            entity.Property(e => e.InvUsage).HasColumnName("INV_USAGE");
        });

        modelBuilder.Entity<DbIBuom>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_i_buom");

            entity.HasIndex(e => new { e.InvCode, e.InvItemcodex, e.InvUom }, "db_i_buomNDX");

            entity.Property(e => e.InvCode)
                .HasColumnType("CHAR(10)")
                .HasColumnName("INV_CODE");
            entity.Property(e => e.InvFactor).HasColumnName("INV_FACTOR");
            entity.Property(e => e.InvItemcodex)
                .HasColumnType("CHAR(18)")
                .HasColumnName("INV_ITEMCODEX");
            entity.Property(e => e.InvUom).HasColumnName("INV_UOM");
        });

        modelBuilder.Entity<DbICond>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_i_cond");

            entity.HasIndex(e => e.InvItemcode, "db_i_condNDX");

            entity.Property(e => e.InvFlag).HasColumnName("INV_FLAG");
            entity.Property(e => e.InvGroup).HasColumnName("INV_GROUP");
            entity.Property(e => e.InvItemcode)
                .HasColumnType("CHAR(14)")
                .HasColumnName("INV_ITEMCODE");
        });

        modelBuilder.Entity<DbIDir>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_i_dir");

            entity.HasIndex(e => e.InvDir, "db_i_dirNDX");

            entity.Property(e => e.InvDescription)
                .HasColumnType("CHAR(40)")
                .HasColumnName("INV_DESCRIPTION");
            entity.Property(e => e.InvDir).HasColumnName("INV_DIR");
        });

        modelBuilder.Entity<DbIItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_i_item");

            entity.HasIndex(e => e.InvItemcode, "db_i_itemNDX");

            entity.Property(e => e.InvFlag).HasColumnName("INV_FLAG");
            entity.Property(e => e.InvItemcode)
                .HasColumnType("CHAR(14)")
                .HasColumnName("INV_ITEMCODE");
            entity.Property(e => e.InvModigrp).HasColumnName("INV_MODIGRP");
            entity.Property(e => e.InvType)
                .HasColumnType("CHAR(1)")
                .HasColumnName("INV_TYPE");
            entity.Property(e => e.PosFormat).HasColumnName("POS_FORMAT");
            entity.Property(e => e.PosTaskcode)
                .HasColumnType("CHAR(17)")
                .HasColumnName("POS_TASKCODE");
        });

        modelBuilder.Entity<DbIIteml>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_i_iteml");

            entity.HasIndex(e => new { e.InvItemcode, e.InvSequence }, "db_i_itemlNDX");

            entity.Property(e => e.InvGroup).HasColumnName("INV_GROUP");
            entity.Property(e => e.InvId).HasColumnName("INV_ID");
            entity.Property(e => e.InvItemcode)
                .HasColumnType("CHAR(14)")
                .HasColumnName("INV_ITEMCODE");
            entity.Property(e => e.InvSequence).HasColumnName("INV_SEQUENCE");
        });

        modelBuilder.Entity<DbIItmao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_i_itmao");

            entity.HasIndex(e => new { e.InvItemcodex, e.InvIndex, e.InvGroup }, "db_i_itmaoNDX");

            entity.Property(e => e.InvGroup).HasColumnName("INV_GROUP");
            entity.Property(e => e.InvIndex).HasColumnName("INV_INDEX");
            entity.Property(e => e.InvItemcodex)
                .HasColumnType("CHAR(18)")
                .HasColumnName("INV_ITEMCODEX");
        });

        modelBuilder.Entity<DbIIuom>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_i_iuom");

            entity.HasIndex(e => new { e.InvItemcodex, e.InvUom }, "db_i_iuomNDX");

            entity.Property(e => e.InvFactor).HasColumnName("INV_FACTOR");
            entity.Property(e => e.InvItemcodex)
                .HasColumnType("CHAR(18)")
                .HasColumnName("INV_ITEMCODEX");
            entity.Property(e => e.InvUom).HasColumnName("INV_UOM");
        });

        modelBuilder.Entity<DbILevel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_i_level");

            entity.HasIndex(e => new { e.InvGroup, e.InvId }, "db_i_levelNDX");

            entity.Property(e => e.InvGroup).HasColumnName("INV_GROUP");
            entity.Property(e => e.InvId).HasColumnName("INV_ID");
            entity.Property(e => e.PosTaskcode)
                .HasColumnType("CHAR(17)")
                .HasColumnName("POS_TASKCODE");
        });

        modelBuilder.Entity<DbILevelg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_i_levelg");

            entity.HasIndex(e => e.InvGroup, "db_i_levelgNDX");

            entity.Property(e => e.InvDescription)
                .HasColumnType("CHAR(40)")
                .HasColumnName("INV_DESCRIPTION");
            entity.Property(e => e.InvGroup).HasColumnName("INV_GROUP");
        });

        modelBuilder.Entity<DbIMatrix>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_i_matrix");

            entity.HasIndex(e => e.InvItemcodex, "db_i_matrixNDX");

            entity.Property(e => e.InvBom)
                .HasColumnType("CHAR(18)")
                .HasColumnName("INV_BOM");
            entity.Property(e => e.InvDrtable).HasColumnName("INV_DRTABLE");
            entity.Property(e => e.InvFlag).HasColumnName("INV_FLAG");
            entity.Property(e => e.InvItemcode)
                .HasColumnType("CHAR(14)")
                .HasColumnName("INV_ITEMCODE");
            entity.Property(e => e.InvItemcodex)
                .HasColumnType("CHAR(18)")
                .HasColumnName("INV_ITEMCODEX");
            entity.Property(e => e.InvKind)
                .HasColumnType("CHAR(1)")
                .HasColumnName("INV_KIND");
            entity.Property(e => e.InvMax).HasColumnName("INV_MAX");
            entity.Property(e => e.InvMin).HasColumnName("INV_MIN");
            entity.Property(e => e.InvStatus).HasColumnName("INV_STATUS");
            entity.Property(e => e.InvSug).HasColumnName("INV_SUG");
            entity.Property(e => e.InvUom)
                .HasColumnType("INTEGER")
                .HasColumnName("INV_UOM");
            entity.Property(e => e.InvYield).HasColumnName("INV_YIELD");
        });

        modelBuilder.Entity<DbIName>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_i_name");

            entity.HasIndex(e => new { e.PosTaskcode, e.PosNamecode }, "db_i_nameNDX");

            entity.Property(e => e.InvName)
                .HasColumnType("CHAR(40)")
                .HasColumnName("INV_NAME");
            entity.Property(e => e.PosNamecode).HasColumnName("POS_NAMECODE");
            entity.Property(e => e.PosTaskcode)
                .HasColumnType("CHAR(17)")
                .HasColumnName("POS_TASKCODE");
        });

        modelBuilder.Entity<DbINcond>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_i_ncond");

            entity.HasIndex(e => new { e.InvItemcode, e.InvGroup }, "db_i_ncondNDX");

            entity.Property(e => e.InvGroup).HasColumnName("INV_GROUP");
            entity.Property(e => e.InvItemcode)
                .HasColumnType("CHAR(14)")
                .HasColumnName("INV_ITEMCODE");
            entity.Property(e => e.InvMax).HasColumnName("INV_MAX");
            entity.Property(e => e.InvMin).HasColumnName("INV_MIN");
        });

        modelBuilder.Entity<DbINoun>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_i_noun");

            entity.HasIndex(e => e.InvItemcode, "db_i_nounNDX");

            entity.Property(e => e.InvFlag).HasColumnName("INV_FLAG");
            entity.Property(e => e.InvItemcode)
                .HasColumnType("CHAR(14)")
                .HasColumnName("INV_ITEMCODE");
            entity.Property(e => e.InvMax).HasColumnName("INV_MAX");
            entity.Property(e => e.InvMin).HasColumnName("INV_MIN");
        });

        modelBuilder.Entity<DbINozzle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_i_nozzle");

            entity.HasIndex(e => new { e.InvPump, e.InvNozzle }, "db_i_nozzleNDX");

            entity.Property(e => e.InvNozzle)
                .HasColumnType("INTEGER")
                .HasColumnName("INV_NOZZLE");
            entity.Property(e => e.InvPricecode)
                .HasColumnType("INTEGER")
                .HasColumnName("INV_PRICECODE");
            entity.Property(e => e.InvPump)
                .HasColumnType("INTEGER")
                .HasColumnName("INV_PUMP");
            entity.Property(e => e.InvTank)
                .HasColumnType("INTEGER")
                .HasColumnName("INV_TANK");
        });

        modelBuilder.Entity<DbIPmtrx>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_i_pmtrx");

            entity.HasIndex(e => new { e.InvItemcodex, e.InvSequence }, "db_i_pmtrxNDX");

            entity.Property(e => e.InvGroup).HasColumnName("INV_GROUP");
            entity.Property(e => e.InvId).HasColumnName("INV_ID");
            entity.Property(e => e.InvItemcodex)
                .HasColumnType("CHAR(18)")
                .HasColumnName("INV_ITEMCODEX");
            entity.Property(e => e.InvSequence).HasColumnName("INV_SEQUENCE");
        });

        modelBuilder.Entity<DbIPrcsch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_i_prcsch");

            entity.HasIndex(e => e.InvPricecode, "db_i_prcschNDX");

            entity.Property(e => e.InvDescription)
                .HasColumnType("CHAR(40)")
                .HasColumnName("INV_DESCRIPTION");
            entity.Property(e => e.InvFlag)
                .HasColumnType("INTEGER")
                .HasColumnName("INV_FLAG");
            entity.Property(e => e.InvPricecode).HasColumnName("INV_PRICECODE");
            entity.Property(e => e.InvScheme)
                .HasColumnType("INTEGER")
                .HasColumnName("INV_SCHEME");
        });

        modelBuilder.Entity<DbIPrice>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_i_price");

            entity.HasIndex(e => new { e.InvItemcodex, e.InvPricecode }, "db_i_priceNDX");

            entity.Property(e => e.InvCut).HasColumnName("INV_CUT");
            entity.Property(e => e.InvFlag)
                .HasColumnType("INTEGER")
                .HasColumnName("INV_FLAG");
            entity.Property(e => e.InvItemcodex)
                .HasColumnType("CHAR(18)")
                .HasColumnName("INV_ITEMCODEX");
            entity.Property(e => e.InvPrice).HasColumnName("INV_PRICE");
            entity.Property(e => e.InvPricecode).HasColumnName("INV_PRICECODE");
        });

        modelBuilder.Entity<DbIPump>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_i_pump");

            entity.HasIndex(e => e.InvPump, "db_i_pumpNDX");

            entity.Property(e => e.InvAuthmode)
                .HasColumnType("CHAR(1)")
                .HasColumnName("INV_AUTHMODE");
            entity.Property(e => e.InvDelmode).HasColumnName("INV_DELMODE");
            entity.Property(e => e.InvPump).HasColumnName("INV_PUMP");
        });

        modelBuilder.Entity<DbIPumpport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_i_pumpport");

            entity.HasIndex(e => e.InvPump, "db_i_pumpportNDX");

            entity.Property(e => e.InvId).HasColumnName("INV_ID");
            entity.Property(e => e.InvPort)
                .HasColumnType("CHAR(10)")
                .HasColumnName("INV_PORT");
            entity.Property(e => e.InvProtocol).HasColumnName("INV_PROTOCOL");
            entity.Property(e => e.InvPump).HasColumnName("INV_PUMP");
        });

        modelBuilder.Entity<DbIReason>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_i_reason");

            entity.HasIndex(e => e.InvReason, "db_i_reasonNDX");

            entity.Property(e => e.InvDescription)
                .HasColumnType("CHAR(40)")
                .HasColumnName("INV_DESCRIPTION");
            entity.Property(e => e.InvReason).HasColumnName("INV_REASON");
        });

        modelBuilder.Entity<DbITank>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_i_tank");

            entity.HasIndex(e => e.InvTank, "db_i_tankNDX");

            entity.Property(e => e.InvCap).HasColumnName("INV_CAP");
            entity.Property(e => e.InvItemcodex)
                .HasColumnType("CHAR(18)")
                .HasColumnName("INV_ITEMCODEX");
            entity.Property(e => e.InvMax).HasColumnName("INV_MAX");
            entity.Property(e => e.InvMin).HasColumnName("INV_MIN");
            entity.Property(e => e.InvSug).HasColumnName("INV_SUG");
            entity.Property(e => e.InvTank).HasColumnName("INV_TANK");
            entity.Property(e => e.InvWetid).HasColumnName("INV_WETID");
        });

        modelBuilder.Entity<DbIUom>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_i_uom");

            entity.HasIndex(e => e.InvCode, "db_i_uomNDX");

            entity.Property(e => e.InvCode)
                .HasColumnType("INTEGER")
                .HasColumnName("INV_CODE");
            entity.Property(e => e.InvName)
                .HasColumnType("CHAR(10)")
                .HasColumnName("INV_NAME");
        });

        modelBuilder.Entity<DbIUuom>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_i_uuom");

            entity.HasIndex(e => new { e.InvItemcodex, e.InvUom }, "db_i_uuomNDX");

            entity.Property(e => e.InvFactor).HasColumnName("INV_FACTOR");
            entity.Property(e => e.InvItemcodex)
                .HasColumnType("CHAR(18)")
                .HasColumnName("INV_ITEMCODEX");
            entity.Property(e => e.InvUom).HasColumnName("INV_UOM");
        });

        modelBuilder.Entity<DbMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_master");

            entity.HasIndex(e => e.Code, "db_masterNDX");

            entity.Property(e => e.Barcode)
                .HasColumnType("CHAR(40)")
                .HasColumnName("BARCODE");
            entity.Property(e => e.Code)
                .HasColumnType("CHAR(14)")
                .HasColumnName("CODE");
            entity.Property(e => e.Cost).HasColumnName("COST");
            entity.Property(e => e.Group).HasColumnName("GROUP");
            entity.Property(e => e.Name)
                .HasColumnType("CHAR(40)")
                .HasColumnName("NAME");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.Qty).HasColumnName("QTY");
        });

        modelBuilder.Entity<DbPApiprm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_apiprm");

            entity.HasIndex(e => e.PosTaskcode, "db_p_apiprmNDX");

            entity.Property(e => e.PosAccount)
                .HasColumnType("CHAR(10)")
                .HasColumnName("POS_ACCOUNT");
            entity.Property(e => e.PosApiid)
                .HasColumnType("INTEGER")
                .HasColumnName("POS_APIID");
            entity.Property(e => e.PosByte1)
                .HasColumnType("CHAR(18)")
                .HasColumnName("POS_BYTE1");
            entity.Property(e => e.PosByte2)
                .HasColumnType("CHAR(18)")
                .HasColumnName("POS_BYTE2");
            entity.Property(e => e.PosDword1)
                .HasColumnType("INTEGER")
                .HasColumnName("POS_DWORD1");
            entity.Property(e => e.PosDword2)
                .HasColumnType("INTEGER")
                .HasColumnName("POS_DWORD2");
            entity.Property(e => e.PosFlag)
                .HasColumnType("INTEGER")
                .HasColumnName("POS_FLAG");
            entity.Property(e => e.PosMoney1).HasColumnName("POS_MONEY1");
            entity.Property(e => e.PosMoney2).HasColumnName("POS_MONEY2");
            entity.Property(e => e.PosReal1).HasColumnName("POS_REAL1");
            entity.Property(e => e.PosReal2).HasColumnName("POS_REAL2");
            entity.Property(e => e.PosTaskcode)
                .HasColumnType("CHAR(17)")
                .HasColumnName("POS_TASKCODE");
            entity.Property(e => e.PosWord1)
                .HasColumnType("INTEGER")
                .HasColumnName("POS_WORD1");
            entity.Property(e => e.PosWord2)
                .HasColumnType("INTEGER")
                .HasColumnName("POS_WORD2");
        });

        modelBuilder.Entity<DbPApiprm2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_apiprm2");

            entity.HasIndex(e => e.PosTaskcode, "db_p_apiprm2NDX");

            entity.Property(e => e.PosAccount)
                .HasColumnType("CHAR(10)")
                .HasColumnName("POS_ACCOUNT");
            entity.Property(e => e.PosApiid).HasColumnName("POS_APIID");
            entity.Property(e => e.PosByte1)
                .HasColumnType("CHAR(18)")
                .HasColumnName("POS_BYTE1");
            entity.Property(e => e.PosByte2)
                .HasColumnType("CHAR(18)")
                .HasColumnName("POS_BYTE2");
            entity.Property(e => e.PosDword1)
                .HasColumnType("INTEGER")
                .HasColumnName("POS_DWORD1");
            entity.Property(e => e.PosDword2)
                .HasColumnType("INTEGER")
                .HasColumnName("POS_DWORD2");
            entity.Property(e => e.PosFlag)
                .HasColumnType("INTEGER")
                .HasColumnName("POS_FLAG");
            entity.Property(e => e.PosMoney1).HasColumnName("POS_MONEY1");
            entity.Property(e => e.PosMoney2).HasColumnName("POS_MONEY2");
            entity.Property(e => e.PosReal1).HasColumnName("POS_REAL1");
            entity.Property(e => e.PosReal2).HasColumnName("POS_REAL2");
            entity.Property(e => e.PosTaskcode)
                .HasColumnType("CHAR(17)")
                .HasColumnName("POS_TASKCODE");
            entity.Property(e => e.PosWord1)
                .HasColumnType("INTEGER")
                .HasColumnName("POS_WORD1");
            entity.Property(e => e.PosWord2)
                .HasColumnType("INTEGER")
                .HasColumnName("POS_WORD2");
        });

        modelBuilder.Entity<DbPButton>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_button");

            entity.HasIndex(e => new { e.PosCode, e.PosLeft, e.PosTop }, "db_p_buttonNDX");

            entity.Property(e => e.PosBitmap)
                .HasColumnType("CHAR(12)")
                .HasColumnName("POS_BITMAP");
            entity.Property(e => e.PosCode).HasColumnName("POS_CODE");
            entity.Property(e => e.PosColor).HasColumnName("POS_COLOR");
            entity.Property(e => e.PosFcode).HasColumnName("POS_FCODE");
            entity.Property(e => e.PosFlag).HasColumnName("POS_FLAG");
            entity.Property(e => e.PosFntcolor).HasColumnName("POS_FNTCOLOR");
            entity.Property(e => e.PosFntname)
                .HasColumnType("CHAR(31)")
                .HasColumnName("POS_FNTNAME");
            entity.Property(e => e.PosFntsize).HasColumnName("POS_FNTSIZE");
            entity.Property(e => e.PosFntstyle).HasColumnName("POS_FNTSTYLE");
            entity.Property(e => e.PosHeight).HasColumnName("POS_HEIGHT");
            entity.Property(e => e.PosLeft).HasColumnName("POS_LEFT");
            entity.Property(e => e.PosSecurity).HasColumnName("POS_SECURITY");
            entity.Property(e => e.PosSfcode).HasColumnName("POS_SFCODE");
            entity.Property(e => e.PosTaskcode)
                .HasColumnType("CHAR(17)")
                .HasColumnName("POS_TASKCODE");
            entity.Property(e => e.PosText)
                .HasColumnType("CHAR(40)")
                .HasColumnName("POS_TEXT");
            entity.Property(e => e.PosTop).HasColumnName("POS_TOP");
            entity.Property(e => e.PosWidth).HasColumnName("POS_WIDTH");
        });

        modelBuilder.Entity<DbPCurr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_curr");

            entity.HasIndex(e => e.PosCode, "db_p_currNDX");

            entity.Property(e => e.PosCode).HasColumnName("POS_CODE");
            entity.Property(e => e.PosRate).HasColumnName("POS_RATE");
            entity.Property(e => e.PosSym)
                .HasColumnType("CHAR(3)")
                .HasColumnName("POS_SYM");
        });

        modelBuilder.Entity<DbPError>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_error");

            entity.HasIndex(e => new { e.PosCode, e.PosNamecode }, "db_p_errorNDX");

            entity.Property(e => e.PosCode).HasColumnName("POS_CODE");
            entity.Property(e => e.PosMessage)
                .HasColumnType("CHAR(250)")
                .HasColumnName("POS_MESSAGE");
            entity.Property(e => e.PosNamecode).HasColumnName("POS_NAMECODE");
            entity.Property(e => e.PosShortmsg)
                .HasColumnType("CHAR(40)")
                .HasColumnName("POS_SHORTMSG");
        });

        modelBuilder.Entity<DbPForm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_form");

            entity.HasIndex(e => e.PosCode, "db_p_formNDX");

            entity.Property(e => e.PosBitmap)
                .HasColumnType("CHAR(12)")
                .HasColumnName("POS_BITMAP");
            entity.Property(e => e.PosCode).HasColumnName("POS_CODE");
            entity.Property(e => e.PosColor).HasColumnName("POS_COLOR");
            entity.Property(e => e.PosHeight).HasColumnName("POS_HEIGHT");
            entity.Property(e => e.PosLeft).HasColumnName("POS_LEFT");
            entity.Property(e => e.PosName)
                .HasColumnType("CHAR(40)")
                .HasColumnName("POS_NAME");
            entity.Property(e => e.PosTop).HasColumnName("POS_TOP");
            entity.Property(e => e.PosType).HasColumnName("POS_TYPE");
            entity.Property(e => e.PosWidth).HasColumnName("POS_WIDTH");
        });

        modelBuilder.Entity<DbPGuide>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_guide");

            entity.HasIndex(e => new { e.PosCode, e.PosNamecode }, "db_p_guideNDX");

            entity.Property(e => e.PosCode)
                .HasColumnType("INTEGER")
                .HasColumnName("POS_CODE");
            entity.Property(e => e.PosMessage)
                .HasColumnType("CHAR(250)")
                .HasColumnName("POS_MESSAGE");
            entity.Property(e => e.PosNamecode).HasColumnName("POS_NAMECODE");
            entity.Property(e => e.PosShortmsg)
                .HasColumnType("CHAR(40)")
                .HasColumnName("POS_SHORTMSG");
        });

        modelBuilder.Entity<DbPHq>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_hq");

            entity.HasIndex(e => e.PosHqcode, "db_p_hqNDX");

            entity.Property(e => e.PosHqaddr)
                .HasColumnType("CHAR(40)")
                .HasColumnName("POS_HQADDR");
            entity.Property(e => e.PosHqcode)
                .HasColumnType("CHAR(10)")
                .HasColumnName("POS_HQCODE");
            entity.Property(e => e.PosHqname)
                .HasColumnType("CHAR(60)")
                .HasColumnName("POS_HQNAME");
            entity.Property(e => e.PosPhone)
                .HasColumnType("CHAR(15)")
                .HasColumnName("POS_PHONE");
            entity.Property(e => e.PosTin)
                .HasColumnType("CHAR(40)")
                .HasColumnName("POS_TIN");
        });

        modelBuilder.Entity<DbPHrlyd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_hrlyd");

            entity.HasIndex(e => new { e.PosCode, e.PosSequence }, "db_p_hrlydNDX");

            entity.Property(e => e.PosCode).HasColumnName("POS_CODE");
            entity.Property(e => e.PosDescription)
                .HasColumnType("CHAR(40)")
                .HasColumnName("POS_DESCRIPTION");
            entity.Property(e => e.PosFrom)
                .HasColumnType("CHAR(4)")
                .HasColumnName("POS_FROM");
            entity.Property(e => e.PosSequence).HasColumnName("POS_SEQUENCE");
            entity.Property(e => e.PosTo)
                .HasColumnType("CHAR(4)")
                .HasColumnName("POS_TO");
        });

        modelBuilder.Entity<DbPHrlyg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_hrlyg");

            entity.HasIndex(e => e.PosCode, "db_p_hrlygNDX");

            entity.Property(e => e.PosCode).HasColumnName("POS_CODE");
            entity.Property(e => e.PosDescription)
                .HasColumnType("CHAR(40)")
                .HasColumnName("POS_DESCRIPTION");
        });

        modelBuilder.Entity<DbPItemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_itemp");

            entity.HasIndex(e => new { e.InvItemcodex, e.PosIndex, e.PosGroup }, "db_p_itempNDX");

            entity.Property(e => e.InvItemcodex)
                .HasColumnType("CHAR(18)")
                .HasColumnName("INV_ITEMCODEX");
            entity.Property(e => e.PosGroup).HasColumnName("POS_GROUP");
            entity.Property(e => e.PosIndex).HasColumnName("POS_INDEX");
        });

        modelBuilder.Entity<DbPKboard>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_kboard");

            entity.HasIndex(e => new { e.PosKey, e.PosShift }, "db_p_kboardNDX");

            entity.Property(e => e.PosFcode).HasColumnName("POS_FCODE");
            entity.Property(e => e.PosFlag).HasColumnName("POS_FLAG");
            entity.Property(e => e.PosKey).HasColumnName("POS_KEY");
            entity.Property(e => e.PosSecurity).HasColumnName("POS_SECURITY");
            entity.Property(e => e.PosSfcode).HasColumnName("POS_SFCODE");
            entity.Property(e => e.PosShift).HasColumnName("POS_SHIFT");
            entity.Property(e => e.PosTaskcode)
                .HasColumnType("CHAR(17)")
                .HasColumnName("POS_TASKCODE");
        });

        modelBuilder.Entity<DbPModi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_modi");

            entity.HasIndex(e => e.PosTaskcode, "db_p_modiNDX");

            entity.Property(e => e.PosFlag).HasColumnName("POS_FLAG");
            entity.Property(e => e.PosGroup).HasColumnName("POS_GROUP");
            entity.Property(e => e.PosSubgroup).HasColumnName("POS_SUBGROUP");
            entity.Property(e => e.PosTaskcode)
                .HasColumnType("CHAR(17)")
                .HasColumnName("POS_TASKCODE");
        });

        modelBuilder.Entity<DbPMsg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_msg");

            entity.HasIndex(e => new { e.PosCode, e.PosNamecode }, "db_p_msgNDX");

            entity.Property(e => e.PosCode).HasColumnName("POS_CODE");
            entity.Property(e => e.PosMessage)
                .HasColumnType("CHAR(250)")
                .HasColumnName("POS_MESSAGE");
            entity.Property(e => e.PosNamecode).HasColumnName("POS_NAMECODE");
            entity.Property(e => e.PosShortmsg)
                .HasColumnType("CHAR(40)")
                .HasColumnName("POS_SHORTMSG");
        });

        modelBuilder.Entity<DbPMsg1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_msg1");

            entity.HasIndex(e => new { e.PosCode, e.PosNamecode }, "db_p_msg1NDX");

            entity.Property(e => e.PosCode).HasColumnName("POS_CODE");
            entity.Property(e => e.PosMessage)
                .HasColumnType("CHAR(250)")
                .HasColumnName("POS_MESSAGE");
            entity.Property(e => e.PosNamecode).HasColumnName("POS_NAMECODE");
            entity.Property(e => e.PosShortmsg)
                .HasColumnType("CHAR(40)")
                .HasColumnName("POS_SHORTMSG");
        });

        modelBuilder.Entity<DbPMsg123>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_msg123");

            entity.HasIndex(e => new { e.PosCode, e.PosNamecode }, "db_p_msg123NDX");

            entity.Property(e => e.PosCode).HasColumnName("POS_CODE");
            entity.Property(e => e.PosMessage)
                .HasColumnType("CHAR(250)")
                .HasColumnName("POS_MESSAGE");
            entity.Property(e => e.PosNamecode).HasColumnName("POS_NAMECODE");
            entity.Property(e => e.PosShortmsg)
                .HasColumnType("CHAR(40)")
                .HasColumnName("POS_SHORTMSG");
        });

        modelBuilder.Entity<DbPName>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_name");

            entity.HasIndex(e => new { e.PosTaskcode, e.PosNamecode }, "db_p_nameNDX");

            entity.Property(e => e.PosNamecode).HasColumnName("POS_NAMECODE");
            entity.Property(e => e.PosTaskcode)
                .HasColumnType("CHAR(17)")
                .HasColumnName("POS_TASKCODE");
            entity.Property(e => e.PosTaskname)
                .HasColumnType("CHAR(40)")
                .HasColumnName("POS_TASKNAME");
        });

        modelBuilder.Entity<DbPNmcode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_nmcode");

            entity.HasIndex(e => e.PosNamecode, "db_p_nmcodeNDX");

            entity.Property(e => e.PosNamecode).HasColumnName("POS_NAMECODE");
            entity.Property(e => e.PosNmschm)
                .HasColumnType("CHAR(40)")
                .HasColumnName("POS_NMSCHM");
        });

        modelBuilder.Entity<DbPPmap>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_pmap");

            entity.HasIndex(e => new { e.PosHqcode, e.PosSitecode, e.PosPstid, e.PosIndex }, "db_p_pmapNDX");

            entity.Property(e => e.PosHqcode)
                .HasColumnType("CHAR(10)")
                .HasColumnName("POS_HQCODE");
            entity.Property(e => e.PosIndex).HasColumnName("POS_INDEX");
            entity.Property(e => e.PosPstid).HasColumnName("POS_PSTID");
            entity.Property(e => e.PosSitecode)
                .HasColumnType("CHAR(10)")
                .HasColumnName("POS_SITECODE");
            entity.Property(e => e.PosTaskcode)
                .HasColumnType("CHAR(17)")
                .HasColumnName("POS_TASKCODE");
        });

        modelBuilder.Entity<DbPPromo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_promo");

            entity.HasIndex(e => new { e.PosAccount, e.PosType, e.InvItemcodex }, "db_p_promoNDX");

            entity.Property(e => e.DptCode).HasColumnName("DPT_CODE");
            entity.Property(e => e.DptGroup).HasColumnName("DPT_GROUP");
            entity.Property(e => e.InvItemcodex)
                .HasColumnType("CHAR(18)")
                .HasColumnName("INV_ITEMCODEX");
            entity.Property(e => e.PosAccount)
                .HasColumnType("CHAR(10)")
                .HasColumnName("POS_ACCOUNT");
            entity.Property(e => e.PosAmt).HasColumnName("POS_AMT");
            entity.Property(e => e.PosQty).HasColumnName("POS_QTY");
            entity.Property(e => e.PosRate).HasColumnName("POS_RATE");
            entity.Property(e => e.PosType)
                .HasColumnType("CHAR(1)")
                .HasColumnName("POS_TYPE");
        });

        modelBuilder.Entity<DbPPromod>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_promod");

            entity.HasIndex(e => new { e.PosGroup, e.PosSequence, e.PosIndex }, "db_p_promodNDX");

            entity.Property(e => e.PosGroup).HasColumnName("POS_GROUP");
            entity.Property(e => e.PosIndex).HasColumnName("POS_INDEX");
            entity.Property(e => e.PosSequence).HasColumnName("POS_SEQUENCE");
        });

        modelBuilder.Entity<DbPPromog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_promog");

            entity.HasIndex(e => e.PosGroup, "db_p_promogNDX");

            entity.Property(e => e.PosDescription)
                .HasColumnType("CHAR(40)")
                .HasColumnName("POS_DESCRIPTION");
            entity.Property(e => e.PosGroup).HasColumnName("POS_GROUP");
        });

        modelBuilder.Entity<DbPPst>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_P_PST");

            entity.HasIndex(e => new { e.PosHqcode, e.PosSitecode, e.PosPstid }, "db_P_PSTNDX");

            entity.Property(e => e.InvPricecode).HasColumnName("INV_PRICECODE");
            entity.Property(e => e.PosDeftask)
                .HasColumnType("CHAR(17)")
                .HasColumnName("POS_DEFTASK");
            entity.Property(e => e.PosForm).HasColumnName("POS_FORM");
            entity.Property(e => e.PosHqcode)
                .HasColumnType("CHAR(10)")
                .HasColumnName("POS_HQCODE");
            entity.Property(e => e.PosKind)
                .HasColumnType("INTEGER")
                .HasColumnName("POS_KIND");
            entity.Property(e => e.PosPstid).HasColumnName("POS_PSTID");
            entity.Property(e => e.PosPstname)
                .HasColumnType("CHAR(40)")
                .HasColumnName("POS_PSTNAME");
            entity.Property(e => e.PosSerial)
                .HasColumnType("CHAR(40)")
                .HasColumnName("POS_SERIAL");
            entity.Property(e => e.PosSitecode)
                .HasColumnType("CHAR(10)")
                .HasColumnName("POS_SITECODE");
            entity.Property(e => e.PosTask0006)
                .HasColumnType("CHAR(17)")
                .HasColumnName("POS_TASK0006");
        });

        modelBuilder.Entity<DbPSdef>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_sdef");

            entity.HasIndex(e => new { e.PosHqcode, e.PosIndex, e.PosGroup }, "db_p_sdefNDX");

            entity.Property(e => e.PosGroup).HasColumnName("POS_GROUP");
            entity.Property(e => e.PosHqcode)
                .HasColumnType("CHAR(10)")
                .HasColumnName("POS_HQCODE");
            entity.Property(e => e.PosIndex).HasColumnName("POS_INDEX");
        });

        modelBuilder.Entity<DbPSite>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_site");

            entity.HasIndex(e => new { e.PosHqcode, e.PosSitecode }, "db_p_siteNDX");

            entity.Property(e => e.PosBhf)
                .HasColumnType("CHAR(6)")
                .HasColumnName("POS_BHF");
            entity.Property(e => e.PosBht)
                .HasColumnType("CHAR(6)")
                .HasColumnName("POS_BHT");
            entity.Property(e => e.PosHqcode)
                .HasColumnType("CHAR(10)")
                .HasColumnName("POS_HQCODE");
            entity.Property(e => e.PosPhone)
                .HasColumnType("CHAR(15)")
                .HasColumnName("POS_PHONE");
            entity.Property(e => e.PosSiteaddr)
                .HasColumnType("CHAR(40)")
                .HasColumnName("POS_SITEADDR");
            entity.Property(e => e.PosSitecode)
                .HasColumnType("CHAR(10)")
                .HasColumnName("POS_SITECODE");
            entity.Property(e => e.PosSitename)
                .HasColumnType("CHAR(40)")
                .HasColumnName("POS_SITENAME");
            entity.Property(e => e.PosSitetin)
                .HasColumnType("CHAR(40)")
                .HasColumnName("POS_SITETIN");
        });

        modelBuilder.Entity<DbPSiteq>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_siteq");

            entity.HasIndex(e => new { e.PosHqcode, e.PosSitecode }, "db_p_siteqNDX");

            entity.Property(e => e.PosFri).HasColumnName("POS_FRI");
            entity.Property(e => e.PosHqcode)
                .HasColumnType("CHAR(10)")
                .HasColumnName("POS_HQCODE");
            entity.Property(e => e.PosMon).HasColumnName("POS_MON");
            entity.Property(e => e.PosSat).HasColumnName("POS_SAT");
            entity.Property(e => e.PosSitecode)
                .HasColumnType("CHAR(10)")
                .HasColumnName("POS_SITECODE");
            entity.Property(e => e.PosSun).HasColumnName("POS_SUN");
            entity.Property(e => e.PosThu).HasColumnName("POS_THU");
            entity.Property(e => e.PosTue).HasColumnName("POS_TUE");
            entity.Property(e => e.PosWed).HasColumnName("POS_WED");
        });

        modelBuilder.Entity<DbPSmap>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_smap");

            entity.HasIndex(e => new { e.PosHqcode, e.PosSitecode, e.PosIndex }, "db_p_smapNDX");

            entity.Property(e => e.PosHqcode)
                .HasColumnType("CHAR(10)")
                .HasColumnName("POS_HQCODE");
            entity.Property(e => e.PosIndex).HasColumnName("POS_INDEX");
            entity.Property(e => e.PosSitecode)
                .HasColumnType("CHAR(10)")
                .HasColumnName("POS_SITECODE");
            entity.Property(e => e.PosTaskcode)
                .HasColumnType("CHAR(17)")
                .HasColumnName("POS_TASKCODE");
        });

        modelBuilder.Entity<DbPTask>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_task");

            entity.HasIndex(e => e.PosTaskcode, "db_p_taskNDX");

            entity.Property(e => e.PosTaskcode)
                .HasColumnType("CHAR(17)")
                .HasColumnName("POS_TASKCODE");
            entity.Property(e => e.PosTasktype)
                .HasColumnType("CHAR(1)")
                .HasColumnName("POS_TASKTYPE");
        });

        modelBuilder.Entity<DbPText>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_text");

            entity.HasIndex(e => new { e.PosTextcode, e.PosNamecode }, "db_p_textNDX");

            entity.Property(e => e.PosNamecode).HasColumnName("POS_NAMECODE");
            entity.Property(e => e.PosText)
                .HasColumnType("CHAR(255)")
                .HasColumnName("POS_TEXT");
            entity.Property(e => e.PosTextcode).HasColumnName("POS_TEXTCODE");
        });

        modelBuilder.Entity<DbPTextTest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_text_test");

            entity.Property(e => e.PosNamecode)
                .HasColumnType("INTEGER")
                .HasColumnName("POS_NAMECODE");
            entity.Property(e => e.PosText)
                .HasColumnType("CHAR(255)")
                .HasColumnName("POS_TEXT");
            entity.Property(e => e.PosTextcode)
                .HasColumnType("INTEGER")
                .HasColumnName("POS_TEXTCODE");
        });

        modelBuilder.Entity<DbPTlink>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_tlink");

            entity.HasIndex(e => new { e.PosTaskcode, e.PosSequence }, "db_p_tlinkNDX");

            entity.Property(e => e.PosSequence)
                .HasColumnType("INTEGER")
                .HasColumnName("POS_SEQUENCE");
            entity.Property(e => e.PosTaskcode)
                .HasColumnType("CHAR(17)")
                .HasColumnName("POS_TASKCODE");
            entity.Property(e => e.PosTasklink)
                .HasColumnType("CHAR(17)")
                .HasColumnName("POS_TASKLINK");
        });

        modelBuilder.Entity<DbPUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_user");

            entity.HasIndex(e => e.PosEmpid, "db_p_userNDX");

            entity.Property(e => e.PosEmpid)
                .HasColumnType("CHAR(10)")
                .HasColumnName("POS_EMPID");
            entity.Property(e => e.PosPassword)
                .HasColumnType("CHAR(10)")
                .HasColumnName("POS_PASSWORD");
            entity.Property(e => e.PosSecurity).HasColumnName("POS_SECURITY");
            entity.Property(e => e.PosUsername)
                .HasColumnType("CHAR(10)")
                .HasColumnName("POS_USERNAME");
            entity.Property(e => e.PosUsertype).HasColumnName("POS_USERTYPE");
        });

        modelBuilder.Entity<DbPUserq>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_p_userq");

            entity.HasIndex(e => e.PosEmpid, "db_p_userqNDX");

            entity.Property(e => e.PosCa).HasColumnName("POS_CA");
            entity.Property(e => e.PosCb).HasColumnName("POS_CB");
            entity.Property(e => e.PosCc).HasColumnName("POS_CC");
            entity.Property(e => e.PosEmpid)
                .HasColumnType("CHAR(10)")
                .HasColumnName("POS_EMPID");
            entity.Property(e => e.PosFri).HasColumnName("POS_FRI");
            entity.Property(e => e.PosMon).HasColumnName("POS_MON");
            entity.Property(e => e.PosQ1).HasColumnName("POS_Q1");
            entity.Property(e => e.PosQ2).HasColumnName("POS_Q2");
            entity.Property(e => e.PosQ3).HasColumnName("POS_Q3");
            entity.Property(e => e.PosSat).HasColumnName("POS_SAT");
            entity.Property(e => e.PosSun).HasColumnName("POS_SUN");
            entity.Property(e => e.PosThu).HasColumnName("POS_THU");
            entity.Property(e => e.PosTue).HasColumnName("POS_TUE");
            entity.Property(e => e.PosWed).HasColumnName("POS_WED");
        });

        modelBuilder.Entity<DbSBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_s_base");

            entity.HasIndex(e => e.CalCode, "db_s_baseNDX");

            entity.Property(e => e.CalCode).HasColumnName("CAL_CODE");
            entity.Property(e => e.CalEdate)
                .HasColumnType("CHAR(8)")
                .HasColumnName("CAL_EDATE");
            entity.Property(e => e.CalFlag).HasColumnName("CAL_FLAG");
            entity.Property(e => e.CalName)
                .HasColumnType("CHAR(40)")
                .HasColumnName("CAL_NAME");
            entity.Property(e => e.CalSdate)
                .HasColumnType("CHAR(8)")
                .HasColumnName("CAL_SDATE");
        });

        modelBuilder.Entity<DbSCustom>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_s_custom");

            entity.HasIndex(e => e.CalCode, "db_s_customNDX");

            entity.Property(e => e.CalCode).HasColumnName("CAL_CODE");
            entity.Property(e => e.CalFlag1).HasColumnName("CAL_FLAG1");
            entity.Property(e => e.CalFlag2).HasColumnName("CAL_FLAG2");
        });

        modelBuilder.Entity<DbSDlist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_s_dlist");

            entity.HasIndex(e => new { e.CalCode, e.CalDate }, "db_s_dlistNDX");

            entity.Property(e => e.CalCode).HasColumnName("CAL_CODE");
            entity.Property(e => e.CalDate)
                .HasColumnType("CHAR(8)")
                .HasColumnName("CAL_DATE");
        });

        modelBuilder.Entity<DbSList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_s_list");

            entity.HasIndex(e => new { e.CalCode, e.CalCodelist }, "db_s_listNDX");

            entity.Property(e => e.CalCode).HasColumnName("CAL_CODE");
            entity.Property(e => e.CalCodelist).HasColumnName("CAL_CODELIST");
        });

        modelBuilder.Entity<DbSPeriod>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_s_period");

            entity.HasIndex(e => e.CalCode, "db_s_periodNDX");

            entity.Property(e => e.CalCode).HasColumnName("CAL_CODE");
            entity.Property(e => e.CalInterval).HasColumnName("CAL_INTERVAL");
            entity.Property(e => e.CalScope).HasColumnName("CAL_SCOPE");
        });

        modelBuilder.Entity<DbSTime>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("db_s_time");

            entity.HasIndex(e => new { e.CalCode, e.CalStime }, "db_s_timeNDX");

            entity.Property(e => e.CalCode).HasColumnName("CAL_CODE");
            entity.Property(e => e.CalEtime)
                .HasColumnType("CHAR(6)")
                .HasColumnName("CAL_ETIME");
            entity.Property(e => e.CalStime)
                .HasColumnType("CHAR(6)")
                .HasColumnName("CAL_STIME");
        });

        modelBuilder.Entity<FuelsWithPo>(entity =>
        {
            entity.ToTable("FuelsWithPOs");

            entity.Property(e => e.InvDate).HasColumnName("INV_DATE");
            entity.Property(e => e.Nozdown).HasColumnName("nozdown");
            entity.Property(e => e.Plateno).HasColumnName("plateno");
            entity.Property(e => e.Pono).HasColumnName("pono");
            entity.Property(e => e.PreInTime).HasColumnName("preInTime");
            entity.Property(e => e.PreOutTime).HasColumnName("preOutTime");
            entity.Property(e => e.Xamount).HasColumnName("XAmount");
            entity.Property(e => e.XamountDb).HasColumnName("XAmountDb");
            entity.Property(e => e.Xcorpcode).HasColumnName("XCorpcode");
            entity.Property(e => e.Xday).HasColumnName("XDay");
            entity.Property(e => e.Xitemcode).HasColumnName("XItemcode");
            entity.Property(e => e.Xmonth).HasColumnName("XMonth");
            entity.Property(e => e.Xnozzle).HasColumnName("XNozzle");
            entity.Property(e => e.Xoid).HasColumnName("XOid");
            entity.Property(e => e.Xoname).HasColumnName("XOname");
            entity.Property(e => e.Xpump).HasColumnName("XPump");
            entity.Property(e => e.Xsitecode).HasColumnName("XSitecode");
            entity.Property(e => e.Xtank).HasColumnName("XTank");
            entity.Property(e => e.Xtransaction).HasColumnName("XTransaction");
            entity.Property(e => e.Xyear).HasColumnName("XYear");
        });

        modelBuilder.Entity<XAddon>(entity =>
        {
            entity.ToTable("xAddon");

            entity.HasIndex(e => e.XTid, "xAddonIDX");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.XAccountcode)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xACCOUNTCODE");
            entity.Property(e => e.XAmountdue)
                .HasColumnType("DOUBLE")
                .HasColumnName("xAMOUNTDUE");
            entity.Property(e => e.XLastUpdate)
                .HasColumnType("TIMESTAMP")
                .HasColumnName("xLastUpdate");
            entity.Property(e => e.XRate)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xRATE");
            entity.Property(e => e.XStamp)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xSTAMP");
            entity.Property(e => e.XTid).HasColumnName("xTid");
        });

        modelBuilder.Entity<XCard>(entity =>
        {
            entity.ToTable("xCard");

            entity.HasIndex(e => e.XTid, "xCardIDX");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.XLastUpdate)
                .HasColumnType("TIMESTAMP")
                .HasColumnName("xLastUpdate");
            entity.Property(e => e.XMcAccount)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xMC_ACCOUNT");
            entity.Property(e => e.XMcAmtbal)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xMC_AMTBAL");
            entity.Property(e => e.XMcCardname)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xMC_CARDNAME");
            entity.Property(e => e.XMcCardno)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xMC_CARDNO");
            entity.Property(e => e.XMcCorpcode)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xMC_CORPCODE");
            entity.Property(e => e.XMcDatetime)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xMC_DATETIME");
            entity.Property(e => e.XMcDaylimit)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xMC_DAYLIMIT");
            entity.Property(e => e.XMcExpire)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xMC_EXPIRE");
            entity.Property(e => e.XMcFlag)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xMC_FLAG");
            entity.Property(e => e.XMcLimit)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xMC_LIMIT");
            entity.Property(e => e.XMcPdatetime)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xMC_PDATETIME");
            entity.Property(e => e.XMcPsitecode)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xMC_PSITECODE");
            entity.Property(e => e.XMcPump)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xMC_PUMP");
            entity.Property(e => e.XMcPvalue)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xMC_PVALUE");
            entity.Property(e => e.XMcPxtype)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xMC_PXTYPE");
            entity.Property(e => e.XMcReqvalue)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xMC_REQVALUE");
            entity.Property(e => e.XMcSeries)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xMC_SERIES");
            entity.Property(e => e.XMcSitecode)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xMC_SITECODE");
            entity.Property(e => e.XMcValue)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xMC_VALUE");
            entity.Property(e => e.XMcVersion)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xMC_VERSION");
            entity.Property(e => e.XMcVolbal)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xMC_VOLBAL");
            entity.Property(e => e.XMcXtype)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xMC_XTYPE");
            entity.Property(e => e.XTid).HasColumnName("xTid");
        });

        modelBuilder.Entity<XFunction>(entity =>
        {
            entity.ToTable("xFunctions");

            entity.HasIndex(e => e.XTid, "xFunctionIDX");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.XAccountcode)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xACCOUNTCODE");
            entity.Property(e => e.XAmount1)
                .HasColumnType("DOUBLE")
                .HasColumnName("xAMOUNT1");
            entity.Property(e => e.XAmount2)
                .HasColumnType("DOUBLE")
                .HasColumnName("xAMOUNT2");
            entity.Property(e => e.XAmountdue)
                .HasColumnType("DOUBLE")
                .HasColumnName("xAMOUNTDUE");
            entity.Property(e => e.XAmt1)
                .HasColumnType("DOUBLE")
                .HasColumnName("xAmt1");
            entity.Property(e => e.XAmt2)
                .HasColumnType("DOUBLE")
                .HasColumnName("xAmt2");
            entity.Property(e => e.XAmt3)
                .HasColumnType("DOUBLE")
                .HasColumnName("xAmt3");
            entity.Property(e => e.XApiflag)
                .HasColumnType("CHAR(2)")
                .HasColumnName("xAPIFLAG");
            entity.Property(e => e.XByte1)
                .HasColumnType("INTEGER")
                .HasColumnName("xBYTE1");
            entity.Property(e => e.XByte2)
                .HasColumnType("INTEGER")
                .HasColumnName("xBYTE2");
            entity.Property(e => e.XChangedue)
                .HasColumnType("DOUBLE")
                .HasColumnName("xCHANGEDUE");
            entity.Property(e => e.XCkBankname)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xCK_BANKNAME");
            entity.Property(e => e.XCkCheckno)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xCK_CHECKNO");
            entity.Property(e => e.XControlno).HasColumnName("xCONTROLNO");
            entity.Property(e => e.XControlr).HasColumnName("xCONTROLR");
            entity.Property(e => e.XCurrsym)
                .HasColumnType("CHAR(12)")
                .HasColumnName("xCURRSYM");
            entity.Property(e => e.XCustomfield1)
                .HasColumnType("CHAR(40)")
                .HasColumnName("xCUSTOMFIELD1");
            entity.Property(e => e.XDescription)
                .HasColumnType("CHAR(32)")
                .HasColumnName("xDESCRIPTION");
            entity.Property(e => e.XDword1)
                .HasColumnType("DOUBLE")
                .HasColumnName("xDWORD1");
            entity.Property(e => e.XDword2)
                .HasColumnType("DOUBLE")
                .HasColumnName("xDWORD2");
            entity.Property(e => e.XFindex).HasColumnName("xFINDEX");
            entity.Property(e => e.XFlag)
                .HasColumnType("CHAR(13)")
                .HasColumnName("xFLAG");
            entity.Property(e => e.XForex)
                .HasColumnType("DOUBLE")
                .HasColumnName("xFOREX");
            entity.Property(e => e.XFormat)
                .HasColumnType("CHAR(14)")
                .HasColumnName("xFORMAT");
            entity.Property(e => e.XFtype)
                .HasColumnType("CHAR(1)")
                .HasColumnName("xFType");
            entity.Property(e => e.XGcSerialno)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xGC_SERIALNO");
            entity.Property(e => e.XGuestcount).HasColumnName("xGUESTCOUNT");
            entity.Property(e => e.XItemcodex)
                .HasColumnType("char(17)")
                .HasColumnName("xITEMCODEX");
            entity.Property(e => e.XLastUpdate)
                .HasColumnType("TIMESTAMP")
                .HasColumnName("xLastUpdate");
            entity.Property(e => e.XMaxamt)
                .HasColumnType("DOUBLE")
                .HasColumnName("xMAXAMT");
            entity.Property(e => e.XMaxqty)
                .HasColumnType("DOUBLE")
                .HasColumnName("xMAXQTY");
            entity.Property(e => e.XQty1)
                .HasColumnType("DOUBLE")
                .HasColumnName("xQty1");
            entity.Property(e => e.XQty2)
                .HasColumnType("DOUBLE")
                .HasColumnName("xQty2");
            entity.Property(e => e.XReal1)
                .HasColumnType("DOUBLE")
                .HasColumnName("xREAL1");
            entity.Property(e => e.XReal2)
                .HasColumnType("DOUBLE")
                .HasColumnName("xREAL2");
            entity.Property(e => e.XRoundamt)
                .HasColumnType("DOUBLE")
                .HasColumnName("xROUNDAMT");
            entity.Property(e => e.XSrcount).HasColumnName("xSRCOUNT");
            entity.Property(e => e.XStamp)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xSTAMP");
            entity.Property(e => e.XTaskcode)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xTASKCODE");
            entity.Property(e => e.XTasktype)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xTASKTYPE");
            entity.Property(e => e.XTid).HasColumnName("xTid");
            entity.Property(e => e.XTotalamount)
                .HasColumnType("DOUBLE")
                .HasColumnName("xTOTALAMOUNT");
            entity.Property(e => e.XTotalamountdue)
                .HasColumnType("DOUBLE")
                .HasColumnName("xTOTALAMOUNTDUE");
            entity.Property(e => e.XTransactiondue)
                .HasColumnType("DOUBLE")
                .HasColumnName("xTRANSACTIONDUE");
            entity.Property(e => e.XTstamp)
                .HasColumnType("char(20)")
                .HasColumnName("xTSTAMP");
            entity.Property(e => e.XUsedamt)
                .HasColumnType("DOUBLE")
                .HasColumnName("xUSEDAMT");
            entity.Property(e => e.XUsedqty)
                .HasColumnType("DOUBLE")
                .HasColumnName("xUSEDQTY");
            entity.Property(e => e.XWord1)
                .HasColumnType("DOUBLE")
                .HasColumnName("xWORD1");
            entity.Property(e => e.XWord2)
                .HasColumnType("DOUBLE")
                .HasColumnName("xWORD2");
        });

        modelBuilder.Entity<XItem>(entity =>
        {
            entity.ToTable("xItems");

            entity.HasIndex(e => e.XApiflag, "iItemsA");

            entity.HasIndex(e => e.XClosetotal, "iItemsC");

            entity.HasIndex(e => e.XTid, "iItemsID");

            entity.HasIndex(e => e.XItemcode, "iItemsIT");

            entity.HasIndex(e => e.XOpentotal, "iItemsO");

            entity.HasIndex(e => e.XPump, "iItemsP");

            entity.HasIndex(e => e.XStamp, "iItemsS");

            entity.HasIndex(e => e.XTank, "iItemsT");

            entity.HasIndex(e => e.XTid, "xItemIDX");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.XAddon)
                .HasColumnType("DOUBLE")
                .HasColumnName("xADDON");
            entity.Property(e => e.XAmount)
                .HasColumnType("DOUBLE")
                .HasColumnName("xAMOUNT");
            entity.Property(e => e.XAmountDb)
                .HasColumnType("DOUBLE")
                .HasColumnName("xAmountDB");
            entity.Property(e => e.XAmountPaid)
                .HasColumnType("DOUBLE")
                .HasColumnName("xAmountPaid");
            entity.Property(e => e.XAmt1)
                .HasColumnType("DOUBLE")
                .HasColumnName("xAmt1");
            entity.Property(e => e.XApiflag)
                .HasColumnType("CHAR(2)")
                .HasColumnName("xAPIFLAG");
            entity.Property(e => e.XBarcode)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xBARCODE");
            entity.Property(e => e.XBaseprice)
                .HasColumnType("DOUBLE")
                .HasColumnName("xBASEPRICE");
            entity.Property(e => e.XCid)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xCID");
            entity.Property(e => e.XClosetotal)
                .HasColumnType("DOUBLE")
                .HasColumnName("xCLOSETOTAL");
            entity.Property(e => e.XCname)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xCNAME");
            entity.Property(e => e.XControlflag)
                .HasColumnType("CHAR(11)")
                .HasColumnName("xCONTROLFLAG");
            entity.Property(e => e.XCoupon)
                .HasColumnType("DOUBLE")
                .HasColumnName("xCOUPON");
            entity.Property(e => e.XCut)
                .HasColumnType("DOUBLE")
                .HasColumnName("xCUT");
            entity.Property(e => e.XDescription)
                .HasColumnType("CHAR(32)")
                .HasColumnName("xDESCRIPTION");
            entity.Property(e => e.XDiscount)
                .HasColumnType("DOUBLE")
                .HasColumnName("xDISCOUNT");
            entity.Property(e => e.XDrtable).HasColumnName("xDRTABLE");
            entity.Property(e => e.XFormat)
                .HasColumnType("CHAR(14)")
                .HasColumnName("xFORMAT");
            entity.Property(e => e.XGuestcount).HasColumnName("xGUESTCOUNT");
            entity.Property(e => e.XInvcode)
                .HasColumnType("CHAR(15)")
                .HasColumnName("xINVCODE");
            entity.Property(e => e.XItemcode)
                .HasColumnType("CHAR(16)")
                .HasColumnName("xITEMCODE");
            entity.Property(e => e.XItemcodex)
                .HasColumnType("CHAR(17)")
                .HasColumnName("xITEMCODEX");
            entity.Property(e => e.XItemflag).HasColumnName("xITEMFLAG");
            entity.Property(e => e.XItemflagx).HasColumnName("xITEMFLAGX");
            entity.Property(e => e.XItemkind)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xITEMKIND");
            entity.Property(e => e.XItemtype)
                .HasColumnType("CHAR(19)")
                .HasColumnName("xITEMTYPE");
            entity.Property(e => e.XLastUpdate)
                .HasColumnType("TIMESTAMP")
                .HasColumnName("xLastUpdate");
            entity.Property(e => e.XMaxcond)
                .HasColumnType("DOUBLE")
                .HasColumnName("xMAXCOND");
            entity.Property(e => e.XMincond)
                .HasColumnType("DOUBLE")
                .HasColumnName("xMINCOND");
            entity.Property(e => e.XModgroup)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xMODGROUP");
            entity.Property(e => e.XNounflag)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xNOUNFLAG");
            entity.Property(e => e.XNozzle).HasColumnName("xNOZZLE");
            entity.Property(e => e.XNzstamp)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xNZSTAMP");
            entity.Property(e => e.XOpentotal)
                .HasColumnType("DOUBLE")
                .HasColumnName("xOPENTOTAL");
            entity.Property(e => e.XPoints)
                .HasColumnType("DOUBLE")
                .HasColumnName("xPOINTS");
            entity.Property(e => e.XPrice)
                .HasColumnType("DOUBLE")
                .HasColumnName("xPRICE");
            entity.Property(e => e.XPricecode)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xPRICECODE");
            entity.Property(e => e.XPricedb)
                .HasColumnType("DOUBLE")
                .HasColumnName("xPRICEDB");
            entity.Property(e => e.XPriceflag)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xPRICEFLAG");
            entity.Property(e => e.XPromoindex).HasColumnName("xPROMOINDEX");
            entity.Property(e => e.XPstid).HasColumnName("xPSTID");
            entity.Property(e => e.XPump).HasColumnName("xPUMP");
            entity.Property(e => e.XPumpflag).HasColumnName("xPUMPFLAG");
            entity.Property(e => e.XQuantity)
                .HasColumnType("DOUBLE")
                .HasColumnName("xQUANTITY");
            entity.Property(e => e.XRoutecolumn).HasColumnName("xROUTECOLUMN");
            entity.Property(e => e.XSeatid)
                .HasColumnType("CHAR(10)")
                .HasColumnName("xSEATID");
            entity.Property(e => e.XSerialnumber)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xSERIALNUMBER");
            entity.Property(e => e.XSid)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xSID");
            entity.Property(e => e.XSname)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xSNAME");
            entity.Property(e => e.XStamp)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xSTAMP");
            entity.Property(e => e.XStampdown)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xSTAMPDOWN");
            entity.Property(e => e.XStampup)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xSTAMPUP");
            entity.Property(e => e.XStatus).HasColumnName("xSTATUS");
            entity.Property(e => e.XTable)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xTABLE");
            entity.Property(e => e.XTank).HasColumnName("xTANK");
            entity.Property(e => e.XTaskcode)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xTASKCODE");
            entity.Property(e => e.XTasktype)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xTASKTYPE");
            entity.Property(e => e.XTid).HasColumnName("xTid");
            entity.Property(e => e.XTotalVariance)
                .HasColumnType("DOUBLE")
                .HasColumnName("xTotalVariance");
            entity.Property(e => e.XTotaltype).HasColumnName("xTOTALTYPE");
            entity.Property(e => e.XTotaltypename)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xTOTALTYPENAME");
            entity.Property(e => e.XUom).HasColumnName("xUOM");
            entity.Property(e => e.XVehicleplateno)
                .HasColumnType("CHAR(10)")
                .HasColumnName("xVEHICLEPLATENO");
            entity.Property(e => e.XVehicletype)
                .HasColumnType("CHAR(10)")
                .HasColumnName("xVEHICLETYPE");
            entity.Property(e => e.XVipCode)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_CODE");
            entity.Property(e => e.XVipF01)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_F01");
            entity.Property(e => e.XVipF02)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_F02");
            entity.Property(e => e.XVipF03)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_F03");
            entity.Property(e => e.XVipF04)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_F04");
            entity.Property(e => e.XVipF05)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_F05");
            entity.Property(e => e.XVipFname)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_FNAME");
            entity.Property(e => e.XVipLname)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_LNAME");
            entity.Property(e => e.XVipMname)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_MNAME");
            entity.Property(e => e.XYield)
                .HasColumnType("DOUBLE")
                .HasColumnName("xYIELD");
        });

        modelBuilder.Entity<XModi>(entity =>
        {
            entity.ToTable("xMODI");

            entity.HasIndex(e => e.XTid, "iModiID");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.XApiflag)
                .HasColumnType("CHAR(2)")
                .HasColumnName("xAPIFLAG");
            entity.Property(e => e.XDescription)
                .HasColumnType("CHAR(32)")
                .HasColumnName("xDESCRIPTION");
            entity.Property(e => e.XFlag).HasColumnName("xFLAG");
            entity.Property(e => e.XFormat)
                .HasColumnType("CHAR(14)")
                .HasColumnName("xFORMAT");
            entity.Property(e => e.XItemId).HasColumnName("xItemId");
            entity.Property(e => e.XLastUpdate)
                .HasColumnType("TIMESTAMP")
                .HasColumnName("xLastUpdate");
            entity.Property(e => e.XModgroup)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xMODGROUP");
            entity.Property(e => e.XModsgroup)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xMODSGROUP");
            entity.Property(e => e.XOwneritemcodx)
                .HasColumnType("CHAR(17)")
                .HasColumnName("xOWNERITEMCODX");
            entity.Property(e => e.XOwnerqty)
                .HasColumnType("DOUBLE")
                .HasColumnName("xOWNERQTY");
            entity.Property(e => e.XOwnerstamp)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xOWNERSTAMP");
            entity.Property(e => e.XQuantity)
                .HasColumnType("DOUBLE")
                .HasColumnName("xQUANTITY");
            entity.Property(e => e.XStamp)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xSTAMP");
            entity.Property(e => e.XTaskcode)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xTASKCODE");
            entity.Property(e => e.XTasktype)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xTASKTYPE");
            entity.Property(e => e.XTid).HasColumnName("xTid");
        });

        modelBuilder.Entity<XOffline>(entity =>
        {
            entity.ToTable("xOffline");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.XAfterInvoice).HasColumnName("xAfterInvoice");
            entity.Property(e => e.XAfterStamp)
                .HasColumnType("TIMESTAMP\n    xLastUpdate TIMESTAMP")
                .HasColumnName("xAfterStamp");
            entity.Property(e => e.XAmount)
                .HasColumnType("DOUBLE")
                .HasColumnName("xAmount");
            entity.Property(e => e.XBatch).HasColumnName("xBatch");
            entity.Property(e => e.XBdate)
                .HasColumnType("DATETIME")
                .HasColumnName("xBDate");
            entity.Property(e => e.XBeforeInvoice).HasColumnName("xBeforeInvoice");
            entity.Property(e => e.XBeforeStamp)
                .HasColumnType("TIMESTAMP")
                .HasColumnName("xBeforeStamp");
            entity.Property(e => e.XCashier)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xCashier");
            entity.Property(e => e.XCashierCode)
                .HasColumnType("CHAR(10)")
                .HasColumnName("xCashierCode");
            entity.Property(e => e.XCloseTotalizer)
                .HasColumnType("DOUBLE")
                .HasColumnName("xCloseTotalizer");
            entity.Property(e => e.XItemCode)
                .HasColumnType("CHAR(16)")
                .HasColumnName("xItemCode");
            entity.Property(e => e.XItemName)
                .HasColumnType("CHAR(32)")
                .HasColumnName("xItemName");
            entity.Property(e => e.XNozzle).HasColumnName("xNozzle");
            entity.Property(e => e.XOpenTotalizer)
                .HasColumnType("DOUBLE")
                .HasColumnName("xOpenTotalizer");
            entity.Property(e => e.XOrigOpenTotal)
                .HasColumnType("DOUBLE")
                .HasColumnName("xOrigOpenTotal");
            entity.Property(e => e.XPumpNo).HasColumnName("xPumpNo");
            entity.Property(e => e.XQuantity)
                .HasColumnType("DOUBLE")
                .HasColumnName("xQuantity");
            entity.Property(e => e.XTankNo).HasColumnName("xTankNo");
            entity.Property(e => e.XTotalType).HasColumnName("xTotalType");
            entity.Property(e => e.XUnitPrice)
                .HasColumnType("DOUBLE")
                .HasColumnName("xUnitPrice");
        });

        modelBuilder.Entity<XTicket>(entity =>
        {
            entity.ToTable("xTickets");

            entity.HasIndex(e => e.XCorpcode, "iTicketsC");

            entity.HasIndex(e => e.XDay, "iTicketsD");

            entity.HasIndex(e => e.XTicketId, "iTicketsID");

            entity.HasIndex(e => e.XMonth, "iTicketsM");

            entity.HasIndex(e => e.XSitecode, "iTicketsS");

            entity.HasIndex(e => e.XYear, "iTicketsY");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.XBatch).HasColumnName("xBATCH");
            entity.Property(e => e.XCorpcode).HasColumnName("xCORPCODE");
            entity.Property(e => e.XDay).HasColumnName("xDAY");
            entity.Property(e => e.XDiscountmethod).HasColumnName("xDISCOUNTMETHOD");
            entity.Property(e => e.XFlag)
                .HasColumnType("CHAR(13)")
                .HasColumnName("xFLAG");
            entity.Property(e => e.XFld001)
                .HasColumnType("CHAR(6)")
                .HasColumnName("xFLD001");
            entity.Property(e => e.XGuestcount).HasColumnName("xGUESTCOUNT");
            entity.Property(e => e.XHqcode).HasColumnName("xHQCODE");
            entity.Property(e => e.XLastUpdate)
                .HasColumnType("TIMESTAMP")
                .HasColumnName("xLastUpdate");
            entity.Property(e => e.XMonth).HasColumnName("xMONTH");
            entity.Property(e => e.XOdometer)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xODOMETER");
            entity.Property(e => e.XOid)
                .HasColumnType("CHAR(10)")
                .HasColumnName("xOID");
            entity.Property(e => e.XOname)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xONAME");
            entity.Property(e => e.XPricecode)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xPRICECODE");
            entity.Property(e => e.XPromoindex).HasColumnName("xPROMOINDEX");
            entity.Property(e => e.XPropertytag)
                .HasColumnType("CHAR(60)")
                .HasColumnName("xPROPERTYTAG");
            entity.Property(e => e.XPstid).HasColumnName("xPSTID");
            entity.Property(e => e.XRoutecolumn).HasColumnName("xROUTECOLUMN");
            entity.Property(e => e.XRsn).HasColumnName("xRSN");
            entity.Property(e => e.XRtn).HasColumnName("xRTN");
            entity.Property(e => e.XSequence).HasColumnName("xSEQUENCE");
            entity.Property(e => e.XShift).HasColumnName("xSHIFT");
            entity.Property(e => e.XSitecode).HasColumnName("xSITECODE");
            entity.Property(e => e.XSrcount)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xSRCOUNT");
            entity.Property(e => e.XStamp)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xSTAMP");
            entity.Property(e => e.XStampfi)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xSTAMPFI");
            entity.Property(e => e.XStamplt)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xSTAMPLT");
            entity.Property(e => e.XTable)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xTABLE");
            entity.Property(e => e.XTent)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xTENT");
            entity.Property(e => e.XTicketId)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xTicketID");
            entity.Property(e => e.XTotaltype).HasColumnName("xTOTALTYPE");
            entity.Property(e => e.XTotaltypename)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xTOTALTYPENAME");
            entity.Property(e => e.XTransaction).HasColumnName("xTRANSACTION");
            entity.Property(e => e.XVoidtransaction)
                .HasColumnType("DOUBLE")
                .HasColumnName("xVOIDTRANSACTION");
            entity.Property(e => e.XYear).HasColumnName("xYEAR");
        });

        modelBuilder.Entity<XVip>(entity =>
        {
            entity.ToTable("xVIP");

            entity.HasIndex(e => e.XTid, "xVIPIDX");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.XLastUpdate)
                .HasColumnType("TIMESTAMP")
                .HasColumnName("xLastUpdate");
            entity.Property(e => e.XTid).HasColumnName("xTid");
            entity.Property(e => e.XVipApc)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_APC");
            entity.Property(e => e.XVipBario)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_BARIO");
            entity.Property(e => e.XVipCardlabel)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_CARDLABEL");
            entity.Property(e => e.XVipCardname)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_CARDNAME");
            entity.Property(e => e.XVipCity)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_CITY");
            entity.Property(e => e.XVipCode)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_CODE");
            entity.Property(e => e.XVipCode2)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_CODE2");
            entity.Property(e => e.XVipFname)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_FNAME");
            entity.Property(e => e.XVipHseno)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_HSENO");
            entity.Property(e => e.XVipLname)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_LNAME");
            entity.Property(e => e.XVipMid)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_MID");
            entity.Property(e => e.XVipMname)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_MNAME");
            entity.Property(e => e.XVipPcode)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_PCODE");
            entity.Property(e => e.XVipPtsa)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_PTSA");
            entity.Property(e => e.XVipPtse)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_PTSE");
            entity.Property(e => e.XVipPtsp)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_PTSP");
            entity.Property(e => e.XVipPtsr)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_PTSR");
            entity.Property(e => e.XVipRef)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_REF");
            entity.Property(e => e.XVipSalute)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_SALUTE");
            entity.Property(e => e.XVipStreet)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_STREET");
            entity.Property(e => e.XVipTid)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_TID");
            entity.Property(e => e.XVipTin)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_TIN");
            entity.Property(e => e.XVipZip)
                .HasColumnType("CHAR(20)")
                .HasColumnName("xVIP_ZIP");
        });

        modelBuilder.Entity<XmlBButton>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xml_B_BUTTON");

            entity.HasIndex(e => new { e.EpoCode, e.EpoLeft, e.EpoTop }, "xml_B_BUTTONNDX");

            entity.Property(e => e.EpoBitmap)
                .HasColumnType("CHAR(12)")
                .HasColumnName("EPO_BITMAP");
            entity.Property(e => e.EpoCode)
                .HasColumnType("INTEGER")
                .HasColumnName("EPO_CODE");
            entity.Property(e => e.EpoColor)
                .HasColumnType("INTEGER")
                .HasColumnName("EPO_COLOR");
            entity.Property(e => e.EpoFcode)
                .HasColumnType("INTEGER")
                .HasColumnName("EPO_FCODE");
            entity.Property(e => e.EpoFlag)
                .HasColumnType("INTEGER")
                .HasColumnName("EPO_FLAG");
            entity.Property(e => e.EpoFntcolor)
                .HasColumnType("INTEGER")
                .HasColumnName("EPO_FNTCOLOR");
            entity.Property(e => e.EpoFntname)
                .HasColumnType("CHAR(31)")
                .HasColumnName("EPO_FNTNAME");
            entity.Property(e => e.EpoFntsize)
                .HasColumnType("INTEGER")
                .HasColumnName("EPO_FNTSIZE");
            entity.Property(e => e.EpoHeight)
                .HasColumnType("INTEGER")
                .HasColumnName("EPO_HEIGHT");
            entity.Property(e => e.EpoLeft)
                .HasColumnType("INTEGER")
                .HasColumnName("EPO_LEFT");
            entity.Property(e => e.EpoSecurity)
                .HasColumnType("INTEGER")
                .HasColumnName("EPO_SECURITY");
            entity.Property(e => e.EpoTaskcode)
                .HasColumnType("CHAR(17)")
                .HasColumnName("EPO_TASKCODE");
            entity.Property(e => e.EpoText)
                .HasColumnType("CHAR(40)")
                .HasColumnName("EPO_TEXT");
            entity.Property(e => e.EpoTop)
                .HasColumnType("INTEGER")
                .HasColumnName("EPO_TOP");
            entity.Property(e => e.EpoWidth)
                .HasColumnType("INTEGER")
                .HasColumnName("EPO_WIDTH");
        });

        modelBuilder.Entity<XmlBForm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xml_B_FORM");

            entity.HasIndex(e => e.EpoCode, "xml_B_FORMNDX");

            entity.Property(e => e.EpoBitmap)
                .HasColumnType("CHAR(12)")
                .HasColumnName("EPO_BITMAP");
            entity.Property(e => e.EpoCode).HasColumnName("EPO_CODE");
            entity.Property(e => e.EpoColor).HasColumnName("EPO_COLOR");
            entity.Property(e => e.EpoName)
                .HasColumnType("CHAR(40)")
                .HasColumnName("EPO_NAME");
        });

        modelBuilder.Entity<XmlBTask>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xml_B_TASK");

            entity.HasIndex(e => e.EpoTaskcode, "xml_B_TASKNDX");

            entity.Property(e => e.EpoCommand)
                .HasColumnType("CHAR(40)")
                .HasColumnName("EPO_COMMAND");
            entity.Property(e => e.EpoTaskcode)
                .HasColumnType("CHAR(17)")
                .HasColumnName("EPO_TASKCODE");
            entity.Property(e => e.EpoTasktype).HasColumnName("EPO_TASKTYPE");
        });

        modelBuilder.Entity<XmlEmp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xml_EMP");

            entity.HasIndex(e => e.EpoCode, "xml_EMPNDX");

            entity.Property(e => e.EpoBirthdate)
                .HasColumnType("CHAR(8)")
                .HasColumnName("EPO_BIRTHDATE");
            entity.Property(e => e.EpoCode)
                .HasColumnType("CHAR(10)")
                .HasColumnName("EPO_CODE");
            entity.Property(e => e.EpoFlag).HasColumnName("EPO_FLAG");
            entity.Property(e => e.EpoFname)
                .HasColumnType("CHAR(20)")
                .HasColumnName("EPO_FNAME");
            entity.Property(e => e.EpoGender).HasColumnName("EPO_GENDER");
            entity.Property(e => e.EpoLname)
                .HasColumnType("CHAR(20)")
                .HasColumnName("EPO_LNAME");
            entity.Property(e => e.EpoMname)
                .HasColumnType("CHAR(20)")
                .HasColumnName("EPO_MNAME");
            entity.Property(e => e.EpoSalute).HasColumnName("EPO_SALUTE");
            entity.Property(e => e.EpoStatus).HasColumnName("EPO_STATUS");
        });

        modelBuilder.Entity<XmlFvbal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xml_FVBAL");

            entity.HasIndex(e => e.Code, "xml_FVBALNDX");

            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.Code)
                .HasColumnType("CHAR(10)")
                .HasColumnName("CODE");
            entity.Property(e => e.Description)
                .HasColumnType("CHAR(20)")
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Lastupdate).HasColumnName("LASTUPDATE");
        });

        modelBuilder.Entity<XmlICogi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xml_I_COGI");

            entity.HasIndex(e => e.InvItemcodex, "xml_I_COGINDX");

            entity.Property(e => e.Bday).HasColumnName("BDAY");
            entity.Property(e => e.Bmonth).HasColumnName("BMONTH");
            entity.Property(e => e.Byear).HasColumnName("BYEAR");
            entity.Property(e => e.Corpcode).HasColumnName("CORPCODE");
            entity.Property(e => e.InvAcuadjamt).HasColumnName("INV_ACUADJAMT");
            entity.Property(e => e.InvAcuadjqty).HasColumnName("INV_ACUADJQTY");
            entity.Property(e => e.InvAcubatamt).HasColumnName("INV_ACUBATAMT");
            entity.Property(e => e.InvAcubatqty).HasColumnName("INV_ACUBATQTY");
            entity.Property(e => e.InvAcubruamt).HasColumnName("INV_ACUBRUAMT");
            entity.Property(e => e.InvAcubruqty).HasColumnName("INV_ACUBRUQTY");
            entity.Property(e => e.InvAcudelamt).HasColumnName("INV_ACUDELAMT");
            entity.Property(e => e.InvAcudelqty).HasColumnName("INV_ACUDELQTY");
            entity.Property(e => e.InvAcuisuamt).HasColumnName("INV_ACUISUAMT");
            entity.Property(e => e.InvAcuisuqty).HasColumnName("INV_ACUISUQTY");
            entity.Property(e => e.InvAcuxfiamt).HasColumnName("INV_ACUXFIAMT");
            entity.Property(e => e.InvAcuxfiqty).HasColumnName("INV_ACUXFIQTY");
            entity.Property(e => e.InvAcuxfoamt).HasColumnName("INV_ACUXFOAMT");
            entity.Property(e => e.InvAcuxfoqty).HasColumnName("INV_ACUXFOQTY");
            entity.Property(e => e.InvAdjamt).HasColumnName("INV_ADJAMT");
            entity.Property(e => e.InvAdjqty).HasColumnName("INV_ADJQTY");
            entity.Property(e => e.InvBatamt).HasColumnName("INV_BATAMT");
            entity.Property(e => e.InvBatch).HasColumnName("INV_BATCH");
            entity.Property(e => e.InvBatqty).HasColumnName("INV_BATQTY");
            entity.Property(e => e.InvBegamt).HasColumnName("INV_BEGAMT");
            entity.Property(e => e.InvBegqty).HasColumnName("INV_BEGQTY");
            entity.Property(e => e.InvBruamt).HasColumnName("INV_BRUAMT");
            entity.Property(e => e.InvBruqty).HasColumnName("INV_BRUQTY");
            entity.Property(e => e.InvCostlast).HasColumnName("INV_COSTLAST");
            entity.Property(e => e.InvCostma).HasColumnName("INV_COSTMA");
            entity.Property(e => e.InvDelamt).HasColumnName("INV_DELAMT");
            entity.Property(e => e.InvDelqty).HasColumnName("INV_DELQTY");
            entity.Property(e => e.InvEndamt).HasColumnName("INV_ENDAMT");
            entity.Property(e => e.InvEndqty).HasColumnName("INV_ENDQTY");
            entity.Property(e => e.InvIsuamt).HasColumnName("INV_ISUAMT");
            entity.Property(e => e.InvIsuqty).HasColumnName("INV_ISUQTY");
            entity.Property(e => e.InvItemcodex)
                .HasColumnType("CHAR(18)")
                .HasColumnName("INV_ITEMCODEX");
            entity.Property(e => e.InvVaramt).HasColumnName("INV_VARAMT");
            entity.Property(e => e.InvVarqty).HasColumnName("INV_VARQTY");
            entity.Property(e => e.InvXfiamt).HasColumnName("INV_XFIAMT");
            entity.Property(e => e.InvXfiqty).HasColumnName("INV_XFIQTY");
            entity.Property(e => e.InvXfoamt).HasColumnName("INV_XFOAMT");
            entity.Property(e => e.InvXfoqty).HasColumnName("INV_XFOQTY");
            entity.Property(e => e.Sitecode).HasColumnName("SITECODE");
        });

        modelBuilder.Entity<XmlICogp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xml_I_COGP");

            entity.HasIndex(e => new { e.InvPump, e.InvNozzle, e.InvTank, e.InvItemcodex }, "xml_I_COGPNDX");

            entity.Property(e => e.Bday).HasColumnName("BDAY");
            entity.Property(e => e.Bmonth).HasColumnName("BMONTH");
            entity.Property(e => e.Byear).HasColumnName("BYEAR");
            entity.Property(e => e.Corpcode).HasColumnName("CORPCODE");
            entity.Property(e => e.InvIsuamt).HasColumnName("INV_ISUAMT");
            entity.Property(e => e.InvIsuqty).HasColumnName("INV_ISUQTY");
            entity.Property(e => e.InvItemcodex)
                .HasColumnType("CHAR(18)")
                .HasColumnName("INV_ITEMCODEX");
            entity.Property(e => e.InvNozzle).HasColumnName("INV_NOZZLE");
            entity.Property(e => e.InvPump).HasColumnName("INV_PUMP");
            entity.Property(e => e.InvTank).HasColumnName("INV_TANK");
            entity.Property(e => e.InvTlzclo).HasColumnName("INV_TLZCLO");
            entity.Property(e => e.InvTlzope).HasColumnName("INV_TLZOPE");
            entity.Property(e => e.Sitecode).HasColumnName("SITECODE");
        });

        modelBuilder.Entity<XmlICogt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xml_I_COGT");

            entity.HasIndex(e => new { e.InvTank, e.InvItemcodex }, "xml_I_COGTNDX");

            entity.Property(e => e.Bday).HasColumnName("BDAY");
            entity.Property(e => e.Bmonth).HasColumnName("BMONTH");
            entity.Property(e => e.Byear).HasColumnName("BYEAR");
            entity.Property(e => e.Corpcode).HasColumnName("CORPCODE");
            entity.Property(e => e.InvAcudelamt).HasColumnName("INV_ACUDELAMT");
            entity.Property(e => e.InvAcudelqty).HasColumnName("INV_ACUDELQTY");
            entity.Property(e => e.InvAcuisuamt).HasColumnName("INV_ACUISUAMT");
            entity.Property(e => e.InvAcuisuqty).HasColumnName("INV_ACUISUQTY");
            entity.Property(e => e.InvBatch).HasColumnName("INV_BATCH");
            entity.Property(e => e.InvBegamt).HasColumnName("INV_BEGAMT");
            entity.Property(e => e.InvBegqty).HasColumnName("INV_BEGQTY");
            entity.Property(e => e.InvCostlast).HasColumnName("INV_COSTLAST");
            entity.Property(e => e.InvCostma).HasColumnName("INV_COSTMA");
            entity.Property(e => e.InvDelamt).HasColumnName("INV_DELAMT");
            entity.Property(e => e.InvDelqty).HasColumnName("INV_DELQTY");
            entity.Property(e => e.InvEndamt).HasColumnName("INV_ENDAMT");
            entity.Property(e => e.InvEndqty).HasColumnName("INV_ENDQTY");
            entity.Property(e => e.InvIsuamt).HasColumnName("INV_ISUAMT");
            entity.Property(e => e.InvIsuqty).HasColumnName("INV_ISUQTY");
            entity.Property(e => e.InvItemcodex)
                .HasColumnType("CHAR(18)")
                .HasColumnName("INV_ITEMCODEX");
            entity.Property(e => e.InvTank).HasColumnName("INV_TANK");
            entity.Property(e => e.InvVaramt).HasColumnName("INV_VARAMT");
            entity.Property(e => e.InvVarqty).HasColumnName("INV_VARQTY");
            entity.Property(e => e.InvWtramt).HasColumnName("INV_WTRAMT");
            entity.Property(e => e.InvWtrqty).HasColumnName("INV_WTRQTY");
            entity.Property(e => e.Sitecode).HasColumnName("SITECODE");
        });

        modelBuilder.Entity<XmlIIfifo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xml_I_IFIFO");

            entity.HasIndex(e => new { e.InvStamp, e.InvPos }, "xml_I_IFIFONDX");

            entity.Property(e => e.Bday).HasColumnName("BDAY");
            entity.Property(e => e.Bmonth).HasColumnName("BMONTH");
            entity.Property(e => e.Byear).HasColumnName("BYEAR");
            entity.Property(e => e.Corpcode).HasColumnName("CORPCODE");
            entity.Property(e => e.InvAccount)
                .HasColumnType("CHAR(10)")
                .HasColumnName("INV_ACCOUNT");
            entity.Property(e => e.InvAmt).HasColumnName("INV_AMT");
            entity.Property(e => e.InvItemcodex)
                .HasColumnType("CHAR(18)")
                .HasColumnName("INV_ITEMCODEX");
            entity.Property(e => e.InvPos).HasColumnName("INV_POS");
            entity.Property(e => e.InvQty).HasColumnName("INV_QTY");
            entity.Property(e => e.InvSource).HasColumnName("INV_SOURCE");
            entity.Property(e => e.InvStamp)
                .HasColumnType("CHAR(17)")
                .HasColumnName("INV_STAMP");
            entity.Property(e => e.InvUsed).HasColumnName("INV_USED");
            entity.Property(e => e.Sitecode).HasColumnName("SITECODE");
        });

        modelBuilder.Entity<XmlIWfifo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xml_I_WFIFO");

            entity.HasIndex(e => new { e.InvStamp, e.InvPos }, "xml_I_WFIFONDX");

            entity.Property(e => e.Bday).HasColumnName("BDAY");
            entity.Property(e => e.Bmonth).HasColumnName("BMONTH");
            entity.Property(e => e.Byear).HasColumnName("BYEAR");
            entity.Property(e => e.Corpcode).HasColumnName("CORPCODE");
            entity.Property(e => e.InvAccount)
                .HasColumnType("CHAR(10)")
                .HasColumnName("INV_ACCOUNT");
            entity.Property(e => e.InvAmt).HasColumnName("INV_AMT");
            entity.Property(e => e.InvItemcodex)
                .HasColumnType("CHAR(18)")
                .HasColumnName("INV_ITEMCODEX");
            entity.Property(e => e.InvPos).HasColumnName("INV_POS");
            entity.Property(e => e.InvQty).HasColumnName("INV_QTY");
            entity.Property(e => e.InvSource).HasColumnName("INV_SOURCE");
            entity.Property(e => e.InvStamp)
                .HasColumnType("CHAR(17)")
                .HasColumnName("INV_STAMP");
            entity.Property(e => e.InvTank).HasColumnName("INV_TANK");
            entity.Property(e => e.InvUsed).HasColumnName("INV_USED");
            entity.Property(e => e.Sitecode).HasColumnName("SITECODE");
        });

        modelBuilder.Entity<XmlIXpldi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xml_I_XPLDI");

            entity.HasIndex(e => new { e.InvSource, e.InvAccount, e.InvTtltype, e.InvItemcodex }, "xml_I_XPLDINDX");

            entity.Property(e => e.Bday).HasColumnName("BDAY");
            entity.Property(e => e.Bmonth).HasColumnName("BMONTH");
            entity.Property(e => e.Byear).HasColumnName("BYEAR");
            entity.Property(e => e.Corpcode).HasColumnName("CORPCODE");
            entity.Property(e => e.InvAccount)
                .HasColumnType("CHAR(10)")
                .HasColumnName("INV_ACCOUNT");
            entity.Property(e => e.InvAmt).HasColumnName("INV_AMT");
            entity.Property(e => e.InvItemcodex)
                .HasColumnType("CHAR(18)")
                .HasColumnName("INV_ITEMCODEX");
            entity.Property(e => e.InvQty).HasColumnName("INV_QTY");
            entity.Property(e => e.InvSource).HasColumnName("INV_SOURCE");
            entity.Property(e => e.InvTtltype).HasColumnName("INV_TTLTYPE");
            entity.Property(e => e.Sitecode).HasColumnName("SITECODE");
        });

        modelBuilder.Entity<XmlIXpldr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xml_I_XPLDR");

            entity.HasIndex(e => new { e.InvSource, e.InvAccount, e.InvTtltype, e.InvItemcodex, e.InvRawmat }, "xml_I_XPLDRNDX");

            entity.Property(e => e.Bday).HasColumnName("BDAY");
            entity.Property(e => e.Bmonth).HasColumnName("BMONTH");
            entity.Property(e => e.Byear).HasColumnName("BYEAR");
            entity.Property(e => e.Corpcode).HasColumnName("CORPCODE");
            entity.Property(e => e.InvAccount)
                .HasColumnType("CHAR(10)")
                .HasColumnName("INV_ACCOUNT");
            entity.Property(e => e.InvAmt).HasColumnName("INV_AMT");
            entity.Property(e => e.InvFifoqty).HasColumnName("INV_FIFOQTY");
            entity.Property(e => e.InvItemcodex)
                .HasColumnType("CHAR(18)")
                .HasColumnName("INV_ITEMCODEX");
            entity.Property(e => e.InvQty).HasColumnName("INV_QTY");
            entity.Property(e => e.InvRawmat)
                .HasColumnType("CHAR(18)")
                .HasColumnName("INV_RAWMAT");
            entity.Property(e => e.InvSource).HasColumnName("INV_SOURCE");
            entity.Property(e => e.InvTtltype).HasColumnName("INV_TTLTYPE");
            entity.Property(e => e.Sitecode).HasColumnName("SITECODE");
        });

        modelBuilder.Entity<XmlSite>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xml_SITE");

            entity.HasIndex(e => new { e.EpoHqcode, e.EpoSitecode }, "xml_SITENDX");

            entity.Property(e => e.EpoBhf)
                .HasColumnType("CHAR(6)")
                .HasColumnName("EPO_BHF");
            entity.Property(e => e.EpoBht)
                .HasColumnType("CHAR(6)")
                .HasColumnName("EPO_BHT");
            entity.Property(e => e.EpoDescription)
                .HasColumnType("CHAR(40)")
                .HasColumnName("EPO_DESCRIPTION");
            entity.Property(e => e.EpoHqcode)
                .HasColumnType("CHAR(10)")
                .HasColumnName("EPO_HQCODE");
            entity.Property(e => e.EpoSitecode)
                .HasColumnType("CHAR(10)")
                .HasColumnName("EPO_SITECODE");
        });

        modelBuilder.Entity<XmlSysUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xml_SYS_USER");

            entity.HasIndex(e => e.EpoCode, "xml_SYS_USERNDX");

            entity.Property(e => e.EpoCode)
                .HasColumnType("CHAR(10)")
                .HasColumnName("EPO_CODE");
            entity.Property(e => e.EpoPassword)
                .HasColumnType("CHAR(10)")
                .HasColumnName("EPO_PASSWORD");
            entity.Property(e => e.EpoSecurity).HasColumnName("EPO_SECURITY");
            entity.Property(e => e.EpoUsername)
                .HasColumnType("CHAR(10)")
                .HasColumnName("EPO_USERNAME");
            entity.Property(e => e.EpoUsertype).HasColumnName("EPO_USERTYPE");
        });

        modelBuilder.Entity<XmlUserinfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xml_USERINFO");

            entity.HasIndex(e => e.UserCode, "xml_USERINFONDX");

            entity.Property(e => e.Email)
                .HasColumnType("CHAR(20)")
                .HasColumnName("EMAIL");
            entity.Property(e => e.Firstname)
                .HasColumnType("CHAR(20)")
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Lastname)
                .HasColumnType("CHAR(20)")
                .HasColumnName("LASTNAME");
            entity.Property(e => e.UserCode)
                .HasColumnType("CHAR(10)")
                .HasColumnName("USER_CODE");
            entity.Property(e => e.Webid)
                .HasColumnType("CHAR(20)")
                .HasColumnName("WEBID");
            entity.Property(e => e.Webpass)
                .HasColumnType("CHAR(20)")
                .HasColumnName("WEBPASS");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
