using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crud_Sqlite.Migrations
{
    /// <inheritdoc />
    public partial class updateFuels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "db_c_addrs");

            migrationBuilder.DropTable(
                name: "db_c_base");

            migrationBuilder.DropTable(
                name: "db_c_card");

            migrationBuilder.DropTable(
                name: "db_c_name");

            migrationBuilder.DropTable(
                name: "db_c_sls");

            migrationBuilder.DropTable(
                name: "db_g_dditm");

            migrationBuilder.DropTable(
                name: "db_g_dept");

            migrationBuilder.DropTable(
                name: "db_g_dptdtl");

            migrationBuilder.DropTable(
                name: "db_i_bcode");

            migrationBuilder.DropTable(
                name: "db_i_bdttl");

            migrationBuilder.DropTable(
                name: "db_i_bom");

            migrationBuilder.DropTable(
                name: "db_i_bomdtl");

            migrationBuilder.DropTable(
                name: "db_i_buom");

            migrationBuilder.DropTable(
                name: "db_i_cond");

            migrationBuilder.DropTable(
                name: "db_i_dir");

            migrationBuilder.DropTable(
                name: "db_i_item");

            migrationBuilder.DropTable(
                name: "db_i_iteml");

            migrationBuilder.DropTable(
                name: "db_i_itmao");

            migrationBuilder.DropTable(
                name: "db_i_iuom");

            migrationBuilder.DropTable(
                name: "db_i_level");

            migrationBuilder.DropTable(
                name: "db_i_levelg");

            migrationBuilder.DropTable(
                name: "db_i_matrix");

            migrationBuilder.DropTable(
                name: "db_i_name");

            migrationBuilder.DropTable(
                name: "db_i_ncond");

            migrationBuilder.DropTable(
                name: "db_i_noun");

            migrationBuilder.DropTable(
                name: "db_i_nozzle");

            migrationBuilder.DropTable(
                name: "db_i_pmtrx");

            migrationBuilder.DropTable(
                name: "db_i_prcsch");

            migrationBuilder.DropTable(
                name: "db_i_price");

            migrationBuilder.DropTable(
                name: "db_i_pump");

            migrationBuilder.DropTable(
                name: "db_i_pumpport");

            migrationBuilder.DropTable(
                name: "db_i_reason");

            migrationBuilder.DropTable(
                name: "db_i_tank");

            migrationBuilder.DropTable(
                name: "db_i_uom");

            migrationBuilder.DropTable(
                name: "db_i_uuom");

            migrationBuilder.DropTable(
                name: "db_master");

            migrationBuilder.DropTable(
                name: "db_p_apiprm");

            migrationBuilder.DropTable(
                name: "db_p_apiprm2");

            migrationBuilder.DropTable(
                name: "db_p_button");

            migrationBuilder.DropTable(
                name: "db_p_curr");

            migrationBuilder.DropTable(
                name: "db_p_error");

            migrationBuilder.DropTable(
                name: "db_p_form");

            migrationBuilder.DropTable(
                name: "db_p_guide");

            migrationBuilder.DropTable(
                name: "db_p_hq");

            migrationBuilder.DropTable(
                name: "db_p_hrlyd");

            migrationBuilder.DropTable(
                name: "db_p_hrlyg");

            migrationBuilder.DropTable(
                name: "db_p_itemp");

            migrationBuilder.DropTable(
                name: "db_p_kboard");

            migrationBuilder.DropTable(
                name: "db_p_modi");

            migrationBuilder.DropTable(
                name: "db_p_msg");

            migrationBuilder.DropTable(
                name: "db_p_msg1");

            migrationBuilder.DropTable(
                name: "db_p_msg123");

            migrationBuilder.DropTable(
                name: "db_p_name");

            migrationBuilder.DropTable(
                name: "db_p_nmcode");

            migrationBuilder.DropTable(
                name: "db_p_pmap");

            migrationBuilder.DropTable(
                name: "db_p_promo");

            migrationBuilder.DropTable(
                name: "db_p_promod");

            migrationBuilder.DropTable(
                name: "db_p_promog");

            migrationBuilder.DropTable(
                name: "db_P_PST");

            migrationBuilder.DropTable(
                name: "db_p_sdef");

            migrationBuilder.DropTable(
                name: "db_p_site");

            migrationBuilder.DropTable(
                name: "db_p_siteq");

            migrationBuilder.DropTable(
                name: "db_p_smap");

            migrationBuilder.DropTable(
                name: "db_p_task");

            migrationBuilder.DropTable(
                name: "db_p_text");

            migrationBuilder.DropTable(
                name: "db_p_text_test");

            migrationBuilder.DropTable(
                name: "db_p_tlink");

            migrationBuilder.DropTable(
                name: "db_p_user");

            migrationBuilder.DropTable(
                name: "db_p_userq");

            migrationBuilder.DropTable(
                name: "db_s_base");

            migrationBuilder.DropTable(
                name: "db_s_custom");

            migrationBuilder.DropTable(
                name: "db_s_dlist");

            migrationBuilder.DropTable(
                name: "db_s_list");

            migrationBuilder.DropTable(
                name: "db_s_period");

            migrationBuilder.DropTable(
                name: "db_s_time");

            migrationBuilder.DropTable(
                name: "xml_B_BUTTON");

            migrationBuilder.DropTable(
                name: "xml_B_FORM");

            migrationBuilder.DropTable(
                name: "xml_B_TASK");

            migrationBuilder.DropTable(
                name: "xml_EMP");

            migrationBuilder.DropTable(
                name: "xml_FVBAL");

            migrationBuilder.DropTable(
                name: "xml_I_COGI");

            migrationBuilder.DropTable(
                name: "xml_I_COGP");

            migrationBuilder.DropTable(
                name: "xml_I_COGT");

            migrationBuilder.DropTable(
                name: "xml_I_IFIFO");

            migrationBuilder.DropTable(
                name: "xml_I_WFIFO");

            migrationBuilder.DropTable(
                name: "xml_I_XPLDI");

            migrationBuilder.DropTable(
                name: "xml_I_XPLDR");

            migrationBuilder.DropTable(
                name: "xml_SITE");

            migrationBuilder.DropTable(
                name: "xml_SYS_USER");

            migrationBuilder.DropTable(
                name: "xml_USERINFO");

            migrationBuilder.DropTable(
                name: "xMODI");

            migrationBuilder.DropPrimaryKey(
                name: "PK_xAddon",
                table: "xAddon");

            migrationBuilder.DropIndex(
                name: "xAddonIDX",
                table: "xAddon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_xOffline",
                table: "xOffline");

            migrationBuilder.DropPrimaryKey(
                name: "PK_xCard",
                table: "xCard");

            migrationBuilder.DropIndex(
                name: "xCardIDX",
                table: "xCard");

            migrationBuilder.DropColumn(
                name: "IsOffline",
                table: "FuelsWithPOs");

            //migrationBuilder.RenameTable(
            //    name: "xAddon",
            //    newName: "XAddon");

            migrationBuilder.RenameTable(
                name: "xOffline",
                newName: "XOfflines");

            migrationBuilder.RenameTable(
                name: "xCard",
                newName: "XCards");

            migrationBuilder.RenameTable(
                name: "db_Backup",
                newName: "DbBackups");

            migrationBuilder.RenameColumn(
                name: "xTid",
                table: "XAddon",
                newName: "XTid");

            migrationBuilder.RenameColumn(
                name: "xSTAMP",
                table: "XAddon",
                newName: "XStamp");

            migrationBuilder.RenameColumn(
                name: "xRATE",
                table: "XAddon",
                newName: "XRate");

            migrationBuilder.RenameColumn(
                name: "xLastUpdate",
                table: "XAddon",
                newName: "XLastUpdate");

            migrationBuilder.RenameColumn(
                name: "xAMOUNTDUE",
                table: "XAddon",
                newName: "XAmountdue");

            migrationBuilder.RenameColumn(
                name: "xACCOUNTCODE",
                table: "XAddon",
                newName: "XAccountcode");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "XAddon",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "xUnitPrice",
                table: "XOfflines",
                newName: "XUnitPrice");

            migrationBuilder.RenameColumn(
                name: "xTotalType",
                table: "XOfflines",
                newName: "XTotalType");

            migrationBuilder.RenameColumn(
                name: "xTankNo",
                table: "XOfflines",
                newName: "XTankNo");

            migrationBuilder.RenameColumn(
                name: "xQuantity",
                table: "XOfflines",
                newName: "XQuantity");

            migrationBuilder.RenameColumn(
                name: "xPumpNo",
                table: "XOfflines",
                newName: "XPumpNo");

            migrationBuilder.RenameColumn(
                name: "xOrigOpenTotal",
                table: "XOfflines",
                newName: "XOrigOpenTotal");

            migrationBuilder.RenameColumn(
                name: "xOpenTotalizer",
                table: "XOfflines",
                newName: "XOpenTotalizer");

            migrationBuilder.RenameColumn(
                name: "xNozzle",
                table: "XOfflines",
                newName: "XNozzle");

            migrationBuilder.RenameColumn(
                name: "xItemName",
                table: "XOfflines",
                newName: "XItemName");

            migrationBuilder.RenameColumn(
                name: "xItemCode",
                table: "XOfflines",
                newName: "XItemCode");

            migrationBuilder.RenameColumn(
                name: "xCloseTotalizer",
                table: "XOfflines",
                newName: "XCloseTotalizer");

            migrationBuilder.RenameColumn(
                name: "xCashierCode",
                table: "XOfflines",
                newName: "XCashierCode");

            migrationBuilder.RenameColumn(
                name: "xCashier",
                table: "XOfflines",
                newName: "XCashier");

            migrationBuilder.RenameColumn(
                name: "xBeforeStamp",
                table: "XOfflines",
                newName: "XBeforeStamp");

            migrationBuilder.RenameColumn(
                name: "xBeforeInvoice",
                table: "XOfflines",
                newName: "XBeforeInvoice");

            migrationBuilder.RenameColumn(
                name: "xBatch",
                table: "XOfflines",
                newName: "XBatch");

            migrationBuilder.RenameColumn(
                name: "xBDate",
                table: "XOfflines",
                newName: "XBdate");

            migrationBuilder.RenameColumn(
                name: "xAmount",
                table: "XOfflines",
                newName: "XAmount");

            migrationBuilder.RenameColumn(
                name: "xAfterStamp",
                table: "XOfflines",
                newName: "XAfterStamp");

            migrationBuilder.RenameColumn(
                name: "xAfterInvoice",
                table: "XOfflines",
                newName: "XAfterInvoice");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "XOfflines",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "xTid",
                table: "XCards",
                newName: "XTid");

            migrationBuilder.RenameColumn(
                name: "xLastUpdate",
                table: "XCards",
                newName: "XLastUpdate");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "XCards",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "xMC_XTYPE",
                table: "XCards",
                newName: "XMcXtype");

            migrationBuilder.RenameColumn(
                name: "xMC_VOLBAL",
                table: "XCards",
                newName: "XMcVolbal");

            migrationBuilder.RenameColumn(
                name: "xMC_VERSION",
                table: "XCards",
                newName: "XMcVersion");

            migrationBuilder.RenameColumn(
                name: "xMC_VALUE",
                table: "XCards",
                newName: "XMcValue");

            migrationBuilder.RenameColumn(
                name: "xMC_SITECODE",
                table: "XCards",
                newName: "XMcSitecode");

            migrationBuilder.RenameColumn(
                name: "xMC_SERIES",
                table: "XCards",
                newName: "XMcSeries");

            migrationBuilder.RenameColumn(
                name: "xMC_REQVALUE",
                table: "XCards",
                newName: "XMcReqvalue");

            migrationBuilder.RenameColumn(
                name: "xMC_PXTYPE",
                table: "XCards",
                newName: "XMcPxtype");

            migrationBuilder.RenameColumn(
                name: "xMC_PVALUE",
                table: "XCards",
                newName: "XMcPvalue");

            migrationBuilder.RenameColumn(
                name: "xMC_PUMP",
                table: "XCards",
                newName: "XMcPump");

            migrationBuilder.RenameColumn(
                name: "xMC_PSITECODE",
                table: "XCards",
                newName: "XMcPsitecode");

            migrationBuilder.RenameColumn(
                name: "xMC_PDATETIME",
                table: "XCards",
                newName: "XMcPdatetime");

            migrationBuilder.RenameColumn(
                name: "xMC_LIMIT",
                table: "XCards",
                newName: "XMcLimit");

            migrationBuilder.RenameColumn(
                name: "xMC_FLAG",
                table: "XCards",
                newName: "XMcFlag");

            migrationBuilder.RenameColumn(
                name: "xMC_EXPIRE",
                table: "XCards",
                newName: "XMcExpire");

            migrationBuilder.RenameColumn(
                name: "xMC_DAYLIMIT",
                table: "XCards",
                newName: "XMcDaylimit");

            migrationBuilder.RenameColumn(
                name: "xMC_DATETIME",
                table: "XCards",
                newName: "XMcDatetime");

            migrationBuilder.RenameColumn(
                name: "xMC_CORPCODE",
                table: "XCards",
                newName: "XMcCorpcode");

            migrationBuilder.RenameColumn(
                name: "xMC_CARDNO",
                table: "XCards",
                newName: "XMcCardno");

            migrationBuilder.RenameColumn(
                name: "xMC_CARDNAME",
                table: "XCards",
                newName: "XMcCardname");

            migrationBuilder.RenameColumn(
                name: "xMC_AMTBAL",
                table: "XCards",
                newName: "XMcAmtbal");

            migrationBuilder.RenameColumn(
                name: "xMC_ACCOUNT",
                table: "XCards",
                newName: "XMcAccount");

            migrationBuilder.RenameColumn(
                name: "POS_WIDTH",
                table: "DbBackups",
                newName: "PosWidth");

            migrationBuilder.RenameColumn(
                name: "POS_TOP",
                table: "DbBackups",
                newName: "PosTop");

            migrationBuilder.RenameColumn(
                name: "POS_TEXT",
                table: "DbBackups",
                newName: "PosText");

            migrationBuilder.RenameColumn(
                name: "POS_TASKCODE",
                table: "DbBackups",
                newName: "PosTaskcode");

            migrationBuilder.RenameColumn(
                name: "POS_SFCODE",
                table: "DbBackups",
                newName: "PosSfcode");

            migrationBuilder.RenameColumn(
                name: "POS_SECURITY",
                table: "DbBackups",
                newName: "PosSecurity");

            migrationBuilder.RenameColumn(
                name: "POS_LEFT",
                table: "DbBackups",
                newName: "PosLeft");

            migrationBuilder.RenameColumn(
                name: "POS_HEIGHT",
                table: "DbBackups",
                newName: "PosHeight");

            migrationBuilder.RenameColumn(
                name: "POS_FNTSTYLE",
                table: "DbBackups",
                newName: "PosFntstyle");

            migrationBuilder.RenameColumn(
                name: "POS_FNTSIZE",
                table: "DbBackups",
                newName: "PosFntsize");

            migrationBuilder.RenameColumn(
                name: "POS_FNTNAME",
                table: "DbBackups",
                newName: "PosFntname");

            migrationBuilder.RenameColumn(
                name: "POS_FNTCOLOR",
                table: "DbBackups",
                newName: "PosFntcolor");

            migrationBuilder.RenameColumn(
                name: "POS_FLAG",
                table: "DbBackups",
                newName: "PosFlag");

            migrationBuilder.RenameColumn(
                name: "POS_FCODE",
                table: "DbBackups",
                newName: "PosFcode");

            migrationBuilder.RenameColumn(
                name: "POS_COLOR",
                table: "DbBackups",
                newName: "PosColor");

            migrationBuilder.RenameColumn(
                name: "POS_CODE",
                table: "DbBackups",
                newName: "PosCode");

            migrationBuilder.RenameColumn(
                name: "POS_BITMAP",
                table: "DbBackups",
                newName: "PosBitmap");

            migrationBuilder.AlterColumn<string>(
                name: "XStamp",
                table: "XAddon",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XRate",
                table: "XAddon",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "XLastUpdate",
                table: "XAddon",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "XAmountdue",
                table: "XAddon",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "DOUBLE",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XAccountcode",
                table: "XAddon",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "XUnitPrice",
                table: "XOfflines",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "DOUBLE",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "XQuantity",
                table: "XOfflines",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "DOUBLE",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "XOrigOpenTotal",
                table: "XOfflines",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "DOUBLE",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "XOpenTotalizer",
                table: "XOfflines",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "DOUBLE",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XItemName",
                table: "XOfflines",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(32)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XItemCode",
                table: "XOfflines",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(16)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "XCloseTotalizer",
                table: "XOfflines",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "DOUBLE",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XCashierCode",
                table: "XOfflines",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XCashier",
                table: "XOfflines",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "XBeforeStamp",
                table: "XOfflines",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "XBdate",
                table: "XOfflines",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "DATETIME",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "XAmount",
                table: "XOfflines",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "DOUBLE",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "XAfterStamp",
                table: "XOfflines",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP\n    xLastUpdate TIMESTAMP",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "XLastUpdate",
                table: "XCards",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XMcXtype",
                table: "XCards",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XMcVolbal",
                table: "XCards",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XMcVersion",
                table: "XCards",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XMcValue",
                table: "XCards",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XMcSitecode",
                table: "XCards",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XMcSeries",
                table: "XCards",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XMcReqvalue",
                table: "XCards",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XMcPxtype",
                table: "XCards",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XMcPvalue",
                table: "XCards",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XMcPump",
                table: "XCards",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XMcPsitecode",
                table: "XCards",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XMcPdatetime",
                table: "XCards",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XMcLimit",
                table: "XCards",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XMcFlag",
                table: "XCards",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XMcExpire",
                table: "XCards",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XMcDaylimit",
                table: "XCards",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XMcDatetime",
                table: "XCards",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XMcCorpcode",
                table: "XCards",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XMcCardno",
                table: "XCards",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XMcCardname",
                table: "XCards",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XMcAmtbal",
                table: "XCards",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "XMcAccount",
                table: "XCards",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PosText",
                table: "DbBackups",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(40)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PosTaskcode",
                table: "DbBackups",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(17)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PosFntname",
                table: "DbBackups",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(31)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PosBitmap",
                table: "DbBackups",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "CHAR(12)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_XAddon",
                table: "XAddon",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_XOfflines",
                table: "XOfflines",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_XCards",
                table: "XCards",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_XAddon",
            //    table: "XAddon");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_XOfflines",
            //    table: "XOfflines");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_XCards",
            //    table: "XCards");

            //migrationBuilder.RenameTable(
            //    name: "XAddon",
            //    newName: "xAddon");

            migrationBuilder.RenameTable(
                name: "XOfflines",
                newName: "xOffline");

            migrationBuilder.RenameTable(
                name: "XCards",
                newName: "xCard");

            migrationBuilder.RenameTable(
                name: "DbBackups",
                newName: "db_Backup");

            migrationBuilder.RenameColumn(
                name: "XTid",
                table: "xAddon",
                newName: "xTid");

            migrationBuilder.RenameColumn(
                name: "XStamp",
                table: "xAddon",
                newName: "xSTAMP");

            migrationBuilder.RenameColumn(
                name: "XRate",
                table: "xAddon",
                newName: "xRATE");

            migrationBuilder.RenameColumn(
                name: "XLastUpdate",
                table: "xAddon",
                newName: "xLastUpdate");

            migrationBuilder.RenameColumn(
                name: "XAmountdue",
                table: "xAddon",
                newName: "xAMOUNTDUE");

            migrationBuilder.RenameColumn(
                name: "XAccountcode",
                table: "xAddon",
                newName: "xACCOUNTCODE");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "xAddon",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "XUnitPrice",
                table: "xOffline",
                newName: "xUnitPrice");

            migrationBuilder.RenameColumn(
                name: "XTotalType",
                table: "xOffline",
                newName: "xTotalType");

            migrationBuilder.RenameColumn(
                name: "XTankNo",
                table: "xOffline",
                newName: "xTankNo");

            migrationBuilder.RenameColumn(
                name: "XQuantity",
                table: "xOffline",
                newName: "xQuantity");

            migrationBuilder.RenameColumn(
                name: "XPumpNo",
                table: "xOffline",
                newName: "xPumpNo");

            migrationBuilder.RenameColumn(
                name: "XOrigOpenTotal",
                table: "xOffline",
                newName: "xOrigOpenTotal");

            migrationBuilder.RenameColumn(
                name: "XOpenTotalizer",
                table: "xOffline",
                newName: "xOpenTotalizer");

            migrationBuilder.RenameColumn(
                name: "XNozzle",
                table: "xOffline",
                newName: "xNozzle");

            migrationBuilder.RenameColumn(
                name: "XItemName",
                table: "xOffline",
                newName: "xItemName");

            migrationBuilder.RenameColumn(
                name: "XItemCode",
                table: "xOffline",
                newName: "xItemCode");

            migrationBuilder.RenameColumn(
                name: "XCloseTotalizer",
                table: "xOffline",
                newName: "xCloseTotalizer");

            migrationBuilder.RenameColumn(
                name: "XCashierCode",
                table: "xOffline",
                newName: "xCashierCode");

            migrationBuilder.RenameColumn(
                name: "XCashier",
                table: "xOffline",
                newName: "xCashier");

            migrationBuilder.RenameColumn(
                name: "XBeforeStamp",
                table: "xOffline",
                newName: "xBeforeStamp");

            migrationBuilder.RenameColumn(
                name: "XBeforeInvoice",
                table: "xOffline",
                newName: "xBeforeInvoice");

            migrationBuilder.RenameColumn(
                name: "XBdate",
                table: "xOffline",
                newName: "xBDate");

            migrationBuilder.RenameColumn(
                name: "XBatch",
                table: "xOffline",
                newName: "xBatch");

            migrationBuilder.RenameColumn(
                name: "XAmount",
                table: "xOffline",
                newName: "xAmount");

            migrationBuilder.RenameColumn(
                name: "XAfterStamp",
                table: "xOffline",
                newName: "xAfterStamp");

            migrationBuilder.RenameColumn(
                name: "XAfterInvoice",
                table: "xOffline",
                newName: "xAfterInvoice");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "xOffline",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "XTid",
                table: "xCard",
                newName: "xTid");

            migrationBuilder.RenameColumn(
                name: "XLastUpdate",
                table: "xCard",
                newName: "xLastUpdate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "xCard",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "XMcXtype",
                table: "xCard",
                newName: "xMC_XTYPE");

            migrationBuilder.RenameColumn(
                name: "XMcVolbal",
                table: "xCard",
                newName: "xMC_VOLBAL");

            migrationBuilder.RenameColumn(
                name: "XMcVersion",
                table: "xCard",
                newName: "xMC_VERSION");

            migrationBuilder.RenameColumn(
                name: "XMcValue",
                table: "xCard",
                newName: "xMC_VALUE");

            migrationBuilder.RenameColumn(
                name: "XMcSitecode",
                table: "xCard",
                newName: "xMC_SITECODE");

            migrationBuilder.RenameColumn(
                name: "XMcSeries",
                table: "xCard",
                newName: "xMC_SERIES");

            migrationBuilder.RenameColumn(
                name: "XMcReqvalue",
                table: "xCard",
                newName: "xMC_REQVALUE");

            migrationBuilder.RenameColumn(
                name: "XMcPxtype",
                table: "xCard",
                newName: "xMC_PXTYPE");

            migrationBuilder.RenameColumn(
                name: "XMcPvalue",
                table: "xCard",
                newName: "xMC_PVALUE");

            migrationBuilder.RenameColumn(
                name: "XMcPump",
                table: "xCard",
                newName: "xMC_PUMP");

            migrationBuilder.RenameColumn(
                name: "XMcPsitecode",
                table: "xCard",
                newName: "xMC_PSITECODE");

            migrationBuilder.RenameColumn(
                name: "XMcPdatetime",
                table: "xCard",
                newName: "xMC_PDATETIME");

            migrationBuilder.RenameColumn(
                name: "XMcLimit",
                table: "xCard",
                newName: "xMC_LIMIT");

            migrationBuilder.RenameColumn(
                name: "XMcFlag",
                table: "xCard",
                newName: "xMC_FLAG");

            migrationBuilder.RenameColumn(
                name: "XMcExpire",
                table: "xCard",
                newName: "xMC_EXPIRE");

            migrationBuilder.RenameColumn(
                name: "XMcDaylimit",
                table: "xCard",
                newName: "xMC_DAYLIMIT");

            migrationBuilder.RenameColumn(
                name: "XMcDatetime",
                table: "xCard",
                newName: "xMC_DATETIME");

            migrationBuilder.RenameColumn(
                name: "XMcCorpcode",
                table: "xCard",
                newName: "xMC_CORPCODE");

            migrationBuilder.RenameColumn(
                name: "XMcCardno",
                table: "xCard",
                newName: "xMC_CARDNO");

            migrationBuilder.RenameColumn(
                name: "XMcCardname",
                table: "xCard",
                newName: "xMC_CARDNAME");

            migrationBuilder.RenameColumn(
                name: "XMcAmtbal",
                table: "xCard",
                newName: "xMC_AMTBAL");

            migrationBuilder.RenameColumn(
                name: "XMcAccount",
                table: "xCard",
                newName: "xMC_ACCOUNT");

            migrationBuilder.RenameColumn(
                name: "PosWidth",
                table: "db_Backup",
                newName: "POS_WIDTH");

            migrationBuilder.RenameColumn(
                name: "PosTop",
                table: "db_Backup",
                newName: "POS_TOP");

            migrationBuilder.RenameColumn(
                name: "PosText",
                table: "db_Backup",
                newName: "POS_TEXT");

            migrationBuilder.RenameColumn(
                name: "PosTaskcode",
                table: "db_Backup",
                newName: "POS_TASKCODE");

            migrationBuilder.RenameColumn(
                name: "PosSfcode",
                table: "db_Backup",
                newName: "POS_SFCODE");

            migrationBuilder.RenameColumn(
                name: "PosSecurity",
                table: "db_Backup",
                newName: "POS_SECURITY");

            migrationBuilder.RenameColumn(
                name: "PosLeft",
                table: "db_Backup",
                newName: "POS_LEFT");

            migrationBuilder.RenameColumn(
                name: "PosHeight",
                table: "db_Backup",
                newName: "POS_HEIGHT");

            migrationBuilder.RenameColumn(
                name: "PosFntstyle",
                table: "db_Backup",
                newName: "POS_FNTSTYLE");

            migrationBuilder.RenameColumn(
                name: "PosFntsize",
                table: "db_Backup",
                newName: "POS_FNTSIZE");

            migrationBuilder.RenameColumn(
                name: "PosFntname",
                table: "db_Backup",
                newName: "POS_FNTNAME");

            migrationBuilder.RenameColumn(
                name: "PosFntcolor",
                table: "db_Backup",
                newName: "POS_FNTCOLOR");

            migrationBuilder.RenameColumn(
                name: "PosFlag",
                table: "db_Backup",
                newName: "POS_FLAG");

            migrationBuilder.RenameColumn(
                name: "PosFcode",
                table: "db_Backup",
                newName: "POS_FCODE");

            migrationBuilder.RenameColumn(
                name: "PosColor",
                table: "db_Backup",
                newName: "POS_COLOR");

            migrationBuilder.RenameColumn(
                name: "PosCode",
                table: "db_Backup",
                newName: "POS_CODE");

            migrationBuilder.RenameColumn(
                name: "PosBitmap",
                table: "db_Backup",
                newName: "POS_BITMAP");

            migrationBuilder.AlterColumn<string>(
                name: "xSTAMP",
                table: "xAddon",
                type: "CHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xRATE",
                table: "xAddon",
                type: "CHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "xLastUpdate",
                table: "xAddon",
                type: "TIMESTAMP",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "xAMOUNTDUE",
                table: "xAddon",
                type: "DOUBLE",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xACCOUNTCODE",
                table: "xAddon",
                type: "CHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            //migrationBuilder.AddColumn<bool>(
            //    name: "IsOffline",
            //    table: "FuelsWithPOs",
            //    type: "INTEGER",
            //    nullable: false,
            //    defaultValue: false);

            migrationBuilder.AlterColumn<double>(
                name: "xUnitPrice",
                table: "xOffline",
                type: "DOUBLE",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "xQuantity",
                table: "xOffline",
                type: "DOUBLE",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "xOrigOpenTotal",
                table: "xOffline",
                type: "DOUBLE",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "xOpenTotalizer",
                table: "xOffline",
                type: "DOUBLE",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xItemName",
                table: "xOffline",
                type: "CHAR(32)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xItemCode",
                table: "xOffline",
                type: "CHAR(16)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "xCloseTotalizer",
                table: "xOffline",
                type: "DOUBLE",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xCashierCode",
                table: "xOffline",
                type: "CHAR(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xCashier",
                table: "xOffline",
                type: "CHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "xBeforeStamp",
                table: "xOffline",
                type: "TIMESTAMP",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "xBDate",
                table: "xOffline",
                type: "DATETIME",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "xAmount",
                table: "xOffline",
                type: "DOUBLE",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "xAfterStamp",
                table: "xOffline",
                type: "TIMESTAMP\n    xLastUpdate TIMESTAMP",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "xLastUpdate",
                table: "xCard",
                type: "TIMESTAMP",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xMC_XTYPE",
                table: "xCard",
                type: "CHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xMC_VOLBAL",
                table: "xCard",
                type: "CHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xMC_VERSION",
                table: "xCard",
                type: "CHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xMC_VALUE",
                table: "xCard",
                type: "CHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xMC_SITECODE",
                table: "xCard",
                type: "CHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xMC_SERIES",
                table: "xCard",
                type: "CHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xMC_REQVALUE",
                table: "xCard",
                type: "CHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xMC_PXTYPE",
                table: "xCard",
                type: "CHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xMC_PVALUE",
                table: "xCard",
                type: "CHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xMC_PUMP",
                table: "xCard",
                type: "CHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xMC_PSITECODE",
                table: "xCard",
                type: "CHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xMC_PDATETIME",
                table: "xCard",
                type: "CHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xMC_LIMIT",
                table: "xCard",
                type: "CHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xMC_FLAG",
                table: "xCard",
                type: "CHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xMC_EXPIRE",
                table: "xCard",
                type: "CHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xMC_DAYLIMIT",
                table: "xCard",
                type: "CHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xMC_DATETIME",
                table: "xCard",
                type: "CHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xMC_CORPCODE",
                table: "xCard",
                type: "CHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xMC_CARDNO",
                table: "xCard",
                type: "CHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xMC_CARDNAME",
                table: "xCard",
                type: "CHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xMC_AMTBAL",
                table: "xCard",
                type: "CHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "xMC_ACCOUNT",
                table: "xCard",
                type: "CHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "POS_TEXT",
                table: "db_Backup",
                type: "CHAR(40)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "POS_TASKCODE",
                table: "db_Backup",
                type: "CHAR(17)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "POS_FNTNAME",
                table: "db_Backup",
                type: "CHAR(31)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "POS_BITMAP",
                table: "db_Backup",
                type: "CHAR(12)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_xAddon",
                table: "xAddon",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_xOffline",
                table: "xOffline",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_xCard",
                table: "xCard",
                column: "id");

            migrationBuilder.CreateTable(
                name: "db_c_addrs",
                columns: table => new
                {
                    VIP_BARIO = table.Column<string>(type: "CHAR(30)", nullable: true),
                    VIP_CITY = table.Column<string>(type: "CHAR(30)", nullable: true),
                    VIP_CODE = table.Column<string>(type: "CHAR(20)", nullable: true),
                    VIP_HIST = table.Column<int>(type: "INTEGER", nullable: true),
                    VIP_HSENO = table.Column<string>(type: "CHAR(10)", nullable: true),
                    VIP_PHONE = table.Column<string>(type: "CHAR(15)", nullable: true),
                    VIP_STREET = table.Column<string>(type: "CHAR(30)", nullable: true),
                    VIP_ZIP = table.Column<string>(type: "CHAR(10)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_c_base",
                columns: table => new
                {
                    VIP_CODE = table.Column<string>(type: "CHAR(20)", nullable: true),
                    VIP_DATEMODI = table.Column<string>(type: "CHAR(8)", nullable: true),
                    VIP_EMPID = table.Column<string>(type: "CHAR(10)", nullable: true),
                    VIP_HIST = table.Column<int>(type: "INTEGER", nullable: true),
                    VIP_PINCODE = table.Column<string>(type: "CHAR(6)", nullable: true),
                    VIP_REASON = table.Column<string>(type: "INTEGER", nullable: true),
                    VIP_SITECODE = table.Column<string>(type: "CHAR(10)", nullable: true),
                    VIP_STATUS = table.Column<string>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_c_card",
                columns: table => new
                {
                    VIP_CARDNO = table.Column<string>(type: "CHAR(16)", nullable: true),
                    VIP_CARDSTS = table.Column<int>(type: "INTEGER", nullable: true),
                    VIP_FLAG = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_c_name",
                columns: table => new
                {
                    VIP_CODE = table.Column<string>(type: "CHAR(20)", nullable: true),
                    VIP_FNAME = table.Column<string>(type: "CHAR(20)", nullable: true),
                    VIP_HIST = table.Column<int>(type: "INTEGER", nullable: true),
                    VIP_LNAME = table.Column<string>(type: "CHAR(20)", nullable: true),
                    VIP_MNAME = table.Column<string>(type: "CHAR(20)", nullable: true),
                    VIP_SALUTE = table.Column<string>(type: "INTEGER", nullable: true),
                    VIP_TIN = table.Column<string>(type: "CHAR(20)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_c_sls",
                columns: table => new
                {
                    VIP_CODE = table.Column<string>(type: "CHAR(20)", nullable: true),
                    VIP_HIST = table.Column<int>(type: "INTEGER", nullable: true),
                    VIP_MVFC = table.Column<double>(type: "REAL", nullable: true),
                    VIP_PCODE = table.Column<string>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_g_dditm",
                columns: table => new
                {
                    DPT_CODE = table.Column<int>(type: "INTEGER", nullable: true),
                    DPT_DATACODE = table.Column<string>(type: "CHAR(18)", nullable: true),
                    DPT_GROUP = table.Column<int>(type: "INTEGER", nullable: true),
                    DPT_TYPE = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_g_dept",
                columns: table => new
                {
                    DPT_CODE = table.Column<int>(type: "INTEGER", nullable: true),
                    DPT_DESCRIPTION = table.Column<string>(type: "CHAR(40)", nullable: true),
                    DPT_TYPE = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_g_dptdtl",
                columns: table => new
                {
                    DPT_CODE = table.Column<int>(type: "INTEGER", nullable: true),
                    DPT_DESCRIPTION = table.Column<string>(type: "CHAR(40)", nullable: true),
                    DPT_GROUP = table.Column<int>(type: "INTEGER", nullable: true),
                    DPT_LEVEL = table.Column<int>(type: "INTEGER", nullable: true),
                    DPT_NODE = table.Column<int>(type: "INTEGER", nullable: true),
                    DPT_TYPE = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_i_bcode",
                columns: table => new
                {
                    INV_BARCODE = table.Column<string>(type: "CHAR(40)", nullable: true),
                    INV_ITEMCODEX = table.Column<string>(type: "CHAR(18)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_i_bdttl",
                columns: table => new
                {
                    INV_CODE = table.Column<string>(type: "CHAR(18)", nullable: true),
                    INV_ITEMCODEX = table.Column<string>(type: "CHAR(18)", nullable: true),
                    INV_TTLTYPE = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_i_bom",
                columns: table => new
                {
                    INV_CODE = table.Column<string>(type: "CHAR(18)", nullable: true),
                    INV_DESCRIPTION = table.Column<string>(type: "CHAR(40)", nullable: true),
                    INV_KIND = table.Column<string>(type: "CHAR(1)", nullable: true),
                    INV_YIELD = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_i_bomdtl",
                columns: table => new
                {
                    INV_CODE = table.Column<string>(type: "CHAR(18)", nullable: true),
                    INV_FLAG = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_ITEMCODEX = table.Column<string>(type: "CHAR(18)", nullable: true),
                    INV_QTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_UOM = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_USAGE = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_i_buom",
                columns: table => new
                {
                    INV_CODE = table.Column<string>(type: "CHAR(10)", nullable: true),
                    INV_FACTOR = table.Column<double>(type: "REAL", nullable: true),
                    INV_ITEMCODEX = table.Column<string>(type: "CHAR(18)", nullable: true),
                    INV_UOM = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_i_cond",
                columns: table => new
                {
                    INV_FLAG = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_GROUP = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_ITEMCODE = table.Column<string>(type: "CHAR(14)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_i_dir",
                columns: table => new
                {
                    INV_DESCRIPTION = table.Column<string>(type: "CHAR(40)", nullable: true),
                    INV_DIR = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_i_item",
                columns: table => new
                {
                    INV_FLAG = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_ITEMCODE = table.Column<string>(type: "CHAR(14)", nullable: true),
                    INV_MODIGRP = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_TYPE = table.Column<string>(type: "CHAR(1)", nullable: true),
                    POS_FORMAT = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_TASKCODE = table.Column<string>(type: "CHAR(17)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_i_iteml",
                columns: table => new
                {
                    INV_GROUP = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_ID = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_ITEMCODE = table.Column<string>(type: "CHAR(14)", nullable: true),
                    INV_SEQUENCE = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_i_itmao",
                columns: table => new
                {
                    INV_GROUP = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_INDEX = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_ITEMCODEX = table.Column<string>(type: "CHAR(18)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_i_iuom",
                columns: table => new
                {
                    INV_FACTOR = table.Column<double>(type: "REAL", nullable: true),
                    INV_ITEMCODEX = table.Column<string>(type: "CHAR(18)", nullable: true),
                    INV_UOM = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_i_level",
                columns: table => new
                {
                    INV_GROUP = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_ID = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_TASKCODE = table.Column<string>(type: "CHAR(17)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_i_levelg",
                columns: table => new
                {
                    INV_DESCRIPTION = table.Column<string>(type: "CHAR(40)", nullable: true),
                    INV_GROUP = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_i_matrix",
                columns: table => new
                {
                    INV_BOM = table.Column<string>(type: "CHAR(18)", nullable: true),
                    INV_DRTABLE = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_FLAG = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_ITEMCODE = table.Column<string>(type: "CHAR(14)", nullable: true),
                    INV_ITEMCODEX = table.Column<string>(type: "CHAR(18)", nullable: true),
                    INV_KIND = table.Column<string>(type: "CHAR(1)", nullable: true),
                    INV_MAX = table.Column<double>(type: "REAL", nullable: true),
                    INV_MIN = table.Column<double>(type: "REAL", nullable: true),
                    INV_STATUS = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_SUG = table.Column<double>(type: "REAL", nullable: true),
                    INV_UOM = table.Column<string>(type: "INTEGER", nullable: true),
                    INV_YIELD = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_i_name",
                columns: table => new
                {
                    INV_NAME = table.Column<string>(type: "CHAR(40)", nullable: true),
                    POS_NAMECODE = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_TASKCODE = table.Column<string>(type: "CHAR(17)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_i_ncond",
                columns: table => new
                {
                    INV_GROUP = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_ITEMCODE = table.Column<string>(type: "CHAR(14)", nullable: true),
                    INV_MAX = table.Column<double>(type: "REAL", nullable: true),
                    INV_MIN = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_i_noun",
                columns: table => new
                {
                    INV_FLAG = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_ITEMCODE = table.Column<string>(type: "CHAR(14)", nullable: true),
                    INV_MAX = table.Column<double>(type: "REAL", nullable: true),
                    INV_MIN = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_i_nozzle",
                columns: table => new
                {
                    INV_NOZZLE = table.Column<string>(type: "INTEGER", nullable: true),
                    INV_PRICECODE = table.Column<string>(type: "INTEGER", nullable: true),
                    INV_PUMP = table.Column<string>(type: "INTEGER", nullable: true),
                    INV_TANK = table.Column<string>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_i_pmtrx",
                columns: table => new
                {
                    INV_GROUP = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_ID = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_ITEMCODEX = table.Column<string>(type: "CHAR(18)", nullable: true),
                    INV_SEQUENCE = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_i_prcsch",
                columns: table => new
                {
                    INV_DESCRIPTION = table.Column<string>(type: "CHAR(40)", nullable: true),
                    INV_FLAG = table.Column<string>(type: "INTEGER", nullable: true),
                    INV_PRICECODE = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_SCHEME = table.Column<string>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_i_price",
                columns: table => new
                {
                    INV_CUT = table.Column<double>(type: "REAL", nullable: true),
                    INV_FLAG = table.Column<string>(type: "INTEGER", nullable: true),
                    INV_ITEMCODEX = table.Column<string>(type: "CHAR(18)", nullable: true),
                    INV_PRICE = table.Column<double>(type: "REAL", nullable: true),
                    INV_PRICECODE = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_i_pump",
                columns: table => new
                {
                    INV_AUTHMODE = table.Column<string>(type: "CHAR(1)", nullable: true),
                    INV_DELMODE = table.Column<string>(type: "INTEGER", nullable: true),
                    INV_PUMP = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_i_pumpport",
                columns: table => new
                {
                    INV_ID = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_PORT = table.Column<string>(type: "CHAR(10)", nullable: true),
                    INV_PROTOCOL = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_PUMP = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_i_reason",
                columns: table => new
                {
                    INV_DESCRIPTION = table.Column<string>(type: "CHAR(40)", nullable: true),
                    INV_REASON = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_i_tank",
                columns: table => new
                {
                    INV_CAP = table.Column<double>(type: "REAL", nullable: true),
                    INV_ITEMCODEX = table.Column<string>(type: "CHAR(18)", nullable: true),
                    INV_MAX = table.Column<double>(type: "REAL", nullable: true),
                    INV_MIN = table.Column<double>(type: "REAL", nullable: true),
                    INV_SUG = table.Column<double>(type: "REAL", nullable: true),
                    INV_TANK = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_WETID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_i_uom",
                columns: table => new
                {
                    INV_CODE = table.Column<string>(type: "INTEGER", nullable: true),
                    INV_NAME = table.Column<string>(type: "CHAR(10)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_i_uuom",
                columns: table => new
                {
                    INV_FACTOR = table.Column<double>(type: "REAL", nullable: true),
                    INV_ITEMCODEX = table.Column<string>(type: "CHAR(18)", nullable: true),
                    INV_UOM = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_master",
                columns: table => new
                {
                    BARCODE = table.Column<string>(type: "CHAR(40)", nullable: true),
                    CODE = table.Column<string>(type: "CHAR(14)", nullable: true),
                    COST = table.Column<double>(type: "REAL", nullable: true),
                    GROUP = table.Column<int>(type: "INTEGER", nullable: true),
                    NAME = table.Column<string>(type: "CHAR(40)", nullable: true),
                    PRICE = table.Column<double>(type: "REAL", nullable: true),
                    QTY = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_apiprm",
                columns: table => new
                {
                    POS_ACCOUNT = table.Column<string>(type: "CHAR(10)", nullable: true),
                    POS_APIID = table.Column<string>(type: "INTEGER", nullable: true),
                    POS_BYTE1 = table.Column<string>(type: "CHAR(18)", nullable: true),
                    POS_BYTE2 = table.Column<string>(type: "CHAR(18)", nullable: true),
                    POS_DWORD1 = table.Column<string>(type: "INTEGER", nullable: true),
                    POS_DWORD2 = table.Column<string>(type: "INTEGER", nullable: true),
                    POS_FLAG = table.Column<string>(type: "INTEGER", nullable: true),
                    POS_MONEY1 = table.Column<double>(type: "REAL", nullable: true),
                    POS_MONEY2 = table.Column<double>(type: "REAL", nullable: true),
                    POS_REAL1 = table.Column<double>(type: "REAL", nullable: true),
                    POS_REAL2 = table.Column<double>(type: "REAL", nullable: true),
                    POS_TASKCODE = table.Column<string>(type: "CHAR(17)", nullable: true),
                    POS_WORD1 = table.Column<string>(type: "INTEGER", nullable: true),
                    POS_WORD2 = table.Column<string>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_apiprm2",
                columns: table => new
                {
                    POS_ACCOUNT = table.Column<string>(type: "CHAR(10)", nullable: true),
                    POS_APIID = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_BYTE1 = table.Column<string>(type: "CHAR(18)", nullable: true),
                    POS_BYTE2 = table.Column<string>(type: "CHAR(18)", nullable: true),
                    POS_DWORD1 = table.Column<string>(type: "INTEGER", nullable: true),
                    POS_DWORD2 = table.Column<string>(type: "INTEGER", nullable: true),
                    POS_FLAG = table.Column<string>(type: "INTEGER", nullable: true),
                    POS_MONEY1 = table.Column<double>(type: "REAL", nullable: true),
                    POS_MONEY2 = table.Column<double>(type: "REAL", nullable: true),
                    POS_REAL1 = table.Column<double>(type: "REAL", nullable: true),
                    POS_REAL2 = table.Column<double>(type: "REAL", nullable: true),
                    POS_TASKCODE = table.Column<string>(type: "CHAR(17)", nullable: true),
                    POS_WORD1 = table.Column<string>(type: "INTEGER", nullable: true),
                    POS_WORD2 = table.Column<string>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_button",
                columns: table => new
                {
                    POS_BITMAP = table.Column<string>(type: "CHAR(12)", nullable: true),
                    POS_CODE = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_COLOR = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_FCODE = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_FLAG = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_FNTCOLOR = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_FNTNAME = table.Column<string>(type: "CHAR(31)", nullable: true),
                    POS_FNTSIZE = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_FNTSTYLE = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_HEIGHT = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_LEFT = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_SECURITY = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_SFCODE = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_TASKCODE = table.Column<string>(type: "CHAR(17)", nullable: true),
                    POS_TEXT = table.Column<string>(type: "CHAR(40)", nullable: true),
                    POS_TOP = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_WIDTH = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_curr",
                columns: table => new
                {
                    POS_CODE = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_RATE = table.Column<double>(type: "REAL", nullable: true),
                    POS_SYM = table.Column<string>(type: "CHAR(3)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_error",
                columns: table => new
                {
                    POS_CODE = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_MESSAGE = table.Column<string>(type: "CHAR(250)", nullable: true),
                    POS_NAMECODE = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_SHORTMSG = table.Column<string>(type: "CHAR(40)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_form",
                columns: table => new
                {
                    POS_BITMAP = table.Column<string>(type: "CHAR(12)", nullable: true),
                    POS_CODE = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_COLOR = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_HEIGHT = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_LEFT = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_NAME = table.Column<string>(type: "CHAR(40)", nullable: true),
                    POS_TOP = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_TYPE = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_WIDTH = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_guide",
                columns: table => new
                {
                    POS_CODE = table.Column<string>(type: "INTEGER", nullable: true),
                    POS_MESSAGE = table.Column<string>(type: "CHAR(250)", nullable: true),
                    POS_NAMECODE = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_SHORTMSG = table.Column<string>(type: "CHAR(40)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_hq",
                columns: table => new
                {
                    POS_HQADDR = table.Column<string>(type: "CHAR(40)", nullable: true),
                    POS_HQCODE = table.Column<string>(type: "CHAR(10)", nullable: true),
                    POS_HQNAME = table.Column<string>(type: "CHAR(60)", nullable: true),
                    POS_PHONE = table.Column<string>(type: "CHAR(15)", nullable: true),
                    POS_TIN = table.Column<string>(type: "CHAR(40)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_hrlyd",
                columns: table => new
                {
                    POS_CODE = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_DESCRIPTION = table.Column<string>(type: "CHAR(40)", nullable: true),
                    POS_FROM = table.Column<string>(type: "CHAR(4)", nullable: true),
                    POS_SEQUENCE = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_TO = table.Column<string>(type: "CHAR(4)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_hrlyg",
                columns: table => new
                {
                    POS_CODE = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_DESCRIPTION = table.Column<string>(type: "CHAR(40)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_itemp",
                columns: table => new
                {
                    INV_ITEMCODEX = table.Column<string>(type: "CHAR(18)", nullable: true),
                    POS_GROUP = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_INDEX = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_kboard",
                columns: table => new
                {
                    POS_FCODE = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_FLAG = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_KEY = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_SECURITY = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_SFCODE = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_SHIFT = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_TASKCODE = table.Column<string>(type: "CHAR(17)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_modi",
                columns: table => new
                {
                    POS_FLAG = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_GROUP = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_SUBGROUP = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_TASKCODE = table.Column<string>(type: "CHAR(17)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_msg",
                columns: table => new
                {
                    POS_CODE = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_MESSAGE = table.Column<string>(type: "CHAR(250)", nullable: true),
                    POS_NAMECODE = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_SHORTMSG = table.Column<string>(type: "CHAR(40)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_msg1",
                columns: table => new
                {
                    POS_CODE = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_MESSAGE = table.Column<string>(type: "CHAR(250)", nullable: true),
                    POS_NAMECODE = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_SHORTMSG = table.Column<string>(type: "CHAR(40)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_msg123",
                columns: table => new
                {
                    POS_CODE = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_MESSAGE = table.Column<string>(type: "CHAR(250)", nullable: true),
                    POS_NAMECODE = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_SHORTMSG = table.Column<string>(type: "CHAR(40)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_name",
                columns: table => new
                {
                    POS_NAMECODE = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_TASKCODE = table.Column<string>(type: "CHAR(17)", nullable: true),
                    POS_TASKNAME = table.Column<string>(type: "CHAR(40)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_nmcode",
                columns: table => new
                {
                    POS_NAMECODE = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_NMSCHM = table.Column<string>(type: "CHAR(40)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_pmap",
                columns: table => new
                {
                    POS_HQCODE = table.Column<string>(type: "CHAR(10)", nullable: true),
                    POS_INDEX = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_PSTID = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_SITECODE = table.Column<string>(type: "CHAR(10)", nullable: true),
                    POS_TASKCODE = table.Column<string>(type: "CHAR(17)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_promo",
                columns: table => new
                {
                    DPT_CODE = table.Column<int>(type: "INTEGER", nullable: true),
                    DPT_GROUP = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_ITEMCODEX = table.Column<string>(type: "CHAR(18)", nullable: true),
                    POS_ACCOUNT = table.Column<string>(type: "CHAR(10)", nullable: true),
                    POS_AMT = table.Column<double>(type: "REAL", nullable: true),
                    POS_QTY = table.Column<double>(type: "REAL", nullable: true),
                    POS_RATE = table.Column<double>(type: "REAL", nullable: true),
                    POS_TYPE = table.Column<string>(type: "CHAR(1)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_promod",
                columns: table => new
                {
                    POS_GROUP = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_INDEX = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_SEQUENCE = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_promog",
                columns: table => new
                {
                    POS_DESCRIPTION = table.Column<string>(type: "CHAR(40)", nullable: true),
                    POS_GROUP = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_P_PST",
                columns: table => new
                {
                    INV_PRICECODE = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_DEFTASK = table.Column<string>(type: "CHAR(17)", nullable: true),
                    POS_FORM = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_HQCODE = table.Column<string>(type: "CHAR(10)", nullable: true),
                    POS_KIND = table.Column<string>(type: "INTEGER", nullable: true),
                    POS_PSTID = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_PSTNAME = table.Column<string>(type: "CHAR(40)", nullable: true),
                    POS_SERIAL = table.Column<string>(type: "CHAR(40)", nullable: true),
                    POS_SITECODE = table.Column<string>(type: "CHAR(10)", nullable: true),
                    POS_TASK0006 = table.Column<string>(type: "CHAR(17)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_sdef",
                columns: table => new
                {
                    POS_GROUP = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_HQCODE = table.Column<string>(type: "CHAR(10)", nullable: true),
                    POS_INDEX = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_site",
                columns: table => new
                {
                    POS_BHF = table.Column<string>(type: "CHAR(6)", nullable: true),
                    POS_BHT = table.Column<string>(type: "CHAR(6)", nullable: true),
                    POS_HQCODE = table.Column<string>(type: "CHAR(10)", nullable: true),
                    POS_PHONE = table.Column<string>(type: "CHAR(15)", nullable: true),
                    POS_SITEADDR = table.Column<string>(type: "CHAR(40)", nullable: true),
                    POS_SITECODE = table.Column<string>(type: "CHAR(10)", nullable: true),
                    POS_SITENAME = table.Column<string>(type: "CHAR(40)", nullable: true),
                    POS_SITETIN = table.Column<string>(type: "CHAR(40)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_siteq",
                columns: table => new
                {
                    POS_FRI = table.Column<double>(type: "REAL", nullable: true),
                    POS_HQCODE = table.Column<string>(type: "CHAR(10)", nullable: true),
                    POS_MON = table.Column<double>(type: "REAL", nullable: true),
                    POS_SAT = table.Column<double>(type: "REAL", nullable: true),
                    POS_SITECODE = table.Column<string>(type: "CHAR(10)", nullable: true),
                    POS_SUN = table.Column<double>(type: "REAL", nullable: true),
                    POS_THU = table.Column<double>(type: "REAL", nullable: true),
                    POS_TUE = table.Column<double>(type: "REAL", nullable: true),
                    POS_WED = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_smap",
                columns: table => new
                {
                    POS_HQCODE = table.Column<string>(type: "CHAR(10)", nullable: true),
                    POS_INDEX = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_SITECODE = table.Column<string>(type: "CHAR(10)", nullable: true),
                    POS_TASKCODE = table.Column<string>(type: "CHAR(17)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_task",
                columns: table => new
                {
                    POS_TASKCODE = table.Column<string>(type: "CHAR(17)", nullable: true),
                    POS_TASKTYPE = table.Column<string>(type: "CHAR(1)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_text",
                columns: table => new
                {
                    POS_NAMECODE = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_TEXT = table.Column<string>(type: "CHAR(255)", nullable: true),
                    POS_TEXTCODE = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_text_test",
                columns: table => new
                {
                    POS_NAMECODE = table.Column<string>(type: "INTEGER", nullable: true),
                    POS_TEXT = table.Column<string>(type: "CHAR(255)", nullable: true),
                    POS_TEXTCODE = table.Column<string>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_tlink",
                columns: table => new
                {
                    POS_SEQUENCE = table.Column<string>(type: "INTEGER", nullable: true),
                    POS_TASKCODE = table.Column<string>(type: "CHAR(17)", nullable: true),
                    POS_TASKLINK = table.Column<string>(type: "CHAR(17)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_user",
                columns: table => new
                {
                    POS_EMPID = table.Column<string>(type: "CHAR(10)", nullable: true),
                    POS_PASSWORD = table.Column<string>(type: "CHAR(10)", nullable: true),
                    POS_SECURITY = table.Column<int>(type: "INTEGER", nullable: true),
                    POS_USERNAME = table.Column<string>(type: "CHAR(10)", nullable: true),
                    POS_USERTYPE = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_p_userq",
                columns: table => new
                {
                    POS_CA = table.Column<double>(type: "REAL", nullable: true),
                    POS_CB = table.Column<double>(type: "REAL", nullable: true),
                    POS_CC = table.Column<double>(type: "REAL", nullable: true),
                    POS_EMPID = table.Column<string>(type: "CHAR(10)", nullable: true),
                    POS_FRI = table.Column<double>(type: "REAL", nullable: true),
                    POS_MON = table.Column<double>(type: "REAL", nullable: true),
                    POS_Q1 = table.Column<double>(type: "REAL", nullable: true),
                    POS_Q2 = table.Column<double>(type: "REAL", nullable: true),
                    POS_Q3 = table.Column<double>(type: "REAL", nullable: true),
                    POS_SAT = table.Column<double>(type: "REAL", nullable: true),
                    POS_SUN = table.Column<double>(type: "REAL", nullable: true),
                    POS_THU = table.Column<double>(type: "REAL", nullable: true),
                    POS_TUE = table.Column<double>(type: "REAL", nullable: true),
                    POS_WED = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_s_base",
                columns: table => new
                {
                    CAL_CODE = table.Column<int>(type: "INTEGER", nullable: true),
                    CAL_EDATE = table.Column<string>(type: "CHAR(8)", nullable: true),
                    CAL_FLAG = table.Column<int>(type: "INTEGER", nullable: true),
                    CAL_NAME = table.Column<string>(type: "CHAR(40)", nullable: true),
                    CAL_SDATE = table.Column<string>(type: "CHAR(8)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_s_custom",
                columns: table => new
                {
                    CAL_CODE = table.Column<int>(type: "INTEGER", nullable: true),
                    CAL_FLAG1 = table.Column<int>(type: "INTEGER", nullable: true),
                    CAL_FLAG2 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_s_dlist",
                columns: table => new
                {
                    CAL_CODE = table.Column<int>(type: "INTEGER", nullable: true),
                    CAL_DATE = table.Column<string>(type: "CHAR(8)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_s_list",
                columns: table => new
                {
                    CAL_CODE = table.Column<int>(type: "INTEGER", nullable: true),
                    CAL_CODELIST = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_s_period",
                columns: table => new
                {
                    CAL_CODE = table.Column<int>(type: "INTEGER", nullable: true),
                    CAL_INTERVAL = table.Column<int>(type: "INTEGER", nullable: true),
                    CAL_SCOPE = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "db_s_time",
                columns: table => new
                {
                    CAL_CODE = table.Column<int>(type: "INTEGER", nullable: true),
                    CAL_ETIME = table.Column<string>(type: "CHAR(6)", nullable: true),
                    CAL_STIME = table.Column<string>(type: "CHAR(6)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "xml_B_BUTTON",
                columns: table => new
                {
                    EPO_BITMAP = table.Column<string>(type: "CHAR(12)", nullable: true),
                    EPO_CODE = table.Column<string>(type: "INTEGER", nullable: true),
                    EPO_COLOR = table.Column<string>(type: "INTEGER", nullable: true),
                    EPO_FCODE = table.Column<string>(type: "INTEGER", nullable: true),
                    EPO_FLAG = table.Column<string>(type: "INTEGER", nullable: true),
                    EPO_FNTCOLOR = table.Column<string>(type: "INTEGER", nullable: true),
                    EPO_FNTNAME = table.Column<string>(type: "CHAR(31)", nullable: true),
                    EPO_FNTSIZE = table.Column<string>(type: "INTEGER", nullable: true),
                    EPO_HEIGHT = table.Column<string>(type: "INTEGER", nullable: true),
                    EPO_LEFT = table.Column<string>(type: "INTEGER", nullable: true),
                    EPO_SECURITY = table.Column<string>(type: "INTEGER", nullable: true),
                    EPO_TASKCODE = table.Column<string>(type: "CHAR(17)", nullable: true),
                    EPO_TEXT = table.Column<string>(type: "CHAR(40)", nullable: true),
                    EPO_TOP = table.Column<string>(type: "INTEGER", nullable: true),
                    EPO_WIDTH = table.Column<string>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "xml_B_FORM",
                columns: table => new
                {
                    EPO_BITMAP = table.Column<string>(type: "CHAR(12)", nullable: true),
                    EPO_CODE = table.Column<int>(type: "INTEGER", nullable: true),
                    EPO_COLOR = table.Column<int>(type: "INTEGER", nullable: true),
                    EPO_NAME = table.Column<string>(type: "CHAR(40)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "xml_B_TASK",
                columns: table => new
                {
                    EPO_COMMAND = table.Column<string>(type: "CHAR(40)", nullable: true),
                    EPO_TASKCODE = table.Column<string>(type: "CHAR(17)", nullable: true),
                    EPO_TASKTYPE = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "xml_EMP",
                columns: table => new
                {
                    EPO_BIRTHDATE = table.Column<string>(type: "CHAR(8)", nullable: true),
                    EPO_CODE = table.Column<string>(type: "CHAR(10)", nullable: true),
                    EPO_FLAG = table.Column<string>(type: "TEXT", nullable: true),
                    EPO_FNAME = table.Column<string>(type: "CHAR(20)", nullable: true),
                    EPO_GENDER = table.Column<int>(type: "INTEGER", nullable: true),
                    EPO_LNAME = table.Column<string>(type: "CHAR(20)", nullable: true),
                    EPO_MNAME = table.Column<string>(type: "CHAR(20)", nullable: true),
                    EPO_SALUTE = table.Column<int>(type: "INTEGER", nullable: true),
                    EPO_STATUS = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "xml_FVBAL",
                columns: table => new
                {
                    AMOUNT = table.Column<double>(type: "REAL", nullable: true),
                    CODE = table.Column<string>(type: "CHAR(10)", nullable: true),
                    DESCRIPTION = table.Column<string>(type: "CHAR(20)", nullable: true),
                    LASTUPDATE = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "xml_I_COGI",
                columns: table => new
                {
                    BDAY = table.Column<int>(type: "INTEGER", nullable: true),
                    BMONTH = table.Column<int>(type: "INTEGER", nullable: true),
                    BYEAR = table.Column<int>(type: "INTEGER", nullable: true),
                    CORPCODE = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_ACUADJAMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_ACUADJQTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_ACUBATAMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_ACUBATQTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_ACUBRUAMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_ACUBRUQTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_ACUDELAMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_ACUDELQTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_ACUISUAMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_ACUISUQTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_ACUXFIAMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_ACUXFIQTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_ACUXFOAMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_ACUXFOQTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_ADJAMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_ADJQTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_BATAMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_BATCH = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_BATQTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_BEGAMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_BEGQTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_BRUAMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_BRUQTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_COSTLAST = table.Column<double>(type: "REAL", nullable: true),
                    INV_COSTMA = table.Column<double>(type: "REAL", nullable: true),
                    INV_DELAMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_DELQTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_ENDAMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_ENDQTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_ISUAMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_ISUQTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_ITEMCODEX = table.Column<string>(type: "CHAR(18)", nullable: true),
                    INV_VARAMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_VARQTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_XFIAMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_XFIQTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_XFOAMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_XFOQTY = table.Column<double>(type: "REAL", nullable: true),
                    SITECODE = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "xml_I_COGP",
                columns: table => new
                {
                    BDAY = table.Column<int>(type: "INTEGER", nullable: true),
                    BMONTH = table.Column<int>(type: "INTEGER", nullable: true),
                    BYEAR = table.Column<int>(type: "INTEGER", nullable: true),
                    CORPCODE = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_ISUAMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_ISUQTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_ITEMCODEX = table.Column<string>(type: "CHAR(18)", nullable: true),
                    INV_NOZZLE = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_PUMP = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_TANK = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_TLZCLO = table.Column<double>(type: "REAL", nullable: true),
                    INV_TLZOPE = table.Column<double>(type: "REAL", nullable: true),
                    SITECODE = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "xml_I_COGT",
                columns: table => new
                {
                    BDAY = table.Column<int>(type: "INTEGER", nullable: true),
                    BMONTH = table.Column<int>(type: "INTEGER", nullable: true),
                    BYEAR = table.Column<int>(type: "INTEGER", nullable: true),
                    CORPCODE = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_ACUDELAMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_ACUDELQTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_ACUISUAMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_ACUISUQTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_BATCH = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_BEGAMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_BEGQTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_COSTLAST = table.Column<double>(type: "REAL", nullable: true),
                    INV_COSTMA = table.Column<double>(type: "REAL", nullable: true),
                    INV_DELAMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_DELQTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_ENDAMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_ENDQTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_ISUAMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_ISUQTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_ITEMCODEX = table.Column<string>(type: "CHAR(18)", nullable: true),
                    INV_TANK = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_VARAMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_VARQTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_WTRAMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_WTRQTY = table.Column<double>(type: "REAL", nullable: true),
                    SITECODE = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "xml_I_IFIFO",
                columns: table => new
                {
                    BDAY = table.Column<int>(type: "INTEGER", nullable: true),
                    BMONTH = table.Column<int>(type: "INTEGER", nullable: true),
                    BYEAR = table.Column<int>(type: "INTEGER", nullable: true),
                    CORPCODE = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_ACCOUNT = table.Column<string>(type: "CHAR(10)", nullable: true),
                    INV_AMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_ITEMCODEX = table.Column<string>(type: "CHAR(18)", nullable: true),
                    INV_POS = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_QTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_SOURCE = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_STAMP = table.Column<string>(type: "CHAR(17)", nullable: true),
                    INV_USED = table.Column<double>(type: "REAL", nullable: true),
                    SITECODE = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "xml_I_WFIFO",
                columns: table => new
                {
                    BDAY = table.Column<int>(type: "INTEGER", nullable: true),
                    BMONTH = table.Column<int>(type: "INTEGER", nullable: true),
                    BYEAR = table.Column<int>(type: "INTEGER", nullable: true),
                    CORPCODE = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_ACCOUNT = table.Column<string>(type: "CHAR(10)", nullable: true),
                    INV_AMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_ITEMCODEX = table.Column<string>(type: "CHAR(18)", nullable: true),
                    INV_POS = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_QTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_SOURCE = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_STAMP = table.Column<string>(type: "CHAR(17)", nullable: true),
                    INV_TANK = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_USED = table.Column<double>(type: "REAL", nullable: true),
                    SITECODE = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "xml_I_XPLDI",
                columns: table => new
                {
                    BDAY = table.Column<int>(type: "INTEGER", nullable: true),
                    BMONTH = table.Column<int>(type: "INTEGER", nullable: true),
                    BYEAR = table.Column<int>(type: "INTEGER", nullable: true),
                    CORPCODE = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_ACCOUNT = table.Column<string>(type: "CHAR(10)", nullable: true),
                    INV_AMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_ITEMCODEX = table.Column<string>(type: "CHAR(18)", nullable: true),
                    INV_QTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_SOURCE = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_TTLTYPE = table.Column<int>(type: "INTEGER", nullable: true),
                    SITECODE = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "xml_I_XPLDR",
                columns: table => new
                {
                    BDAY = table.Column<int>(type: "INTEGER", nullable: true),
                    BMONTH = table.Column<int>(type: "INTEGER", nullable: true),
                    BYEAR = table.Column<int>(type: "INTEGER", nullable: true),
                    CORPCODE = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_ACCOUNT = table.Column<string>(type: "CHAR(10)", nullable: true),
                    INV_AMT = table.Column<double>(type: "REAL", nullable: true),
                    INV_FIFOQTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_ITEMCODEX = table.Column<string>(type: "CHAR(18)", nullable: true),
                    INV_QTY = table.Column<double>(type: "REAL", nullable: true),
                    INV_RAWMAT = table.Column<string>(type: "CHAR(18)", nullable: true),
                    INV_SOURCE = table.Column<int>(type: "INTEGER", nullable: true),
                    INV_TTLTYPE = table.Column<int>(type: "INTEGER", nullable: true),
                    SITECODE = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "xml_SITE",
                columns: table => new
                {
                    EPO_BHF = table.Column<string>(type: "CHAR(6)", nullable: true),
                    EPO_BHT = table.Column<string>(type: "CHAR(6)", nullable: true),
                    EPO_DESCRIPTION = table.Column<string>(type: "CHAR(40)", nullable: true),
                    EPO_HQCODE = table.Column<string>(type: "CHAR(10)", nullable: true),
                    EPO_SITECODE = table.Column<string>(type: "CHAR(10)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "xml_SYS_USER",
                columns: table => new
                {
                    EPO_CODE = table.Column<string>(type: "CHAR(10)", nullable: true),
                    EPO_PASSWORD = table.Column<string>(type: "CHAR(10)", nullable: true),
                    EPO_SECURITY = table.Column<int>(type: "INTEGER", nullable: true),
                    EPO_USERNAME = table.Column<string>(type: "CHAR(10)", nullable: true),
                    EPO_USERTYPE = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "xml_USERINFO",
                columns: table => new
                {
                    EMAIL = table.Column<string>(type: "CHAR(20)", nullable: true),
                    FIRSTNAME = table.Column<string>(type: "CHAR(20)", nullable: true),
                    LASTNAME = table.Column<string>(type: "CHAR(20)", nullable: true),
                    USER_CODE = table.Column<string>(type: "CHAR(10)", nullable: true),
                    WEBID = table.Column<string>(type: "CHAR(20)", nullable: true),
                    WEBPASS = table.Column<string>(type: "CHAR(20)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "xMODI",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    xAPIFLAG = table.Column<string>(type: "CHAR(2)", nullable: true),
                    xDESCRIPTION = table.Column<string>(type: "CHAR(32)", nullable: true),
                    xFLAG = table.Column<int>(type: "INTEGER", nullable: true),
                    xFORMAT = table.Column<string>(type: "CHAR(14)", nullable: true),
                    xItemId = table.Column<int>(type: "INTEGER", nullable: true),
                    xLastUpdate = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    xMODGROUP = table.Column<string>(type: "CHAR(20)", nullable: true),
                    xMODSGROUP = table.Column<string>(type: "CHAR(20)", nullable: true),
                    xOWNERITEMCODX = table.Column<string>(type: "CHAR(17)", nullable: true),
                    xOWNERQTY = table.Column<double>(type: "DOUBLE", nullable: true),
                    xOWNERSTAMP = table.Column<string>(type: "CHAR(20)", nullable: true),
                    xQUANTITY = table.Column<double>(type: "DOUBLE", nullable: true),
                    xSTAMP = table.Column<string>(type: "CHAR(20)", nullable: true),
                    xTASKCODE = table.Column<string>(type: "CHAR(20)", nullable: true),
                    xTASKTYPE = table.Column<string>(type: "CHAR(20)", nullable: true),
                    xTid = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_xMODI", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "xAddonIDX",
                table: "xAddon",
                column: "xTid");

            migrationBuilder.CreateIndex(
                name: "xCardIDX",
                table: "xCard",
                column: "xTid");

            migrationBuilder.CreateIndex(
                name: "db_c_addrsNDX",
                table: "db_c_addrs",
                columns: new[] { "VIP_CODE", "VIP_HIST" });

            migrationBuilder.CreateIndex(
                name: "db_c_baseNDX",
                table: "db_c_base",
                columns: new[] { "VIP_CODE", "VIP_HIST" });

            migrationBuilder.CreateIndex(
                name: "db_c_cardNDX",
                table: "db_c_card",
                column: "VIP_CARDNO");

            migrationBuilder.CreateIndex(
                name: "db_c_nameNDX",
                table: "db_c_name",
                columns: new[] { "VIP_CODE", "VIP_HIST" });

            migrationBuilder.CreateIndex(
                name: "db_c_slsNDX",
                table: "db_c_sls",
                columns: new[] { "VIP_CODE", "VIP_HIST" });

            migrationBuilder.CreateIndex(
                name: "db_g_dditmNDX",
                table: "db_g_dditm",
                columns: new[] { "DPT_CODE", "DPT_TYPE", "DPT_GROUP", "DPT_DATACODE" });

            migrationBuilder.CreateIndex(
                name: "db_g_deptNDX",
                table: "db_g_dept",
                columns: new[] { "DPT_CODE", "DPT_TYPE" });

            migrationBuilder.CreateIndex(
                name: "db_g_dptdtlNDX",
                table: "db_g_dptdtl",
                columns: new[] { "DPT_CODE", "DPT_TYPE", "DPT_GROUP" });

            migrationBuilder.CreateIndex(
                name: "db_i_bcodeNDX",
                table: "db_i_bcode",
                columns: new[] { "INV_ITEMCODEX", "INV_BARCODE" });

            migrationBuilder.CreateIndex(
                name: "db_i_bdttlNDX",
                table: "db_i_bdttl",
                columns: new[] { "INV_CODE", "INV_ITEMCODEX", "INV_TTLTYPE" });

            migrationBuilder.CreateIndex(
                name: "db_i_bomNDX",
                table: "db_i_bom",
                column: "INV_CODE");

            migrationBuilder.CreateIndex(
                name: "db_i_bomdtlNDX",
                table: "db_i_bomdtl",
                columns: new[] { "INV_CODE", "INV_ITEMCODEX" });

            migrationBuilder.CreateIndex(
                name: "db_i_buomNDX",
                table: "db_i_buom",
                columns: new[] { "INV_CODE", "INV_ITEMCODEX", "INV_UOM" });

            migrationBuilder.CreateIndex(
                name: "db_i_condNDX",
                table: "db_i_cond",
                column: "INV_ITEMCODE");

            migrationBuilder.CreateIndex(
                name: "db_i_dirNDX",
                table: "db_i_dir",
                column: "INV_DIR");

            migrationBuilder.CreateIndex(
                name: "db_i_itemNDX",
                table: "db_i_item",
                column: "INV_ITEMCODE");

            migrationBuilder.CreateIndex(
                name: "db_i_itemlNDX",
                table: "db_i_iteml",
                columns: new[] { "INV_ITEMCODE", "INV_SEQUENCE" });

            migrationBuilder.CreateIndex(
                name: "db_i_itmaoNDX",
                table: "db_i_itmao",
                columns: new[] { "INV_ITEMCODEX", "INV_INDEX", "INV_GROUP" });

            migrationBuilder.CreateIndex(
                name: "db_i_iuomNDX",
                table: "db_i_iuom",
                columns: new[] { "INV_ITEMCODEX", "INV_UOM" });

            migrationBuilder.CreateIndex(
                name: "db_i_levelNDX",
                table: "db_i_level",
                columns: new[] { "INV_GROUP", "INV_ID" });

            migrationBuilder.CreateIndex(
                name: "db_i_levelgNDX",
                table: "db_i_levelg",
                column: "INV_GROUP");

            migrationBuilder.CreateIndex(
                name: "db_i_matrixNDX",
                table: "db_i_matrix",
                column: "INV_ITEMCODEX");

            migrationBuilder.CreateIndex(
                name: "db_i_nameNDX",
                table: "db_i_name",
                columns: new[] { "POS_TASKCODE", "POS_NAMECODE" });

            migrationBuilder.CreateIndex(
                name: "db_i_ncondNDX",
                table: "db_i_ncond",
                columns: new[] { "INV_ITEMCODE", "INV_GROUP" });

            migrationBuilder.CreateIndex(
                name: "db_i_nounNDX",
                table: "db_i_noun",
                column: "INV_ITEMCODE");

            migrationBuilder.CreateIndex(
                name: "db_i_nozzleNDX",
                table: "db_i_nozzle",
                columns: new[] { "INV_PUMP", "INV_NOZZLE" });

            migrationBuilder.CreateIndex(
                name: "db_i_pmtrxNDX",
                table: "db_i_pmtrx",
                columns: new[] { "INV_ITEMCODEX", "INV_SEQUENCE" });

            migrationBuilder.CreateIndex(
                name: "db_i_prcschNDX",
                table: "db_i_prcsch",
                column: "INV_PRICECODE");

            migrationBuilder.CreateIndex(
                name: "db_i_priceNDX",
                table: "db_i_price",
                columns: new[] { "INV_ITEMCODEX", "INV_PRICECODE" });

            migrationBuilder.CreateIndex(
                name: "db_i_pumpNDX",
                table: "db_i_pump",
                column: "INV_PUMP");

            migrationBuilder.CreateIndex(
                name: "db_i_pumpportNDX",
                table: "db_i_pumpport",
                column: "INV_PUMP");

            migrationBuilder.CreateIndex(
                name: "db_i_reasonNDX",
                table: "db_i_reason",
                column: "INV_REASON");

            migrationBuilder.CreateIndex(
                name: "db_i_tankNDX",
                table: "db_i_tank",
                column: "INV_TANK");

            migrationBuilder.CreateIndex(
                name: "db_i_uomNDX",
                table: "db_i_uom",
                column: "INV_CODE");

            migrationBuilder.CreateIndex(
                name: "db_i_uuomNDX",
                table: "db_i_uuom",
                columns: new[] { "INV_ITEMCODEX", "INV_UOM" });

            migrationBuilder.CreateIndex(
                name: "db_masterNDX",
                table: "db_master",
                column: "CODE");

            migrationBuilder.CreateIndex(
                name: "db_p_apiprmNDX",
                table: "db_p_apiprm",
                column: "POS_TASKCODE");

            migrationBuilder.CreateIndex(
                name: "db_p_apiprm2NDX",
                table: "db_p_apiprm2",
                column: "POS_TASKCODE");

            migrationBuilder.CreateIndex(
                name: "db_p_buttonNDX",
                table: "db_p_button",
                columns: new[] { "POS_CODE", "POS_LEFT", "POS_TOP" });

            migrationBuilder.CreateIndex(
                name: "db_p_currNDX",
                table: "db_p_curr",
                column: "POS_CODE");

            migrationBuilder.CreateIndex(
                name: "db_p_errorNDX",
                table: "db_p_error",
                columns: new[] { "POS_CODE", "POS_NAMECODE" });

            migrationBuilder.CreateIndex(
                name: "db_p_formNDX",
                table: "db_p_form",
                column: "POS_CODE");

            migrationBuilder.CreateIndex(
                name: "db_p_guideNDX",
                table: "db_p_guide",
                columns: new[] { "POS_CODE", "POS_NAMECODE" });

            migrationBuilder.CreateIndex(
                name: "db_p_hqNDX",
                table: "db_p_hq",
                column: "POS_HQCODE");

            migrationBuilder.CreateIndex(
                name: "db_p_hrlydNDX",
                table: "db_p_hrlyd",
                columns: new[] { "POS_CODE", "POS_SEQUENCE" });

            migrationBuilder.CreateIndex(
                name: "db_p_hrlygNDX",
                table: "db_p_hrlyg",
                column: "POS_CODE");

            migrationBuilder.CreateIndex(
                name: "db_p_itempNDX",
                table: "db_p_itemp",
                columns: new[] { "INV_ITEMCODEX", "POS_INDEX", "POS_GROUP" });

            migrationBuilder.CreateIndex(
                name: "db_p_kboardNDX",
                table: "db_p_kboard",
                columns: new[] { "POS_KEY", "POS_SHIFT" });

            migrationBuilder.CreateIndex(
                name: "db_p_modiNDX",
                table: "db_p_modi",
                column: "POS_TASKCODE");

            migrationBuilder.CreateIndex(
                name: "db_p_msgNDX",
                table: "db_p_msg",
                columns: new[] { "POS_CODE", "POS_NAMECODE" });

            migrationBuilder.CreateIndex(
                name: "db_p_msg1NDX",
                table: "db_p_msg1",
                columns: new[] { "POS_CODE", "POS_NAMECODE" });

            migrationBuilder.CreateIndex(
                name: "db_p_msg123NDX",
                table: "db_p_msg123",
                columns: new[] { "POS_CODE", "POS_NAMECODE" });

            migrationBuilder.CreateIndex(
                name: "db_p_nameNDX",
                table: "db_p_name",
                columns: new[] { "POS_TASKCODE", "POS_NAMECODE" });

            migrationBuilder.CreateIndex(
                name: "db_p_nmcodeNDX",
                table: "db_p_nmcode",
                column: "POS_NAMECODE");

            migrationBuilder.CreateIndex(
                name: "db_p_pmapNDX",
                table: "db_p_pmap",
                columns: new[] { "POS_HQCODE", "POS_SITECODE", "POS_PSTID", "POS_INDEX" });

            migrationBuilder.CreateIndex(
                name: "db_p_promoNDX",
                table: "db_p_promo",
                columns: new[] { "POS_ACCOUNT", "POS_TYPE", "INV_ITEMCODEX" });

            migrationBuilder.CreateIndex(
                name: "db_p_promodNDX",
                table: "db_p_promod",
                columns: new[] { "POS_GROUP", "POS_SEQUENCE", "POS_INDEX" });

            migrationBuilder.CreateIndex(
                name: "db_p_promogNDX",
                table: "db_p_promog",
                column: "POS_GROUP");

            migrationBuilder.CreateIndex(
                name: "db_P_PSTNDX",
                table: "db_P_PST",
                columns: new[] { "POS_HQCODE", "POS_SITECODE", "POS_PSTID" });

            migrationBuilder.CreateIndex(
                name: "db_p_sdefNDX",
                table: "db_p_sdef",
                columns: new[] { "POS_HQCODE", "POS_INDEX", "POS_GROUP" });

            migrationBuilder.CreateIndex(
                name: "db_p_siteNDX",
                table: "db_p_site",
                columns: new[] { "POS_HQCODE", "POS_SITECODE" });

            migrationBuilder.CreateIndex(
                name: "db_p_siteqNDX",
                table: "db_p_siteq",
                columns: new[] { "POS_HQCODE", "POS_SITECODE" });

            migrationBuilder.CreateIndex(
                name: "db_p_smapNDX",
                table: "db_p_smap",
                columns: new[] { "POS_HQCODE", "POS_SITECODE", "POS_INDEX" });

            migrationBuilder.CreateIndex(
                name: "db_p_taskNDX",
                table: "db_p_task",
                column: "POS_TASKCODE");

            migrationBuilder.CreateIndex(
                name: "db_p_textNDX",
                table: "db_p_text",
                columns: new[] { "POS_TEXTCODE", "POS_NAMECODE" });

            migrationBuilder.CreateIndex(
                name: "db_p_tlinkNDX",
                table: "db_p_tlink",
                columns: new[] { "POS_TASKCODE", "POS_SEQUENCE" });

            migrationBuilder.CreateIndex(
                name: "db_p_userNDX",
                table: "db_p_user",
                column: "POS_EMPID");

            migrationBuilder.CreateIndex(
                name: "db_p_userqNDX",
                table: "db_p_userq",
                column: "POS_EMPID");

            migrationBuilder.CreateIndex(
                name: "db_s_baseNDX",
                table: "db_s_base",
                column: "CAL_CODE");

            migrationBuilder.CreateIndex(
                name: "db_s_customNDX",
                table: "db_s_custom",
                column: "CAL_CODE");

            migrationBuilder.CreateIndex(
                name: "db_s_dlistNDX",
                table: "db_s_dlist",
                columns: new[] { "CAL_CODE", "CAL_DATE" });

            migrationBuilder.CreateIndex(
                name: "db_s_listNDX",
                table: "db_s_list",
                columns: new[] { "CAL_CODE", "CAL_CODELIST" });

            migrationBuilder.CreateIndex(
                name: "db_s_periodNDX",
                table: "db_s_period",
                column: "CAL_CODE");

            migrationBuilder.CreateIndex(
                name: "db_s_timeNDX",
                table: "db_s_time",
                columns: new[] { "CAL_CODE", "CAL_STIME" });

            migrationBuilder.CreateIndex(
                name: "xml_B_BUTTONNDX",
                table: "xml_B_BUTTON",
                columns: new[] { "EPO_CODE", "EPO_LEFT", "EPO_TOP" });

            migrationBuilder.CreateIndex(
                name: "xml_B_FORMNDX",
                table: "xml_B_FORM",
                column: "EPO_CODE");

            migrationBuilder.CreateIndex(
                name: "xml_B_TASKNDX",
                table: "xml_B_TASK",
                column: "EPO_TASKCODE");

            migrationBuilder.CreateIndex(
                name: "xml_EMPNDX",
                table: "xml_EMP",
                column: "EPO_CODE");

            migrationBuilder.CreateIndex(
                name: "xml_FVBALNDX",
                table: "xml_FVBAL",
                column: "CODE");

            migrationBuilder.CreateIndex(
                name: "xml_I_COGINDX",
                table: "xml_I_COGI",
                column: "INV_ITEMCODEX");

            migrationBuilder.CreateIndex(
                name: "xml_I_COGPNDX",
                table: "xml_I_COGP",
                columns: new[] { "INV_PUMP", "INV_NOZZLE", "INV_TANK", "INV_ITEMCODEX" });

            migrationBuilder.CreateIndex(
                name: "xml_I_COGTNDX",
                table: "xml_I_COGT",
                columns: new[] { "INV_TANK", "INV_ITEMCODEX" });

            migrationBuilder.CreateIndex(
                name: "xml_I_IFIFONDX",
                table: "xml_I_IFIFO",
                columns: new[] { "INV_STAMP", "INV_POS" });

            migrationBuilder.CreateIndex(
                name: "xml_I_WFIFONDX",
                table: "xml_I_WFIFO",
                columns: new[] { "INV_STAMP", "INV_POS" });

            migrationBuilder.CreateIndex(
                name: "xml_I_XPLDINDX",
                table: "xml_I_XPLDI",
                columns: new[] { "INV_SOURCE", "INV_ACCOUNT", "INV_TTLTYPE", "INV_ITEMCODEX" });

            migrationBuilder.CreateIndex(
                name: "xml_I_XPLDRNDX",
                table: "xml_I_XPLDR",
                columns: new[] { "INV_SOURCE", "INV_ACCOUNT", "INV_TTLTYPE", "INV_ITEMCODEX", "INV_RAWMAT" });

            migrationBuilder.CreateIndex(
                name: "xml_SITENDX",
                table: "xml_SITE",
                columns: new[] { "EPO_HQCODE", "EPO_SITECODE" });

            migrationBuilder.CreateIndex(
                name: "xml_SYS_USERNDX",
                table: "xml_SYS_USER",
                column: "EPO_CODE");

            migrationBuilder.CreateIndex(
                name: "xml_USERINFONDX",
                table: "xml_USERINFO",
                column: "USER_CODE");

            migrationBuilder.CreateIndex(
                name: "iModiID",
                table: "xMODI",
                column: "xTid");
        }
    }
}
