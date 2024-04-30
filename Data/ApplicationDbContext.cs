using Crud_Sqlite.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_Sqlite.Data
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }
        public virtual DbSet<XFunction> XFunctions { get; set; }
        public virtual DbSet<XItem> XItems { get; set; }
        public virtual DbSet<XVip> XVips { get; set; }
        public virtual DbSet<XCard> XCards { get; set; }
        public virtual DbSet<XAddon> XAddons { get; set; }
        public virtual DbSet<XOffline> XOfflines { get; set; }
        public virtual DbSet<XTicket> XTickets { get; set; }
        public virtual DbSet<Abnormalities> Abnormalities { get; set; }
        public virtual DbSet<xFuelsWithPO> FuelsWithPOs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseSqlite("Data Source=C:\\Crud-Sqlite\\journal.sqlite");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Abnormalities>().HasNoKey();

            modelBuilder.Entity<xFuelsWithPO>();

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}