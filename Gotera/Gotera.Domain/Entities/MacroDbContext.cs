using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Gotera.Infrastructure.Persistence;

public partial class MacroDbContext : DbContext
{
    public MacroDbContext()
    {
    }

    public MacroDbContext(DbContextOptions<MacroDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Acctautojv> Acctautojvs { get; set; }

    public virtual DbSet<Agreementtype> Agreementtypes { get; set; }

    public virtual DbSet<Allocationcode> Allocationcodes { get; set; }

    public virtual DbSet<Allowancetype> Allowancetypes { get; set; }

    public virtual DbSet<Aspnetrole> Aspnetroles { get; set; }

    public virtual DbSet<Aspnetuser> Aspnetusers { get; set; }

    public virtual DbSet<Aspnetuserrole> Aspnetuserroles { get; set; }

    public virtual DbSet<Billactivity> Billactivities { get; set; }

    public virtual DbSet<Billactivityrecovery> Billactivityrecoveries { get; set; }

    public virtual DbSet<Billactivityrecovery1> Billactivityrecovery1s { get; set; }

    public virtual DbSet<Bondauto> Bondautos { get; set; }

    public virtual DbSet<Budcode> Budcodes { get; set; }

    public virtual DbSet<BudgetPoAccount> BudgetPoAccounts { get; set; }

    public virtual DbSet<Capitalagreement> Capitalagreements { get; set; }

    public virtual DbSet<CfRevenue> CfRevenues { get; set; }

    public virtual DbSet<Cfbank> Cfbanks { get; set; }

    public virtual DbSet<Cfbanktran> Cfbanktrans { get; set; }

    public virtual DbSet<Cfcategory> Cfcategories { get; set; }

    public virtual DbSet<Cfsubcategory> Cfsubcategories { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Cpbackupsheetmain> Cpbackupsheetmains { get; set; }

    public virtual DbSet<Cpbackupsheetsc> Cpbackupsheetscs { get; set; }

    public virtual DbSet<Cpbillgroup> Cpbillgroups { get; set; }

    public virtual DbSet<Cpipcno> Cpipcnos { get; set; }

    public virtual DbSet<Cppayitemsmain> Cppayitemsmains { get; set; }

    public virtual DbSet<Cppayitemssc> Cppayitemsscs { get; set; }

    public virtual DbSet<Cpstation> Cpstations { get; set; }

    public virtual DbSet<Cpuom> Cpuoms { get; set; }

    public virtual DbSet<Dcattachement> Dcattachements { get; set; }

    public virtual DbSet<Dcauto> Dcautos { get; set; }

    public virtual DbSet<Dccontact> Dccontacts { get; set; }

    public virtual DbSet<Dcdoctype> Dcdoctypes { get; set; }

    public virtual DbSet<Dcdocument> Dcdocuments { get; set; }

    public virtual DbSet<Dcfile> Dcfiles { get; set; }

    public virtual DbSet<Dcmail> Dcmails { get; set; }

    public virtual DbSet<Dcmailatt> Dcmailatts { get; set; }

    public virtual DbSet<Dcmailauto> Dcmailautos { get; set; }

    public virtual DbSet<Dcmailsendto> Dcmailsendtos { get; set; }

    public virtual DbSet<Dcsendto> Dcsendtos { get; set; }

    public virtual DbSet<Dcsubdoctype> Dcsubdoctypes { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Employeeloan> Employeeloans { get; set; }

    public virtual DbSet<Employeetimesheet> Employeetimesheets { get; set; }

    public virtual DbSet<Employeetsperiod> Employeetsperiods { get; set; }

    public virtual DbSet<Engautobudget> Engautobudgets { get; set; }

    public virtual DbSet<Engautogrn> Engautogrns { get; set; }

    public virtual DbSet<Engbudget> Engbudgets { get; set; }

    public virtual DbSet<Engbudgetauto> Engbudgetautos { get; set; }

    public virtual DbSet<EngeqTimesheet> EngeqTimesheets { get; set; }

    public virtual DbSet<Engexpense> Engexpenses { get; set; }

    public virtual DbSet<EngfinTimesheet> EngfinTimesheets { get; set; }

    public virtual DbSet<Engmaterial> Engmaterials { get; set; }

    public virtual DbSet<Engpayment> Engpayments { get; set; }

    public virtual DbSet<Engstatus> Engstatuses { get; set; }

    public virtual DbSet<Engstoretran> Engstoretrans { get; set; }

    public virtual DbSet<Engsubcontractor> Engsubcontractors { get; set; }

    public virtual DbSet<Eqauto> Eqautos { get; set; }

    public virtual DbSet<Eqcontract> Eqcontracts { get; set; }

    public virtual DbSet<Eqoutsource> Eqoutsources { get; set; }

    public virtual DbSet<Equipmenttype> Equipmenttypes { get; set; }

    public virtual DbSet<Eqworkshop> Eqworkshops { get; set; }

    public virtual DbSet<Expense> Expenses { get; set; }

    public virtual DbSet<Expenserecovery> Expenserecoveries { get; set; }

    public virtual DbSet<FaAllocation> FaAllocations { get; set; }

    public virtual DbSet<FaCategory> FaCategories { get; set; }

    public virtual DbSet<FaRegistry> FaRegistries { get; set; }

    public virtual DbSet<GlForvendorreport> GlForvendorreports { get; set; }

    public virtual DbSet<Income> Incomes { get; set; }

    public virtual DbSet<Invautosr> Invautosrs { get; set; }

    public virtual DbSet<Invdeliverytran> Invdeliverytrans { get; set; }

    public virtual DbSet<Invdispatch> Invdispatches { get; set; }

    public virtual DbSet<Invpurchaser> Invpurchasers { get; set; }

    public virtual DbSet<Invstoreman> Invstoremen { get; set; }

    public virtual DbSet<Invstoretran> Invstoretrans { get; set; }

    public virtual DbSet<Ledger> Ledgers { get; set; }

    public virtual DbSet<LedgerErpvendor> LedgerErpvendors { get; set; }

    public virtual DbSet<Machineryrentalagreement> Machineryrentalagreements { get; set; }

    public virtual DbSet<Manager> Managers { get; set; }

    public virtual DbSet<Managertype> Managertypes { get; set; }

    public virtual DbSet<Materialinputactivity> Materialinputactivities { get; set; }

    public virtual DbSet<Materialoutputactivity> Materialoutputactivities { get; set; }

    public virtual DbSet<Materialoutputactivityold> Materialoutputactivityolds { get; set; }

    public virtual DbSet<OwnerAgreement> OwnerAgreements { get; set; }

    public virtual DbSet<Paymentfor> Paymentfors { get; set; }

    public virtual DbSet<PeachtreeLedger2011> PeachtreeLedger2011s { get; set; }

    public virtual DbSet<Pension> Pensions { get; set; }

    public virtual DbSet<Propertytype> Propertytypes { get; set; }

    public virtual DbSet<Purchaseagreement> Purchaseagreements { get; set; }

    public virtual DbSet<PvBill> PvBills { get; set; }

    public virtual DbSet<PvPo> PvPos { get; set; }

    public virtual DbSet<QbLedger> QbLedgers { get; set; }

    public virtual DbSet<Realestate> Realestates { get; set; }

    public virtual DbSet<Requestcode> Requestcodes { get; set; }

    public virtual DbSet<Salesagreement> Salesagreements { get; set; }

    public virtual DbSet<Serviceagreement> Serviceagreements { get; set; }

    public virtual DbSet<Sheet1> Sheet1s { get; set; }

    public virtual DbSet<Site> Sites { get; set; }

    public virtual DbSet<Stockitem> Stockitems { get; set; }

    public virtual DbSet<Sysdiagram> Sysdiagrams { get; set; }

    public virtual DbSet<Taxbracket> Taxbrackets { get; set; }

    public virtual DbSet<Tblaccessaccount> Tblaccessaccounts { get; set; }

    public virtual DbSet<Tblaccessaccounts1> Tblaccessaccounts1s { get; set; }

    public virtual DbSet<Tblaccessadmin> Tblaccessadmins { get; set; }

    public virtual DbSet<Tblaccesscontract> Tblaccesscontracts { get; set; }

    public virtual DbSet<Tblaccessdocument> Tblaccessdocuments { get; set; }

    public virtual DbSet<Tblaccessengineering> Tblaccessengineerings { get; set; }

    public virtual DbSet<Tblaccessequipment> Tblaccessequipments { get; set; }

    public virtual DbSet<Tblaccessfinance> Tblaccessfinances { get; set; }

    public virtual DbSet<Tblaccesshrm> Tblaccesshrms { get; set; }

    public virtual DbSet<Tblaccessinventory> Tblaccessinventories { get; set; }

    public virtual DbSet<Tblaccesspayment> Tblaccesspayments { get; set; }

    public virtual DbSet<Tblaccessplanning> Tblaccessplannings { get; set; }

    public virtual DbSet<Tblaccesspm> Tblaccesspms { get; set; }

    public virtual DbSet<Tblaccountbegining> Tblaccountbeginings { get; set; }

    public virtual DbSet<TblaccountsArchive> TblaccountsArchives { get; set; }

    public virtual DbSet<Tblaccountsetup> Tblaccountsetups { get; set; }

    public virtual DbSet<Tblagreement> Tblagreements { get; set; }

    public virtual DbSet<Tblarchiveactivity> Tblarchiveactivities { get; set; }

    public virtual DbSet<Tblautopo> Tblautopos { get; set; }

    public virtual DbSet<Tblautorefreceivable> Tblautorefreceivables { get; set; }

    public virtual DbSet<Tblbankstatementtype> Tblbankstatementtypes { get; set; }

    public virtual DbSet<Tblbanktransfereregistry> Tblbanktransfereregistries { get; set; }

    public virtual DbSet<Tblbond> Tblbonds { get; set; }

    public virtual DbSet<Tblbondtype> Tblbondtypes { get; set; }

    public virtual DbSet<Tblbudgetyear> Tblbudgetyears { get; set; }

    public virtual DbSet<Tblcaniblization> Tblcaniblizations { get; set; }

    public virtual DbSet<Tblcapture> Tblcaptures { get; set; }

    public virtual DbSet<Tblcase> Tblcases { get; set; }

    public virtual DbSet<Tblcat> Tblcats { get; set; }

    public virtual DbSet<Tblcatsub> Tblcatsubs { get; set; }

    public virtual DbSet<Tblchart> Tblcharts { get; set; }

    public virtual DbSet<Tblchart2012> Tblchart2012s { get; set; }

    public virtual DbSet<Tblchart2013> Tblchart2013s { get; set; }

    public virtual DbSet<TblchartPeachtree> TblchartPeachtrees { get; set; }

    public virtual DbSet<Tblcheckregistry> Tblcheckregistries { get; set; }

    public virtual DbSet<Tblclient> Tblclients { get; set; }

    public virtual DbSet<Tblcompany> Tblcompanies { get; set; }

    public virtual DbSet<Tblcondition> Tblconditions { get; set; }

    public virtual DbSet<TblcustomReport> TblcustomReports { get; set; }

    public virtual DbSet<Tbldailyactivity> Tbldailyactivities { get; set; }

    public virtual DbSet<Tbldailyactivityexcel> Tbldailyactivityexcels { get; set; }

    public virtual DbSet<Tbldailyactivityrented> Tbldailyactivityrenteds { get; set; }

    public virtual DbSet<Tbldd> Tbldds { get; set; }

    public virtual DbSet<TbldlDeduction> TbldlDeductions { get; set; }

    public virtual DbSet<TbldlJobtitle> TbldlJobtitles { get; set; }

    public virtual DbSet<TbldlRegistry> TbldlRegistries { get; set; }

    public virtual DbSet<TbldlSection> TbldlSections { get; set; }

    public virtual DbSet<TbldlTimecard> TbldlTimecards { get; set; }

    public virtual DbSet<Tbldoccomment> Tbldoccomments { get; set; }

    public virtual DbSet<Tbldocref> Tbldocrefs { get; set; }

    public virtual DbSet<TbldtDd> TbldtDds { get; set; }

    public virtual DbSet<TbldtMm> TbldtMms { get; set; }

    public virtual DbSet<TbldtYy> TbldtYys { get; set; }

    public virtual DbSet<TbldtYy1> TbldtYy1s { get; set; }

    public virtual DbSet<TblempJob> TblempJobs { get; set; }

    public virtual DbSet<TblempPerdium> TblempPerdia { get; set; }

    public virtual DbSet<TblempPerdiumscale> TblempPerdiumscales { get; set; }

    public virtual DbSet<TblempTimecard> TblempTimecards { get; set; }

    public virtual DbSet<Tblemployee> Tblemployees { get; set; }

    public virtual DbSet<Tblepaymentmode> Tblepaymentmodes { get; set; }

    public virtual DbSet<Tblfrequency> Tblfrequencies { get; set; }

    public virtual DbSet<Tblfuel> Tblfuels { get; set; }

    public virtual DbSet<Tblgovtax> Tblgovtaxes { get; set; }

    public virtual DbSet<Tblgrn> Tblgrns { get; set; }

    public virtual DbSet<Tblinspection> Tblinspections { get; set; }

    public virtual DbSet<Tblitem> Tblitems { get; set; }

    public virtual DbSet<TblitemSubcategory> TblitemSubcategories { get; set; }

    public virtual DbSet<Tblitemcat> Tblitemcats { get; set; }

    public virtual DbSet<Tblitemcategory> Tblitemcategories { get; set; }

    public virtual DbSet<Tblitemclass> Tblitemclasses { get; set; }

    public virtual DbSet<Tblitempart> Tblitemparts { get; set; }

    public virtual DbSet<Tblitemrequest> Tblitemrequests { get; set; }

    public virtual DbSet<Tblitemrequestdetail> Tblitemrequestdetails { get; set; }

    public virtual DbSet<Tblmaintenance> Tblmaintenances { get; set; }

    public virtual DbSet<Tblmanufacturer> Tblmanufacturers { get; set; }

    public virtual DbSet<Tblmrp> Tblmrps { get; set; }

    public virtual DbSet<Tblmunit> Tblmunits { get; set; }

    public virtual DbSet<Tbloperator> Tbloperators { get; set; }

    public virtual DbSet<Tblothrsrate> Tblothrsrates { get; set; }

    public virtual DbSet<Tbloutsource> Tbloutsources { get; set; }

    public virtual DbSet<Tblownership> Tblownerships { get; set; }

    public virtual DbSet<Tblpart> Tblparts { get; set; }

    public virtual DbSet<Tblpaymenttype> Tblpaymenttypes { get; set; }

    public virtual DbSet<Tblpayrollcontrol> Tblpayrollcontrols { get; set; }

    public virtual DbSet<Tblpayrolljournalsetup> Tblpayrolljournalsetups { get; set; }

    public virtual DbSet<TblpeachtreeLedgerArchive> TblpeachtreeLedgerArchives { get; set; }

    public virtual DbSet<TblplateNo> TblplateNos { get; set; }

    public virtual DbSet<TblpmCode> TblpmCodes { get; set; }

    public virtual DbSet<Tblproblem> Tblproblems { get; set; }

    public virtual DbSet<Tblproblemproposed> Tblproblemproposeds { get; set; }

    public virtual DbSet<Tblproject> Tblprojects { get; set; }

    public virtual DbSet<Tblpurchass> Tblpurchasses { get; set; }

    public virtual DbSet<Tblpurque> Tblpurques { get; set; }

    public virtual DbSet<TblpvReq> TblpvReqs { get; set; }

    public virtual DbSet<Tblquotation> Tblquotations { get; set; }

    public virtual DbSet<TblquotationApproval> TblquotationApprovals { get; set; }

    public virtual DbSet<Tblrate> Tblrates { get; set; }

    public virtual DbSet<TblreasonDown> TblreasonDowns { get; set; }

    public virtual DbSet<TblreasonIdle> TblreasonIdles { get; set; }

    public virtual DbSet<Tblrecovery> Tblrecoveries { get; set; }

    public virtual DbSet<Tblrecurringexpense> Tblrecurringexpenses { get; set; }

    public virtual DbSet<TblregistryOwned> TblregistryOwneds { get; set; }

    public virtual DbSet<Tblrentalaccountsetup> Tblrentalaccountsetups { get; set; }

    public virtual DbSet<Tblschedule> Tblschedules { get; set; }

    public virtual DbSet<Tblsiv> Tblsivs { get; set; }

    public virtual DbSet<Tblsivdetail> Tblsivdetails { get; set; }

    public virtual DbSet<Tblstartdate> Tblstartdates { get; set; }

    public virtual DbSet<Tblstatus> Tblstatuses { get; set; }

    public virtual DbSet<Tblstore> Tblstores { get; set; }

    public virtual DbSet<Tblstoreass> Tblstoreasses { get; set; }

    public virtual DbSet<Tbltechnician> Tbltechnicians { get; set; }

    public virtual DbSet<TbltechnicianAssignment> TbltechnicianAssignments { get; set; }

    public virtual DbSet<Tbltool> Tbltools { get; set; }

    public virtual DbSet<Tbltsjournalsetup> Tbltsjournalsetups { get; set; }

    public virtual DbSet<Tbluser> Tblusers { get; set; }

    public virtual DbSet<Tbluserprovilege> Tbluserprovileges { get; set; }

    public virtual DbSet<Tblvendor> Tblvendors { get; set; }

    public virtual DbSet<Tblvendorcreditregistry> Tblvendorcreditregistries { get; set; }

    public virtual DbSet<Tblzoholedger> Tblzoholedgers { get; set; }

    public virtual DbSet<Tempchartoldnew> Tempchartoldnews { get; set; }

    public virtual DbSet<Temppv> Temppvs { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    public virtual DbSet<Vehicleactivity> Vehicleactivities { get; set; }

    public virtual DbSet<Vehiclerentalagreement> Vehiclerentalagreements { get; set; }

    public virtual DbSet<Vehicletransportactivity> Vehicletransportactivities { get; set; }

    public virtual DbSet<Vehicletransportagreement> Vehicletransportagreements { get; set; }

    public virtual DbSet<Xx> Xxes { get; set; }

    public virtual DbSet<ZohoErpVendor> ZohoErpVendors { get; set; }

    public virtual DbSet<ZohoLedger> ZohoLedgers { get; set; }

    public virtual DbSet<Zoholedger1> Zoholedgers1 { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;User Id=postgres;Password=postgres;Pooling=false;Database=MacroDB");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Acctautojv>(entity =>
        {
            entity.HasKey(e => e.Autono).HasName("pk_acctautojv");

            entity.ToTable("acctautojv");

            entity.Property(e => e.Autono).HasColumnName("autono");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Trial265)
                .HasMaxLength(1)
                .HasColumnName("trial265");
        });

        modelBuilder.Entity<Agreementtype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_agreementtype");

            entity.ToTable("agreementtype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Trial268)
                .HasMaxLength(1)
                .HasColumnName("trial268");
        });

        modelBuilder.Entity<Allocationcode>(entity =>
        {
            entity.HasKey(e => e.Allocationid).HasName("pk_allocationcode");

            entity.ToTable("allocationcode");

            entity.Property(e => e.Allocationid)
                .ValueGeneratedNever()
                .HasColumnName("allocationid");
            entity.Property(e => e.AllocationDesc)
                .HasMaxLength(100)
                .HasColumnName("allocation_desc");
            entity.Property(e => e.Trial268)
                .HasMaxLength(1)
                .HasColumnName("trial268");
        });

        modelBuilder.Entity<Allowancetype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_allowancetype");

            entity.ToTable("allowancetype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.Isactive)
                .IsRequired()
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Trial271)
                .HasMaxLength(1)
                .HasColumnName("trial271");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
        });

        modelBuilder.Entity<Aspnetrole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_aspnetroles");

            entity.ToTable("aspnetroles");

            entity.Property(e => e.Id)
                .HasMaxLength(128)
                .HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(256)
                .HasColumnName("name");
            entity.Property(e => e.Trial271)
                .HasMaxLength(1)
                .HasColumnName("trial271");
        });

        modelBuilder.Entity<Aspnetuser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_aspnetusers");

            entity.ToTable("aspnetusers");

            entity.Property(e => e.Id)
                .HasMaxLength(128)
                .HasColumnName("id");
            entity.Property(e => e.Approvedby).HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Canseeactivitytracking).HasColumnName("canseeactivitytracking");
            entity.Property(e => e.Canseearchive).HasColumnName("canseearchive");
            entity.Property(e => e.Canseebankreport).HasColumnName("canseebankreport");
            entity.Property(e => e.Canseebillactivity).HasColumnName("canseebillactivity");
            entity.Property(e => e.Canseebillarchive).HasColumnName("canseebillarchive");
            entity.Property(e => e.Canseebillreport).HasColumnName("canseebillreport");
            entity.Property(e => e.Canseeclientreport).HasColumnName("canseeclientreport");
            entity.Property(e => e.Canseecollectionactivity).HasColumnName("canseecollectionactivity");
            entity.Property(e => e.Canseecollectionarchive).HasColumnName("canseecollectionarchive");
            entity.Property(e => e.Canseecollectionreport).HasColumnName("canseecollectionreport");
            entity.Property(e => e.Canseedataentry).HasColumnName("canseedataentry");
            entity.Property(e => e.Canseedisbursmentactivity).HasColumnName("canseedisbursmentactivity");
            entity.Property(e => e.Canseedisbursmentarchive).HasColumnName("canseedisbursmentarchive");
            entity.Property(e => e.Canseedisbursmentreport).HasColumnName("canseedisbursmentreport");
            entity.Property(e => e.Canseefuelinputactivity).HasColumnName("canseefuelinputactivity");
            entity.Property(e => e.Canseefuelinputarchive).HasColumnName("canseefuelinputarchive");
            entity.Property(e => e.Canseefueloutputactivity).HasColumnName("canseefueloutputactivity");
            entity.Property(e => e.Canseefueloutputarchive).HasColumnName("canseefueloutputarchive");
            entity.Property(e => e.Canseefuelreport).HasColumnName("canseefuelreport");
            entity.Property(e => e.Canseemachineryactivity).HasColumnName("canseemachineryactivity");
            entity.Property(e => e.Canseemachineryarchive).HasColumnName("canseemachineryarchive");
            entity.Property(e => e.Canseemachineryreport).HasColumnName("canseemachineryreport");
            entity.Property(e => e.Canseemanage).HasColumnName("canseemanage");
            entity.Property(e => e.Canseemanageaccount).HasColumnName("canseemanageaccount");
            entity.Property(e => e.Canseemanageagreement).HasColumnName("canseemanageagreement");
            entity.Property(e => e.Canseemanageallowancetype).HasColumnName("canseemanageallowancetype");
            entity.Property(e => e.Canseemanagebank).HasColumnName("canseemanagebank");
            entity.Property(e => e.Canseemanagecapitalagreement).HasColumnName("canseemanagecapitalagreement");
            entity.Property(e => e.Canseemanageemployee).HasColumnName("canseemanageemployee");
            entity.Property(e => e.Canseemanageemployeeloan).HasColumnName("canseemanageemployeeloan");
            entity.Property(e => e.Canseemanageequipmenttype).HasColumnName("canseemanageequipmenttype");
            entity.Property(e => e.Canseemanagefinance).HasColumnName("canseemanagefinance");
            entity.Property(e => e.Canseemanagelocality).HasColumnName("canseemanagelocality");
            entity.Property(e => e.Canseemanagemachinery).HasColumnName("canseemanagemachinery");
            entity.Property(e => e.Canseemanagemachineryagreement).HasColumnName("canseemanagemachineryagreement");
            entity.Property(e => e.Canseemanagemanager).HasColumnName("canseemanagemanager");
            entity.Property(e => e.Canseemanagemanagertype).HasColumnName("canseemanagemanagertype");
            entity.Property(e => e.Canseemanagematerialtype).HasColumnName("canseemanagematerialtype");
            entity.Property(e => e.Canseemanagepension).HasColumnName("canseemanagepension");
            entity.Property(e => e.Canseemanagepersonnel).HasColumnName("canseemanagepersonnel");
            entity.Property(e => e.Canseemanageproject).HasColumnName("canseemanageproject");
            entity.Property(e => e.Canseemanageproperty).HasColumnName("canseemanageproperty");
            entity.Property(e => e.Canseemanagerealestate).HasColumnName("canseemanagerealestate");
            entity.Property(e => e.Canseemanagesalesagreement).HasColumnName("canseemanagesalesagreement");
            entity.Property(e => e.Canseemanageserviceagreement).HasColumnName("canseemanageserviceagreement");
            entity.Property(e => e.Canseemanagesettings).HasColumnName("canseemanagesettings");
            entity.Property(e => e.Canseemanagesite).HasColumnName("canseemanagesite");
            entity.Property(e => e.Canseemanagestakeholder).HasColumnName("canseemanagestakeholder");
            entity.Property(e => e.Canseemanagetaxbracket).HasColumnName("canseemanagetaxbracket");
            entity.Property(e => e.Canseemanagetransportvehicleagreement).HasColumnName("canseemanagetransportvehicleagreement");
            entity.Property(e => e.Canseemanageuser).HasColumnName("canseemanageuser");
            entity.Property(e => e.Canseemanagevehicle).HasColumnName("canseemanagevehicle");
            entity.Property(e => e.Canseemanagevehicleagreement).HasColumnName("canseemanagevehicleagreement");
            entity.Property(e => e.Canseemanagevehicletype).HasColumnName("canseemanagevehicletype");
            entity.Property(e => e.Canseematerialinputactivity).HasColumnName("canseematerialinputactivity");
            entity.Property(e => e.Canseematerialinputarchive).HasColumnName("canseematerialinputarchive");
            entity.Property(e => e.Canseematerialoutputactivity).HasColumnName("canseematerialoutputactivity");
            entity.Property(e => e.Canseematerialoutputarchive).HasColumnName("canseematerialoutputarchive");
            entity.Property(e => e.Canseematerialreport).HasColumnName("canseematerialreport");
            entity.Property(e => e.Canseenetcashflowreport).HasColumnName("canseenetcashflowreport");
            entity.Property(e => e.Canseepayrollreport).HasColumnName("canseepayrollreport");
            entity.Property(e => e.Canseeprogressreport).HasColumnName("canseeprogressreport");
            entity.Property(e => e.Canseereport).HasColumnName("canseereport");
            entity.Property(e => e.Canseetimesheetactivity).HasColumnName("canseetimesheetactivity");
            entity.Property(e => e.Canseetimesheetarchive).HasColumnName("canseetimesheetarchive");
            entity.Property(e => e.Canseetransportvehicleactivity).HasColumnName("canseetransportvehicleactivity");
            entity.Property(e => e.Canseetransportvehiclearchive).HasColumnName("canseetransportvehiclearchive");
            entity.Property(e => e.Canseetransportvehiclereport).HasColumnName("canseetransportvehiclereport");
            entity.Property(e => e.Canseevehicleactivity).HasColumnName("canseevehicleactivity");
            entity.Property(e => e.Canseevehiclearchive).HasColumnName("canseevehiclearchive");
            entity.Property(e => e.Canseevehiclereport).HasColumnName("canseevehiclereport");
            entity.Property(e => e.Codes)
                .HasMaxLength(50)
                .HasColumnName("codes");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Email)
                .HasMaxLength(256)
                .HasColumnName("email");
            entity.Property(e => e.Firstname).HasColumnName("firstname");
            entity.Property(e => e.Isactive)
                .IsRequired()
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Lastname).HasColumnName("lastname");
            entity.Property(e => e.Middlename).HasColumnName("middlename");
            entity.Property(e => e.Passwordhash).HasColumnName("passwordhash");
            entity.Property(e => e.Reasonfordelete).HasColumnName("reasonfordelete");
            entity.Property(e => e.Reviewedby).HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Roles)
                .HasMaxLength(250)
                .HasColumnName("roles");
            entity.Property(e => e.Trial275)
                .HasMaxLength(1)
                .HasColumnName("trial275");
            entity.Property(e => e.Username)
                .IsRequired()
                .HasMaxLength(256)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Aspnetuserrole>(entity =>
        {
            entity.HasKey(e => new { e.Userid, e.Roleid }).HasName("pk_dbo_aspnetuserroles");

            entity.ToTable("aspnetuserroles");

            entity.Property(e => e.Userid)
                .HasMaxLength(128)
                .HasColumnName("userid");
            entity.Property(e => e.Roleid)
                .HasMaxLength(128)
                .HasColumnName("roleid");
            entity.Property(e => e.Trial271)
                .HasMaxLength(1)
                .HasColumnName("trial271");

            entity.HasOne(d => d.Role).WithMany(p => p.Aspnetuserroles)
                .HasForeignKey(d => d.Roleid)
                .HasConstraintName("fk_dbo_aspnetuserroles_dbo_aspnetroles_roleid");

            entity.HasOne(d => d.User).WithMany(p => p.Aspnetuserroles)
                .HasForeignKey(d => d.Userid)
                .HasConstraintName("fk_dbo_aspnetuserroles_dbo_aspnetusers_userid");
        });

        modelBuilder.Entity<Billactivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_billactivity");

            entity.ToTable("billactivity");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accountid).HasColumnName("accountid");
            entity.Property(e => e.Accountname)
                .HasMaxLength(100)
                .HasColumnName("accountname");
            entity.Property(e => e.Actualadvance)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("actualadvance");
            entity.Property(e => e.Advancepayment)
                .HasPrecision(18, 2)
                .HasColumnName("advancepayment");
            entity.Property(e => e.Agreementid)
                .HasDefaultValueSql("0")
                .HasColumnName("agreementid");
            entity.Property(e => e.Agreementname)
                .HasMaxLength(500)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("agreementname");
            entity.Property(e => e.Agreementtypeid)
                .HasDefaultValueSql("0")
                .HasColumnName("agreementtypeid");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Bankid).HasColumnName("bankid");
            entity.Property(e => e.Bankname)
                .HasMaxLength(50)
                .HasColumnName("bankname");
            entity.Property(e => e.Billdate).HasColumnName("billdate");
            entity.Property(e => e.Boxfileno)
                .HasMaxLength(50)
                .HasColumnName("boxfileno");
            entity.Property(e => e.ChkNo)
                .HasMaxLength(50)
                .HasColumnName("chk_no");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Deduction30percent)
                .HasPrecision(18, 2)
                .HasColumnName("deduction_30percent");
            entity.Property(e => e.Deductionapplicable)
                .HasDefaultValueSql("false")
                .HasColumnName("deductionapplicable");
            entity.Property(e => e.Deptid).HasColumnName("deptid");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.ErpAmount)
                .HasPrecision(18, 2)
                .HasColumnName("erp_amount");
            entity.Property(e => e.ErpDate).HasColumnName("erp_date");
            entity.Property(e => e.Escalation)
                .HasPrecision(18, 2)
                .HasColumnName("escalation");
            entity.Property(e => e.Grossadvance)
                .HasPrecision(18, 2)
                .HasColumnName("grossadvance");
            entity.Property(e => e.Grossescalation)
                .HasPrecision(18, 2)
                .HasColumnName("grossescalation");
            entity.Property(e => e.Grossfueldeduction)
                .HasPrecision(18, 2)
                .HasColumnName("grossfueldeduction");
            entity.Property(e => e.Grossmachinerydeduction)
                .HasPrecision(18, 2)
                .HasColumnName("grossmachinerydeduction");
            entity.Property(e => e.Grossmaterialdeduction)
                .HasPrecision(18, 2)
                .HasColumnName("grossmaterialdeduction");
            entity.Property(e => e.Grosspayment)
                .HasPrecision(18, 2)
                .HasColumnName("grosspayment");
            entity.Property(e => e.Grosspaymentamount)
                .HasPrecision(18, 2)
                .HasColumnName("grosspaymentamount");
            entity.Property(e => e.Grossretention)
                .HasPrecision(18, 2)
                .HasColumnName("grossretention");
            entity.Property(e => e.Grosstransportdeduction)
                .HasPrecision(18, 2)
                .HasColumnName("grosstransportdeduction");
            entity.Property(e => e.Grossvat)
                .HasPrecision(18, 2)
                .HasColumnName("grossvat");
            entity.Property(e => e.Grossvehiclededuction)
                .HasPrecision(18, 2)
                .HasColumnName("grossvehiclededuction");
            entity.Property(e => e.Grosswithholding)
                .HasPrecision(18, 2)
                .HasColumnName("grosswithholding");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isforadvance)
                .HasDefaultValueSql("false")
                .HasColumnName("isforadvance");
            entity.Property(e => e.Isforpurchase)
                .HasDefaultValueSql("false")
                .HasColumnName("isforpurchase");
            entity.Property(e => e.Isforsell)
                .HasDefaultValueSql("false")
                .HasColumnName("isforsell");
            entity.Property(e => e.Isincomegenerating)
                .HasDefaultValueSql("false")
                .HasColumnName("isincomegenerating");
            entity.Property(e => e.Ispaid)
                .HasDefaultValueSql("false")
                .HasColumnName("ispaid");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Managerid)
                .HasDefaultValueSql("0")
                .HasColumnName("managerid");
            entity.Property(e => e.Managername)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("managername");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("name");
            entity.Property(e => e.Netpaymentamount)
                .HasPrecision(18, 2)
                .HasColumnName("netpaymentamount");
            entity.Property(e => e.Payeeid)
                .HasDefaultValueSql("0")
                .HasColumnName("payeeid");
            entity.Property(e => e.Payeename)
                .HasMaxLength(200)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("payeename");
            entity.Property(e => e.Payerid)
                .HasDefaultValueSql("0")
                .HasColumnName("payerid");
            entity.Property(e => e.Payername)
                .HasMaxLength(200)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("payername");
            entity.Property(e => e.Paymenttype)
                .HasMaxLength(15)
                .HasColumnName("paymenttype");
            entity.Property(e => e.Period).HasColumnName("period");
            entity.Property(e => e.PlateNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'Select'::character varying")
                .HasColumnName("plate_no");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Projectname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("projectname");
            entity.Property(e => e.PvNo).HasColumnName("pv_no");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(50)
                .HasColumnName("receiptno");
            entity.Property(e => e.ReqId).HasColumnName("req_id");
            entity.Property(e => e.Retention)
                .HasPrecision(18, 2)
                .HasColumnName("retention");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Trial275)
                .HasMaxLength(1)
                .HasColumnName("trial275");
            entity.Property(e => e.Unpaidamount)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("unpaidamount");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Vat)
                .HasPrecision(18, 2)
                .HasColumnName("vat");
            entity.Property(e => e.Withholding)
                .HasPrecision(18, 2)
                .HasColumnName("withholding");
        });

        modelBuilder.Entity<Billactivityrecovery>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_billactivityrecovery");

            entity.ToTable("billactivityrecovery");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accountid).HasColumnName("accountid");
            entity.Property(e => e.Accountname)
                .HasMaxLength(100)
                .HasColumnName("accountname");
            entity.Property(e => e.Actualadvance)
                .HasPrecision(18, 2)
                .HasColumnName("actualadvance");
            entity.Property(e => e.Advancepayment)
                .HasPrecision(18, 2)
                .HasColumnName("advancepayment");
            entity.Property(e => e.Agreementid).HasColumnName("agreementid");
            entity.Property(e => e.Agreementname)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("agreementname");
            entity.Property(e => e.Agreementtypeid).HasColumnName("agreementtypeid");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Bankid).HasColumnName("bankid");
            entity.Property(e => e.Bankname)
                .HasMaxLength(50)
                .HasColumnName("bankname");
            entity.Property(e => e.Billdate)
                .IsRequired()
                .HasColumnName("billdate");
            entity.Property(e => e.Boxfileno)
                .HasMaxLength(50)
                .HasColumnName("boxfileno");
            entity.Property(e => e.ChkNo)
                .HasMaxLength(50)
                .HasColumnName("chk_no");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Deductionapplicable).HasColumnName("deductionapplicable");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.ErpAmount)
                .HasPrecision(18, 2)
                .HasColumnName("erp_amount");
            entity.Property(e => e.ErpDate).HasColumnName("erp_date");
            entity.Property(e => e.Escalation)
                .HasPrecision(18, 2)
                .HasColumnName("escalation");
            entity.Property(e => e.Grossadvance)
                .HasPrecision(18, 2)
                .HasColumnName("grossadvance");
            entity.Property(e => e.Grossescalation)
                .HasPrecision(18, 2)
                .HasColumnName("grossescalation");
            entity.Property(e => e.Grossfueldeduction)
                .HasPrecision(18, 2)
                .HasColumnName("grossfueldeduction");
            entity.Property(e => e.Grossmachinerydeduction)
                .HasPrecision(18, 2)
                .HasColumnName("grossmachinerydeduction");
            entity.Property(e => e.Grossmaterialdeduction)
                .HasPrecision(18, 2)
                .HasColumnName("grossmaterialdeduction");
            entity.Property(e => e.Grosspayment)
                .HasPrecision(18, 2)
                .HasColumnName("grosspayment");
            entity.Property(e => e.Grosspaymentamount)
                .HasPrecision(18, 2)
                .HasColumnName("grosspaymentamount");
            entity.Property(e => e.Grossretention)
                .HasPrecision(18, 2)
                .HasColumnName("grossretention");
            entity.Property(e => e.Grosstransportdeduction)
                .HasPrecision(18, 2)
                .HasColumnName("grosstransportdeduction");
            entity.Property(e => e.Grossvat)
                .HasPrecision(18, 2)
                .HasColumnName("grossvat");
            entity.Property(e => e.Grossvehiclededuction)
                .HasPrecision(18, 2)
                .HasColumnName("grossvehiclededuction");
            entity.Property(e => e.Grosswithholding)
                .HasPrecision(18, 2)
                .HasColumnName("grosswithholding");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isforadvance).HasColumnName("isforadvance");
            entity.Property(e => e.Isforpurchase)
                .HasDefaultValueSql("false")
                .HasColumnName("isforpurchase");
            entity.Property(e => e.Isforsell).HasColumnName("isforsell");
            entity.Property(e => e.Isincomegenerating).HasColumnName("isincomegenerating");
            entity.Property(e => e.Ispaid).HasColumnName("ispaid");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Managerid).HasColumnName("managerid");
            entity.Property(e => e.Managername)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("managername");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("name");
            entity.Property(e => e.Netpaymentamount)
                .HasPrecision(18, 2)
                .HasColumnName("netpaymentamount");
            entity.Property(e => e.Payeeid).HasColumnName("payeeid");
            entity.Property(e => e.Payeename)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("payeename");
            entity.Property(e => e.Payerid).HasColumnName("payerid");
            entity.Property(e => e.Payername)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("payername");
            entity.Property(e => e.Paymenttype)
                .HasMaxLength(3)
                .HasColumnName("paymenttype");
            entity.Property(e => e.Period).HasColumnName("period");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Projectname)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("projectname");
            entity.Property(e => e.PvNo).HasColumnName("pv_no");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(50)
                .HasColumnName("receiptno");
            entity.Property(e => e.ReqId).HasColumnName("req_id");
            entity.Property(e => e.Retention)
                .HasPrecision(18, 2)
                .HasColumnName("retention");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Trial294)
                .HasMaxLength(1)
                .HasColumnName("trial294");
            entity.Property(e => e.Unpaidamount)
                .HasPrecision(18, 2)
                .HasColumnName("unpaidamount");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Vat)
                .HasPrecision(18, 2)
                .HasColumnName("vat");
            entity.Property(e => e.Withholding)
                .HasPrecision(18, 2)
                .HasColumnName("withholding");
        });

        modelBuilder.Entity<Billactivityrecovery1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_billactivityrecovery1");

            entity.ToTable("billactivityrecovery1");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Accountid).HasColumnName("accountid");
            entity.Property(e => e.Accountname)
                .HasMaxLength(100)
                .HasColumnName("accountname");
            entity.Property(e => e.Actualadvance)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("actualadvance");
            entity.Property(e => e.Advancepayment)
                .HasPrecision(18, 2)
                .HasColumnName("advancepayment");
            entity.Property(e => e.Agreementid)
                .HasDefaultValueSql("0")
                .HasColumnName("agreementid");
            entity.Property(e => e.Agreementname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("agreementname");
            entity.Property(e => e.Agreementtypeid)
                .HasDefaultValueSql("0")
                .HasColumnName("agreementtypeid");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Bankid).HasColumnName("bankid");
            entity.Property(e => e.Bankname)
                .HasMaxLength(50)
                .HasColumnName("bankname");
            entity.Property(e => e.Billdate).HasColumnName("billdate");
            entity.Property(e => e.Boxfileno)
                .HasMaxLength(50)
                .HasColumnName("boxfileno");
            entity.Property(e => e.ChkNo)
                .HasMaxLength(50)
                .HasColumnName("chk_no");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Deductionapplicable)
                .HasDefaultValueSql("false")
                .HasColumnName("deductionapplicable");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.ErpAmount)
                .HasPrecision(18, 2)
                .HasColumnName("erp_amount");
            entity.Property(e => e.ErpDate).HasColumnName("erp_date");
            entity.Property(e => e.Escalation)
                .HasPrecision(18, 2)
                .HasColumnName("escalation");
            entity.Property(e => e.Grossadvance)
                .HasPrecision(18, 2)
                .HasColumnName("grossadvance");
            entity.Property(e => e.Grossescalation)
                .HasPrecision(18, 2)
                .HasColumnName("grossescalation");
            entity.Property(e => e.Grossfueldeduction)
                .HasPrecision(18, 2)
                .HasColumnName("grossfueldeduction");
            entity.Property(e => e.Grossmachinerydeduction)
                .HasPrecision(18, 2)
                .HasColumnName("grossmachinerydeduction");
            entity.Property(e => e.Grossmaterialdeduction)
                .HasPrecision(18, 2)
                .HasColumnName("grossmaterialdeduction");
            entity.Property(e => e.Grosspayment)
                .HasPrecision(18, 2)
                .HasColumnName("grosspayment");
            entity.Property(e => e.Grosspaymentamount)
                .HasPrecision(18, 2)
                .HasColumnName("grosspaymentamount");
            entity.Property(e => e.Grossretention)
                .HasPrecision(18, 2)
                .HasColumnName("grossretention");
            entity.Property(e => e.Grosstransportdeduction)
                .HasPrecision(18, 2)
                .HasColumnName("grosstransportdeduction");
            entity.Property(e => e.Grossvat)
                .HasPrecision(18, 2)
                .HasColumnName("grossvat");
            entity.Property(e => e.Grossvehiclededuction)
                .HasPrecision(18, 2)
                .HasColumnName("grossvehiclededuction");
            entity.Property(e => e.Grosswithholding)
                .HasPrecision(18, 2)
                .HasColumnName("grosswithholding");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isforadvance)
                .HasDefaultValueSql("false")
                .HasColumnName("isforadvance");
            entity.Property(e => e.Isforpurchase)
                .HasDefaultValueSql("false")
                .HasColumnName("isforpurchase");
            entity.Property(e => e.Isforsell)
                .HasDefaultValueSql("false")
                .HasColumnName("isforsell");
            entity.Property(e => e.Isincomegenerating)
                .HasDefaultValueSql("false")
                .HasColumnName("isincomegenerating");
            entity.Property(e => e.Ispaid)
                .HasDefaultValueSql("false")
                .HasColumnName("ispaid");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Managerid)
                .HasDefaultValueSql("0")
                .HasColumnName("managerid");
            entity.Property(e => e.Managername)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("managername");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("name");
            entity.Property(e => e.Netpaymentamount)
                .HasPrecision(18, 2)
                .HasColumnName("netpaymentamount");
            entity.Property(e => e.Payeeid)
                .HasDefaultValueSql("0")
                .HasColumnName("payeeid");
            entity.Property(e => e.Payeename)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("payeename");
            entity.Property(e => e.Payerid)
                .HasDefaultValueSql("0")
                .HasColumnName("payerid");
            entity.Property(e => e.Payername)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("payername");
            entity.Property(e => e.Paymenttype)
                .HasMaxLength(3)
                .HasColumnName("paymenttype");
            entity.Property(e => e.Period).HasColumnName("period");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Projectname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("projectname");
            entity.Property(e => e.PvNo).HasColumnName("pv_no");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Receiptno)
                .HasMaxLength(50)
                .HasColumnName("receiptno");
            entity.Property(e => e.ReqId).HasColumnName("req_id");
            entity.Property(e => e.Retention)
                .HasPrecision(18, 2)
                .HasColumnName("retention");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Trial297)
                .HasMaxLength(1)
                .HasColumnName("trial297");
            entity.Property(e => e.Unpaidamount)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("unpaidamount");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Vat)
                .HasPrecision(18, 2)
                .HasColumnName("vat");
            entity.Property(e => e.Withholding)
                .HasPrecision(18, 2)
                .HasColumnName("withholding");
        });

        modelBuilder.Entity<Bondauto>(entity =>
        {
            entity.HasKey(e => e.Autono).HasName("pk_bondauto");

            entity.ToTable("bondauto");

            entity.Property(e => e.Autono).HasColumnName("autono");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Trial307)
                .HasMaxLength(1)
                .HasColumnName("trial307");
        });

        modelBuilder.Entity<Budcode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("budcode");

            entity.Property(e => e.Loaction)
                .HasMaxLength(100)
                .HasColumnName("loaction");
            entity.Property(e => e.Locationid)
                .HasMaxLength(3)
                .HasColumnName("locationid");
            entity.Property(e => e.Trial307)
                .HasMaxLength(1)
                .HasColumnName("trial307");
        });

        modelBuilder.Entity<BudgetPoAccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("budget_po_account");

            entity.Property(e => e.AccountsId).HasColumnName("accounts_id");
            entity.Property(e => e.AmountPaid).HasColumnName("amount_paid");
            entity.Property(e => e.ExpenseId)
                .HasMaxLength(255)
                .HasColumnName("expense_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RequestId).HasColumnName("request_id");
            entity.Property(e => e.RequestType)
                .HasMaxLength(255)
                .HasColumnName("request_type");
            entity.Property(e => e.Trial310)
                .HasMaxLength(1)
                .HasColumnName("trial310");
        });

        modelBuilder.Entity<Capitalagreement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_capitalagreement");

            entity.ToTable("capitalagreement");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Agreementdate)
                .IsRequired()
                .HasColumnName("agreementdate");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.Isactive)
                .IsRequired()
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Managerid).HasColumnName("managerid");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Paidamount)
                .HasPrecision(18, 2)
                .HasColumnName("paidamount");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Shareholderid).HasColumnName("shareholderid");
            entity.Property(e => e.Sharemoneyvalue)
                .HasPrecision(18, 2)
                .HasColumnName("sharemoneyvalue");
            entity.Property(e => e.Shareprecent)
                .HasPrecision(18, 2)
                .HasColumnName("shareprecent");
            entity.Property(e => e.Trial314)
                .HasMaxLength(1)
                .HasColumnName("trial314");
            entity.Property(e => e.Unpaidamount)
                .HasPrecision(18, 2)
                .HasColumnName("unpaidamount");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");

            entity.HasOne(d => d.Manager).WithMany(p => p.Capitalagreements)
                .HasForeignKey(d => d.Managerid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbo_capitalagreement_dbo_manager_managerid");

            entity.HasOne(d => d.Project).WithMany(p => p.Capitalagreements)
                .HasForeignKey(d => d.Projectid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbo_capitalagreement_dbo_project_projectid");

            entity.HasOne(d => d.Shareholder).WithMany(p => p.Capitalagreements)
                .HasForeignKey(d => d.Shareholderid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbo_capitalagreement_dbo_client_shareholderid");
        });

        modelBuilder.Entity<CfRevenue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_cf_revenue");

            entity.ToTable("cf_revenue");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActualAmt)
                .HasPrecision(18, 2)
                .HasColumnName("actual_amt");
            entity.Property(e => e.AdvDeduction)
                .HasPrecision(18, 2)
                .HasColumnName("adv_deduction");
            entity.Property(e => e.BankId).HasColumnName("bank_id");
            entity.Property(e => e.Checked)
                .HasMaxLength(10)
                .HasColumnName("checked");
            entity.Property(e => e.ChkNo)
                .HasMaxLength(100)
                .HasColumnName("chk_no");
            entity.Property(e => e.CreatedDate).HasColumnName("created_date");
            entity.Property(e => e.DateRcvd).HasColumnName("date_rcvd");
            entity.Property(e => e.ExcecutedRev)
                .HasPrecision(18, 2)
                .HasColumnName("excecuted_rev");
            entity.Property(e => e.JvNo)
                .HasMaxLength(50)
                .HasColumnName("jv_no");
            entity.Property(e => e.Other)
                .HasPrecision(18, 2)
                .HasColumnName("other");
            entity.Property(e => e.Payer).HasColumnName("payer");
            entity.Property(e => e.PaymentNo)
                .HasMaxLength(100)
                .HasColumnName("payment_no");
            entity.Property(e => e.Period).HasColumnName("period");
            entity.Property(e => e.Project).HasColumnName("project");
            entity.Property(e => e.Remark)
                .HasMaxLength(300)
                .HasColumnName("remark");
            entity.Property(e => e.Retention)
                .HasPrecision(18, 2)
                .HasColumnName("retention");
            entity.Property(e => e.Trial314)
                .HasMaxLength(1)
                .HasColumnName("trial314");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Vat)
                .HasPrecision(18, 2)
                .HasColumnName("vat");
            entity.Property(e => e.Wht)
                .HasPrecision(18, 2)
                .HasColumnName("wht");
        });

        modelBuilder.Entity<Cfbank>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_cfbank");

            entity.ToTable("cfbank");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountNo)
                .HasMaxLength(200)
                .HasColumnName("account_no");
            entity.Property(e => e.AllowNegativeBalance)
                .HasDefaultValueSql("false")
                .HasColumnName("allow_negative_balance");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.BalDate).HasColumnName("bal_date");
            entity.Property(e => e.BankName)
                .HasMaxLength(100)
                .HasColumnName("bank_name");
            entity.Property(e => e.BeginingBalance)
                .HasPrecision(18, 2)
                .HasColumnName("begining_balance");
            entity.Property(e => e.ContactAddress)
                .HasMaxLength(100)
                .HasColumnName("contact_address");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.GlAccount)
                .HasMaxLength(10)
                .HasColumnName("gl_account");
            entity.Property(e => e.Isactive)
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdefaultbank)
                .HasDefaultValueSql("false")
                .HasColumnName("isdefaultbank");
            entity.Property(e => e.Isdeleted)
                .HasDefaultValueSql("false")
                .HasColumnName("isdeleted");
            entity.Property(e => e.Ispettycashier)
                .HasDefaultValueSql("false")
                .HasColumnName("ispettycashier");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Location)
                .HasMaxLength(100)
                .HasColumnName("location");
            entity.Property(e => e.Ref).HasColumnName("ref");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Trial317)
                .HasMaxLength(1)
                .HasColumnName("trial317");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Cfbanktran>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_cfbanktran");

            entity.ToTable("cfbanktran");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApprovedBy).HasColumnName("approved_by");
            entity.Property(e => e.BankId).HasColumnName("bank_id");
            entity.Property(e => e.CashAmount)
                .HasPrecision(18, 2)
                .HasColumnName("cash_amount");
            entity.Property(e => e.CashIn)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("cash_in");
            entity.Property(e => e.CashOut)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("cash_out");
            entity.Property(e => e.CheckNo)
                .HasMaxLength(50)
                .HasColumnName("check_no");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(100)
                .HasColumnName("created_date");
            entity.Property(e => e.Fcode1).HasColumnName("fcode1");
            entity.Property(e => e.Fcode2).HasColumnName("fcode2");
            entity.Property(e => e.PaidTo).HasColumnName("paid_to");
            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.PvNo)
                .HasMaxLength(50)
                .HasColumnName("pv_no");
            entity.Property(e => e.RecordType)
                .HasMaxLength(10)
                .HasColumnName("record_type");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .HasColumnName("remark");
            entity.Property(e => e.Status)
                .HasMaxLength(4)
                .HasColumnName("status");
            entity.Property(e => e.TrDate).HasColumnName("tr_date");
            entity.Property(e => e.TrWithdrawDate).HasColumnName("tr_withdraw_date");
            entity.Property(e => e.Trial317)
                .HasMaxLength(1)
                .HasColumnName("trial317");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Vat)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vat");
            entity.Property(e => e.Void)
                .HasMaxLength(3)
                .HasColumnName("void");
            entity.Property(e => e.Wht)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("wht");
        });

        modelBuilder.Entity<Cfcategory>(entity =>
        {
            entity.HasKey(e => e.Cid).HasName("pk_cfcategory");

            entity.ToTable("cfcategory");

            entity.Property(e => e.Cid)
                .ValueGeneratedNever()
                .HasColumnName("cid");
            entity.Property(e => e.CatName)
                .HasMaxLength(100)
                .HasColumnName("cat_name");
            entity.Property(e => e.IdDesc)
                .HasMaxLength(200)
                .HasColumnName("id_desc");
            entity.Property(e => e.Trial317)
                .HasMaxLength(1)
                .HasColumnName("trial317");
        });

        modelBuilder.Entity<Cfsubcategory>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("pk_cfsubcategory");

            entity.ToTable("cfsubcategory");

            entity.Property(e => e.Sid).HasColumnName("sid");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.SubcatName)
                .HasMaxLength(100)
                .HasColumnName("subcat_name");
            entity.Property(e => e.Trial320)
                .HasMaxLength(1)
                .HasColumnName("trial320");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_client");

            entity.ToTable("client");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.Isactive)
                .IsRequired()
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isinternal).HasColumnName("isinternal");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Trial320)
                .HasMaxLength(1)
                .HasColumnName("trial320");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
        });

        modelBuilder.Entity<Cpbackupsheetmain>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_cpbackupsheetmain");

            entity.ToTable("cpbackupsheetmain");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Billgroupid)
                .HasMaxLength(50)
                .HasColumnName("billgroupid");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Executedamount)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("executedamount");
            entity.Property(e => e.Executedqty)
                .HasPrecision(18, 3)
                .HasDefaultValueSql("0")
                .HasColumnName("executedqty");
            entity.Property(e => e.Ipcno)
                .HasMaxLength(50)
                .HasColumnName("ipcno");
            entity.Property(e => e.Isactive)
                .IsRequired()
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Payitem)
                .HasMaxLength(50)
                .HasColumnName("payitem");
            entity.Property(e => e.Payitemdescr)
                .HasMaxLength(300)
                .HasColumnName("payitemdescr");
            entity.Property(e => e.Period).HasColumnName("period");
            entity.Property(e => e.Periodend).HasColumnName("periodend");
            entity.Property(e => e.Periodstart).HasColumnName("periodstart");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Projectname)
                .HasMaxLength(100)
                .HasColumnName("projectname");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .HasColumnName("remark");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.StationEnd)
                .HasDefaultValueSql("0")
                .HasColumnName("station_end");
            entity.Property(e => e.StationStart)
                .HasDefaultValueSql("0")
                .HasColumnName("station_start");
            entity.Property(e => e.Stationname)
                .HasMaxLength(50)
                .HasColumnName("stationname");
            entity.Property(e => e.Trial320)
                .HasMaxLength(1)
                .HasColumnName("trial320");
            entity.Property(e => e.Unitrate)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("unitrate");
            entity.Property(e => e.Uom)
                .HasMaxLength(15)
                .HasDefaultValueSql("'None'::character varying")
                .HasColumnName("uom");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
        });

        modelBuilder.Entity<Cpbackupsheetsc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_cpbackupsheetsc_1");

            entity.ToTable("cpbackupsheetsc");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Billgroup)
                .HasMaxLength(50)
                .HasColumnName("billgroup");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Executedqty)
                .HasPrecision(18, 3)
                .HasDefaultValueSql("0")
                .HasColumnName("executedqty");
            entity.Property(e => e.Ipcno)
                .HasMaxLength(50)
                .HasColumnName("ipcno");
            entity.Property(e => e.Isactive)
                .IsRequired()
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Payitemdescr)
                .HasMaxLength(300)
                .HasColumnName("payitemdescr");
            entity.Property(e => e.Payitemmain)
                .HasMaxLength(50)
                .HasColumnName("payitemmain");
            entity.Property(e => e.Payitemsc)
                .HasMaxLength(50)
                .HasColumnName("payitemsc");
            entity.Property(e => e.Period).HasColumnName("period");
            entity.Property(e => e.Periodend).HasColumnName("periodend");
            entity.Property(e => e.Periodstart).HasColumnName("periodstart");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Projectname)
                .HasMaxLength(100)
                .HasColumnName("projectname");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .HasColumnName("remark");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Stationname)
                .HasMaxLength(50)
                .HasColumnName("stationname");
            entity.Property(e => e.Subcontractor).HasColumnName("subcontractor");
            entity.Property(e => e.Trial330)
                .HasMaxLength(1)
                .HasColumnName("trial330");
            entity.Property(e => e.Unitrate)
                .HasPrecision(18, 2)
                .HasColumnName("unitrate");
            entity.Property(e => e.Uom)
                .HasMaxLength(10)
                .HasColumnName("uom");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
        });

        modelBuilder.Entity<Cpbillgroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_cpbillgroup");

            entity.ToTable("cpbillgroup");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Agreementid).HasColumnName("agreementid");
            entity.Property(e => e.Agreementname)
                .HasMaxLength(50)
                .HasColumnName("agreementname");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Billdescription)
                .HasMaxLength(100)
                .HasColumnName("billdescription");
            entity.Property(e => e.Billgroupid)
                .HasMaxLength(50)
                .HasColumnName("billgroupid");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Isactive)
                .IsRequired()
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Projectname)
                .HasMaxLength(100)
                .HasColumnName("projectname");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Trial330)
                .HasMaxLength(1)
                .HasColumnName("trial330");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
        });

        modelBuilder.Entity<Cpipcno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_cpipcno");

            entity.ToTable("cpipcno");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ipcno)
                .HasMaxLength(50)
                .HasColumnName("ipcno");
            entity.Property(e => e.Trial330)
                .HasMaxLength(1)
                .HasColumnName("trial330");
        });

        modelBuilder.Entity<Cppayitemsmain>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_cppayitemsmain_1");

            entity.ToTable("cppayitemsmain");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Adjustedquantity)
                .HasPrecision(18, 3)
                .HasColumnName("adjustedquantity");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Billgroupid)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("billgroupid");
            entity.Property(e => e.Contractquantity)
                .HasPrecision(18, 3)
                .HasColumnName("contractquantity");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Isactive)
                .IsRequired()
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isheading).HasColumnName("isheading");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Issiteoperation)
                .HasDefaultValueSql("true")
                .HasColumnName("issiteoperation");
            entity.Property(e => e.Payitem)
                .HasMaxLength(50)
                .HasColumnName("payitem");
            entity.Property(e => e.Payitemdescription)
                .HasMaxLength(500)
                .HasColumnName("payitemdescription");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Projectname)
                .HasMaxLength(100)
                .HasColumnName("projectname");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Trial330)
                .HasMaxLength(1)
                .HasColumnName("trial330");
            entity.Property(e => e.Unitrate)
                .HasPrecision(18, 2)
                .HasColumnName("unitrate");
            entity.Property(e => e.Unitrateadjusted)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("unitrateadjusted");
            entity.Property(e => e.Uom)
                .HasMaxLength(15)
                .HasColumnName("uom");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
        });

        modelBuilder.Entity<Cppayitemssc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_cppayitemssc");

            entity.ToTable("cppayitemssc");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Adjustedquantity)
                .HasPrecision(18, 3)
                .HasColumnName("adjustedquantity");
            entity.Property(e => e.Agreementname)
                .HasMaxLength(50)
                .HasColumnName("agreementname");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Billgroupid)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("billgroupid");
            entity.Property(e => e.Contractquantity)
                .HasPrecision(18, 3)
                .HasColumnName("contractquantity");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Isactive)
                .IsRequired()
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isheading).HasColumnName("isheading");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Payitemdescription)
                .HasMaxLength(500)
                .HasColumnName("payitemdescription");
            entity.Property(e => e.Payitemmain)
                .HasMaxLength(50)
                .HasColumnName("payitemmain");
            entity.Property(e => e.Payitemsc)
                .HasMaxLength(50)
                .HasColumnName("payitemsc");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Projectname)
                .HasMaxLength(100)
                .HasColumnName("projectname");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.ScName)
                .HasMaxLength(100)
                .HasColumnName("sc_name");
            entity.Property(e => e.Subcontractor).HasColumnName("subcontractor");
            entity.Property(e => e.Trial333)
                .HasMaxLength(1)
                .HasColumnName("trial333");
            entity.Property(e => e.Unitrate)
                .HasPrecision(18, 2)
                .HasColumnName("unitrate");
            entity.Property(e => e.Uom)
                .HasMaxLength(15)
                .HasColumnName("uom");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
        });

        modelBuilder.Entity<Cpstation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_cpstation");

            entity.ToTable("cpstation");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Isactive)
                .IsRequired()
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Projectname)
                .HasMaxLength(100)
                .HasColumnName("projectname");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Stationdescription)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("stationdescription");
            entity.Property(e => e.Trial337)
                .HasMaxLength(1)
                .HasColumnName("trial337");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
        });

        modelBuilder.Entity<Cpuom>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_cfuom");

            entity.ToTable("cpuom");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descr)
                .HasMaxLength(50)
                .HasColumnName("descr");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnName("name");
            entity.Property(e => e.Trial337)
                .HasMaxLength(1)
                .HasColumnName("trial337");
        });

        modelBuilder.Entity<Dcattachement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dcattachement");

            entity.ToTable("dcattachement");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DocId).HasColumnName("doc_id");
            entity.Property(e => e.DocType).HasColumnName("doc_type");
            entity.Property(e => e.FileName)
                .HasMaxLength(100)
                .HasColumnName("file_name");
            entity.Property(e => e.Trial337)
                .HasMaxLength(1)
                .HasColumnName("trial337");
        });

        modelBuilder.Entity<Dcauto>(entity =>
        {
            entity.HasKey(e => e.Autono).HasName("pk_dcauto");

            entity.ToTable("dcauto");

            entity.Property(e => e.Autono).HasColumnName("autono");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Trial337)
                .HasMaxLength(1)
                .HasColumnName("trial337");
        });

        modelBuilder.Entity<Dccontact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dccontacts");

            entity.ToTable("dccontacts");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .HasColumnName("address");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Trial340)
                .HasMaxLength(1)
                .HasColumnName("trial340");
        });

        modelBuilder.Entity<Dcdoctype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dcdoctype");

            entity.ToTable("dcdoctype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Doctype)
                .HasMaxLength(30)
                .HasColumnName("doctype");
            entity.Property(e => e.Trial340)
                .HasMaxLength(1)
                .HasColumnName("trial340");
        });

        modelBuilder.Entity<Dcdocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dcdocument");

            entity.ToTable("dcdocument");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Author)
                .HasMaxLength(100)
                .HasColumnName("author");
            entity.Property(e => e.Createddate)
                .HasMaxLength(50)
                .HasDefaultValueSql("'getdate()'::character varying")
                .HasColumnName("createddate");
            entity.Property(e => e.DateRec).HasColumnName("date_rec");
            entity.Property(e => e.Dept).HasColumnName("dept");
            entity.Property(e => e.DocType)
                .HasMaxLength(20)
                .HasColumnName("doc_type");
            entity.Property(e => e.Keywords)
                .HasMaxLength(500)
                .HasColumnName("keywords");
            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.ReceiverSender).HasColumnName("receiver_sender");
            entity.Property(e => e.RefNo)
                .HasMaxLength(30)
                .HasColumnName("ref_no");
            entity.Property(e => e.ReplytoRefno)
                .HasMaxLength(30)
                .HasColumnName("replyto_refno");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.SubDocType)
                .HasMaxLength(20)
                .HasColumnName("sub_doc_type");
            entity.Property(e => e.Subject)
                .HasMaxLength(400)
                .HasColumnName("subject");
            entity.Property(e => e.Trial343)
                .HasMaxLength(1)
                .HasColumnName("trial343");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Dcfile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dcfiles");

            entity.Property(e => e.Contenttype)
                .HasMaxLength(200)
                .HasColumnName("contenttype");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Docid).HasColumnName("docid");
            entity.Property(e => e.Doctype).HasColumnName("doctype");
            entity.Property(e => e.Filename)
                .HasMaxLength(200)
                .HasColumnName("filename");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Trial346)
                .HasMaxLength(1)
                .HasColumnName("trial346");
        });

        modelBuilder.Entity<Dcmail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dcmail");

            entity.ToTable("dcmail");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Attachement)
                .HasMaxLength(50)
                .HasColumnName("attachement");
            entity.Property(e => e.Body)
                .HasMaxLength(2000)
                .HasColumnName("body");
            entity.Property(e => e.DateRcvd).HasColumnName("date_rcvd");
            entity.Property(e => e.Readstatus).HasColumnName("readstatus");
            entity.Property(e => e.Receiver).HasColumnName("receiver");
            entity.Property(e => e.Sender).HasColumnName("sender");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.Subject)
                .HasMaxLength(100)
                .HasColumnName("subject");
            entity.Property(e => e.TimeRcvd)
                .HasMaxLength(30)
                .HasColumnName("time_rcvd");
            entity.Property(e => e.Trial217)
                .HasMaxLength(1)
                .HasColumnName("trial217");
        });

        modelBuilder.Entity<Dcmailatt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dcmailatt");

            entity.ToTable("dcmailatt");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FileName)
                .HasMaxLength(100)
                .HasColumnName("file_name");
            entity.Property(e => e.MailId).HasColumnName("mail_id");
            entity.Property(e => e.Trial221)
                .HasMaxLength(1)
                .HasColumnName("trial221");
        });

        modelBuilder.Entity<Dcmailauto>(entity =>
        {
            entity.HasKey(e => e.Autono).HasName("pk_dcmailauto");

            entity.ToTable("dcmailauto");

            entity.Property(e => e.Autono).HasColumnName("autono");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Trial221)
                .HasMaxLength(1)
                .HasColumnName("trial221");
        });

        modelBuilder.Entity<Dcmailsendto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dcmailsendto");

            entity.ToTable("dcmailsendto");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MailId).HasColumnName("mail_id");
            entity.Property(e => e.SendTo).HasColumnName("send_to");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Trial224)
                .HasMaxLength(1)
                .HasColumnName("trial224");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Dcsendto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dcsendto");

            entity.ToTable("dcsendto");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comment)
                .HasMaxLength(1000)
                .HasColumnName("comment");
            entity.Property(e => e.DocId).HasColumnName("doc_id");
            entity.Property(e => e.Sendto).HasColumnName("sendto");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Trial224)
                .HasMaxLength(1)
                .HasColumnName("trial224");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Dcsubdoctype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dcsubdoctype");

            entity.ToTable("dcsubdoctype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Docid).HasColumnName("docid");
            entity.Property(e => e.Subdoc)
                .HasMaxLength(30)
                .HasColumnName("subdoc");
            entity.Property(e => e.Trial230)
                .HasMaxLength(1)
                .HasColumnName("trial230");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_employee");

            entity.ToTable("employee");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Costsharing)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("costsharing");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Deptid).HasColumnName("deptid");
            entity.Property(e => e.Deptname)
                .HasMaxLength(100)
                .HasColumnName("deptname");
            entity.Property(e => e.Desertallowancepercent)
                .HasDefaultValueSql("0")
                .HasColumnName("desertallowancepercent");
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .HasColumnName("emp_name");
            entity.Property(e => e.Employeebankaccount)
                .HasMaxLength(100)
                .HasColumnName("employeebankaccount");
            entity.Property(e => e.Employeebankname)
                .HasMaxLength(100)
                .HasColumnName("employeebankname");
            entity.Property(e => e.Employeefamilybankaccount)
                .HasMaxLength(100)
                .HasColumnName("employeefamilybankaccount");
            entity.Property(e => e.Employeefamilybankname)
                .HasMaxLength(100)
                .HasColumnName("employeefamilybankname");
            entity.Property(e => e.Employeefamilyname)
                .HasMaxLength(100)
                .HasColumnName("employeefamilyname");
            entity.Property(e => e.Employeeid)
                .HasMaxLength(50)
                .HasColumnName("employeeid");
            entity.Property(e => e.Familyallotment)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("familyallotment");
            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .HasColumnName("firstname");
            entity.Property(e => e.Hiredate).HasColumnName("hiredate");
            entity.Property(e => e.Hourlyperdiemrate)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("hourlyperdiemrate");
            entity.Property(e => e.Hourlyrate)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("hourlyrate");
            entity.Property(e => e.Isactive)
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Ispermanent).HasColumnName("ispermanent");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .HasColumnName("lastname");
            entity.Property(e => e.Middlename)
                .HasMaxLength(50)
                .HasColumnName("middlename");
            entity.Property(e => e.PensionNo)
                .HasMaxLength(50)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("pension_no");
            entity.Property(e => e.PositionAllowance)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("position_allowance");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Salary)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("salary");
            entity.Property(e => e.Serviceagreementid).HasColumnName("serviceagreementid");
            entity.Property(e => e.Terminateddate)
                .HasMaxLength(50)
                .HasColumnName("terminateddate");
            entity.Property(e => e.TinNo)
                .HasMaxLength(50)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("tin_no");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("title");
            entity.Property(e => e.Titleid).HasColumnName("titleid");
            entity.Property(e => e.Trial230)
                .HasMaxLength(1)
                .HasColumnName("trial230");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Vendorid).HasColumnName("vendorid");
        });

        modelBuilder.Entity<Employeeloan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_employeeloan");

            entity.ToTable("employeeloan");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Clientid).HasColumnName("clientid");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Employeeid).HasColumnName("employeeid");
            entity.Property(e => e.Enddate)
                .IsRequired()
                .HasColumnName("enddate");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Loanamount)
                .HasPrecision(18, 2)
                .HasColumnName("loanamount");
            entity.Property(e => e.Outstandingloanamount)
                .HasPrecision(18, 2)
                .HasColumnName("outstandingloanamount");
            entity.Property(e => e.Precentdeduction)
                .HasPrecision(18, 2)
                .HasColumnName("precentdeduction");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Startdate)
                .IsRequired()
                .HasColumnName("startdate");
            entity.Property(e => e.Trial237)
                .HasMaxLength(1)
                .HasColumnName("trial237");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
        });

        modelBuilder.Entity<Employeetimesheet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_employeetimesheet");

            entity.ToTable("employeetimesheet");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Absenthrs)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("absenthrs");
            entity.Property(e => e.Allowance)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("allowance");
            entity.Property(e => e.AllowanceDesert)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("allowance_desert");
            entity.Property(e => e.AllowancePerdium)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("allowance_perdium");
            entity.Property(e => e.Allowancetypes)
                .HasMaxLength(200)
                .HasColumnName("allowancetypes");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Basicsalary)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("basicsalary");
            entity.Property(e => e.Costsharing)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("costsharing");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Deptid).HasColumnName("deptid");
            entity.Property(e => e.Deptname)
                .HasMaxLength(100)
                .HasColumnName("deptname");
            entity.Property(e => e.DesertAllowanceDays)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("desert_allowance_days");
            entity.Property(e => e.Employeefamilybankaccount)
                .HasMaxLength(100)
                .HasColumnName("employeefamilybankaccount");
            entity.Property(e => e.Employeefamilybankname)
                .HasMaxLength(100)
                .HasColumnName("employeefamilybankname");
            entity.Property(e => e.Employeefamilyname)
                .HasMaxLength(100)
                .HasColumnName("employeefamilyname");
            entity.Property(e => e.Employeeid)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("employeeid");
            entity.Property(e => e.Employeename)
                .HasMaxLength(200)
                .HasColumnName("employeename");
            entity.Property(e => e.Employeepension)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("employeepension");
            entity.Property(e => e.Employerpension)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("employerpension");
            entity.Property(e => e.Familyallotment)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("familyallotment");
            entity.Property(e => e.FoodDeduction)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("food_deduction");
            entity.Property(e => e.Grosssalary)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("grosssalary");
            entity.Property(e => e.Hasloan)
                .HasDefaultValueSql("false")
                .HasColumnName("hasloan");
            entity.Property(e => e.Holidayovertimes)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("holidayovertimes");
            entity.Property(e => e.Hourlyperdiemrate)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("hourlyperdiemrate");
            entity.Property(e => e.Hourlyrate)
                .HasPrecision(18, 2)
                .HasColumnName("hourlyrate");
            entity.Property(e => e.Isactive)
                .HasDefaultValueSql("false")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted)
                .HasDefaultValueSql("false")
                .HasColumnName("isdeleted");
            entity.Property(e => e.Isprinted)
                .HasDefaultValueSql("false")
                .HasColumnName("isprinted");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Issendtobill)
                .HasDefaultValueSql("false")
                .HasColumnName("issendtobill");
            entity.Property(e => e.Issubmitted)
                .HasDefaultValueSql("false")
                .HasColumnName("issubmitted");
            entity.Property(e => e.Loanamount)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("loanamount");
            entity.Property(e => e.Loandeduction)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("loandeduction");
            entity.Property(e => e.Loanstartperiod)
                .HasDefaultValueSql("0")
                .HasColumnName("loanstartperiod");
            entity.Property(e => e.Netpay)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("netpay");
            entity.Property(e => e.Nightovertimes)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("nightovertimes");
            entity.Property(e => e.Paidperiods)
                .HasDefaultValueSql("0")
                .HasColumnName("paidperiods");
            entity.Property(e => e.Paymentperiod)
                .HasDefaultValueSql("0")
                .HasColumnName("paymentperiod");
            entity.Property(e => e.Percentdeduction)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("percentdeduction");
            entity.Property(e => e.Perdiemhours)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("perdiemhours");
            entity.Property(e => e.Perdiempayment)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("perdiempayment");
            entity.Property(e => e.Period).HasColumnName("period");
            entity.Property(e => e.Printbatchno)
                .HasDefaultValueSql("0")
                .HasColumnName("printbatchno");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Projectname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("projectname");
            entity.Property(e => e.Reason)
                .HasMaxLength(200)
                .HasColumnName("reason");
            entity.Property(e => e.Regularhours)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("208")
                .HasColumnName("regularhours");
            entity.Property(e => e.Regularpayment)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("regularpayment");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Salary)
                .HasPrecision(18, 2)
                .HasColumnName("salary");
            entity.Property(e => e.Tax)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("tax");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
            entity.Property(e => e.Totaldeduction)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("totaldeduction");
            entity.Property(e => e.Totalovertimepayment)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("totalovertimepayment");
            entity.Property(e => e.Totalpayment)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("totalpayment");
            entity.Property(e => e.Trial237)
                .HasMaxLength(1)
                .HasColumnName("trial237");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Weekdayovertimes)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("weekdayovertimes");
            entity.Property(e => e.Weekendovertimes)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("weekendovertimes");
        });

        modelBuilder.Entity<Employeetsperiod>(entity =>
        {
            entity.HasKey(e => e.TsPeriod).HasName("pk_employeetsperiod");

            entity.ToTable("employeetsperiod");

            entity.Property(e => e.TsPeriod)
                .ValueGeneratedNever()
                .HasColumnName("ts_period");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createdtime)
                .HasMaxLength(50)
                .HasColumnName("createdtime");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.Trial257)
                .HasMaxLength(1)
                .HasColumnName("trial257");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updateddate");
        });

        modelBuilder.Entity<Engautobudget>(entity =>
        {
            entity.HasKey(e => e.Autono).HasName("pk_engautobudget");

            entity.ToTable("engautobudget");

            entity.Property(e => e.Autono).HasColumnName("autono");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Trial260)
                .HasMaxLength(1)
                .HasColumnName("trial260");
        });

        modelBuilder.Entity<Engautogrn>(entity =>
        {
            entity.HasKey(e => e.Autono).HasName("pk_engautogrn");

            entity.ToTable("engautogrn");

            entity.Property(e => e.Autono).HasColumnName("autono");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Trial263)
                .HasMaxLength(1)
                .HasColumnName("trial263");
        });

        modelBuilder.Entity<Engbudget>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_engbudget");

            entity.ToTable("engbudget");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApprovedAmount)
                .HasPrecision(18, 2)
                .HasColumnName("approved_amount");
            entity.Property(e => e.ApprovedBy).HasColumnName("approved_by");
            entity.Property(e => e.BudgetPeriod).HasColumnName("budget_period");
            entity.Property(e => e.BudgetType)
                .HasMaxLength(20)
                .HasColumnName("budget_type");
            entity.Property(e => e.Checked)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("checked");
            entity.Property(e => e.Descr)
                .HasMaxLength(100)
                .HasColumnName("descr");
            entity.Property(e => e.Expecteddate).HasColumnName("expecteddate");
            entity.Property(e => e.PlateNo)
                .HasMaxLength(20)
                .HasColumnName("plate_no");
            entity.Property(e => e.Project).HasColumnName("project");
            entity.Property(e => e.ReceivedBy)
                .HasMaxLength(300)
                .HasColumnName("received_by");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.RequestId).HasColumnName("request_id");
            entity.Property(e => e.RequestedAmount)
                .HasPrecision(18, 2)
                .HasColumnName("requested_amount");
            entity.Property(e => e.Subcontractor).HasColumnName("subcontractor");
            entity.Property(e => e.Trdate).HasColumnName("trdate");
            entity.Property(e => e.Trial266)
                .HasMaxLength(1)
                .HasColumnName("trial266");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<Engbudgetauto>(entity =>
        {
            entity.HasKey(e => e.Autono).HasName("pk_tblbudgetauto");

            entity.ToTable("engbudgetauto");

            entity.Property(e => e.Autono).HasColumnName("autono");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Trial266)
                .HasMaxLength(1)
                .HasColumnName("trial266");
        });

        modelBuilder.Entity<EngeqTimesheet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_engeq_timesheet");

            entity.ToTable("engeq_timesheet");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AfternoonOpHr).HasColumnName("afternoon_op_hr");
            entity.Property(e => e.AfternoonOpMin).HasColumnName("afternoon_op_min");
            entity.Property(e => e.AfternoonetH).HasColumnName("afternoonet_h");
            entity.Property(e => e.AfternoonetM).HasColumnName("afternoonet_m");
            entity.Property(e => e.AfternoonstH).HasColumnName("afternoonst_h");
            entity.Property(e => e.AfternoonstM).HasColumnName("afternoonst_m");
            entity.Property(e => e.Agreementid)
                .HasDefaultValueSql("0")
                .HasColumnName("agreementid");
            entity.Property(e => e.Agreementname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("agreementname");
            entity.Property(e => e.Amount)
                .HasPrecision(18, 2)
                .HasColumnName("amount");
            entity.Property(e => e.ApprovedBy).HasColumnName("approved_by");
            entity.Property(e => e.ApprovedTime)
                .HasMaxLength(30)
                .HasColumnName("approved_time");
            entity.Property(e => e.Approvedby1)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.AuthorizedBy).HasColumnName("authorized_by");
            entity.Property(e => e.AuthorizedTime)
                .HasMaxLength(30)
                .HasColumnName("authorized_time");
            entity.Property(e => e.Billgroupid)
                .HasMaxLength(50)
                .HasDefaultValueSql("'1'::character varying")
                .HasColumnName("billgroupid");
            entity.Property(e => e.ChkNight).HasColumnName("chk_night");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.CreatedTime)
                .HasMaxLength(30)
                .HasColumnName("created_time");
            entity.Property(e => e.Createdby1)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.DateRent).HasColumnName("date_rent");
            entity.Property(e => e.DownH).HasColumnName("down_h");
            entity.Property(e => e.DownM).HasColumnName("down_m");
            entity.Property(e => e.EqName)
                .HasMaxLength(30)
                .HasColumnName("eq_name");
            entity.Property(e => e.Fuelprice)
                .HasPrecision(18, 2)
                .HasColumnName("fuelprice");
            entity.Property(e => e.Fueltaken)
                .HasPrecision(18, 2)
                .HasColumnName("fueltaken");
            entity.Property(e => e.Fueltype)
                .HasMaxLength(50)
                .HasColumnName("fueltype");
            entity.Property(e => e.IdleHPaid).HasColumnName("idle_h_paid");
            entity.Property(e => e.IdleHUnpaid).HasColumnName("idle_h_unpaid");
            entity.Property(e => e.IdleMPaid).HasColumnName("idle_m_paid");
            entity.Property(e => e.IdleMUnpaid).HasColumnName("idle_m_unpaid");
            entity.Property(e => e.IdleRate)
                .HasPrecision(16, 2)
                .HasColumnName("idle_rate");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdatafromsite)
                .HasDefaultValueSql("false")
                .HasColumnName("isdatafromsite");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Issendtobill)
                .HasDefaultValueSql("false")
                .HasColumnName("issendtobill");
            entity.Property(e => e.LocationEnd)
                .HasMaxLength(50)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("location_end");
            entity.Property(e => e.LocationStart)
                .HasMaxLength(50)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("location_start");
            entity.Property(e => e.Machineryid).HasColumnName("machineryid");
            entity.Property(e => e.Managerid).HasColumnName("managerid");
            entity.Property(e => e.Managername)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("managername");
            entity.Property(e => e.Mcomment)
                .HasMaxLength(100)
                .HasColumnName("mcomment");
            entity.Property(e => e.MinH).HasColumnName("min_h");
            entity.Property(e => e.MinM).HasColumnName("min_m");
            entity.Property(e => e.MorningOpHrs).HasColumnName("morning_op_hrs");
            entity.Property(e => e.MorningOpMin).HasColumnName("morning_op_min");
            entity.Property(e => e.MorningetH).HasColumnName("morninget_h");
            entity.Property(e => e.MorningetM).HasColumnName("morninget_m");
            entity.Property(e => e.MorningstH).HasColumnName("morningst_h");
            entity.Property(e => e.MorningstM).HasColumnName("morningst_m");
            entity.Property(e => e.Odometerreading).HasColumnName("odometerreading");
            entity.Property(e => e.Operator)
                .HasMaxLength(30)
                .HasColumnName("operator");
            entity.Property(e => e.Owner)
                .HasMaxLength(100)
                .HasColumnName("owner");
            entity.Property(e => e.Ownerid).HasColumnName("ownerid");
            entity.Property(e => e.Payitem)
                .HasMaxLength(50)
                .HasDefaultValueSql("'None'::character varying")
                .HasColumnName("payitem");
            entity.Property(e => e.PayitemDescr)
                .HasMaxLength(300)
                .HasDefaultValueSql("'None'::character varying")
                .HasColumnName("payitem_descr");
            entity.Property(e => e.PeriodYearmonth).HasColumnName("period_yearmonth");
            entity.Property(e => e.PlateNo)
                .HasMaxLength(20)
                .HasColumnName("plate_no");
            entity.Property(e => e.ProjId).HasColumnName("proj_id");
            entity.Property(e => e.Projectname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("projectname");
            entity.Property(e => e.Rate)
                .HasPrecision(16, 2)
                .HasColumnName("rate");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.ReasonDown)
                .HasMaxLength(50)
                .HasColumnName("reason_down");
            entity.Property(e => e.ReasonIdle)
                .HasMaxLength(50)
                .HasColumnName("reason_idle");
            entity.Property(e => e.RemarkType)
                .HasMaxLength(10)
                .HasColumnName("remark_type");
            entity.Property(e => e.Reportedby)
                .HasMaxLength(100)
                .HasColumnName("reportedby");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.ScId).HasColumnName("sc_id");
            entity.Property(e => e.Siteid).HasColumnName("siteid");
            entity.Property(e => e.Sitename)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("sitename");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("0")
                .HasColumnName("status");
            entity.Property(e => e.TotalOpH).HasColumnName("total_op_h");
            entity.Property(e => e.TotalOpM).HasColumnName("total_op_m");
            entity.Property(e => e.TranDate).HasColumnName("tran_date");
            entity.Property(e => e.Trial270)
                .HasMaxLength(1)
                .HasColumnName("trial270");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Usedbyname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("usedbyname");
        });

        modelBuilder.Entity<Engexpense>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_engexpense");

            entity.ToTable("engexpense");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApprovedAmount)
                .HasPrecision(18, 2)
                .HasColumnName("approved_amount");
            entity.Property(e => e.BudApprovedby)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("bud_approvedby");
            entity.Property(e => e.BudCheckedby)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("bud_checkedby");
            entity.Property(e => e.Cash)
                .HasMaxLength(3)
                .HasDefaultValueSql("'NO'::character varying")
                .HasColumnName("cash");
            entity.Property(e => e.Checked)
                .HasMaxLength(3)
                .HasColumnName("checked");
            entity.Property(e => e.GrnNo).HasColumnName("grn_no");
            entity.Property(e => e.Iscreditpayment)
                .HasDefaultValueSql("false")
                .HasColumnName("iscreditpayment");
            entity.Property(e => e.Ispayrolltran)
                .HasDefaultValueSql("false")
                .HasColumnName("ispayrolltran");
            entity.Property(e => e.Isprojecttran)
                .HasDefaultValueSql("false")
                .HasColumnName("isprojecttran");
            entity.Property(e => e.Issendtobill)
                .HasDefaultValueSql("false")
                .HasColumnName("issendtobill");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.MtvDate).HasColumnName("mtv_date");
            entity.Property(e => e.MtvNo).HasColumnName("mtv_no");
            entity.Property(e => e.Paid)
                .HasMaxLength(3)
                .HasColumnName("paid");
            entity.Property(e => e.PayTo)
                .HasDefaultValueSql("1")
                .HasColumnName("pay_to");
            entity.Property(e => e.Period).HasColumnName("period");
            entity.Property(e => e.PlateNo)
                .HasMaxLength(50)
                .HasColumnName("plate_no");
            entity.Property(e => e.PrintRec)
                .HasMaxLength(3)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("print_rec");
            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.PvChecked)
                .HasMaxLength(3)
                .HasDefaultValueSql("'NO'::character varying")
                .HasColumnName("pv_checked");
            entity.Property(e => e.PvEnteredby).HasColumnName("pv_enteredby");
            entity.Property(e => e.PvNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("pv_no");
            entity.Property(e => e.Qty)
                .HasPrecision(18, 2)
                .HasColumnName("qty");
            entity.Property(e => e.RecStatus)
                .HasMaxLength(3)
                .HasColumnName("rec_status");
            entity.Property(e => e.RecordType)
                .HasMaxLength(3)
                .HasColumnName("record_type");
            entity.Property(e => e.Ref).HasColumnName("ref");
            entity.Property(e => e.Remark)
                .HasMaxLength(1000)
                .HasColumnName("remark");
            entity.Property(e => e.Reqid).HasColumnName("reqid");
            entity.Property(e => e.Subcontractor).HasColumnName("subcontractor");
            entity.Property(e => e.TranValid)
                .HasMaxLength(3)
                .HasColumnName("tran_valid");
            entity.Property(e => e.Trial332)
                .HasMaxLength(1)
                .HasColumnName("trial332");
            entity.Property(e => e.UnitPrice)
                .HasPrecision(18, 2)
                .HasColumnName("unit_price");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<EngfinTimesheet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_engfin_timesheet");

            entity.ToTable("engfin_timesheet");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AfternoonOpHr).HasColumnName("afternoon_op_hr");
            entity.Property(e => e.AfternoonOpMin).HasColumnName("afternoon_op_min");
            entity.Property(e => e.AfternoonetH).HasColumnName("afternoonet_h");
            entity.Property(e => e.AfternoonetM).HasColumnName("afternoonet_m");
            entity.Property(e => e.AfternoonstH).HasColumnName("afternoonst_h");
            entity.Property(e => e.AfternoonstM).HasColumnName("afternoonst_m");
            entity.Property(e => e.Agreementid)
                .HasDefaultValueSql("0")
                .HasColumnName("agreementid");
            entity.Property(e => e.Agreementname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("agreementname");
            entity.Property(e => e.Amount)
                .HasPrecision(18, 2)
                .HasColumnName("amount");
            entity.Property(e => e.ApprovedBy).HasColumnName("approved_by");
            entity.Property(e => e.ApprovedTime)
                .HasMaxLength(30)
                .HasColumnName("approved_time");
            entity.Property(e => e.Approvedby1)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.AuthorizedBy).HasColumnName("authorized_by");
            entity.Property(e => e.AuthorizedTime)
                .HasMaxLength(30)
                .HasColumnName("authorized_time");
            entity.Property(e => e.Billgroupid)
                .HasMaxLength(50)
                .HasDefaultValueSql("'1'::character varying")
                .HasColumnName("billgroupid");
            entity.Property(e => e.ChkNight).HasColumnName("chk_night");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.CreatedTime)
                .HasMaxLength(30)
                .HasColumnName("created_time");
            entity.Property(e => e.Createdby1)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.DateRent).HasColumnName("date_rent");
            entity.Property(e => e.DownH).HasColumnName("down_h");
            entity.Property(e => e.DownM).HasColumnName("down_m");
            entity.Property(e => e.EqName)
                .HasMaxLength(30)
                .HasColumnName("eq_name");
            entity.Property(e => e.Fuelprice)
                .HasPrecision(18, 2)
                .HasColumnName("fuelprice");
            entity.Property(e => e.Fueltaken)
                .HasPrecision(18, 2)
                .HasColumnName("fueltaken");
            entity.Property(e => e.Fueltype)
                .HasMaxLength(50)
                .HasColumnName("fueltype");
            entity.Property(e => e.IdleHPaid).HasColumnName("idle_h_paid");
            entity.Property(e => e.IdleHUnpaid).HasColumnName("idle_h_unpaid");
            entity.Property(e => e.IdleMPaid).HasColumnName("idle_m_paid");
            entity.Property(e => e.IdleMUnpaid).HasColumnName("idle_m_unpaid");
            entity.Property(e => e.IdleRate)
                .HasPrecision(16, 2)
                .HasColumnName("idle_rate");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdatafromsite)
                .HasDefaultValueSql("false")
                .HasColumnName("isdatafromsite");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Issendtobill)
                .HasDefaultValueSql("false")
                .HasColumnName("issendtobill");
            entity.Property(e => e.LocationEnd)
                .HasMaxLength(50)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("location_end");
            entity.Property(e => e.LocationStart)
                .HasMaxLength(50)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("location_start");
            entity.Property(e => e.Machineryid).HasColumnName("machineryid");
            entity.Property(e => e.Managerid).HasColumnName("managerid");
            entity.Property(e => e.Managername)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("managername");
            entity.Property(e => e.Mcomment)
                .HasMaxLength(100)
                .HasColumnName("mcomment");
            entity.Property(e => e.MinH).HasColumnName("min_h");
            entity.Property(e => e.MinM).HasColumnName("min_m");
            entity.Property(e => e.MorningOpHrs).HasColumnName("morning_op_hrs");
            entity.Property(e => e.MorningOpMin).HasColumnName("morning_op_min");
            entity.Property(e => e.MorningetH).HasColumnName("morninget_h");
            entity.Property(e => e.MorningetM).HasColumnName("morninget_m");
            entity.Property(e => e.MorningstH).HasColumnName("morningst_h");
            entity.Property(e => e.MorningstM).HasColumnName("morningst_m");
            entity.Property(e => e.Odometerreading).HasColumnName("odometerreading");
            entity.Property(e => e.Operator)
                .HasMaxLength(30)
                .HasColumnName("operator");
            entity.Property(e => e.Owner)
                .HasMaxLength(100)
                .HasColumnName("owner");
            entity.Property(e => e.Ownerid).HasColumnName("ownerid");
            entity.Property(e => e.Payitem)
                .HasMaxLength(50)
                .HasDefaultValueSql("'None'::character varying")
                .HasColumnName("payitem");
            entity.Property(e => e.PayitemDescr)
                .HasMaxLength(300)
                .HasDefaultValueSql("'None'::character varying")
                .HasColumnName("payitem_descr");
            entity.Property(e => e.PeriodYearmonth).HasColumnName("period_yearmonth");
            entity.Property(e => e.PlateNo)
                .HasMaxLength(20)
                .HasColumnName("plate_no");
            entity.Property(e => e.ProjId).HasColumnName("proj_id");
            entity.Property(e => e.Projectname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("projectname");
            entity.Property(e => e.Rate)
                .HasPrecision(16, 2)
                .HasColumnName("rate");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.ReasonDown)
                .HasMaxLength(50)
                .HasColumnName("reason_down");
            entity.Property(e => e.ReasonIdle)
                .HasMaxLength(50)
                .HasColumnName("reason_idle");
            entity.Property(e => e.RemarkType)
                .HasMaxLength(10)
                .HasColumnName("remark_type");
            entity.Property(e => e.Reportedby)
                .HasMaxLength(100)
                .HasColumnName("reportedby");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.ScId).HasColumnName("sc_id");
            entity.Property(e => e.Siteid).HasColumnName("siteid");
            entity.Property(e => e.Sitename)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("sitename");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("0")
                .HasColumnName("status");
            entity.Property(e => e.TotalOpH).HasColumnName("total_op_h");
            entity.Property(e => e.TotalOpM).HasColumnName("total_op_m");
            entity.Property(e => e.TranDate).HasColumnName("tran_date");
            entity.Property(e => e.Trial351)
                .HasMaxLength(1)
                .HasColumnName("trial351");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Usedbyname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("usedbyname");
        });

        modelBuilder.Entity<Engmaterial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_engmaterial");

            entity.ToTable("engmaterial");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Checked)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("checked");
            entity.Property(e => e.GrnNo).HasColumnName("grn_no");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.MtvDate).HasColumnName("mtv_date");
            entity.Property(e => e.MtvNo).HasColumnName("mtv_no");
            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.Qty)
                .HasPrecision(18)
                .HasColumnName("qty");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Trial403)
                .HasMaxLength(1)
                .HasColumnName("trial403");
            entity.Property(e => e.Unitprice)
                .HasPrecision(16, 2)
                .HasColumnName("unitprice");
        });

        modelBuilder.Entity<Engpayment>(entity =>
        {
            entity.HasKey(e => e.ReqId).HasName("pk_engpayment");

            entity.ToTable("engpayment");

            entity.Property(e => e.ReqId).HasColumnName("req_id");
            entity.Property(e => e.Amount)
                .HasPrecision(16, 2)
                .HasColumnName("amount");
            entity.Property(e => e.AmountPercent).HasColumnName("amount_percent");
            entity.Property(e => e.ApprovedAmount)
                .HasPrecision(16, 2)
                .HasColumnName("approved_amount");
            entity.Property(e => e.BudgetMonth)
                .HasMaxLength(3)
                .HasColumnName("budget_month");
            entity.Property(e => e.BudgetYear).HasColumnName("budget_year");
            entity.Property(e => e.Descr)
                .HasMaxLength(50)
                .HasColumnName("descr");
            entity.Property(e => e.Expecteddate).HasColumnName("expecteddate");
            entity.Property(e => e.PaidAmount)
                .HasPrecision(16, 2)
                .HasColumnName("paid_amount");
            entity.Property(e => e.Project).HasColumnName("project");
            entity.Property(e => e.Pvno)
                .HasMaxLength(20)
                .HasColumnName("pvno");
            entity.Property(e => e.PydDate).HasColumnName("pyd_date");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.SubContractor).HasColumnName("sub_contractor");
            entity.Property(e => e.Trdate).HasColumnName("trdate");
            entity.Property(e => e.Trial403)
                .HasMaxLength(1)
                .HasColumnName("trial403");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<Engstatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_engstatus");

            entity.ToTable("engstatus");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.StatusDesc)
                .HasMaxLength(20)
                .HasColumnName("status_desc");
            entity.Property(e => e.Trial403)
                .HasMaxLength(1)
                .HasColumnName("trial403");
        });

        modelBuilder.Entity<Engstoretran>(entity =>
        {
            entity.HasKey(e => e.Stid).HasName("pk_engstoretran");

            entity.ToTable("engstoretran");

            entity.Property(e => e.Stid).HasColumnName("stid");
            entity.Property(e => e.AppDate).HasColumnName("app_date");
            entity.Property(e => e.AppUser).HasColumnName("app_user");
            entity.Property(e => e.Catid).HasColumnName("catid");
            entity.Property(e => e.Checked).HasColumnName("checked");
            entity.Property(e => e.GrnsivNo)
                .HasMaxLength(20)
                .HasColumnName("grnsiv_no");
            entity.Property(e => e.ItemDesc)
                .HasMaxLength(150)
                .HasColumnName("item_desc");
            entity.Property(e => e.Itemid)
                .HasDefaultValueSql("0")
                .HasColumnName("itemid");
            entity.Property(e => e.MtvNo)
                .HasMaxLength(20)
                .HasColumnName("mtv_no");
            entity.Property(e => e.PlateNo)
                .HasMaxLength(20)
                .HasColumnName("plate_no");
            entity.Property(e => e.Project).HasColumnName("project");
            entity.Property(e => e.Qtyiss)
                .HasPrecision(14, 2)
                .HasColumnName("qtyiss");
            entity.Property(e => e.Qtyrcvd)
                .HasPrecision(14, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("qtyrcvd");
            entity.Property(e => e.RcvdBy)
                .HasMaxLength(30)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("rcvd_by");
            entity.Property(e => e.RcvdFrom)
                .HasMaxLength(30)
                .HasColumnName("rcvd_from");
            entity.Property(e => e.RecType)
                .HasMaxLength(3)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("rec_type");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Reqid).HasColumnName("reqid");
            entity.Property(e => e.SivGrn)
                .HasMaxLength(50)
                .HasColumnName("siv_grn");
            entity.Property(e => e.StoreId).HasColumnName("store_id");
            entity.Property(e => e.Subcontractor).HasColumnName("subcontractor");
            entity.Property(e => e.Supplier)
                .HasMaxLength(30)
                .HasColumnName("supplier");
            entity.Property(e => e.Trdate).HasColumnName("trdate");
            entity.Property(e => e.Trial407)
                .HasMaxLength(1)
                .HasColumnName("trial407");
            entity.Property(e => e.Unitprice)
                .HasPrecision(14, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("unitprice");
            entity.Property(e => e.Uom)
                .HasMaxLength(10)
                .HasColumnName("uom");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VatExcl).HasColumnName("vat_excl");
        });

        modelBuilder.Entity<Engsubcontractor>(entity =>
        {
            entity.HasKey(e => e.Scid).HasName("pk_engsubcontractor");

            entity.ToTable("engsubcontractor");

            entity.Property(e => e.Scid).HasColumnName("scid");
            entity.Property(e => e.Issc)
                .HasMaxLength(3)
                .HasColumnName("issc");
            entity.Property(e => e.Isstore)
                .HasMaxLength(3)
                .HasColumnName("isstore");
            entity.Property(e => e.Project).HasColumnName("project");
            entity.Property(e => e.ScName)
                .HasMaxLength(50)
                .HasColumnName("sc_name");
            entity.Property(e => e.SubCategory).HasColumnName("sub_category");
            entity.Property(e => e.Trial407)
                .HasMaxLength(1)
                .HasColumnName("trial407");
        });

        modelBuilder.Entity<Eqauto>(entity =>
        {
            entity.HasKey(e => e.Autono).HasName("pk_eqauto");

            entity.ToTable("eqauto");

            entity.Property(e => e.Autono).HasColumnName("autono");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Trial410)
                .HasMaxLength(1)
                .HasColumnName("trial410");
        });

        modelBuilder.Entity<Eqcontract>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_eqcontract");

            entity.ToTable("eqcontract");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Capacity)
                .HasPrecision(18, 2)
                .HasColumnName("capacity");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.DateEntered).HasColumnName("date_entered");
            entity.Property(e => e.EquipmentName)
                .HasMaxLength(100)
                .HasColumnName("equipment_name");
            entity.Property(e => e.PlateNo)
                .HasMaxLength(20)
                .HasColumnName("plate_no");
            entity.Property(e => e.Project).HasColumnName("project");
            entity.Property(e => e.Rentrate05)
                .HasPrecision(18, 2)
                .HasColumnName("rentrate0_5");
            entity.Property(e => e.Rentrate1015)
                .HasPrecision(18, 2)
                .HasColumnName("rentrate10_15");
            entity.Property(e => e.Rentrate15More)
                .HasPrecision(18, 2)
                .HasColumnName("rentrate15_more");
            entity.Property(e => e.Rentrate57)
                .HasPrecision(18, 2)
                .HasColumnName("rentrate5_7");
            entity.Property(e => e.Rentrate710)
                .HasPrecision(18, 2)
                .HasColumnName("rentrate7_10");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.Trial410)
                .HasMaxLength(1)
                .HasColumnName("trial410");
        });

        modelBuilder.Entity<Eqoutsource>(entity =>
        {
            entity.HasKey(e => e.Workorderno).HasName("pk_eqoutsource");

            entity.ToTable("eqoutsource");

            entity.Property(e => e.Workorderno).HasColumnName("workorderno");
            entity.Property(e => e.CompletionDate).HasColumnName("completion_date");
            entity.Property(e => e.LabourCost)
                .HasPrecision(18, 2)
                .HasColumnName("labour_cost");
            entity.Property(e => e.MaterialCost)
                .HasPrecision(18, 2)
                .HasColumnName("material_cost");
            entity.Property(e => e.QuotationId).HasColumnName("quotation_id");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Sendto).HasColumnName("sendto");
            entity.Property(e => e.Trial413)
                .HasMaxLength(1)
                .HasColumnName("trial413");
            entity.Property(e => e.Vat)
                .HasPrecision(18, 2)
                .HasColumnName("vat");
        });

        modelBuilder.Entity<Equipmenttype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_equipmenttype");

            entity.ToTable("equipmenttype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.Isactive)
                .IsRequired()
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Trial413)
                .HasMaxLength(1)
                .HasColumnName("trial413");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
        });

        modelBuilder.Entity<Eqworkshop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_eqworkshop");

            entity.ToTable("eqworkshop");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Qty)
                .HasPrecision(18, 2)
                .HasColumnName("qty");
            entity.Property(e => e.QuotationId).HasColumnName("quotation_id");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Trial417)
                .HasMaxLength(1)
                .HasColumnName("trial417");
        });

        modelBuilder.Entity<Expense>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_expense");

            entity.ToTable("expense");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accountid)
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("accountid");
            entity.Property(e => e.Advice)
                .HasDefaultValueSql("false")
                .HasColumnName("advice");
            entity.Property(e => e.Agreementid)
                .HasDefaultValueSql("0")
                .HasColumnName("agreementid");
            entity.Property(e => e.Agreementname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("agreementname");
            entity.Property(e => e.Agreementtypeid)
                .HasDefaultValueSql("0")
                .HasColumnName("agreementtypeid");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Auditedby)
                .HasMaxLength(50)
                .HasColumnName("auditedby");
            entity.Property(e => e.Bankid).HasColumnName("bankid");
            entity.Property(e => e.Bankname)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("bankname");
            entity.Property(e => e.Bankstatementid)
                .HasDefaultValueSql("0")
                .HasColumnName("bankstatementid");
            entity.Property(e => e.Billamount)
                .HasPrecision(18, 2)
                .HasColumnName("billamount");
            entity.Property(e => e.Billid).HasColumnName("billid");
            entity.Property(e => e.Billname)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("billname");
            entity.Property(e => e.Checknumber)
                .IsRequired()
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("checknumber");
            entity.Property(e => e.Checktype)
                .HasMaxLength(50)
                .HasDefaultValueSql("'Check'::character varying")
                .HasColumnName("checktype");
            entity.Property(e => e.ContractAgreement)
                .HasDefaultValueSql("false")
                .HasColumnName("contract_agreement");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.ErpDate).HasColumnName("erp_date");
            entity.Property(e => e.ErpPeriod).HasColumnName("erp_period");
            entity.Property(e => e.Hascompletedocument)
                .HasDefaultValueSql("false")
                .HasColumnName("hascompletedocument");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isforprint)
                .HasDefaultValueSql("false")
                .HasColumnName("isforprint");
            entity.Property(e => e.Ispostdated)
                .HasDefaultValueSql("false")
                .HasColumnName("ispostdated");
            entity.Property(e => e.Isprinted)
                .HasDefaultValueSql("false")
                .HasColumnName("isprinted");
            entity.Property(e => e.Isreceivedbyarchive)
                .HasDefaultValueSql("false")
                .HasColumnName("isreceivedbyarchive");
            entity.Property(e => e.Isreconcile)
                .HasDefaultValueSql("false")
                .HasColumnName("isreconcile");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Managerid)
                .HasDefaultValueSql("0")
                .HasColumnName("managerid");
            entity.Property(e => e.Managername)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("managername");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("name");
            entity.Property(e => e.Nameoncheck)
                .HasMaxLength(100)
                .HasColumnName("nameoncheck");
            entity.Property(e => e.NoneVatRct)
                .HasDefaultValueSql("false")
                .HasColumnName("none_vat_rct");
            entity.Property(e => e.OtherDocument)
                .HasMaxLength(200)
                .HasColumnName("other_document");
            entity.Property(e => e.Ownercashieragent)
                .HasMaxLength(50)
                .HasDefaultValueSql("'Owner'::character varying")
                .HasColumnName("ownercashieragent");
            entity.Property(e => e.Payeeid).HasColumnName("payeeid");
            entity.Property(e => e.Payeename)
                .IsRequired()
                .HasMaxLength(200)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("payeename");
            entity.Property(e => e.Payeestatus)
                .HasMaxLength(50)
                .HasColumnName("payeestatus");
            entity.Property(e => e.Payeestatusid).HasColumnName("payeestatusid");
            entity.Property(e => e.Payeestatusname)
                .HasMaxLength(100)
                .HasColumnName("payeestatusname");
            entity.Property(e => e.Paymentamount)
                .HasPrecision(18, 2)
                .HasColumnName("paymentamount");
            entity.Property(e => e.Paymentdate)
                .IsRequired()
                .HasColumnName("paymentdate");
            entity.Property(e => e.Paymentforid).HasColumnName("paymentforid");
            entity.Property(e => e.Paymentforname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("paymentforname");
            entity.Property(e => e.Paymenttype)
                .HasMaxLength(3)
                .HasColumnName("paymenttype");
            entity.Property(e => e.PerdiumLetter)
                .HasDefaultValueSql("false")
                .HasColumnName("perdium_letter");
            entity.Property(e => e.PowerOfAttorney)
                .HasDefaultValueSql("false")
                .HasColumnName("power_of_attorney");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Projectname)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("projectname");
            entity.Property(e => e.PvNo)
                .HasMaxLength(20)
                .HasColumnName("pv_no");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Receiptnumber)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("receiptnumber");
            entity.Property(e => e.Reconcileby)
                .HasMaxLength(50)
                .HasColumnName("reconcileby");
            entity.Property(e => e.Reconcileperiod)
                .HasDefaultValueSql("0")
                .HasColumnName("reconcileperiod");
            entity.Property(e => e.Remark)
                .HasMaxLength(300)
                .HasColumnName("remark");
            entity.Property(e => e.ReqId).HasColumnName("req_id");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Signername)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("signername");
            entity.Property(e => e.TinCerteficate)
                .HasDefaultValueSql("false")
                .HasColumnName("tin_certeficate");
            entity.Property(e => e.TradeLicense)
                .HasDefaultValueSql("false")
                .HasColumnName("trade_license");
            entity.Property(e => e.Trial417)
                .HasMaxLength(1)
                .HasColumnName("trial417");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Vat)
                .HasPrecision(18, 2)
                .HasColumnName("vat");
            entity.Property(e => e.VatCerteficate)
                .HasDefaultValueSql("false")
                .HasColumnName("vat_certeficate");
            entity.Property(e => e.VatRct)
                .HasDefaultValueSql("false")
                .HasColumnName("vat_rct");
            entity.Property(e => e.WhtRct)
                .HasDefaultValueSql("false")
                .HasColumnName("wht_rct");
            entity.Property(e => e.Withholding)
                .HasPrecision(18, 2)
                .HasColumnName("withholding");
        });

        modelBuilder.Entity<Expenserecovery>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_expenserecovery");

            entity.ToTable("expenserecovery");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Accountid)
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("accountid");
            entity.Property(e => e.Agreementid)
                .HasDefaultValueSql("0")
                .HasColumnName("agreementid");
            entity.Property(e => e.Agreementname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("agreementname");
            entity.Property(e => e.Agreementtypeid)
                .HasDefaultValueSql("0")
                .HasColumnName("agreementtypeid");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Bankid).HasColumnName("bankid");
            entity.Property(e => e.Bankname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("bankname");
            entity.Property(e => e.Billamount)
                .HasPrecision(18, 2)
                .HasColumnName("billamount");
            entity.Property(e => e.Billid)
                .HasDefaultValueSql("0")
                .HasColumnName("billid");
            entity.Property(e => e.Billname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("billname");
            entity.Property(e => e.Checknumber)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("checknumber");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.ErpDate).HasColumnName("erp_date");
            entity.Property(e => e.ErpPeriod).HasColumnName("erp_period");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Ispostdated)
                .HasDefaultValueSql("false")
                .HasColumnName("ispostdated");
            entity.Property(e => e.Isprinted)
                .HasDefaultValueSql("false")
                .HasColumnName("isprinted");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Managerid)
                .HasDefaultValueSql("0")
                .HasColumnName("managerid");
            entity.Property(e => e.Managername)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("managername");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("name");
            entity.Property(e => e.Payeeid)
                .HasDefaultValueSql("0")
                .HasColumnName("payeeid");
            entity.Property(e => e.Payeename)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("payeename");
            entity.Property(e => e.Paymentamount)
                .HasPrecision(18, 2)
                .HasColumnName("paymentamount");
            entity.Property(e => e.Paymentdate).HasColumnName("paymentdate");
            entity.Property(e => e.Paymentforid).HasColumnName("paymentforid");
            entity.Property(e => e.Paymentforname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("paymentforname");
            entity.Property(e => e.Paymenttype)
                .HasMaxLength(3)
                .HasColumnName("paymenttype");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Projectname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("projectname");
            entity.Property(e => e.PvNo)
                .HasMaxLength(20)
                .HasColumnName("pv_no");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Receiptnumber)
                .HasMaxLength(100)
                .HasColumnName("receiptnumber");
            entity.Property(e => e.ReqId).HasColumnName("req_id");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Signername)
                .HasMaxLength(100)
                .HasColumnName("signername");
            entity.Property(e => e.Trial430)
                .HasMaxLength(1)
                .HasColumnName("trial430");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Vat)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vat");
            entity.Property(e => e.Withholding)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("withholding");
        });

        modelBuilder.Entity<FaAllocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_fa_allocation");

            entity.ToTable("fa_allocation");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Checked)
                .HasMaxLength(3)
                .HasColumnName("checked");
            entity.Property(e => e.EqId)
                .HasMaxLength(20)
                .HasColumnName("eq_id");
            entity.Property(e => e.EstEndDate).HasColumnName("est_end_date");
            entity.Property(e => e.Ownership)
                .HasMaxLength(6)
                .HasColumnName("ownership");
            entity.Property(e => e.Project).HasColumnName("project");
            entity.Property(e => e.Reason)
                .HasMaxLength(200)
                .HasColumnName("reason");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.Trial436)
                .HasMaxLength(1)
                .HasColumnName("trial436");
            entity.Property(e => e.Userdept).HasColumnName("userdept");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<FaCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_fa_category");

            entity.ToTable("fa_category");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CatName)
                .HasMaxLength(50)
                .HasColumnName("cat_name");
            entity.Property(e => e.Trial436)
                .HasMaxLength(1)
                .HasColumnName("trial436");
        });

        modelBuilder.Entity<FaRegistry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_fa_registry");

            entity.ToTable("fa_registry");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CatId).HasColumnName("cat_id");
            entity.Property(e => e.Checked)
                .HasMaxLength(3)
                .HasColumnName("checked");
            entity.Property(e => e.EqId)
                .HasMaxLength(20)
                .HasColumnName("eq_id");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .HasColumnName("item_name");
            entity.Property(e => e.LifeTime).HasColumnName("life_time");
            entity.Property(e => e.OriginalCost)
                .HasPrecision(18, 2)
                .HasColumnName("original_cost");
            entity.Property(e => e.Project).HasColumnName("project");
            entity.Property(e => e.PurchaseDate).HasColumnName("purchase_date");
            entity.Property(e => e.Ref).HasColumnName("ref");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.SalvageValue)
                .HasPrecision(18, 2)
                .HasColumnName("salvage_value");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("status");
            entity.Property(e => e.Trial436)
                .HasMaxLength(1)
                .HasColumnName("trial436");
        });

        modelBuilder.Entity<GlForvendorreport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_gl_forvendorreport");

            entity.ToTable("gl_forvendorreport");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accounttype)
                .HasMaxLength(200)
                .HasColumnName("accounttype");
            entity.Property(e => e.GlAccount)
                .HasMaxLength(20)
                .HasColumnName("gl_account");
            entity.Property(e => e.GlDescription)
                .HasMaxLength(200)
                .HasColumnName("gl_description");
            entity.Property(e => e.Trial436)
                .HasMaxLength(1)
                .HasColumnName("trial436");
        });

        modelBuilder.Entity<Income>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_income");

            entity.ToTable("income");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accountid)
                .IsRequired()
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("accountid");
            entity.Property(e => e.Agreementid).HasColumnName("agreementid");
            entity.Property(e => e.Agreementname)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("agreementname");
            entity.Property(e => e.Agreementtypeid).HasColumnName("agreementtypeid");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Bankid).HasColumnName("bankid");
            entity.Property(e => e.Bankname)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("bankname");
            entity.Property(e => e.Billamount)
                .HasPrecision(18, 2)
                .HasColumnName("billamount");
            entity.Property(e => e.Billid).HasColumnName("billid");
            entity.Property(e => e.Billname)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("billname");
            entity.Property(e => e.Checknumber)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("checknumber");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.ErpDate).HasColumnName("erp_date");
            entity.Property(e => e.ErpPeriod).HasColumnName("erp_period");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isreconcile)
                .HasDefaultValueSql("false")
                .HasColumnName("isreconcile");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Managerid).HasColumnName("managerid");
            entity.Property(e => e.Managername)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("managername");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("name");
            entity.Property(e => e.Payerid).HasColumnName("payerid");
            entity.Property(e => e.Payername)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("payername");
            entity.Property(e => e.Paymentamount)
                .HasPrecision(18, 2)
                .HasColumnName("paymentamount");
            entity.Property(e => e.Paymentdate)
                .IsRequired()
                .HasColumnName("paymentdate");
            entity.Property(e => e.Paymentforid).HasColumnName("paymentforid");
            entity.Property(e => e.Paymentforname)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("paymentforname");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Projectname)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("projectname");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Receiptnumber)
                .IsRequired()
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("receiptnumber");
            entity.Property(e => e.Receivername)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("receivername");
            entity.Property(e => e.Reconcileby)
                .HasMaxLength(100)
                .HasColumnName("reconcileby");
            entity.Property(e => e.Reconcileperiod).HasColumnName("reconcileperiod");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Trial439)
                .HasMaxLength(1)
                .HasColumnName("trial439");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Vat)
                .HasPrecision(18, 2)
                .HasColumnName("vat");
            entity.Property(e => e.Withholding)
                .HasPrecision(18, 2)
                .HasColumnName("withholding");
        });

        modelBuilder.Entity<Invautosr>(entity =>
        {
            entity.HasKey(e => e.Autono).HasName("pk_invautosr");

            entity.ToTable("invautosr");

            entity.Property(e => e.Autono).HasColumnName("autono");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Trial443)
                .HasMaxLength(1)
                .HasColumnName("trial443");
        });

        modelBuilder.Entity<Invdeliverytran>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_invdeliverytran");

            entity.ToTable("invdeliverytran");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DeliveryType)
                .HasMaxLength(10)
                .HasColumnName("delivery_type");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Project).HasColumnName("project");
            entity.Property(e => e.Qty)
                .HasPrecision(18, 2)
                .HasColumnName("qty");
            entity.Property(e => e.RecType)
                .HasMaxLength(3)
                .HasColumnName("rec_type");
            entity.Property(e => e.Ref).HasColumnName("ref");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.TranDate).HasColumnName("tran_date");
            entity.Property(e => e.Trial446)
                .HasMaxLength(1)
                .HasColumnName("trial446");
            entity.Property(e => e.UnitPrice)
                .HasPrecision(18, 2)
                .HasColumnName("unit_price");
            entity.Property(e => e.Userid1).HasColumnName("userid1");
            entity.Property(e => e.Userid2).HasColumnName("userid2");
        });

        modelBuilder.Entity<Invdispatch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_invdispatch");

            entity.ToTable("invdispatch");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Applevel).HasColumnName("applevel");
            entity.Property(e => e.DeliveryType)
                .HasMaxLength(10)
                .HasColumnName("delivery_type");
            entity.Property(e => e.Employee).HasColumnName("employee");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Project).HasColumnName("project");
            entity.Property(e => e.Qty)
                .HasPrecision(18, 2)
                .HasColumnName("qty");
            entity.Property(e => e.QtyApp)
                .HasPrecision(18, 2)
                .HasColumnName("qty_app");
            entity.Property(e => e.Ref).HasColumnName("ref");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.Subcontractor).HasColumnName("subcontractor");
            entity.Property(e => e.TrDate).HasColumnName("tr_date");
            entity.Property(e => e.Trial452)
                .HasMaxLength(1)
                .HasColumnName("trial452");
            entity.Property(e => e.Userid2).HasColumnName("userid2");
        });

        modelBuilder.Entity<Invpurchaser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_invpurchaser");

            entity.ToTable("invpurchaser");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Craeteddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("craeteddate");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .HasColumnName("createdby");
            entity.Property(e => e.GlAccount)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("gl_account");
            entity.Property(e => e.Ispurchaser).HasColumnName("ispurchaser");
            entity.Property(e => e.Pass)
                .HasMaxLength(12)
                .HasColumnName("pass");
            entity.Property(e => e.PurchaserName)
                .HasMaxLength(30)
                .HasColumnName("purchaser_name");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.Trial456)
                .HasMaxLength(1)
                .HasColumnName("trial456");
        });

        modelBuilder.Entity<Invstoreman>(entity =>
        {
            entity.HasKey(e => e.Storemanid).HasName("pk_invstoreman");

            entity.ToTable("invstoreman");

            entity.Property(e => e.Storemanid).HasColumnName("storemanid");
            entity.Property(e => e.Storemanname)
                .HasMaxLength(30)
                .HasColumnName("storemanname");
            entity.Property(e => e.Storename).HasColumnName("storename");
            entity.Property(e => e.Trial459)
                .HasMaxLength(1)
                .HasColumnName("trial459");
        });

        modelBuilder.Entity<Invstoretran>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("pk_invstoretran");

            entity.ToTable("invstoretran");

            entity.Property(e => e.RecId).HasColumnName("rec_id");
            entity.Property(e => e.Condition)
                .HasMaxLength(10)
                .HasColumnName("condition");
            entity.Property(e => e.Dept).HasColumnName("dept");
            entity.Property(e => e.Issuedto)
                .HasMaxLength(30)
                .HasColumnName("issuedto");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Project).HasColumnName("project");
            entity.Property(e => e.Purchaser).HasColumnName("purchaser");
            entity.Property(e => e.QtyGrn)
                .HasPrecision(14, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("qty_grn");
            entity.Property(e => e.QtyIss)
                .HasPrecision(14, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("qty_iss");
            entity.Property(e => e.QtyIst)
                .HasPrecision(14, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("qty_ist");
            entity.Property(e => e.QtyRet)
                .HasPrecision(14, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("qty_ret");
            entity.Property(e => e.QuotationId).HasColumnName("quotation_id");
            entity.Property(e => e.RecType)
                .HasMaxLength(3)
                .HasColumnName("rec_type");
            entity.Property(e => e.Receivedfrom)
                .HasMaxLength(30)
                .HasColumnName("receivedfrom");
            entity.Property(e => e.Reference)
                .HasMaxLength(30)
                .HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.StoreId).HasColumnName("store_id");
            entity.Property(e => e.Supplier).HasColumnName("supplier");
            entity.Property(e => e.Trdate)
                .HasMaxLength(12)
                .HasColumnName("trdate");
            entity.Property(e => e.Trial459)
                .HasMaxLength(1)
                .HasColumnName("trial459");
            entity.Property(e => e.Unitprice)
                .HasPrecision(14, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("unitprice");
            entity.Property(e => e.ViewState).HasColumnName("view_state");
        });

        modelBuilder.Entity<Ledger>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ledger");

            entity.Property(e => e.Account)
                .HasMaxLength(255)
                .HasColumnName("account");
            entity.Property(e => e.AccountNo)
                .HasMaxLength(255)
                .HasColumnName("account_no_");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.Balance).HasColumnName("balance");
            entity.Property(e => e.Checkno)
                .HasMaxLength(255)
                .HasColumnName("checkno");
            entity.Property(e => e.Class)
                .HasMaxLength(255)
                .HasColumnName("class");
            entity.Property(e => e.CreateDate)
                .HasMaxLength(255)
                .HasColumnName("create_date");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.Credit).HasColumnName("credit");
            entity.Property(e => e.Customer)
                .HasMaxLength(255)
                .HasColumnName("customer");
            entity.Property(e => e.Date)
                .HasMaxLength(255)
                .HasColumnName("date");
            entity.Property(e => e.Debit).HasColumnName("debit");
            entity.Property(e => e.Employee)
                .HasMaxLength(255)
                .HasColumnName("employee");
            entity.Property(e => e.ErpId).HasColumnName("erp_id");
            entity.Property(e => e.LastModified)
                .HasMaxLength(255)
                .HasColumnName("last_modified");
            entity.Property(e => e.LastModifiedBy)
                .HasMaxLength(255)
                .HasColumnName("last_modified_by");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .HasColumnName("location");
            entity.Property(e => e.MemoDescription)
                .HasMaxLength(255)
                .HasColumnName("memo_description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.No)
                .HasMaxLength(255)
                .HasColumnName("no_");
            entity.Property(e => e.Pv)
                .HasMaxLength(255)
                .HasColumnName("pv");
            entity.Property(e => e.QbId).HasColumnName("qb_id");
            entity.Property(e => e.Split)
                .HasMaxLength(255)
                .HasColumnName("split");
            entity.Property(e => e.Supplier)
                .HasMaxLength(255)
                .HasColumnName("supplier");
            entity.Property(e => e.TrDate).HasColumnName("tr_date");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(255)
                .HasColumnName("transaction_type");
            entity.Property(e => e.Transationdate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("transationdate");
            entity.Property(e => e.Trial459)
                .HasMaxLength(1)
                .HasColumnName("trial459");
        });

        modelBuilder.Entity<LedgerErpvendor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ledger_erpvendor");

            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Trial485)
                .HasMaxLength(1)
                .HasColumnName("trial485");
            entity.Property(e => e.VendorCustomerId).HasColumnName("vendor_customer_id");
        });

        modelBuilder.Entity<Machineryrentalagreement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_machineryrentalagreement");

            entity.ToTable("machineryrentalagreement");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppLevel)
                .HasDefaultValueSql("0")
                .HasColumnName("app_level");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Contractedhours)
                .HasPrecision(18, 2)
                .HasColumnName("contractedhours");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Creatoruserid).HasColumnName("creatoruserid");
            entity.Property(e => e.Currentadvanceamount)
                .HasPrecision(18, 2)
                .HasColumnName("currentadvanceamount");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.EndDate1).HasColumnName("end_date");
            entity.Property(e => e.Enddate).HasColumnName("enddate");
            entity.Property(e => e.ErpDate).HasColumnName("erp_date");
            entity.Property(e => e.Hasattachement)
                .HasDefaultValueSql("false")
                .HasColumnName("hasattachement");
            entity.Property(e => e.Hourlyrate)
                .HasPrecision(18, 2)
                .HasColumnName("hourlyrate");
            entity.Property(e => e.Isactive)
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved)
                .HasDefaultValueSql("false")
                .HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted)
                .HasDefaultValueSql("false")
                .HasColumnName("isdeleted");
            entity.Property(e => e.Isincomegenerating)
                .HasDefaultValueSql("false")
                .HasColumnName("isincomegenerating");
            entity.Property(e => e.Isreviewed)
                .HasDefaultValueSql("false")
                .HasColumnName("isreviewed");
            entity.Property(e => e.IsvatRegistered)
                .HasDefaultValueSql("false")
                .HasColumnName("isvat_registered");
            entity.Property(e => e.Machineryid).HasColumnName("machineryid");
            entity.Property(e => e.Managerid).HasColumnName("managerid");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Odometerreading).HasColumnName("odometerreading");
            entity.Property(e => e.Outstandingadvanceamount)
                .HasPrecision(18, 2)
                .HasColumnName("outstandingadvanceamount");
            entity.Property(e => e.Ownerid).HasColumnName("ownerid");
            entity.Property(e => e.PlateNo)
                .HasMaxLength(20)
                .HasColumnName("plate_no");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(150)
                .HasColumnName("reference_no");
            entity.Property(e => e.Renterid).HasColumnName("renterid");
            entity.Property(e => e.Rentingid).HasColumnName("rentingid");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.StartDate1).HasColumnName("start_date");
            entity.Property(e => e.Startdate).HasColumnName("startdate");
            entity.Property(e => e.Trial485)
                .HasMaxLength(1)
                .HasColumnName("trial485");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");

            entity.HasOne(d => d.Manager).WithMany(p => p.Machineryrentalagreements)
                .HasForeignKey(d => d.Managerid)
                .HasConstraintName("fk_dbo_machineryrentalagreement_dbo_manager_managerid");

            entity.HasOne(d => d.Project).WithMany(p => p.Machineryrentalagreements)
                .HasForeignKey(d => d.Projectid)
                .HasConstraintName("fk_dbo_machineryrentalagreement_dbo_project_projectid");
        });

        modelBuilder.Entity<Manager>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_manager");

            entity.ToTable("manager");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Employeeid)
                .HasMaxLength(50)
                .HasColumnName("employeeid");
            entity.Property(e => e.Firstname)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("firstname");
            entity.Property(e => e.Isactive)
                .IsRequired()
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Lastname)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("lastname");
            entity.Property(e => e.Managertypeid).HasColumnName("managertypeid");
            entity.Property(e => e.Middlename)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("middlename");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Trial488)
                .HasMaxLength(1)
                .HasColumnName("trial488");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");

            entity.HasOne(d => d.Managertype).WithMany(p => p.Managers)
                .HasForeignKey(d => d.Managertypeid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbo_manager_dbo_managertype_managertypeid");
        });

        modelBuilder.Entity<Managertype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_managertype");

            entity.ToTable("managertype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.Isactive)
                .IsRequired()
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Trial492)
                .HasMaxLength(1)
                .HasColumnName("trial492");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
        });

        modelBuilder.Entity<Materialinputactivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_materialinputactivity");

            entity.ToTable("materialinputactivity");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Agreementid).HasColumnName("agreementid");
            entity.Property(e => e.Agreementname)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("agreementname");
            entity.Property(e => e.Agreementtypeid).HasColumnName("agreementtypeid");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Clientid).HasColumnName("clientid");
            entity.Property(e => e.Clientname)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("clientname");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Deliverydate)
                .IsRequired()
                .HasColumnName("deliverydate");
            entity.Property(e => e.Drivername)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("drivername");
            entity.Property(e => e.Erpdate).HasColumnName("erpdate");
            entity.Property(e => e.GrnNo)
                .HasMaxLength(50)
                .HasColumnName("grn_no");
            entity.Property(e => e.Isactive)
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Managerid).HasColumnName("managerid");
            entity.Property(e => e.Managername)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("managername");
            entity.Property(e => e.Materialprice)
                .HasPrecision(18, 2)
                .HasColumnName("materialprice");
            entity.Property(e => e.Materialtype)
                .HasMaxLength(50)
                .HasColumnName("materialtype");
            entity.Property(e => e.Materialtypeid).HasColumnName("materialtypeid");
            entity.Property(e => e.Materialtypename)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("materialtypename");
            entity.Property(e => e.Materialtypeunit)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("materialtypeunit");
            entity.Property(e => e.Period).HasColumnName("period");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Projectname)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("projectname");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Receivedquantity)
                .HasPrecision(18, 2)
                .HasColumnName("receivedquantity");
            entity.Property(e => e.Receivername)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("receivername");
            entity.Property(e => e.Reportedby)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("reportedby");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.ScId).HasColumnName("sc_id");
            entity.Property(e => e.Siteid).HasColumnName("siteid");
            entity.Property(e => e.Sitename)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("sitename");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("0")
                .HasColumnName("status");
            entity.Property(e => e.Trial492)
                .HasMaxLength(1)
                .HasColumnName("trial492");
            entity.Property(e => e.Truckplatenumber)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("truckplatenumber");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Vat)
                .HasPrecision(18, 2)
                .HasColumnName("vat");
            entity.Property(e => e.Withholding)
                .HasPrecision(18, 2)
                .HasColumnName("withholding");
            entity.Property(e => e.Witnessname)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("witnessname");
        });

        modelBuilder.Entity<Materialoutputactivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk1_dbo_materialoutputactivity");

            entity.ToTable("materialoutputactivity");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Clientid).HasColumnName("clientid");
            entity.Property(e => e.Clientname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("clientname");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Dispenseddate).HasColumnName("dispenseddate");
            entity.Property(e => e.Erpdate).HasColumnName("erpdate");
            entity.Property(e => e.GrnNo)
                .HasMaxLength(50)
                .HasColumnName("grn_no");
            entity.Property(e => e.Isactive)
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Itemdescription)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("itemdescription");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.Period).HasColumnName("period");
            entity.Property(e => e.Platenumber)
                .HasMaxLength(50)
                .HasColumnName("platenumber");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Projectname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("projectname");
            entity.Property(e => e.Quantity)
                .HasPrecision(18, 2)
                .HasColumnName("quantity");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Receivername)
                .HasMaxLength(100)
                .HasColumnName("receivername");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.ScId).HasColumnName("sc_id");
            entity.Property(e => e.SivNo)
                .HasMaxLength(50)
                .HasColumnName("siv_no");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("0")
                .HasColumnName("status");
            entity.Property(e => e.Trial495)
                .HasMaxLength(1)
                .HasColumnName("trial495");
            entity.Property(e => e.Unitprice)
                .HasPrecision(18, 2)
                .HasColumnName("unitprice");
            entity.Property(e => e.Uom)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("uom");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<Materialoutputactivityold>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_materialoutputactivity");

            entity.ToTable("materialoutputactivityold");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Agreementid).HasColumnName("agreementid");
            entity.Property(e => e.Agreementname)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("agreementname");
            entity.Property(e => e.Agreementtypeid).HasColumnName("agreementtypeid");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Clientauthorizer)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("clientauthorizer");
            entity.Property(e => e.Clientid).HasColumnName("clientid");
            entity.Property(e => e.Clientname)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("clientname");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Dispenseddate)
                .IsRequired()
                .HasColumnName("dispenseddate");
            entity.Property(e => e.Dispensedquantity)
                .HasPrecision(18, 2)
                .HasColumnName("dispensedquantity");
            entity.Property(e => e.Erpdate).HasColumnName("erpdate");
            entity.Property(e => e.GrnNo)
                .HasMaxLength(50)
                .HasColumnName("grn_no");
            entity.Property(e => e.Isactive)
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.Machineryplatenumber)
                .HasMaxLength(100)
                .HasColumnName("machineryplatenumber");
            entity.Property(e => e.Managerid).HasColumnName("managerid");
            entity.Property(e => e.Managername)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("managername");
            entity.Property(e => e.Materialprice)
                .HasPrecision(18, 2)
                .HasColumnName("materialprice");
            entity.Property(e => e.Materialtype)
                .HasMaxLength(50)
                .HasColumnName("materialtype");
            entity.Property(e => e.Materialtypeid).HasColumnName("materialtypeid");
            entity.Property(e => e.Materialtypename)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("materialtypename");
            entity.Property(e => e.Materialtypeunit)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("materialtypeunit");
            entity.Property(e => e.Period).HasColumnName("period");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Projectname)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("projectname");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Receivername)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("receivername");
            entity.Property(e => e.Reportedby)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("reportedby");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.ScId).HasColumnName("sc_id");
            entity.Property(e => e.Siteid).HasColumnName("siteid");
            entity.Property(e => e.Sitename)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("sitename");
            entity.Property(e => e.SivNo)
                .HasMaxLength(50)
                .HasColumnName("siv_no");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("0")
                .HasColumnName("status");
            entity.Property(e => e.Storemanname)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("storemanname");
            entity.Property(e => e.Trial498)
                .HasMaxLength(1)
                .HasColumnName("trial498");
            entity.Property(e => e.Truckplatenumber)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("truckplatenumber");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Vat)
                .HasPrecision(18, 2)
                .HasColumnName("vat");
            entity.Property(e => e.Withholding)
                .HasPrecision(18, 2)
                .HasColumnName("withholding");
        });

        modelBuilder.Entity<OwnerAgreement>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("owner_agreement");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Managerid).HasColumnName("managerid");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Ownerid).HasColumnName("ownerid");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Renterid).HasColumnName("renterid");
            entity.Property(e => e.Trial505)
                .HasMaxLength(1)
                .HasColumnName("trial505");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Paymentfor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_paymentfor");

            entity.ToTable("paymentfor");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accountid)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("accountid");
            entity.Property(e => e.Accounttype).HasColumnName("accounttype");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Trial505)
                .HasMaxLength(1)
                .HasColumnName("trial505");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
        });

        modelBuilder.Entity<PeachtreeLedger2011>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("peachtree_ledger2011");

            entity.Property(e => e.AccountDescription)
                .HasMaxLength(255)
                .HasColumnName("account_description");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.Balance).HasColumnName("balance");
            entity.Property(e => e.Checkno)
                .HasMaxLength(255)
                .HasColumnName("checkno");
            entity.Property(e => e.CreditAmt).HasColumnName("credit_amt");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(255)
                .HasColumnName("customer_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .HasColumnName("customer_name");
            entity.Property(e => e.Date)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("date");
            entity.Property(e => e.Date1)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("date1");
            entity.Property(e => e.DebitAmt).HasColumnName("debit_amt");
            entity.Property(e => e.ErpId).HasColumnName("erp_id");
            entity.Property(e => e.ErpVendorId).HasColumnName("erp_vendor_id");
            entity.Property(e => e.Jrnl)
                .HasMaxLength(255)
                .HasColumnName("jrnl");
            entity.Property(e => e.PeachtreeId).HasColumnName("peachtree_id");
            entity.Property(e => e.Pv)
                .HasMaxLength(255)
                .HasColumnName("pv");
            entity.Property(e => e.Reference)
                .HasMaxLength(255)
                .HasColumnName("reference");
            entity.Property(e => e.TrDate)
                .HasMaxLength(255)
                .HasColumnName("tr_date");
            entity.Property(e => e.TransDescription)
                .HasMaxLength(255)
                .HasColumnName("trans_description");
            entity.Property(e => e.Trial508)
                .HasMaxLength(1)
                .HasColumnName("trial508");
            entity.Property(e => e.VendorId)
                .HasMaxLength(255)
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorName)
                .HasMaxLength(255)
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<Pension>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_pension");

            entity.ToTable("pension");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Isactive)
                .IsRequired()
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Reason)
                .HasMaxLength(50)
                .HasColumnName("reason");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Trial521)
                .HasMaxLength(1)
                .HasColumnName("trial521");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Value)
                .HasPrecision(18, 2)
                .HasColumnName("value");
        });

        modelBuilder.Entity<Propertytype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_propertytype");

            entity.ToTable("propertytype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Trial521)
                .HasMaxLength(1)
                .HasColumnName("trial521");
        });

        modelBuilder.Entity<Purchaseagreement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_purchaseagreement");

            entity.ToTable("purchaseagreement");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Agreementdate).HasColumnName("agreementdate");
            entity.Property(e => e.Amount)
                .HasPrecision(18, 2)
                .HasColumnName("amount");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.Enddate).HasColumnName("enddate");
            entity.Property(e => e.ErpDate).HasColumnName("erp_date");
            entity.Property(e => e.Isactive)
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved)
                .HasDefaultValueSql("false")
                .HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted)
                .HasDefaultValueSql("false")
                .HasColumnName("isdeleted");
            entity.Property(e => e.Isreviewed)
                .HasDefaultValueSql("false")
                .HasColumnName("isreviewed");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Startdate).HasColumnName("startdate");
            entity.Property(e => e.Trial524)
                .HasMaxLength(1)
                .HasColumnName("trial524");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
        });

        modelBuilder.Entity<PvBill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_pv_bill");

            entity.ToTable("pv_bill");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AcctCode).HasColumnName("acct_code");
            entity.Property(e => e.Actualadvance)
                .HasPrecision(18, 2)
                .HasColumnName("actualadvance");
            entity.Property(e => e.Advancepayment)
                .HasPrecision(18, 2)
                .HasColumnName("advancepayment");
            entity.Property(e => e.Agreementid)
                .HasDefaultValueSql("0")
                .HasColumnName("agreementid");
            entity.Property(e => e.Agreementname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("agreementname");
            entity.Property(e => e.Agreementtypeid)
                .HasDefaultValueSql("0")
                .HasColumnName("agreementtypeid");
            entity.Property(e => e.AmtBeforeVat)
                .HasPrecision(18, 2)
                .HasColumnName("amt_before_vat");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Bank).HasColumnName("bank");
            entity.Property(e => e.Bankname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("bankname");
            entity.Property(e => e.Billdate).HasColumnName("billdate");
            entity.Property(e => e.ChequeAmt)
                .HasPrecision(18, 2)
                .HasColumnName("cheque_amt");
            entity.Property(e => e.ChkNo)
                .HasMaxLength(30)
                .HasColumnName("chk_no");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(50)
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser).HasColumnName("created_user");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate1)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Deductionapplicable).HasColumnName("deductionapplicable");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Dispersed)
                .HasMaxLength(10)
                .HasColumnName("dispersed");
            entity.Property(e => e.DispersedDate).HasColumnName("dispersed_date");
            entity.Property(e => e.Escalation)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("escalation");
            entity.Property(e => e.Grossadvance)
                .HasPrecision(18, 2)
                .HasColumnName("grossadvance");
            entity.Property(e => e.Grossescalation)
                .HasPrecision(18, 2)
                .HasColumnName("grossescalation");
            entity.Property(e => e.Grossfueldeduction)
                .HasPrecision(18, 2)
                .HasColumnName("grossfueldeduction");
            entity.Property(e => e.Grossmachinerydeduction)
                .HasPrecision(18, 2)
                .HasColumnName("grossmachinerydeduction");
            entity.Property(e => e.Grossmaterialdeduction)
                .HasPrecision(18, 2)
                .HasColumnName("grossmaterialdeduction");
            entity.Property(e => e.Grosspayment)
                .HasPrecision(18, 2)
                .HasColumnName("grosspayment");
            entity.Property(e => e.Grosspaymentamount)
                .HasPrecision(18, 2)
                .HasColumnName("grosspaymentamount");
            entity.Property(e => e.Grossretention)
                .HasPrecision(18, 2)
                .HasColumnName("grossretention");
            entity.Property(e => e.Grosstransportdeduction)
                .HasPrecision(18, 2)
                .HasColumnName("grosstransportdeduction");
            entity.Property(e => e.Grossvat)
                .HasPrecision(18, 2)
                .HasColumnName("grossvat");
            entity.Property(e => e.Grossvehiclededuction)
                .HasPrecision(18, 2)
                .HasColumnName("grossvehiclededuction");
            entity.Property(e => e.Grosswithholding)
                .HasPrecision(18, 2)
                .HasColumnName("grosswithholding");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isforadvance).HasColumnName("isforadvance");
            entity.Property(e => e.Isforpurchase).HasColumnName("isforpurchase");
            entity.Property(e => e.Isforsell).HasColumnName("isforsell");
            entity.Property(e => e.Isincomegenerating).HasColumnName("isincomegenerating");
            entity.Property(e => e.Ispaid).HasColumnName("ispaid");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Managerid)
                .HasDefaultValueSql("0")
                .HasColumnName("managerid");
            entity.Property(e => e.Managername)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("managername");
            entity.Property(e => e.Payeeid)
                .HasDefaultValueSql("0")
                .HasColumnName("payeeid");
            entity.Property(e => e.Payeename)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("payeename");
            entity.Property(e => e.Payerid).HasColumnName("payerid");
            entity.Property(e => e.Payername)
                .HasMaxLength(50)
                .HasColumnName("payername");
            entity.Property(e => e.Paymentforid).HasColumnName("paymentforid");
            entity.Property(e => e.Paymentforname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("paymentforname");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Projectname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("projectname");
            entity.Property(e => e.PvNo).HasColumnName("pv_no");
            entity.Property(e => e.PvVoid)
                .HasMaxLength(10)
                .HasColumnName("pv_void");
            entity.Property(e => e.Reason)
                .HasMaxLength(50)
                .HasColumnName("reason");
            entity.Property(e => e.ReqId).HasColumnName("req_id");
            entity.Property(e => e.Retention)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("retention");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Signername)
                .HasMaxLength(50)
                .HasColumnName("signername");
            entity.Property(e => e.Tot)
                .HasPrecision(18, 2)
                .HasColumnName("tot");
            entity.Property(e => e.TotPayable)
                .HasPrecision(18, 2)
                .HasColumnName("tot_payable");
            entity.Property(e => e.Trial524)
                .HasMaxLength(1)
                .HasColumnName("trial524");
            entity.Property(e => e.Unpaidamount)
                .HasPrecision(18, 2)
                .HasColumnName("unpaidamount");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Vat)
                .HasPrecision(18, 2)
                .HasColumnName("vat");
            entity.Property(e => e.Wht)
                .HasPrecision(18, 2)
                .HasColumnName("wht");
        });

        modelBuilder.Entity<PvPo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_pv_po");

            entity.ToTable("pv_po");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AcctCode).HasColumnName("acct_code");
            entity.Property(e => e.Actualadvance)
                .HasPrecision(18, 2)
                .HasColumnName("actualadvance");
            entity.Property(e => e.Agreementid)
                .HasDefaultValueSql("0")
                .HasColumnName("agreementid");
            entity.Property(e => e.Agreementname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("agreementname");
            entity.Property(e => e.Agreementtypeid)
                .HasDefaultValueSql("0")
                .HasColumnName("agreementtypeid");
            entity.Property(e => e.AmtBeforeVat)
                .HasPrecision(18, 2)
                .HasColumnName("amt_before_vat");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Bank).HasColumnName("bank");
            entity.Property(e => e.Bankname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("bankname");
            entity.Property(e => e.ChequeAmt)
                .HasPrecision(18, 2)
                .HasColumnName("cheque_amt");
            entity.Property(e => e.ChkNo)
                .HasMaxLength(30)
                .HasColumnName("chk_no");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(30)
                .HasColumnName("created_date");
            entity.Property(e => e.CreatedUser).HasColumnName("created_user");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate1)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.Dispersed)
                .HasMaxLength(10)
                .HasColumnName("dispersed");
            entity.Property(e => e.DispersedDate).HasColumnName("dispersed_date");
            entity.Property(e => e.Grossadvance)
                .HasPrecision(18, 2)
                .HasColumnName("grossadvance");
            entity.Property(e => e.Grossescalation)
                .HasPrecision(18, 2)
                .HasColumnName("grossescalation");
            entity.Property(e => e.Grossfueldeduction)
                .HasPrecision(18, 2)
                .HasColumnName("grossfueldeduction");
            entity.Property(e => e.Grossmachinerydeduction)
                .HasPrecision(18, 2)
                .HasColumnName("grossmachinerydeduction");
            entity.Property(e => e.Grossmaterialdeduction)
                .HasPrecision(18, 2)
                .HasColumnName("grossmaterialdeduction");
            entity.Property(e => e.Grosspayment)
                .HasPrecision(18, 2)
                .HasColumnName("grosspayment");
            entity.Property(e => e.Grossretention)
                .HasPrecision(18, 2)
                .HasColumnName("grossretention");
            entity.Property(e => e.Grosstransportdeduction)
                .HasPrecision(18, 2)
                .HasColumnName("grosstransportdeduction");
            entity.Property(e => e.Grossvat)
                .HasPrecision(18, 2)
                .HasColumnName("grossvat");
            entity.Property(e => e.Grossvehiclededuction)
                .HasPrecision(18, 2)
                .HasColumnName("grossvehiclededuction");
            entity.Property(e => e.Grosswithholding)
                .HasPrecision(18, 2)
                .HasColumnName("grosswithholding");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isforpurchase).HasColumnName("isforpurchase");
            entity.Property(e => e.Isforsell).HasColumnName("isforsell");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Managerid)
                .HasDefaultValueSql("0")
                .HasColumnName("managerid");
            entity.Property(e => e.Managername)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("managername");
            entity.Property(e => e.Payeeid)
                .HasDefaultValueSql("0")
                .HasColumnName("payeeid");
            entity.Property(e => e.Payeename)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("payeename");
            entity.Property(e => e.Paymentforid).HasColumnName("paymentforid");
            entity.Property(e => e.Paymentforname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("paymentforname");
            entity.Property(e => e.Projectname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("projectname");
            entity.Property(e => e.PvNo).HasColumnName("pv_no");
            entity.Property(e => e.PvVoid)
                .HasMaxLength(10)
                .HasDefaultValueSql("'NO'::character varying")
                .HasColumnName("pv_void");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.ReqId).HasColumnName("req_id");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Signername)
                .HasMaxLength(100)
                .HasColumnName("signername");
            entity.Property(e => e.Tot)
                .HasPrecision(18, 2)
                .HasColumnName("tot");
            entity.Property(e => e.TotPayable)
                .HasPrecision(18, 2)
                .HasColumnName("tot_payable");
            entity.Property(e => e.Trial528)
                .HasMaxLength(1)
                .HasColumnName("trial528");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Vat)
                .HasPrecision(18, 2)
                .HasColumnName("vat");
            entity.Property(e => e.Wht)
                .HasPrecision(18, 2)
                .HasColumnName("wht");
        });

        modelBuilder.Entity<QbLedger>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("qb_ledger");

            entity.Property(e => e.Account)
                .HasMaxLength(255)
                .HasColumnName("account");
            entity.Property(e => e.AccountNo)
                .HasMaxLength(255)
                .HasColumnName("account_no_");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.Balance).HasColumnName("balance");
            entity.Property(e => e.Checkno)
                .HasMaxLength(255)
                .HasColumnName("checkno");
            entity.Property(e => e.Class)
                .HasMaxLength(255)
                .HasColumnName("class");
            entity.Property(e => e.CreateDate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.Credit).HasColumnName("credit");
            entity.Property(e => e.Customer)
                .HasMaxLength(255)
                .HasColumnName("customer");
            entity.Property(e => e.Date)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("date");
            entity.Property(e => e.Debit).HasColumnName("debit");
            entity.Property(e => e.Employee)
                .HasMaxLength(255)
                .HasColumnName("employee");
            entity.Property(e => e.ErpId).HasColumnName("erp_id");
            entity.Property(e => e.LastModified)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("last_modified");
            entity.Property(e => e.LastModifiedBy)
                .HasMaxLength(255)
                .HasColumnName("last_modified_by");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .HasColumnName("location");
            entity.Property(e => e.MemoDescription)
                .HasMaxLength(255)
                .HasColumnName("memo_description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.No)
                .HasMaxLength(255)
                .HasColumnName("no_");
            entity.Property(e => e.Pv)
                .HasMaxLength(255)
                .HasColumnName("pv");
            entity.Property(e => e.QbId).HasColumnName("qb_id");
            entity.Property(e => e.Split)
                .HasMaxLength(255)
                .HasColumnName("split");
            entity.Property(e => e.Supplier)
                .HasMaxLength(255)
                .HasColumnName("supplier");
            entity.Property(e => e.TrDate).HasColumnName("tr_date");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(255)
                .HasColumnName("transaction_type");
            entity.Property(e => e.Transationdate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("transationdate");
            entity.Property(e => e.Trial528)
                .HasMaxLength(1)
                .HasColumnName("trial528");
            entity.Property(e => e.ZohoId).HasColumnName("zoho_id");
        });

        modelBuilder.Entity<Realestate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_realestate");

            entity.ToTable("realestate");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Bathroomnumber)
                .HasPrecision(18, 2)
                .HasColumnName("bathroomnumber");
            entity.Property(e => e.Bedroomnumber)
                .HasPrecision(18, 2)
                .HasColumnName("bedroomnumber");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.Floorlocation)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("floorlocation");
            entity.Property(e => e.Housetype)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("housetype");
            entity.Property(e => e.Isactive)
                .IsRequired()
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Location)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("location");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Ownerid).HasColumnName("ownerid");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Totalarea)
                .HasPrecision(18, 2)
                .HasColumnName("totalarea");
            entity.Property(e => e.Trial563)
                .HasMaxLength(1)
                .HasColumnName("trial563");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Yearbuilt).HasColumnName("yearbuilt");
        });

        modelBuilder.Entity<Requestcode>(entity =>
        {
            entity.HasKey(e => e.Loactionid).HasName("pk_requestcode");

            entity.ToTable("requestcode");

            entity.Property(e => e.Loactionid)
                .HasMaxLength(5)
                .HasColumnName("loactionid");
            entity.Property(e => e.Loaction)
                .HasMaxLength(100)
                .HasColumnName("loaction");
            entity.Property(e => e.Reqorder).HasColumnName("reqorder");
            entity.Property(e => e.Trial563)
                .HasMaxLength(1)
                .HasColumnName("trial563");
        });

        modelBuilder.Entity<Salesagreement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_salesagreement");

            entity.ToTable("salesagreement");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Agreementdate)
                .IsRequired()
                .HasColumnName("agreementdate");
            entity.Property(e => e.Agreementnumber)
                .HasMaxLength(50)
                .HasColumnName("agreementnumber");
            entity.Property(e => e.Agreementsize)
                .HasPrecision(18, 2)
                .HasColumnName("agreementsize");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Buyerid).HasColumnName("buyerid");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.ErpDate).HasColumnName("erp_date");
            entity.Property(e => e.Installmentfour)
                .HasPrecision(18, 2)
                .HasColumnName("installmentfour");
            entity.Property(e => e.Installmentone)
                .HasPrecision(18, 2)
                .HasColumnName("installmentone");
            entity.Property(e => e.Installmentthree)
                .HasPrecision(18, 2)
                .HasColumnName("installmentthree");
            entity.Property(e => e.Installmenttwo)
                .HasPrecision(18, 2)
                .HasColumnName("installmenttwo");
            entity.Property(e => e.Isactive)
                .IsRequired()
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isincomegenerating).HasColumnName("isincomegenerating");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Managerid).HasColumnName("managerid");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Outstandingbalance)
                .HasPrecision(18, 2)
                .HasColumnName("outstandingbalance");
            entity.Property(e => e.Paymentdatefour)
                .IsRequired()
                .HasColumnName("paymentdatefour");
            entity.Property(e => e.Paymentdateone)
                .IsRequired()
                .HasColumnName("paymentdateone");
            entity.Property(e => e.Paymentdatethree)
                .IsRequired()
                .HasColumnName("paymentdatethree");
            entity.Property(e => e.Paymentdatetwo)
                .IsRequired()
                .HasColumnName("paymentdatetwo");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Propertyid).HasColumnName("propertyid");
            entity.Property(e => e.Propertyname)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("propertyname");
            entity.Property(e => e.Propertytypeid).HasColumnName("propertytypeid");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Sellerid).HasColumnName("sellerid");
            entity.Property(e => e.Trial563)
                .HasMaxLength(1)
                .HasColumnName("trial563");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");

            entity.HasOne(d => d.Manager).WithMany(p => p.Salesagreements)
                .HasForeignKey(d => d.Managerid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbo_salesagreement_dbo_manager_managerid");

            entity.HasOne(d => d.Project).WithMany(p => p.Salesagreements)
                .HasForeignKey(d => d.Projectid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbo_salesagreement_dbo_project_projectid");

            entity.HasOne(d => d.Propertytype).WithMany(p => p.Salesagreements)
                .HasForeignKey(d => d.Propertytypeid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbo_salesagreement_dbo_propertytype_propertytypeid");

            entity.HasOne(d => d.Seller).WithMany(p => p.Salesagreements)
                .HasForeignKey(d => d.Sellerid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbo_salesagreement_dbo_client_sellerid");
        });

        modelBuilder.Entity<Serviceagreement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_serviceagreement");

            entity.ToTable("serviceagreement");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Abovephaseone)
                .HasPrecision(18, 2)
                .HasColumnName("abovephaseone");
            entity.Property(e => e.Agreementnumber)
                .HasMaxLength(50)
                .HasColumnName("agreementnumber");
            entity.Property(e => e.Agreementsize)
                .HasPrecision(18, 2)
                .HasColumnName("agreementsize");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Currentadvanceamount)
                .HasPrecision(18, 2)
                .HasColumnName("currentadvanceamount");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.EndDate1).HasColumnName("end_date");
            entity.Property(e => e.Enddate).HasColumnName("enddate");
            entity.Property(e => e.ErpDate).HasColumnName("erp_date");
            entity.Property(e => e.ErpScid).HasColumnName("erp_scid");
            entity.Property(e => e.ErpScname)
                .HasMaxLength(100)
                .HasColumnName("erp_scname");
            entity.Property(e => e.Hasattachement)
                .HasDefaultValueSql("false")
                .HasColumnName("hasattachement");
            entity.Property(e => e.Isactive)
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isincomegenerating).HasColumnName("isincomegenerating");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Managerid).HasColumnName("managerid");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Outstandingadvanceamount)
                .HasPrecision(18, 2)
                .HasColumnName("outstandingadvanceamount");
            entity.Property(e => e.Phaseone)
                .HasPrecision(18, 2)
                .HasColumnName("phaseone");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Serviceproviderid).HasColumnName("serviceproviderid");
            entity.Property(e => e.Servicerecieverid).HasColumnName("servicerecieverid");
            entity.Property(e => e.StartDate1).HasColumnName("start_date");
            entity.Property(e => e.Startdate).HasColumnName("startdate");
            entity.Property(e => e.Trial567)
                .HasMaxLength(1)
                .HasColumnName("trial567");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Uptophaseone)
                .HasPrecision(18, 2)
                .HasColumnName("uptophaseone");

            entity.HasOne(d => d.Manager).WithMany(p => p.Serviceagreements)
                .HasForeignKey(d => d.Managerid)
                .HasConstraintName("fk_dbo_serviceagreement_dbo_manager_managerid");
        });

        modelBuilder.Entity<Sheet1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sheet1_");

            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(255)
                .HasColumnName("approved_by");
            entity.Property(e => e.Approvedby1)
                .HasMaxLength(255)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Capacity).HasColumnName("capacity");
            entity.Property(e => e.CheckedBy)
                .HasMaxLength(255)
                .HasColumnName("checked_by");
            entity.Property(e => e.Createdby)
                .HasMaxLength(255)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.DateCreated)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("date_created");
            entity.Property(e => e.DriverName)
                .HasMaxLength(255)
                .HasColumnName("driver_name");
            entity.Property(e => e.ExecutionAmount).HasColumnName("execution_amount");
            entity.Property(e => e.FuleTaken).HasColumnName("fule_taken");
            entity.Property(e => e.HaulingDistance).HasColumnName("hauling_distance");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Issendtobill).HasColumnName("issendtobill");
            entity.Property(e => e.LoadingOfficer)
                .HasMaxLength(255)
                .HasColumnName("loading_officer");
            entity.Property(e => e.LoadingSite).HasColumnName("loading_site");
            entity.Property(e => e.MaterialType)
                .HasMaxLength(255)
                .HasColumnName("material_type");
            entity.Property(e => e.MaxKm).HasColumnName("max_km");
            entity.Property(e => e.MeterEnd).HasColumnName("meter_end");
            entity.Property(e => e.MeterStart).HasColumnName("meter_start");
            entity.Property(e => e.NoOfTrips).HasColumnName("no_of_trips");
            entity.Property(e => e.PaidIdleAmount).HasColumnName("paid_idle_amount");
            entity.Property(e => e.PaidIdleHrs).HasColumnName("paid_idle_hrs");
            entity.Property(e => e.Period).HasColumnName("period");
            entity.Property(e => e.PlateNo)
                .HasMaxLength(255)
                .HasColumnName("plate_no");
            entity.Property(e => e.PricePerLiter).HasColumnName("price_per_liter");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Projectname)
                .HasMaxLength(255)
                .HasColumnName("projectname");
            entity.Property(e => e.Rate).HasColumnName("rate");
            entity.Property(e => e.Remark)
                .HasMaxLength(255)
                .HasColumnName("remark");
            entity.Property(e => e.ScId).HasColumnName("sc_id");
            entity.Property(e => e.ScName)
                .HasMaxLength(255)
                .HasColumnName("sc_name");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TrDate).HasColumnName("tr_date");
            entity.Property(e => e.Trial570)
                .HasMaxLength(1)
                .HasColumnName("trial570");
            entity.Property(e => e.UnloadingOfficer)
                .HasMaxLength(255)
                .HasColumnName("unloading_officer");
            entity.Property(e => e.UnloadingSite).HasColumnName("unloading_site");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(255)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.User1).HasColumnName("user1");
            entity.Property(e => e.User2)
                .HasMaxLength(255)
                .HasColumnName("user2");
        });

        modelBuilder.Entity<Site>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_site");

            entity.ToTable("site");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.Hasinternet).HasColumnName("hasinternet");
            entity.Property(e => e.Haspower).HasColumnName("haspower");
            entity.Property(e => e.Isactive)
                .IsRequired()
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Ismainsite).HasColumnName("ismainsite");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Location)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("location");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Sitenumber)
                .HasMaxLength(50)
                .HasColumnName("sitenumber");
            entity.Property(e => e.Trial570)
                .HasMaxLength(1)
                .HasColumnName("trial570");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");

            entity.HasOne(d => d.Project).WithMany(p => p.Sites)
                .HasForeignKey(d => d.Projectid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbo_site_dbo_project_projectid");
        });

        modelBuilder.Entity<Stockitem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("stockitem");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.GlCostOfSalesAccount).HasColumnName("gl_cost_of_sales_account");
            entity.Property(e => e.GlInventoryAccount).HasColumnName("gl_inventory_account");
            entity.Property(e => e.GlSalesAccount).HasColumnName("gl_sales_account");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Trial570)
                .HasMaxLength(1)
                .HasColumnName("trial570");
        });

        modelBuilder.Entity<Sysdiagram>(entity =>
        {
            entity.HasKey(e => e.DiagramId).HasName("pk__sysdiagrams__2bfe89a6");

            entity.ToTable("sysdiagrams");

            entity.HasIndex(e => new { e.PrincipalId, e.Name }, "uk_principal_name").IsUnique();

            entity.Property(e => e.DiagramId).HasColumnName("diagram_id");
            entity.Property(e => e.Definition).HasColumnName("definition");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(128)
                .HasColumnName("name");
            entity.Property(e => e.PrincipalId).HasColumnName("principal_id");
            entity.Property(e => e.Trial573)
                .HasMaxLength(1)
                .HasColumnName("trial573");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<Taxbracket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_taxbracket");

            entity.ToTable("taxbracket");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Deductible)
                .HasPrecision(18, 2)
                .HasColumnName("deductible");
            entity.Property(e => e.From)
                .HasPrecision(18, 2)
                .HasColumnName("from");
            entity.Property(e => e.Isactive)
                .IsRequired()
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Percent)
                .HasPrecision(18, 2)
                .HasColumnName("percent");
            entity.Property(e => e.Reason)
                .HasMaxLength(50)
                .HasColumnName("reason");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.To)
                .HasPrecision(18, 2)
                .HasColumnName("to");
            entity.Property(e => e.Trial577)
                .HasMaxLength(1)
                .HasColumnName("trial577");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
        });

        modelBuilder.Entity<Tblaccessaccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblaccessaccounts");

            entity.Property(e => e.Accountbegining)
                .HasDefaultValueSql("false")
                .HasColumnName("accountbegining");
            entity.Property(e => e.Accounttype)
                .HasDefaultValueSql("false")
                .HasColumnName("accounttype");
            entity.Property(e => e.Admiupdaterecords)
                .HasDefaultValueSql("false")
                .HasColumnName("admiupdaterecords");
            entity.Property(e => e.AppAccountbegining)
                .HasDefaultValueSql("false")
                .HasColumnName("app_accountbegining");
            entity.Property(e => e.AppAp)
                .HasDefaultValueSql("false")
                .HasColumnName("app_ap");
            entity.Property(e => e.AppAr)
                .HasDefaultValueSql("false")
                .HasColumnName("app_ar");
            entity.Property(e => e.AppChartofaccounts)
                .HasDefaultValueSql("false")
                .HasColumnName("app_chartofaccounts");
            entity.Property(e => e.AppCustomerbegining)
                .HasDefaultValueSql("false")
                .HasColumnName("app_customerbegining");
            entity.Property(e => e.AppDisbursement)
                .HasDefaultValueSql("false")
                .HasColumnName("app_disbursement");
            entity.Property(e => e.AppGj)
                .HasDefaultValueSql("false")
                .HasColumnName("app_gj");
            entity.Property(e => e.AppPayments)
                .HasDefaultValueSql("false")
                .HasColumnName("app_payments");
            entity.Property(e => e.AppProjectPayment)
                .HasDefaultValueSql("false")
                .HasColumnName("app_project_payment");
            entity.Property(e => e.AppReceipts)
                .HasDefaultValueSql("false")
                .HasColumnName("app_receipts");
            entity.Property(e => e.AppSettlements)
                .HasDefaultValueSql("false")
                .HasColumnName("app_settlements");
            entity.Property(e => e.AppVendorbegining)
                .HasDefaultValueSql("false")
                .HasColumnName("app_vendorbegining");
            entity.Property(e => e.Bankbalances)
                .HasDefaultValueSql("false")
                .HasColumnName("bankbalances");
            entity.Property(e => e.Bankconfirmation)
                .HasDefaultValueSql("false")
                .HasColumnName("bankconfirmation");
            entity.Property(e => e.Bankreconcilation)
                .HasDefaultValueSql("false")
                .HasColumnName("bankreconcilation");
            entity.Property(e => e.Bankreconciliation)
                .HasDefaultValueSql("false")
                .HasColumnName("bankreconciliation");
            entity.Property(e => e.Bankregistry)
                .HasDefaultValueSql("false")
                .HasColumnName("bankregistry");
            entity.Property(e => e.Banktransaction)
                .HasDefaultValueSql("false")
                .HasColumnName("banktransaction");
            entity.Property(e => e.Billforpettycash)
                .HasDefaultValueSql("false")
                .HasColumnName("billforpettycash");
            entity.Property(e => e.Chartofaccount)
                .HasDefaultValueSql("false")
                .HasColumnName("chartofaccount");
            entity.Property(e => e.Checkregistry)
                .HasDefaultValueSql("false")
                .HasColumnName("checkregistry");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasMaxLength(50)
                .HasDefaultValueSql("'getdate()'::character varying")
                .HasColumnName("createddate");
            entity.Property(e => e.Customerbegining)
                .HasDefaultValueSql("false")
                .HasColumnName("customerbegining");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Outstanding)
                .HasDefaultValueSql("false")
                .HasColumnName("outstanding");
            entity.Property(e => e.Paymentforpettycash)
                .HasDefaultValueSql("false")
                .HasColumnName("paymentforpettycash");
            entity.Property(e => e.Paymentorder)
                .HasDefaultValueSql("false")
                .HasColumnName("paymentorder");
            entity.Property(e => e.Pettyattachement)
                .HasDefaultValueSql("false")
                .HasColumnName("pettyattachement");
            entity.Property(e => e.Pettyattachementapp)
                .HasDefaultValueSql("false")
                .HasColumnName("pettyattachementapp");
            entity.Property(e => e.Pettycashdisbursement)
                .HasDefaultValueSql("false")
                .HasColumnName("pettycashdisbursement");
            entity.Property(e => e.Pettycashsettlement)
                .HasDefaultValueSql("false")
                .HasColumnName("pettycashsettlement");
            entity.Property(e => e.Pettycashsettlementapp)
                .HasDefaultValueSql("false")
                .HasColumnName("pettycashsettlementapp");
            entity.Property(e => e.Postaudit)
                .HasDefaultValueSql("false")
                .HasColumnName("postaudit");
            entity.Property(e => e.Postdated)
                .HasDefaultValueSql("false")
                .HasColumnName("postdated");
            entity.Property(e => e.Projectpayment)
                .HasDefaultValueSql("false")
                .HasColumnName("projectpayment");
            entity.Property(e => e.Pvattachementreport)
                .HasDefaultValueSql("false")
                .HasColumnName("pvattachementreport");
            entity.Property(e => e.Pvstatus)
                .HasDefaultValueSql("false")
                .HasColumnName("pvstatus");
            entity.Property(e => e.RepAp)
                .HasDefaultValueSql("false")
                .HasColumnName("rep_ap");
            entity.Property(e => e.RepAr)
                .HasDefaultValueSql("false")
                .HasColumnName("rep_ar");
            entity.Property(e => e.RepFinancialstatement)
                .HasDefaultValueSql("false")
                .HasColumnName("rep_financialstatement");
            entity.Property(e => e.RepGl)
                .HasDefaultValueSql("false")
                .HasColumnName("rep_gl");
            entity.Property(e => e.RepInventory)
                .HasDefaultValueSql("false")
                .HasColumnName("rep_inventory");
            entity.Property(e => e.RepPayroll)
                .HasDefaultValueSql("false")
                .HasColumnName("rep_payroll");
            entity.Property(e => e.Reversal)
                .HasDefaultValueSql("false")
                .HasColumnName("reversal");
            entity.Property(e => e.Servicecharge)
                .HasDefaultValueSql("false")
                .HasColumnName("servicecharge");
            entity.Property(e => e.Statemenreport)
                .HasDefaultValueSql("false")
                .HasColumnName("statemenreport");
            entity.Property(e => e.Statementapproval)
                .HasDefaultValueSql("false")
                .HasColumnName("statementapproval");
            entity.Property(e => e.Statemententry)
                .HasDefaultValueSql("false")
                .HasColumnName("statemententry");
            entity.Property(e => e.Statementreview)
                .HasDefaultValueSql("false")
                .HasColumnName("statementreview");
            entity.Property(e => e.TasksAp)
                .HasDefaultValueSql("false")
                .HasColumnName("tasks_ap");
            entity.Property(e => e.TasksAr)
                .HasDefaultValueSql("false")
                .HasColumnName("tasks_ar");
            entity.Property(e => e.TasksBill)
                .HasDefaultValueSql("false")
                .HasColumnName("tasks_bill");
            entity.Property(e => e.TasksGj)
                .HasDefaultValueSql("false")
                .HasColumnName("tasks_gj");
            entity.Property(e => e.TasksPayments)
                .HasDefaultValueSql("false")
                .HasColumnName("tasks_payments");
            entity.Property(e => e.TasksReceipts)
                .HasDefaultValueSql("false")
                .HasColumnName("tasks_receipts");
            entity.Property(e => e.TasksSettlements)
                .HasDefaultValueSql("false")
                .HasColumnName("tasks_settlements");
            entity.Property(e => e.Trial577)
                .HasMaxLength(1)
                .HasColumnName("trial577");
            entity.Property(e => e.Unreconciledrecords)
                .HasDefaultValueSql("false")
                .HasColumnName("unreconciledrecords");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasMaxLength(50)
                .HasColumnName("updateddate");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Username)
                .HasMaxLength(15)
                .HasColumnName("username");
            entity.Property(e => e.Vendorbegining)
                .HasDefaultValueSql("false")
                .HasColumnName("vendorbegining");
            entity.Property(e => e.Vendorexpenditure)
                .HasDefaultValueSql("false")
                .HasColumnName("vendorexpenditure");
            entity.Property(e => e.Voidcheck)
                .HasDefaultValueSql("false")
                .HasColumnName("voidcheck");
        });

        modelBuilder.Entity<Tblaccessaccounts1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblaccessaccounts1");

            entity.ToTable("tblaccessaccounts1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Billforpettycash)
                .HasDefaultValueSql("false")
                .HasColumnName("billforpettycash");
            entity.Property(e => e.ChkaccBeginingbalance)
                .HasDefaultValueSql("false")
                .HasColumnName("chkacc_beginingbalance");
            entity.Property(e => e.ChkaccCharts)
                .HasDefaultValueSql("false")
                .HasColumnName("chkacc_charts");
            entity.Property(e => e.ChkaccCheckregistry)
                .HasDefaultValueSql("false")
                .HasColumnName("chkacc_checkregistry");
            entity.Property(e => e.ChkaccGeneraljournal)
                .HasDefaultValueSql("false")
                .HasColumnName("chkacc_generaljournal");
            entity.Property(e => e.ChkaccPaymentpostaudit)
                .HasDefaultValueSql("false")
                .HasColumnName("chkacc_paymentpostaudit");
            entity.Property(e => e.ChkadminPostdatedchecks)
                .HasDefaultValueSql("false")
                .HasColumnName("chkadmin_postdatedchecks");
            entity.Property(e => e.ChkadminTranreversal)
                .HasDefaultValueSql("false")
                .HasColumnName("chkadmin_tranreversal");
            entity.Property(e => e.ChkadminUpdateappnonepayments)
                .HasDefaultValueSql("false")
                .HasColumnName("chkadmin_updateappnonepayments");
            entity.Property(e => e.ChkadminUpdateapppayments)
                .HasDefaultValueSql("false")
                .HasColumnName("chkadmin_updateapppayments");
            entity.Property(e => e.ChkappAccountbegining)
                .HasDefaultValueSql("false")
                .HasColumnName("chkapp_accountbegining");
            entity.Property(e => e.ChkappBillProjects)
                .HasDefaultValueSql("false")
                .HasColumnName("chkapp_bill_projects");
            entity.Property(e => e.ChkappChartofaccounts)
                .HasDefaultValueSql("false")
                .HasColumnName("chkapp_chartofaccounts");
            entity.Property(e => e.ChkappExpense)
                .HasDefaultValueSql("false")
                .HasColumnName("chkapp_expense");
            entity.Property(e => e.ChkappExpenseProjects)
                .HasDefaultValueSql("false")
                .HasColumnName("chkapp_expense_projects");
            entity.Property(e => e.ChkappGeneraljournal)
                .HasDefaultValueSql("false")
                .HasColumnName("chkapp_generaljournal");
            entity.Property(e => e.ChkappInvoiceHo)
                .HasDefaultValueSql("false")
                .HasColumnName("chkapp_invoice_ho");
            entity.Property(e => e.ChkappPaybillHo)
                .HasDefaultValueSql("false")
                .HasColumnName("chkapp_paybill_ho");
            entity.Property(e => e.ChkappPaybillProjects)
                .HasDefaultValueSql("false")
                .HasColumnName("chkapp_paybill_projects");
            entity.Property(e => e.ChkappReceiptHo)
                .HasDefaultValueSql("false")
                .HasColumnName("chkapp_receipt_ho");
            entity.Property(e => e.ChkappSettGoodsHo)
                .HasDefaultValueSql("false")
                .HasColumnName("chkapp_sett_goods_ho");
            entity.Property(e => e.ChkappSettServicesHo)
                .HasDefaultValueSql("false")
                .HasColumnName("chkapp_sett_services_ho");
            entity.Property(e => e.ChkappSettServicesP)
                .HasDefaultValueSql("false")
                .HasColumnName("chkapp_sett_services_p");
            entity.Property(e => e.ChkappSettlementHo)
                .HasDefaultValueSql("false")
                .HasColumnName("chkapp_settlement_ho");
            entity.Property(e => e.ChkappSettlementProject)
                .HasDefaultValueSql("false")
                .HasColumnName("chkapp_settlement_project");
            entity.Property(e => e.ChkappTransfereProjects)
                .HasDefaultValueSql("false")
                .HasColumnName("chkapp_transfere_projects");
            entity.Property(e => e.ChkappVendorcredit)
                .HasDefaultValueSql("false")
                .HasColumnName("chkapp_vendorcredit");
            entity.Property(e => e.ChkappVendorcreditProjects)
                .HasDefaultValueSql("false")
                .HasColumnName("chkapp_vendorcredit_projects");
            entity.Property(e => e.ChkbankCheckregistry)
                .HasDefaultValueSql("false")
                .HasColumnName("chkbank_checkregistry");
            entity.Property(e => e.ChkbankOutstanding)
                .HasDefaultValueSql("false")
                .HasColumnName("chkbank_outstanding");
            entity.Property(e => e.ChkbankReconciliation)
                .HasDefaultValueSql("false")
                .HasColumnName("chkbank_reconciliation");
            entity.Property(e => e.ChkbankRegistry)
                .HasDefaultValueSql("false")
                .HasColumnName("chkbank_registry");
            entity.Property(e => e.ChkbankStatementapproval)
                .HasDefaultValueSql("false")
                .HasColumnName("chkbank_statementapproval");
            entity.Property(e => e.ChkbankStatemententry)
                .HasDefaultValueSql("false")
                .HasColumnName("chkbank_statemententry");
            entity.Property(e => e.ChkbankStatementreport)
                .HasDefaultValueSql("false")
                .HasColumnName("chkbank_statementreport");
            entity.Property(e => e.ChkbankStatementreview)
                .HasDefaultValueSql("false")
                .HasColumnName("chkbank_statementreview");
            entity.Property(e => e.ChkbankTransfere)
                .HasDefaultValueSql("false")
                .HasColumnName("chkbank_transfere");
            entity.Property(e => e.ChkbankUnreconciled)
                .HasDefaultValueSql("false")
                .HasColumnName("chkbank_unreconciled");
            entity.Property(e => e.ChkbankVoidcheck)
                .HasDefaultValueSql("false")
                .HasColumnName("chkbank_voidcheck");
            entity.Property(e => e.ChkbankWritecheck)
                .HasDefaultValueSql("false")
                .HasColumnName("chkbank_writecheck");
            entity.Property(e => e.Chkcontacts)
                .HasDefaultValueSql("false")
                .HasColumnName("chkcontacts");
            entity.Property(e => e.Chkdashboard)
                .HasDefaultValueSql("false")
                .HasColumnName("chkdashboard");
            entity.Property(e => e.ChkpurchaseBillHo)
                .HasDefaultValueSql("false")
                .HasColumnName("chkpurchase_bill_ho");
            entity.Property(e => e.ChkpurchaseBillProjects)
                .HasDefaultValueSql("false")
                .HasColumnName("chkpurchase_bill_projects");
            entity.Property(e => e.ChkpurchaseBillServices)
                .HasDefaultValueSql("false")
                .HasColumnName("chkpurchase_bill_services");
            entity.Property(e => e.ChkpurchaseExpense)
                .HasDefaultValueSql("false")
                .HasColumnName("chkpurchase_expense");
            entity.Property(e => e.ChkpurchasePaybill)
                .HasDefaultValueSql("false")
                .HasColumnName("chkpurchase_paybill");
            entity.Property(e => e.ChkpurchasePaymentsmade)
                .HasDefaultValueSql("false")
                .HasColumnName("chkpurchase_paymentsmade");
            entity.Property(e => e.ChkpurchaseRecurringexpense)
                .HasDefaultValueSql("false")
                .HasColumnName("chkpurchase_recurringexpense");
            entity.Property(e => e.ChkpurchaseSettlement)
                .HasDefaultValueSql("false")
                .HasColumnName("chkpurchase_settlement");
            entity.Property(e => e.ChkpurchaseVendorcredit)
                .HasDefaultValueSql("false")
                .HasColumnName("chkpurchase_vendorcredit");
            entity.Property(e => e.Chkrep1Accountbeg)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep1_accountbeg");
            entity.Property(e => e.Chkrep1Balancesheet)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep1_balancesheet");
            entity.Property(e => e.Chkrep1Cashflow)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep1_cashflow");
            entity.Property(e => e.Chkrep1Chartofaccounts)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep1_chartofaccounts");
            entity.Property(e => e.Chkrep1Generaljournal)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep1_generaljournal");
            entity.Property(e => e.Chkrep1Gj)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep1_gj");
            entity.Property(e => e.Chkrep1GovTaxes)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep1_gov_taxes");
            entity.Property(e => e.Chkrep1Inventory)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep1_inventory");
            entity.Property(e => e.Chkrep1Payables)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep1_payables");
            entity.Property(e => e.Chkrep1Paymentsreceived)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep1_paymentsreceived");
            entity.Property(e => e.Chkrep1Profitloss)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep1_profitloss");
            entity.Property(e => e.Chkrep1Purchaseexpense)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep1_purchaseexpense");
            entity.Property(e => e.Chkrep1Receivables)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep1_receivables");
            entity.Property(e => e.Chkrep1Sales)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep1_sales");
            entity.Property(e => e.Chkrep1Trailbalance)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep1_trailbalance");
            entity.Property(e => e.Chkrep1VendorCustomerBeg)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep1_vendor_customer_beg");
            entity.Property(e => e.Chkrep1Vendorcustomerlrdger)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep1_vendorcustomerlrdger");
            entity.Property(e => e.Chkrep2Accountbalance)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep2_accountbalance");
            entity.Property(e => e.Chkrep2Accounttranlist)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep2_accounttranlist");
            entity.Property(e => e.Chkrep2Banktrans)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep2_banktrans");
            entity.Property(e => e.Chkrep2Boxfile)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep2_boxfile");
            entity.Property(e => e.Chkrep2Budgetrequestequip)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep2_budgetrequestequip");
            entity.Property(e => e.Chkrep2Engvsfin)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep2_engvsfin");
            entity.Property(e => e.Chkrep2Outstandingpayment)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep2_outstandingpayment");
            entity.Property(e => e.Chkrep2Payableowned)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep2_payableowned");
            entity.Property(e => e.Chkrep2Payablevsbudget)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep2_payablevsbudget");
            entity.Property(e => e.Chkrep2Payablevspayment)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep2_payablevspayment");
            entity.Property(e => e.Chkrep2Paymentpostaudit)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep2_paymentpostaudit");
            entity.Property(e => e.Chkrep2Postdatedchecks)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep2_postdatedchecks");
            entity.Property(e => e.Chkrep2Projectaccountlist)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep2_projectaccountlist");
            entity.Property(e => e.Chkrep2Purchaseledger)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep2_purchaseledger");
            entity.Property(e => e.Chkrep2PvAattachement)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep2_pv_aattachement");
            entity.Property(e => e.Chkrep2Pvstatus)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep2_pvstatus");
            entity.Property(e => e.Chkrep2Rentalbalance)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep2_rentalbalance");
            entity.Property(e => e.Chkrep2Rentalstatus)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep2_rentalstatus");
            entity.Property(e => e.Chkrep2Reversedtran)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep2_reversedtran");
            entity.Property(e => e.Chkrep2Tranwithoutattachement)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep2_tranwithoutattachement");
            entity.Property(e => e.Chkrep2TsPayables)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep2_ts_payables");
            entity.Property(e => e.Chkrep2Vendorexpenditure)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep2_vendorexpenditure");
            entity.Property(e => e.Chkrep2Vendorjournal)
                .HasDefaultValueSql("false")
                .HasColumnName("chkrep2_vendorjournal");
            entity.Property(e => e.ChksalesCollectionrequest)
                .HasDefaultValueSql("false")
                .HasColumnName("chksales_collectionrequest");
            entity.Property(e => e.ChksalesInvoiceServices)
                .HasDefaultValueSql("false")
                .HasColumnName("chksales_invoice_services");
            entity.Property(e => e.ChksalesInvoicegoods)
                .HasDefaultValueSql("false")
                .HasColumnName("chksales_invoicegoods");
            entity.Property(e => e.ChksalesPaymentsreceived)
                .HasDefaultValueSql("false")
                .HasColumnName("chksales_paymentsreceived");
            entity.Property(e => e.ChksalesReceipts)
                .HasDefaultValueSql("false")
                .HasColumnName("chksales_receipts");
            entity.Property(e => e.ChksalesReceivepayment)
                .HasDefaultValueSql("false")
                .HasColumnName("chksales_receivepayment");
            entity.Property(e => e.Chktax)
                .HasDefaultValueSql("false")
                .HasColumnName("chktax");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Paymentforpettycash)
                .HasDefaultValueSql("false")
                .HasColumnName("paymentforpettycash");
            entity.Property(e => e.Pettyattachement)
                .HasDefaultValueSql("false")
                .HasColumnName("pettyattachement");
            entity.Property(e => e.Pettyattachementapp)
                .HasDefaultValueSql("false")
                .HasColumnName("pettyattachementapp");
            entity.Property(e => e.Pettycash)
                .HasDefaultValueSql("false")
                .HasColumnName("pettycash");
            entity.Property(e => e.Pettycashdisbursement)
                .HasDefaultValueSql("false")
                .HasColumnName("pettycashdisbursement");
            entity.Property(e => e.Pettycashsettlement)
                .HasDefaultValueSql("false")
                .HasColumnName("pettycashsettlement");
            entity.Property(e => e.Pettycashsettlementapp)
                .HasDefaultValueSql("false")
                .HasColumnName("pettycashsettlementapp");
            entity.Property(e => e.ReversalBill)
                .HasDefaultValueSql("false")
                .HasColumnName("reversal_bill");
            entity.Property(e => e.ReversalJv)
                .HasDefaultValueSql("false")
                .HasColumnName("reversal_jv");
            entity.Property(e => e.ReversalPaybill)
                .HasDefaultValueSql("false")
                .HasColumnName("reversal_paybill");
            entity.Property(e => e.ReversalPv)
                .HasDefaultValueSql("false")
                .HasColumnName("reversal_pv");
            entity.Property(e => e.SettlementGoodsProjects)
                .HasDefaultValueSql("false")
                .HasColumnName("settlement_goods_projects");
            entity.Property(e => e.SettlementServicesBoth)
                .HasDefaultValueSql("false")
                .HasColumnName("settlement_services_both");
            entity.Property(e => e.Trial580)
                .HasMaxLength(1)
                .HasColumnName("trial580");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Username)
                .HasMaxLength(15)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Tblaccessadmin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblaccessadmin");

            entity.ToTable("tblaccessadmin");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accessprivilege)
                .HasDefaultValueSql("false")
                .HasColumnName("accessprivilege");
            entity.Property(e => e.Clientvendor)
                .HasDefaultValueSql("false")
                .HasColumnName("clientvendor");
            entity.Property(e => e.CrQdesigner)
                .HasDefaultValueSql("false")
                .HasColumnName("cr_qdesigner");
            entity.Property(e => e.CrViewer)
                .HasDefaultValueSql("false")
                .HasColumnName("cr_viewer");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasMaxLength(50)
                .HasColumnName("createddate");
            entity.Property(e => e.Department)
                .HasDefaultValueSql("false")
                .HasColumnName("department");
            entity.Property(e => e.Passwordchange)
                .HasDefaultValueSql("false")
                .HasColumnName("passwordchange");
            entity.Property(e => e.Paymentrequest)
                .HasDefaultValueSql("false")
                .HasColumnName("paymentrequest");
            entity.Property(e => e.Project)
                .HasDefaultValueSql("false")
                .HasColumnName("project");
            entity.Property(e => e.Purchase)
                .HasDefaultValueSql("false")
                .HasColumnName("purchase");
            entity.Property(e => e.Specialapproval)
                .HasDefaultValueSql("false")
                .HasColumnName("specialapproval");
            entity.Property(e => e.Storeclassification)
                .HasDefaultValueSql("false")
                .HasColumnName("storeclassification");
            entity.Property(e => e.Trial580)
                .HasMaxLength(1)
                .HasColumnName("trial580");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasMaxLength(50)
                .HasColumnName("updateddate");
            entity.Property(e => e.Updategrn)
                .HasDefaultValueSql("false")
                .HasColumnName("updategrn");
            entity.Property(e => e.Updatepo)
                .HasDefaultValueSql("false")
                .HasColumnName("updatepo");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Usermanagement)
                .HasDefaultValueSql("false")
                .HasColumnName("usermanagement");
            entity.Property(e => e.Username)
                .HasMaxLength(15)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Tblaccesscontract>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblaccesscontract");

            entity.ToTable("tblaccesscontract");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Admincapital)
                .HasDefaultValueSql("false")
                .HasColumnName("admincapital");
            entity.Property(e => e.Adminmachinery)
                .HasDefaultValueSql("false")
                .HasColumnName("adminmachinery");
            entity.Property(e => e.Adminpurchase)
                .HasDefaultValueSql("false")
                .HasColumnName("adminpurchase");
            entity.Property(e => e.Adminsales)
                .HasDefaultValueSql("false")
                .HasColumnName("adminsales");
            entity.Property(e => e.Adminservice)
                .HasDefaultValueSql("false")
                .HasColumnName("adminservice");
            entity.Property(e => e.Admintransport)
                .HasDefaultValueSql("false")
                .HasColumnName("admintransport");
            entity.Property(e => e.Adminvehicle)
                .HasDefaultValueSql("false")
                .HasColumnName("adminvehicle");
            entity.Property(e => e.Agreementreport)
                .HasDefaultValueSql("false")
                .HasColumnName("agreementreport");
            entity.Property(e => e.Agreementtype)
                .HasDefaultValueSql("false")
                .HasColumnName("agreementtype");
            entity.Property(e => e.Appcapital)
                .HasDefaultValueSql("false")
                .HasColumnName("appcapital");
            entity.Property(e => e.Appmachineryrental)
                .HasDefaultValueSql("0")
                .HasColumnName("appmachineryrental");
            entity.Property(e => e.Apppurchase)
                .HasDefaultValueSql("false")
                .HasColumnName("apppurchase");
            entity.Property(e => e.Appsales)
                .HasDefaultValueSql("0")
                .HasColumnName("appsales");
            entity.Property(e => e.Appservice)
                .HasDefaultValueSql("0")
                .HasColumnName("appservice");
            entity.Property(e => e.Appvehiclerental)
                .HasDefaultValueSql("0")
                .HasColumnName("appvehiclerental");
            entity.Property(e => e.Appvehicletransport)
                .HasDefaultValueSql("0")
                .HasColumnName("appvehicletransport");
            entity.Property(e => e.Capital)
                .HasDefaultValueSql("false")
                .HasColumnName("capital");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasMaxLength(50)
                .HasColumnName("createddate");
            entity.Property(e => e.Field1)
                .HasDefaultValueSql("false")
                .HasColumnName("field1");
            entity.Property(e => e.Machineryrental)
                .HasDefaultValueSql("false")
                .HasColumnName("machineryrental");
            entity.Property(e => e.Purchase)
                .HasDefaultValueSql("false")
                .HasColumnName("purchase");
            entity.Property(e => e.Sales)
                .HasDefaultValueSql("false")
                .HasColumnName("sales");
            entity.Property(e => e.Service)
                .HasDefaultValueSql("false")
                .HasColumnName("service");
            entity.Property(e => e.Trial583)
                .HasMaxLength(1)
                .HasColumnName("trial583");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasMaxLength(50)
                .HasColumnName("updateddate");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Username)
                .HasMaxLength(15)
                .HasColumnName("username");
            entity.Property(e => e.Vehiclerental)
                .HasDefaultValueSql("false")
                .HasColumnName("vehiclerental");
            entity.Property(e => e.Vehicletransport)
                .HasDefaultValueSql("false")
                .HasColumnName("vehicletransport");
        });

        modelBuilder.Entity<Tblaccessdocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblaccessdocument");

            entity.ToTable("tblaccessdocument");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Bondapproval)
                .HasDefaultValueSql("false")
                .HasColumnName("bondapproval");
            entity.Property(e => e.Bondentry)
                .HasDefaultValueSql("false")
                .HasColumnName("bondentry");
            entity.Property(e => e.Bondnotification)
                .HasDefaultValueSql("false")
                .HasColumnName("bondnotification");
            entity.Property(e => e.Bondrenewal)
                .HasDefaultValueSql("false")
                .HasColumnName("bondrenewal");
            entity.Property(e => e.Bondreports)
                .HasDefaultValueSql("false")
                .HasColumnName("bondreports");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasMaxLength(50)
                .HasColumnName("createddate");
            entity.Property(e => e.Docreports)
                .HasDefaultValueSql("false")
                .HasColumnName("docreports");
            entity.Property(e => e.Documentissue)
                .HasDefaultValueSql("false")
                .HasColumnName("documentissue");
            entity.Property(e => e.Documentreceiving)
                .HasDefaultValueSql("false")
                .HasColumnName("documentreceiving");
            entity.Property(e => e.Documentrequest)
                .HasDefaultValueSql("false")
                .HasColumnName("documentrequest");
            entity.Property(e => e.Documentreturn)
                .HasDefaultValueSql("false")
                .HasColumnName("documentreturn");
            entity.Property(e => e.Documentstatus)
                .HasDefaultValueSql("false")
                .HasColumnName("documentstatus");
            entity.Property(e => e.Documenttype)
                .HasDefaultValueSql("false")
                .HasColumnName("documenttype");
            entity.Property(e => e.Drawing)
                .HasDefaultValueSql("false")
                .HasColumnName("drawing");
            entity.Property(e => e.Incoming)
                .HasDefaultValueSql("false")
                .HasColumnName("incoming");
            entity.Property(e => e.Internal)
                .HasDefaultValueSql("false")
                .HasColumnName("internal");
            entity.Property(e => e.Issueddocuments)
                .HasDefaultValueSql("false")
                .HasColumnName("issueddocuments");
            entity.Property(e => e.Lostdocuments)
                .HasDefaultValueSql("false")
                .HasColumnName("lostdocuments");
            entity.Property(e => e.Memo)
                .HasDefaultValueSql("false")
                .HasColumnName("memo");
            entity.Property(e => e.Otherfiles)
                .HasDefaultValueSql("false")
                .HasColumnName("otherfiles");
            entity.Property(e => e.Outgoing)
                .HasDefaultValueSql("false")
                .HasColumnName("outgoing");
            entity.Property(e => e.Requestapproval)
                .HasDefaultValueSql("false")
                .HasColumnName("requestapproval");
            entity.Property(e => e.Trial583)
                .HasMaxLength(1)
                .HasColumnName("trial583");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasMaxLength(50)
                .HasColumnName("updateddate");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Username)
                .HasMaxLength(15)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Tblaccessengineering>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblaccessengineering");

            entity.ToTable("tblaccessengineering");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Allocatedresources)
                .HasDefaultValueSql("false")
                .HasColumnName("allocatedresources");
            entity.Property(e => e.Allocation)
                .HasDefaultValueSql("false")
                .HasColumnName("allocation");
            entity.Property(e => e.Allocationapproval)
                .HasDefaultValueSql("0")
                .HasColumnName("allocationapproval");
            entity.Property(e => e.Backupsheet)
                .HasDefaultValueSql("false")
                .HasColumnName("backupsheet");
            entity.Property(e => e.Backupsheetmainapp)
                .HasDefaultValueSql("false")
                .HasColumnName("backupsheetmainapp");
            entity.Property(e => e.Backupsheetsc)
                .HasDefaultValueSql("false")
                .HasColumnName("backupsheetsc");
            entity.Property(e => e.Backupsheetscapp)
                .HasDefaultValueSql("false")
                .HasColumnName("backupsheetscapp");
            entity.Property(e => e.Billgroup)
                .HasDefaultValueSql("false")
                .HasColumnName("billgroup");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasMaxLength(50)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("createddate");
            entity.Property(e => e.Dailyactivitykm)
                .HasDefaultValueSql("false")
                .HasColumnName("dailyactivitykm");
            entity.Property(e => e.Dailyactivitykmapp)
                .HasDefaultValueSql("false")
                .HasColumnName("dailyactivitykmapp");
            entity.Property(e => e.DeductionApproval)
                .HasDefaultValueSql("false")
                .HasColumnName("deduction_approval");
            entity.Property(e => e.DeductionEntry)
                .HasDefaultValueSql("false")
                .HasColumnName("deduction_entry");
            entity.Property(e => e.DeductionReport)
                .HasDefaultValueSql("false")
                .HasColumnName("deduction_report");
            entity.Property(e => e.Eqdailyactivity)
                .HasDefaultValueSql("false")
                .HasColumnName("eqdailyactivity");
            entity.Property(e => e.Expectedcosts)
                .HasDefaultValueSql("false")
                .HasColumnName("expectedcosts");
            entity.Property(e => e.Ipcreports)
                .HasDefaultValueSql("false")
                .HasColumnName("ipcreports");
            entity.Property(e => e.M3kmcontract)
                .HasDefaultValueSql("false")
                .HasColumnName("m3kmcontract");
            entity.Property(e => e.Payitems)
                .HasDefaultValueSql("false")
                .HasColumnName("payitems");
            entity.Property(e => e.Payitemssc)
                .HasDefaultValueSql("false")
                .HasColumnName("payitemssc");
            entity.Property(e => e.Priceadjustment)
                .HasDefaultValueSql("false")
                .HasColumnName("priceadjustment");
            entity.Property(e => e.Projectexpense)
                .HasDefaultValueSql("false")
                .HasColumnName("projectexpense");
            entity.Property(e => e.Projectreports)
                .HasDefaultValueSql("false")
                .HasColumnName("projectreports");
            entity.Property(e => e.Screport)
                .HasDefaultValueSql("false")
                .HasColumnName("screport");
            entity.Property(e => e.Site)
                .HasDefaultValueSql("false")
                .HasColumnName("site");
            entity.Property(e => e.Station)
                .HasDefaultValueSql("false")
                .HasColumnName("station");
            entity.Property(e => e.Subcontractor)
                .HasDefaultValueSql("false")
                .HasColumnName("subcontractor");
            entity.Property(e => e.Timesheetappdaily)
                .HasDefaultValueSql("false")
                .HasColumnName("timesheetappdaily");
            entity.Property(e => e.Timesheetapproval)
                .HasDefaultValueSql("0")
                .HasColumnName("timesheetapproval");
            entity.Property(e => e.Timesheetentry)
                .HasDefaultValueSql("false")
                .HasColumnName("timesheetentry");
            entity.Property(e => e.Timesheetlist)
                .HasDefaultValueSql("false")
                .HasColumnName("timesheetlist");
            entity.Property(e => e.Timesheetreport)
                .HasDefaultValueSql("false")
                .HasColumnName("timesheetreport");
            entity.Property(e => e.Timesheetstatus)
                .HasDefaultValueSql("false")
                .HasColumnName("timesheetstatus");
            entity.Property(e => e.Timesheetsummary)
                .HasDefaultValueSql("false")
                .HasColumnName("timesheetsummary");
            entity.Property(e => e.Trial583)
                .HasMaxLength(1)
                .HasColumnName("trial583");
            entity.Property(e => e.Unitofmeasure)
                .HasDefaultValueSql("false")
                .HasColumnName("unitofmeasure");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasMaxLength(50)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("updateddate");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Username)
                .HasMaxLength(15)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Tblaccessequipment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblaccessequipment");

            entity.ToTable("tblaccessequipment");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Caniblization)
                .HasDefaultValueSql("false")
                .HasColumnName("caniblization");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasMaxLength(50)
                .HasColumnName("createddate");
            entity.Property(e => e.Dailyactivity)
                .HasDefaultValueSql("false")
                .HasColumnName("dailyactivity");
            entity.Property(e => e.Dailyactivityapp)
                .HasDefaultValueSql("false")
                .HasColumnName("dailyactivityapp");
            entity.Property(e => e.Dailyactivitykm)
                .HasDefaultValueSql("false")
                .HasColumnName("dailyactivitykm");
            entity.Property(e => e.Documentreport)
                .HasDefaultValueSql("false")
                .HasColumnName("documentreport");
            entity.Property(e => e.Equipmentcategory)
                .HasDefaultValueSql("false")
                .HasColumnName("equipmentcategory");
            entity.Property(e => e.Equipmentparts)
                .HasDefaultValueSql("false")
                .HasColumnName("equipmentparts");
            entity.Property(e => e.Equipmentreports)
                .HasDefaultValueSql("false")
                .HasColumnName("equipmentreports");
            entity.Property(e => e.Inspection)
                .HasDefaultValueSql("false")
                .HasColumnName("inspection");
            entity.Property(e => e.Jobstatus)
                .HasDefaultValueSql("false")
                .HasColumnName("jobstatus");
            entity.Property(e => e.Maintcompletion)
                .HasDefaultValueSql("false")
                .HasColumnName("maintcompletion");
            entity.Property(e => e.Outsource)
                .HasDefaultValueSql("false")
                .HasColumnName("outsource");
            entity.Property(e => e.Ownedeqattachementapp)
                .HasDefaultValueSql("false")
                .HasColumnName("ownedeqattachementapp");
            entity.Property(e => e.Ownedeqattachemententry)
                .HasDefaultValueSql("false")
                .HasColumnName("ownedeqattachemententry");
            entity.Property(e => e.Ownedequipment)
                .HasDefaultValueSql("false")
                .HasColumnName("ownedequipment");
            entity.Property(e => e.Pmschedule)
                .HasDefaultValueSql("false")
                .HasColumnName("pmschedule");
            entity.Property(e => e.Pmtypes)
                .HasDefaultValueSql("false")
                .HasColumnName("pmtypes");
            entity.Property(e => e.Problemcodes)
                .HasDefaultValueSql("false")
                .HasColumnName("problemcodes");
            entity.Property(e => e.Propertyapproval)
                .HasDefaultValueSql("false")
                .HasColumnName("propertyapproval");
            entity.Property(e => e.Propertyregistry)
                .HasDefaultValueSql("false")
                .HasColumnName("propertyregistry");
            entity.Property(e => e.Propertyreview)
                .HasDefaultValueSql("false")
                .HasColumnName("propertyreview");
            entity.Property(e => e.Propertyupdate)
                .HasDefaultValueSql("false")
                .HasColumnName("propertyupdate");
            entity.Property(e => e.Quotationapproval)
                .HasDefaultValueSql("false")
                .HasColumnName("quotationapproval");
            entity.Property(e => e.Quotationrequest)
                .HasDefaultValueSql("false")
                .HasColumnName("quotationrequest");
            entity.Property(e => e.Tools)
                .HasDefaultValueSql("false")
                .HasColumnName("tools");
            entity.Property(e => e.Trial590)
                .HasMaxLength(1)
                .HasColumnName("trial590");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasMaxLength(50)
                .HasColumnName("updateddate");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Username)
                .HasMaxLength(15)
                .HasColumnName("username");
            entity.Property(e => e.Workorderapproval)
                .HasDefaultValueSql("false")
                .HasColumnName("workorderapproval");
            entity.Property(e => e.Workorderprint)
                .HasDefaultValueSql("false")
                .HasColumnName("workorderprint");
            entity.Property(e => e.Workshop)
                .HasDefaultValueSql("false")
                .HasColumnName("workshop");
        });

        modelBuilder.Entity<Tblaccessfinance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_accessfinance");

            entity.ToTable("tblaccessfinance");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accounttype)
                .HasDefaultValueSql("false")
                .HasColumnName("accounttype");
            entity.Property(e => e.Attachementapproval)
                .HasDefaultValueSql("false")
                .HasColumnName("attachementapproval");
            entity.Property(e => e.Bankbalances)
                .HasDefaultValueSql("false")
                .HasColumnName("bankbalances");
            entity.Property(e => e.Bankreconcilation)
                .HasDefaultValueSql("false")
                .HasColumnName("bankreconcilation");
            entity.Property(e => e.Banks)
                .HasDefaultValueSql("false")
                .HasColumnName("banks");
            entity.Property(e => e.Banktransaction)
                .HasDefaultValueSql("false")
                .HasColumnName("banktransaction");
            entity.Property(e => e.Billapproval)
                .HasDefaultValueSql("false")
                .HasColumnName("billapproval");
            entity.Property(e => e.Billforpayment)
                .HasDefaultValueSql("false")
                .HasColumnName("billforpayment");
            entity.Property(e => e.Billreview)
                .HasDefaultValueSql("false")
                .HasColumnName("billreview");
            entity.Property(e => e.Billstatus)
                .HasDefaultValueSql("false")
                .HasColumnName("billstatus");
            entity.Property(e => e.Chartofaccounts)
                .HasDefaultValueSql("false")
                .HasColumnName("chartofaccounts");
            entity.Property(e => e.Client)
                .HasDefaultValueSql("false")
                .HasColumnName("client");
            entity.Property(e => e.Collectionattachement)
                .HasDefaultValueSql("false")
                .HasColumnName("collectionattachement");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasMaxLength(50)
                .HasColumnName("createddate");
            entity.Property(e => e.Disbursement)
                .HasDefaultValueSql("false")
                .HasColumnName("disbursement");
            entity.Property(e => e.Disbursementapproval)
                .HasDefaultValueSql("false")
                .HasColumnName("disbursementapproval");
            entity.Property(e => e.Documentissue)
                .HasDefaultValueSql("false")
                .HasColumnName("documentissue");
            entity.Property(e => e.Documentreceiving)
                .HasDefaultValueSql("false")
                .HasColumnName("documentreceiving");
            entity.Property(e => e.Documentrequest)
                .HasDefaultValueSql("false")
                .HasColumnName("documentrequest");
            entity.Property(e => e.Documentreturn)
                .HasDefaultValueSql("false")
                .HasColumnName("documentreturn");
            entity.Property(e => e.Documentstatus)
                .HasDefaultValueSql("false")
                .HasColumnName("documentstatus");
            entity.Property(e => e.Income)
                .HasDefaultValueSql("false")
                .HasColumnName("income");
            entity.Property(e => e.Incomeapproval)
                .HasDefaultValueSql("false")
                .HasColumnName("incomeapproval");
            entity.Property(e => e.Incomebillapproval)
                .HasDefaultValueSql("false")
                .HasColumnName("incomebillapproval");
            entity.Property(e => e.Incomebillentry)
                .HasDefaultValueSql("false")
                .HasColumnName("incomebillentry");
            entity.Property(e => e.Incomebillreview)
                .HasDefaultValueSql("false")
                .HasColumnName("incomebillreview");
            entity.Property(e => e.Incomereview)
                .HasDefaultValueSql("false")
                .HasColumnName("incomereview");
            entity.Property(e => e.Issueddocuments)
                .HasDefaultValueSql("false")
                .HasColumnName("issueddocuments");
            entity.Property(e => e.Journalsetup)
                .HasDefaultValueSql("false")
                .HasColumnName("journalsetup");
            entity.Property(e => e.Lostdocuments)
                .HasDefaultValueSql("false")
                .HasColumnName("lostdocuments");
            entity.Property(e => e.M3kmAppEng)
                .HasDefaultValueSql("false")
                .HasColumnName("m3km_app_eng");
            entity.Property(e => e.M3kmAppFin)
                .HasDefaultValueSql("false")
                .HasColumnName("m3km_app_fin");
            entity.Property(e => e.M3kmReports)
                .HasDefaultValueSql("false")
                .HasColumnName("m3km_reports");
            entity.Property(e => e.M3kmReview)
                .HasDefaultValueSql("false")
                .HasColumnName("m3km_review");
            entity.Property(e => e.Payableapproval)
                .HasDefaultValueSql("false")
                .HasColumnName("payableapproval");
            entity.Property(e => e.Payableattachement)
                .HasDefaultValueSql("false")
                .HasColumnName("payableattachement");
            entity.Property(e => e.Paymentorder)
                .HasDefaultValueSql("false")
                .HasColumnName("paymentorder");
            entity.Property(e => e.Postdated)
                .HasDefaultValueSql("false")
                .HasColumnName("postdated");
            entity.Property(e => e.Pvattachement)
                .HasDefaultValueSql("false")
                .HasColumnName("pvattachement");
            entity.Property(e => e.Pvattachementreport)
                .HasDefaultValueSql("false")
                .HasColumnName("pvattachementreport");
            entity.Property(e => e.Pvstatus)
                .HasDefaultValueSql("false")
                .HasColumnName("pvstatus");
            entity.Property(e => e.Requestapproval)
                .HasDefaultValueSql("false")
                .HasColumnName("requestapproval");
            entity.Property(e => e.Setelementattachement)
                .HasDefaultValueSql("false")
                .HasColumnName("setelementattachement");
            entity.Property(e => e.Timesheetapproval)
                .HasDefaultValueSql("0")
                .HasColumnName("timesheetapproval");
            entity.Property(e => e.Trial590)
                .HasMaxLength(1)
                .HasColumnName("trial590");
            entity.Property(e => e.Tsreport)
                .HasDefaultValueSql("false")
                .HasColumnName("tsreport");
            entity.Property(e => e.Tsstatus)
                .HasDefaultValueSql("false")
                .HasColumnName("tsstatus");
            entity.Property(e => e.Tssummary)
                .HasDefaultValueSql("false")
                .HasColumnName("tssummary");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasMaxLength(50)
                .HasColumnName("updateddate");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Username)
                .HasMaxLength(15)
                .HasColumnName("username");
            entity.Property(e => e.Vendor)
                .HasDefaultValueSql("false")
                .HasColumnName("vendor");
            entity.Property(e => e.Vendorexpenditure)
                .HasDefaultValueSql("false")
                .HasColumnName("vendorexpenditure");
            entity.Property(e => e.Voidcheck)
                .HasDefaultValueSql("false")
                .HasColumnName("voidcheck");
        });

        modelBuilder.Entity<Tblaccesshrm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblaccesshrm");

            entity.ToTable("tblaccesshrm");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasMaxLength(50)
                .HasColumnName("createddate");
            entity.Property(e => e.Dailylabourer)
                .HasDefaultValueSql("false")
                .HasColumnName("dailylabourer");
            entity.Property(e => e.Denomination)
                .HasDefaultValueSql("false")
                .HasColumnName("denomination");
            entity.Property(e => e.DlBudget)
                .HasDefaultValueSql("false")
                .HasColumnName("dl_budget");
            entity.Property(e => e.DlPayroll)
                .HasDefaultValueSql("false")
                .HasColumnName("dl_payroll");
            entity.Property(e => e.DlPayrollBudgetRequest)
                .HasDefaultValueSql("false")
                .HasColumnName("dl_payroll_budget_request");
            entity.Property(e => e.DlPrintPayrollBudget)
                .HasDefaultValueSql("false")
                .HasColumnName("dl_print_payroll_budget");
            entity.Property(e => e.DlRegistry)
                .HasDefaultValueSql("false")
                .HasColumnName("dl_registry");
            entity.Property(e => e.DlRegistryList)
                .HasDefaultValueSql("false")
                .HasColumnName("dl_registry_list");
            entity.Property(e => e.DlTimesheet)
                .HasDefaultValueSql("false")
                .HasColumnName("dl_timesheet");
            entity.Property(e => e.DlTimesheetList)
                .HasDefaultValueSql("false")
                .HasColumnName("dl_timesheet_list");
            entity.Property(e => e.DlTimesheetapp)
                .HasDefaultValueSql("false")
                .HasColumnName("dl_timesheetapp");
            entity.Property(e => e.DlTimesheetreview)
                .HasDefaultValueSql("false")
                .HasColumnName("dl_timesheetreview");
            entity.Property(e => e.Docattachementapp)
                .HasDefaultValueSql("false")
                .HasColumnName("docattachementapp");
            entity.Property(e => e.Docattachemententry)
                .HasDefaultValueSql("false")
                .HasColumnName("docattachemententry");
            entity.Property(e => e.Documentreport)
                .HasDefaultValueSql("false")
                .HasColumnName("documentreport");
            entity.Property(e => e.Documenttype)
                .HasDefaultValueSql("false")
                .HasColumnName("documenttype");
            entity.Property(e => e.EmpBudget)
                .HasDefaultValueSql("false")
                .HasColumnName("emp_budget");
            entity.Property(e => e.EmpTimecard).HasColumnName("emp_timecard");
            entity.Property(e => e.Employee)
                .HasDefaultValueSql("false")
                .HasColumnName("employee");
            entity.Property(e => e.EmployeePayrollBudgetRequest)
                .HasDefaultValueSql("false")
                .HasColumnName("employee_payroll_budget_request");
            entity.Property(e => e.EmployeePrintPayrollBudget)
                .HasDefaultValueSql("false")
                .HasColumnName("employee_print_payroll_budget");
            entity.Property(e => e.Employeelist)
                .HasDefaultValueSql("false")
                .HasColumnName("employeelist");
            entity.Property(e => e.Hrreports)
                .HasDefaultValueSql("false")
                .HasColumnName("hrreports");
            entity.Property(e => e.Jobtitle)
                .HasDefaultValueSql("false")
                .HasColumnName("jobtitle");
            entity.Property(e => e.Newpayperiod)
                .HasDefaultValueSql("false")
                .HasColumnName("newpayperiod");
            entity.Property(e => e.Payrollsheet)
                .HasDefaultValueSql("false")
                .HasColumnName("payrollsheet");
            entity.Property(e => e.Payrollsheetselected)
                .HasDefaultValueSql("false")
                .HasColumnName("payrollsheetselected");
            entity.Property(e => e.Payrollsummary)
                .HasDefaultValueSql("false")
                .HasColumnName("payrollsummary");
            entity.Property(e => e.Perdiumappdept)
                .HasDefaultValueSql("false")
                .HasColumnName("perdiumappdept");
            entity.Property(e => e.Perdiumprocess)
                .HasDefaultValueSql("false")
                .HasColumnName("perdiumprocess");
            entity.Property(e => e.Perdiumrequest)
                .HasDefaultValueSql("false")
                .HasColumnName("perdiumrequest");
            entity.Property(e => e.Printpayrollslip)
                .HasDefaultValueSql("false")
                .HasColumnName("printpayrollslip");
            entity.Property(e => e.Submitpayroll)
                .HasDefaultValueSql("false")
                .HasColumnName("submitpayroll");
            entity.Property(e => e.Taxrate)
                .HasDefaultValueSql("false")
                .HasColumnName("taxrate");
            entity.Property(e => e.Timesheet)
                .HasDefaultValueSql("false")
                .HasColumnName("timesheet");
            entity.Property(e => e.Trial593)
                .HasMaxLength(1)
                .HasColumnName("trial593");
            entity.Property(e => e.Tsapproval)
                .HasDefaultValueSql("false")
                .HasColumnName("tsapproval");
            entity.Property(e => e.Tsreversal)
                .HasDefaultValueSql("false")
                .HasColumnName("tsreversal");
            entity.Property(e => e.Tsreview)
                .HasDefaultValueSql("false")
                .HasColumnName("tsreview");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasMaxLength(50)
                .HasColumnName("updateddate");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Username)
                .HasMaxLength(15)
                .HasColumnName("username");
            entity.Property(e => e.Viewpayrollsheet)
                .HasDefaultValueSql("false")
                .HasColumnName("viewpayrollsheet");
        });

        modelBuilder.Entity<Tblaccessinventory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblaccessinventory");

            entity.ToTable("tblaccessinventory");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdby)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("createddate");
            entity.Property(e => e.FinanaceRequest)
                .HasDefaultValueSql("false")
                .HasColumnName("finanace_request");
            entity.Property(e => e.GrnHo)
                .HasDefaultValueSql("false")
                .HasColumnName("grn_ho");
            entity.Property(e => e.GrnProject)
                .HasDefaultValueSql("false")
                .HasColumnName("grn_project");
            entity.Property(e => e.InvenroryReports)
                .HasDefaultValueSql("false")
                .HasColumnName("invenrory_reports");
            entity.Property(e => e.ItemMaster)
                .HasDefaultValueSql("false")
                .HasColumnName("item_master");
            entity.Property(e => e.Mtv)
                .HasDefaultValueSql("false")
                .HasColumnName("mtv");
            entity.Property(e => e.PhysicalCount)
                .HasDefaultValueSql("false")
                .HasColumnName("physical_count");
            entity.Property(e => e.Po)
                .HasDefaultValueSql("false")
                .HasColumnName("po");
            entity.Property(e => e.PoApproval)
                .HasDefaultValueSql("false")
                .HasColumnName("po_approval");
            entity.Property(e => e.Prapproval)
                .HasDefaultValueSql("0")
                .HasColumnName("prapproval");
            entity.Property(e => e.Priceapproval)
                .HasDefaultValueSql("0")
                .HasColumnName("priceapproval");
            entity.Property(e => e.PurchaseRequisition)
                .HasDefaultValueSql("false")
                .HasColumnName("purchase_requisition");
            entity.Property(e => e.Quotation)
                .HasDefaultValueSql("false")
                .HasColumnName("quotation");
            entity.Property(e => e.QuotationApproval)
                .HasDefaultValueSql("false")
                .HasColumnName("quotation_approval");
            entity.Property(e => e.Siv)
                .HasDefaultValueSql("false")
                .HasColumnName("siv");
            entity.Property(e => e.SrApproval)
                .HasDefaultValueSql("0")
                .HasColumnName("sr_approval");
            entity.Property(e => e.Srv)
                .HasDefaultValueSql("false")
                .HasColumnName("srv");
            entity.Property(e => e.SrvApp)
                .HasDefaultValueSql("false")
                .HasColumnName("srv_app");
            entity.Property(e => e.Store)
                .HasDefaultValueSql("false")
                .HasColumnName("store");
            entity.Property(e => e.StoreRequisition)
                .HasDefaultValueSql("false")
                .HasColumnName("store_requisition");
            entity.Property(e => e.Trial593)
                .HasMaxLength(1)
                .HasColumnName("trial593");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("updateddate");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Username)
                .HasMaxLength(15)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Tblaccesspayment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblaccesspayment");

            entity.ToTable("tblaccesspayment");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approval)
                .HasDefaultValueSql("0")
                .HasColumnName("approval");
            entity.Property(e => e.Bankreconciliation)
                .HasDefaultValueSql("false")
                .HasColumnName("bankreconciliation");
            entity.Property(e => e.Checkregistry)
                .HasDefaultValueSql("false")
                .HasColumnName("checkregistry");
            entity.Property(e => e.Confirmation)
                .HasDefaultValueSql("false")
                .HasColumnName("confirmation");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasMaxLength(50)
                .HasColumnName("createddate");
            entity.Property(e => e.Dedaccountsetup)
                .HasDefaultValueSql("false")
                .HasColumnName("dedaccountsetup");
            entity.Property(e => e.Outstanding)
                .HasDefaultValueSql("false")
                .HasColumnName("outstanding");
            entity.Property(e => e.Paymentreports)
                .HasDefaultValueSql("false")
                .HasColumnName("paymentreports");
            entity.Property(e => e.Rejectbudget)
                .HasDefaultValueSql("false")
                .HasColumnName("rejectbudget");
            entity.Property(e => e.Rentalbill)
                .HasDefaultValueSql("false")
                .HasColumnName("rentalbill");
            entity.Property(e => e.Rentalbillm3km)
                .HasDefaultValueSql("false")
                .HasColumnName("rentalbillm3km");
            entity.Property(e => e.Rentaldeductions)
                .HasDefaultValueSql("false")
                .HasColumnName("rentaldeductions");
            entity.Property(e => e.Rentaldeductionsapproval)
                .HasDefaultValueSql("false")
                .HasColumnName("rentaldeductionsapproval");
            entity.Property(e => e.Request)
                .HasDefaultValueSql("false")
                .HasColumnName("request");
            entity.Property(e => e.Statemenreport)
                .HasDefaultValueSql("false")
                .HasColumnName("statemenreport");
            entity.Property(e => e.Statementapproval)
                .HasDefaultValueSql("false")
                .HasColumnName("statementapproval");
            entity.Property(e => e.Statemententry)
                .HasDefaultValueSql("false")
                .HasColumnName("statemententry");
            entity.Property(e => e.Statementreview)
                .HasDefaultValueSql("false")
                .HasColumnName("statementreview");
            entity.Property(e => e.Trial593)
                .HasMaxLength(1)
                .HasColumnName("trial593");
            entity.Property(e => e.Unreconciledrecords)
                .HasDefaultValueSql("false")
                .HasColumnName("unreconciledrecords");
            entity.Property(e => e.Updatebill)
                .HasDefaultValueSql("false")
                .HasColumnName("updatebill");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasMaxLength(50)
                .HasColumnName("updateddate");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Username)
                .HasMaxLength(15)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Tblaccessplanning>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblaccessplanning");

            entity.ToTable("tblaccessplanning");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Billgroup)
                .HasDefaultValueSql("false")
                .HasColumnName("billgroup");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasMaxLength(50)
                .HasColumnName("createddate");
            entity.Property(e => e.Payitems)
                .HasDefaultValueSql("false")
                .HasColumnName("payitems");
            entity.Property(e => e.Planningreports)
                .HasDefaultValueSql("false")
                .HasColumnName("planningreports");
            entity.Property(e => e.Projectbudget)
                .HasDefaultValueSql("false")
                .HasColumnName("projectbudget");
            entity.Property(e => e.Projectexecution)
                .HasDefaultValueSql("false")
                .HasColumnName("projectexecution");
            entity.Property(e => e.Projectplan)
                .HasDefaultValueSql("false")
                .HasColumnName("projectplan");
            entity.Property(e => e.Trial596)
                .HasMaxLength(1)
                .HasColumnName("trial596");
            entity.Property(e => e.Unitofmeasure)
                .HasDefaultValueSql("false")
                .HasColumnName("unitofmeasure");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasMaxLength(50)
                .HasColumnName("updateddate");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Username)
                .HasMaxLength(15)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Tblaccesspm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblaccesspm");

            entity.ToTable("tblaccesspm");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Attachgrn)
                .HasDefaultValueSql("false")
                .HasColumnName("attachgrn");
            entity.Property(e => e.Attachsiv)
                .HasDefaultValueSql("false")
                .HasColumnName("attachsiv");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasMaxLength(50)
                .HasColumnName("createddate");
            entity.Property(e => e.Grn)
                .HasDefaultValueSql("false")
                .HasColumnName("grn");
            entity.Property(e => e.Grnapproval)
                .HasDefaultValueSql("false")
                .HasColumnName("grnapproval");
            entity.Property(e => e.Grnreview)
                .HasDefaultValueSql("false")
                .HasColumnName("grnreview");
            entity.Property(e => e.Inventoryadjustment)
                .HasDefaultValueSql("false")
                .HasColumnName("inventoryadjustment");
            entity.Property(e => e.Materialreturn)
                .HasDefaultValueSql("false")
                .HasColumnName("materialreturn");
            entity.Property(e => e.Materialreturnapp)
                .HasDefaultValueSql("false")
                .HasColumnName("materialreturnapp");
            entity.Property(e => e.Physicalcountentered)
                .HasDefaultValueSql("false")
                .HasColumnName("physicalcountentered");
            entity.Property(e => e.Physicalcountsheet)
                .HasDefaultValueSql("false")
                .HasColumnName("physicalcountsheet");
            entity.Property(e => e.Pmreports)
                .HasDefaultValueSql("false")
                .HasColumnName("pmreports");
            entity.Property(e => e.Projectpurchase)
                .HasDefaultValueSql("false")
                .HasColumnName("projectpurchase");
            entity.Property(e => e.Siv)
                .HasDefaultValueSql("false")
                .HasColumnName("siv");
            entity.Property(e => e.Sivapproval)
                .HasDefaultValueSql("false")
                .HasColumnName("sivapproval");
            entity.Property(e => e.Sivreview)
                .HasDefaultValueSql("false")
                .HasColumnName("sivreview");
            entity.Property(e => e.Sivupdate)
                .HasDefaultValueSql("false")
                .HasColumnName("sivupdate");
            entity.Property(e => e.Stockitemreconciliation)
                .HasDefaultValueSql("false")
                .HasColumnName("stockitemreconciliation");
            entity.Property(e => e.Trial596)
                .HasMaxLength(1)
                .HasColumnName("trial596");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasMaxLength(50)
                .HasColumnName("updateddate");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Username)
                .HasMaxLength(15)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Tblaccountbegining>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblaccountbegining");

            entity.ToTable("tblaccountbegining");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Credit)
                .HasPrecision(18, 2)
                .HasColumnName("credit");
            entity.Property(e => e.Debit)
                .HasPrecision(18, 2)
                .HasColumnName("debit");
            entity.Property(e => e.GlAccount)
                .HasMaxLength(50)
                .HasColumnName("gl_account");
            entity.Property(e => e.GlDescription)
                .HasMaxLength(200)
                .HasColumnName("gl_description");
            entity.Property(e => e.Trial596)
                .HasMaxLength(1)
                .HasColumnName("trial596");
            entity.Property(e => e.VendorCustomerId).HasColumnName("vendor_customer_id");
            entity.Property(e => e.VendorCustomerName)
                .HasMaxLength(200)
                .HasColumnName("vendor_customer_name");
        });

        modelBuilder.Entity<TblaccountsArchive>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblaccounts_archive");

            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasMaxLength(50)
                .HasColumnName("approveddate");
            entity.Property(e => e.Bankstatementid).HasColumnName("bankstatementid");
            entity.Property(e => e.Boxfileno)
                .HasMaxLength(50)
                .HasColumnName("boxfileno");
            entity.Property(e => e.Budgetyear).HasColumnName("budgetyear");
            entity.Property(e => e.CashReceiptDate).HasColumnName("cash_receipt_date");
            entity.Property(e => e.CashReceiptNo)
                .HasMaxLength(50)
                .HasColumnName("cash_receipt_no");
            entity.Property(e => e.Checkissuedate).HasColumnName("checkissuedate");
            entity.Property(e => e.Checknumberorreference)
                .HasMaxLength(50)
                .HasColumnName("checknumberorreference");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.FsNo)
                .HasMaxLength(50)
                .HasColumnName("fs_no");
            entity.Property(e => e.GlAccount)
                .HasMaxLength(50)
                .HasColumnName("gl_account");
            entity.Property(e => e.GlCredit)
                .HasPrecision(18, 2)
                .HasColumnName("gl_credit");
            entity.Property(e => e.GlDebit)
                .HasPrecision(18, 2)
                .HasColumnName("gl_debit");
            entity.Property(e => e.GlDescription)
                .HasMaxLength(200)
                .HasColumnName("gl_description");
            entity.Property(e => e.Hascompletedocument).HasColumnName("hascompletedocument");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(50)
                .HasColumnName("invoice_no");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isbankaccount).HasColumnName("isbankaccount");
            entity.Property(e => e.Isbegining).HasColumnName("isbegining");
            entity.Property(e => e.Ischeckconfirmed).HasColumnName("ischeckconfirmed");
            entity.Property(e => e.Isfromsource).HasColumnName("isfromsource");
            entity.Property(e => e.Ispaid).HasColumnName("ispaid");
            entity.Property(e => e.Ispostdated).HasColumnName("ispostdated");
            entity.Property(e => e.Isprojectaccounts).HasColumnName("isprojectaccounts");
            entity.Property(e => e.Isprojectpettycash).HasColumnName("isprojectpettycash");
            entity.Property(e => e.Ispurchase).HasColumnName("ispurchase");
            entity.Property(e => e.Isrental).HasColumnName("isrental");
            entity.Property(e => e.Isreplenished).HasColumnName("isreplenished");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Isvoidcheck).HasColumnName("isvoidcheck");
            entity.Property(e => e.Job).HasColumnName("job");
            entity.Property(e => e.JobId)
                .HasMaxLength(50)
                .HasColumnName("job_id");
            entity.Property(e => e.JobName)
                .HasMaxLength(100)
                .HasColumnName("job_name");
            entity.Property(e => e.JvNo)
                .HasMaxLength(20)
                .HasColumnName("jv_no");
            entity.Property(e => e.MrcNumber)
                .HasMaxLength(50)
                .HasColumnName("mrc_number");
            entity.Property(e => e.Nameoncheckid).HasColumnName("nameoncheckid");
            entity.Property(e => e.Nameoncheckname)
                .HasMaxLength(200)
                .HasColumnName("nameoncheckname");
            entity.Property(e => e.PettycashNo)
                .HasMaxLength(20)
                .HasColumnName("pettycash_no");
            entity.Property(e => e.PlateNo)
                .HasMaxLength(50)
                .HasColumnName("plate_no");
            entity.Property(e => e.PoNpo)
                .HasMaxLength(20)
                .HasColumnName("po_npo");
            entity.Property(e => e.PvNo)
                .HasMaxLength(20)
                .HasColumnName("pv_no");
            entity.Property(e => e.Recordtype)
                .HasMaxLength(10)
                .HasColumnName("recordtype");
            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .HasColumnName("reference");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .HasColumnName("remark");
            entity.Property(e => e.Reqid)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("reqid");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasMaxLength(50)
                .HasColumnName("revieweddate");
            entity.Property(e => e.Servicecharge)
                .HasPrecision(18, 2)
                .HasColumnName("servicecharge");
            entity.Property(e => e.Signername)
                .HasMaxLength(100)
                .HasColumnName("signername");
            entity.Property(e => e.Statusofpayee)
                .HasMaxLength(10)
                .HasColumnName("statusofpayee");
            entity.Property(e => e.TranDate).HasColumnName("tran_date");
            entity.Property(e => e.Transubtype)
                .HasMaxLength(20)
                .HasColumnName("transubtype");
            entity.Property(e => e.Trial599)
                .HasMaxLength(1)
                .HasColumnName("trial599");
            entity.Property(e => e.Typeofpayment)
                .HasMaxLength(50)
                .HasColumnName("typeofpayment");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.VendorCustomerId).HasColumnName("vendor_customer_id");
            entity.Property(e => e.VendorCustomerName)
                .HasMaxLength(100)
                .HasColumnName("vendor_customer_name");
            entity.Property(e => e.Zohoid).HasColumnName("zohoid");
        });

        modelBuilder.Entity<Tblaccountsetup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblaccountsetup");

            entity.ToTable("tblaccountsetup");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DefaultBankAccount)
                .HasMaxLength(50)
                .HasColumnName("default_bank_account");
            entity.Property(e => e.Trial642)
                .HasMaxLength(1)
                .HasColumnName("trial642");
            entity.Property(e => e.VatGlAccount)
                .HasMaxLength(50)
                .HasColumnName("vat_gl_account");
            entity.Property(e => e.WhtGlAccount)
                .HasMaxLength(50)
                .HasColumnName("wht_gl_account");
        });

        modelBuilder.Entity<Tblagreement>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblagreements");

            entity.Property(e => e.Agreementid).HasColumnName("agreementid");
            entity.Property(e => e.Agreementname)
                .HasMaxLength(200)
                .HasColumnName("agreementname");
            entity.Property(e => e.Agreementtypeid).HasColumnName("agreementtypeid");
            entity.Property(e => e.Ownerid).HasColumnName("ownerid");
            entity.Property(e => e.Ownername)
                .HasMaxLength(200)
                .HasColumnName("ownername");
            entity.Property(e => e.PlateNo)
                .HasMaxLength(100)
                .HasColumnName("plate_no");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Projectname)
                .HasMaxLength(150)
                .HasColumnName("projectname");
            entity.Property(e => e.Startdate).HasColumnName("startdate");
            entity.Property(e => e.Trial645)
                .HasMaxLength(1)
                .HasColumnName("trial645");
        });

        modelBuilder.Entity<Tblarchiveactivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblarchiveactivity");

            entity.ToTable("tblarchiveactivity");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasPrecision(18, 2)
                .HasColumnName("amount");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(100)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.CollectionReference)
                .HasMaxLength(50)
                .HasColumnName("collection_reference");
            entity.Property(e => e.Createdby)
                .HasMaxLength(100)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Dateissued).HasColumnName("dateissued");
            entity.Property(e => e.Daterequested).HasColumnName("daterequested");
            entity.Property(e => e.Datereturned).HasColumnName("datereturned");
            entity.Property(e => e.Deptid).HasColumnName("deptid");
            entity.Property(e => e.Documenttype)
                .HasMaxLength(20)
                .HasColumnName("documenttype");
            entity.Property(e => e.Isapproved)
                .HasDefaultValueSql("false")
                .HasColumnName("isapproved");
            entity.Property(e => e.Issuedby)
                .HasMaxLength(100)
                .HasColumnName("issuedby");
            entity.Property(e => e.PayeePayerName)
                .HasMaxLength(100)
                .HasColumnName("payee_payer_name");
            entity.Property(e => e.PvNo).HasColumnName("pv_no");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .HasColumnName("reason");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("status");
            entity.Property(e => e.Trial645)
                .HasMaxLength(1)
                .HasColumnName("trial645");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Tblautopo>(entity =>
        {
            entity.HasKey(e => e.PoNo).HasName("pk_tblautopo");

            entity.ToTable("tblautopo");

            entity.Property(e => e.PoNo).HasColumnName("po_no");
            entity.Property(e => e.Amount)
                .HasPrecision(18, 2)
                .HasColumnName("amount");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Trial645)
                .HasMaxLength(1)
                .HasColumnName("trial645");
        });

        modelBuilder.Entity<Tblautorefreceivable>(entity =>
        {
            entity.HasKey(e => e.Autono).HasName("pk_tblautorefreceivable");

            entity.ToTable("tblautorefreceivable");

            entity.Property(e => e.Autono).HasColumnName("autono");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Trial648)
                .HasMaxLength(1)
                .HasColumnName("trial648");
        });

        modelBuilder.Entity<Tblbankstatementtype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_bankstatementtype");

            entity.ToTable("tblbankstatementtype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Trial648)
                .HasMaxLength(1)
                .HasColumnName("trial648");
        });

        modelBuilder.Entity<Tblbanktransfereregistry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblbanktransfereregistry");

            entity.ToTable("tblbanktransfereregistry");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accountrectype)
                .HasMaxLength(20)
                .HasColumnName("accountrectype");
            entity.Property(e => e.Isprojecttran)
                .HasDefaultValueSql("false")
                .HasColumnName("isprojecttran");
            entity.Property(e => e.ItemType)
                .HasMaxLength(50)
                .HasColumnName("item_type");
            entity.Property(e => e.PoReqNo).HasColumnName("po_req_no");
            entity.Property(e => e.PvNo)
                .HasMaxLength(50)
                .HasColumnName("pv_no");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Reqid)
                .HasMaxLength(50)
                .HasColumnName("reqid");
            entity.Property(e => e.Totalamount)
                .HasPrecision(18, 2)
                .HasColumnName("totalamount");
            entity.Property(e => e.Trial648)
                .HasMaxLength(1)
                .HasColumnName("trial648");
        });

        modelBuilder.Entity<Tblbond>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblbond");

            entity.ToTable("tblbond");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasPrecision(18, 2)
                .HasColumnName("amount");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.BankInsuranceId).HasColumnName("bank_insurance_id");
            entity.Property(e => e.BankInsuranceName)
                .HasMaxLength(200)
                .HasColumnName("bank_insurance_name");
            entity.Property(e => e.BondTypeDescription)
                .HasMaxLength(200)
                .HasColumnName("bond_type_description");
            entity.Property(e => e.BondTypeId).HasColumnName("bond_type_id");
            entity.Property(e => e.Clientid).HasColumnName("clientid");
            entity.Property(e => e.Clientname)
                .HasMaxLength(200)
                .HasColumnName("clientname");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.DefectLiabliltyPeriod).HasColumnName("defect_liablilty_period");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.Isapproved)
                .HasDefaultValueSql("false")
                .HasColumnName("isapproved");
            entity.Property(e => e.ProjectName)
                .HasMaxLength(50)
                .HasColumnName("project_name");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Reference)
                .HasMaxLength(200)
                .HasColumnName("reference");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Status)
                .HasMaxLength(200)
                .HasColumnName("status");
            entity.Property(e => e.Trial652)
                .HasMaxLength(1)
                .HasColumnName("trial652");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updateddate");
        });

        modelBuilder.Entity<Tblbondtype>(entity =>
        {
            entity.HasKey(e => e.BondTypeId).HasName("pk_tblbondtype");

            entity.ToTable("tblbondtype");

            entity.Property(e => e.BondTypeId).HasColumnName("bond_type_id");
            entity.Property(e => e.BondTypeDescription)
                .HasMaxLength(100)
                .HasColumnName("bond_type_description");
            entity.Property(e => e.Trial652)
                .HasMaxLength(1)
                .HasColumnName("trial652");
        });

        modelBuilder.Entity<Tblbudgetyear>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblbudgetyear");

            entity.ToTable("tblbudgetyear");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Budgetyear).HasColumnName("budgetyear");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Trial655)
                .HasMaxLength(1)
                .HasColumnName("trial655");
        });

        modelBuilder.Entity<Tblcaniblization>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblcaniblization_1");

            entity.ToTable("tblcaniblization");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CanDate).HasColumnName("can_date");
            entity.Property(e => e.CaniblizeBy)
                .HasMaxLength(100)
                .HasColumnName("caniblize_by");
            entity.Property(e => e.ChangedPartLocation)
                .HasMaxLength(100)
                .HasColumnName("changed_part_location");
            entity.Property(e => e.PartName)
                .HasMaxLength(100)
                .HasColumnName("part_name");
            entity.Property(e => e.PartSerialNo)
                .HasMaxLength(100)
                .HasColumnName("part_serial_no");
            entity.Property(e => e.PartTakenFrom)
                .HasMaxLength(20)
                .HasColumnName("part_taken_from");
            entity.Property(e => e.Quantity)
                .HasPrecision(18, 2)
                .HasColumnName("quantity");
            entity.Property(e => e.QuotationId).HasColumnName("quotation_id");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .HasColumnName("remark");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("status");
            entity.Property(e => e.Trial655)
                .HasMaxLength(1)
                .HasColumnName("trial655");
        });

        modelBuilder.Entity<Tblcapture>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblcapture");

            entity.ToTable("tblcapture");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Docatt).HasColumnName("docatt");
            entity.Property(e => e.Docauthor)
                .HasMaxLength(50)
                .HasColumnName("docauthor");
            entity.Property(e => e.Doccategory)
                .HasMaxLength(20)
                .HasColumnName("doccategory");
            entity.Property(e => e.Docdate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("docdate");
            entity.Property(e => e.Doclang)
                .HasMaxLength(20)
                .HasColumnName("doclang");
            entity.Property(e => e.Docpages).HasColumnName("docpages");
            entity.Property(e => e.Docrcvdate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("docrcvdate");
            entity.Property(e => e.Docref)
                .HasMaxLength(20)
                .HasColumnName("docref");
            entity.Property(e => e.Docsubject)
                .HasMaxLength(150)
                .HasColumnName("docsubject");
            entity.Property(e => e.Doctype).HasColumnName("doctype");
            entity.Property(e => e.Docurl)
                .HasMaxLength(150)
                .HasColumnName("docurl");
            entity.Property(e => e.Macroref)
                .HasMaxLength(20)
                .HasColumnName("macroref");
            entity.Property(e => e.Time)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("time");
            entity.Property(e => e.Trial655)
                .HasMaxLength(1)
                .HasColumnName("trial655");
        });

        modelBuilder.Entity<Tblcase>(entity =>
        {
            entity.HasKey(e => e.CaseId).HasName("pk_tblcase");

            entity.ToTable("tblcase");

            entity.Property(e => e.CaseId)
                .HasMaxLength(2)
                .HasColumnName("case_id");
            entity.Property(e => e.CaseDesc)
                .HasMaxLength(30)
                .HasColumnName("case_desc");
            entity.Property(e => e.Trial655)
                .HasMaxLength(1)
                .HasColumnName("trial655");
        });

        modelBuilder.Entity<Tblcat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblcat");

            entity.ToTable("tblcat");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("name");
            entity.Property(e => e.ScItems).HasColumnName("sc_items");
            entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            entity.Property(e => e.Trial658)
                .HasMaxLength(1)
                .HasColumnName("trial658");
        });

        modelBuilder.Entity<Tblcatsub>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblcatsub");

            entity.ToTable("tblcatsub");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CatId).HasColumnName("cat_id");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("name");
            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.Trial658)
                .HasMaxLength(1)
                .HasColumnName("trial658");
        });

        modelBuilder.Entity<Tblchart>(entity =>
        {
            entity.HasKey(e => e.GlAccount).HasName("pk_tblchart_1");

            entity.ToTable("tblchart");

            entity.Property(e => e.GlAccount)
                .HasMaxLength(10)
                .HasColumnName("gl_account");
            entity.Property(e => e.AccountSubtype)
                .HasMaxLength(200)
                .HasColumnName("account_subtype");
            entity.Property(e => e.AccountType)
                .HasMaxLength(200)
                .HasColumnName("account_type");
            entity.Property(e => e.AccountTypeId).HasColumnName("account_type_id");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
            entity.Property(e => e.GlDescription)
                .HasMaxLength(200)
                .HasColumnName("gl_description");
            entity.Property(e => e.Isactive)
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved)
                .HasDefaultValueSql("false")
                .HasColumnName("isapproved");
            entity.Property(e => e.Isreviewed)
                .HasDefaultValueSql("false")
                .HasColumnName("isreviewed");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.SubtypeId).HasColumnName("subtype_id");
            entity.Property(e => e.Trial661)
                .HasMaxLength(1)
                .HasColumnName("trial661");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Tblchart2012>(entity =>
        {
            entity.HasKey(e => e.GlAccount).HasName("pk_tblchart2012");

            entity.ToTable("tblchart2012");

            entity.Property(e => e.GlAccount)
                .HasMaxLength(10)
                .HasColumnName("gl_account");
            entity.Property(e => e.AccountSubtype)
                .HasMaxLength(200)
                .HasColumnName("account_subtype");
            entity.Property(e => e.AccountType)
                .HasMaxLength(200)
                .HasColumnName("account_type");
            entity.Property(e => e.AccountTypeId).HasColumnName("account_type_id");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.BankallowNegativebalance)
                .HasDefaultValueSql("false")
                .HasColumnName("bankallow_negativebalance");
            entity.Property(e => e.Category)
                .HasMaxLength(10)
                .HasColumnName("category");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
            entity.Property(e => e.GlDescription)
                .HasMaxLength(200)
                .HasColumnName("gl_description");
            entity.Property(e => e.Isactive)
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved)
                .HasDefaultValueSql("false")
                .HasColumnName("isapproved");
            entity.Property(e => e.Isreviewed)
                .HasDefaultValueSql("false")
                .HasColumnName("isreviewed");
            entity.Property(e => e.IsvatAccount)
                .HasDefaultValueSql("false")
                .HasColumnName("isvat_account");
            entity.Property(e => e.IswhtAccount)
                .HasDefaultValueSql("false")
                .HasColumnName("iswht_account");
            entity.Property(e => e.OldAccountName)
                .HasMaxLength(200)
                .HasColumnName("old_account_name");
            entity.Property(e => e.OldAccountNo)
                .HasMaxLength(10)
                .HasColumnName("old_account_no");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.SubtypeId).HasColumnName("subtype_id");
            entity.Property(e => e.Trial665)
                .HasMaxLength(1)
                .HasColumnName("trial665");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Tblchart2013>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblchart2013");

            entity.Property(e => e.AccountSubtype)
                .HasMaxLength(200)
                .HasColumnName("account_subtype");
            entity.Property(e => e.AccountType)
                .HasMaxLength(200)
                .HasColumnName("account_type");
            entity.Property(e => e.AccountTypeId).HasColumnName("account_type_id");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
            entity.Property(e => e.GlAccount)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("gl_account");
            entity.Property(e => e.GlDescription)
                .HasMaxLength(200)
                .HasColumnName("gl_description");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.SubtypeId).HasColumnName("subtype_id");
            entity.Property(e => e.Trial668)
                .HasMaxLength(1)
                .HasColumnName("trial668");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<TblchartPeachtree>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblchart_peachtree_");

            entity.Property(e => e.AccountDescription)
                .HasMaxLength(255)
                .HasColumnName("account_description");
            entity.Property(e => e.AccountId)
                .HasMaxLength(255)
                .HasColumnName("account_id");
            entity.Property(e => e.JobDescription)
                .HasMaxLength(255)
                .HasColumnName("job_description");
            entity.Property(e => e.JobId)
                .HasMaxLength(255)
                .HasColumnName("job_id");
            entity.Property(e => e.Trial665)
                .HasMaxLength(1)
                .HasColumnName("trial665");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
        });

        modelBuilder.Entity<Tblcheckregistry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblcheckregistry");

            entity.ToTable("tblcheckregistry");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Bankid).HasColumnName("bankid");
            entity.Property(e => e.Bankname).HasColumnName("bankname");
            entity.Property(e => e.Checknumber)
                .HasMaxLength(200)
                .HasColumnName("checknumber");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasMaxLength(50)
                .HasColumnName("createddate");
            entity.Property(e => e.GlAccount)
                .HasMaxLength(50)
                .HasColumnName("gl_account");
            entity.Property(e => e.Isapproved)
                .HasDefaultValueSql("false")
                .HasColumnName("isapproved");
            entity.Property(e => e.Isused)
                .HasDefaultValueSql("false")
                .HasColumnName("isused");
            entity.Property(e => e.QbGlAccount)
                .HasMaxLength(20)
                .HasColumnName("qb_gl_account");
            entity.Property(e => e.QbGlDescription)
                .HasMaxLength(200)
                .HasColumnName("qb_gl_description");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Trial668)
                .HasMaxLength(1)
                .HasColumnName("trial668");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasMaxLength(50)
                .HasColumnName("updateddate");
        });

        modelBuilder.Entity<Tblclient>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblclient");

            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .HasColumnName("address");
            entity.Property(e => e.ClientName)
                .HasMaxLength(100)
                .HasColumnName("client_name");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Trial671)
                .HasMaxLength(1)
                .HasColumnName("trial671");
        });

        modelBuilder.Entity<Tblcompany>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblcompany");

            entity.ToTable("tblcompany");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Companylogo).HasColumnName("companylogo");
            entity.Property(e => e.Companymoto)
                .HasMaxLength(200)
                .HasColumnName("companymoto");
            entity.Property(e => e.Companyname)
                .HasMaxLength(200)
                .HasColumnName("companyname");
            entity.Property(e => e.Trial675)
                .HasMaxLength(1)
                .HasColumnName("trial675");
        });

        modelBuilder.Entity<Tblcondition>(entity =>
        {
            entity.HasKey(e => e.CondId).HasName("pk_tblcondition");

            entity.ToTable("tblcondition");

            entity.Property(e => e.CondId).HasColumnName("cond_id");
            entity.Property(e => e.CondName)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("cond_name");
            entity.Property(e => e.Trial675)
                .HasMaxLength(1)
                .HasColumnName("trial675");
        });

        modelBuilder.Entity<TblcustomReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblcustome_reports");

            entity.ToTable("tblcustom_reports");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Reporttitle)
                .HasMaxLength(200)
                .HasColumnName("reporttitle");
            entity.Property(e => e.Reporttype)
                .HasMaxLength(100)
                .HasColumnName("reporttype");
            entity.Property(e => e.SqlStatement)
                .HasMaxLength(2500)
                .HasColumnName("sql_statement");
            entity.Property(e => e.Trial678)
                .HasMaxLength(1)
                .HasColumnName("trial678");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updateddate");
        });

        modelBuilder.Entity<Tbldailyactivity>(entity =>
        {
            entity.HasKey(e => e.ActivityId).HasName("pk_tbldailyactivity");

            entity.ToTable("tbldailyactivity");

            entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            entity.Property(e => e.ActivityDate).HasColumnName("activity_date");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Checked).HasColumnName("checked");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.CurrentRate)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("current_rate");
            entity.Property(e => e.DownHrs).HasColumnName("down_hrs");
            entity.Property(e => e.DownMin).HasColumnName("down_min");
            entity.Property(e => e.EqId)
                .HasMaxLength(10)
                .HasColumnName("eq_id");
            entity.Property(e => e.FuelTaken)
                .HasPrecision(12, 2)
                .HasColumnName("fuel_taken");
            entity.Property(e => e.IdlHrs).HasColumnName("idl_hrs");
            entity.Property(e => e.IdlHrsPaid).HasColumnName("idl_hrs_paid");
            entity.Property(e => e.IdlMin).HasColumnName("idl_min");
            entity.Property(e => e.IdlMinPaid).HasColumnName("idl_min_paid");
            entity.Property(e => e.Isapproved)
                .HasDefaultValueSql("false")
                .HasColumnName("isapproved");
            entity.Property(e => e.OidCase)
                .HasMaxLength(2)
                .HasColumnName("oid_case");
            entity.Property(e => e.OperationalHrs).HasColumnName("operational_hrs");
            entity.Property(e => e.OperationalMin).HasColumnName("operational_min");
            entity.Property(e => e.OperatorId)
                .HasMaxLength(50)
                .HasColumnName("operator_id");
            entity.Property(e => e.Ownership)
                .HasMaxLength(1)
                .HasColumnName("ownership");
            entity.Property(e => e.PlateNo)
                .HasMaxLength(20)
                .HasColumnName("plate_no");
            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.Reason)
                .HasMaxLength(30)
                .HasColumnName("reason");
            entity.Property(e => e.Reason1)
                .HasMaxLength(30)
                .HasColumnName("reason1");
            entity.Property(e => e.Remark)
                .HasMaxLength(30)
                .HasColumnName("remark");
            entity.Property(e => e.Status)
                .HasMaxLength(8)
                .HasColumnName("status");
            entity.Property(e => e.Subcontractor)
                .HasMaxLength(50)
                .HasColumnName("subcontractor");
            entity.Property(e => e.TravelledKms)
                .HasPrecision(12, 2)
                .HasColumnName("travelled_kms");
            entity.Property(e => e.Trial678)
                .HasMaxLength(1)
                .HasColumnName("trial678");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.VolumeOfMaterialMoved)
                .HasPrecision(12, 2)
                .HasColumnName("volume_of_material_moved");
            entity.Property(e => e.WeekNo)
                .HasMaxLength(6)
                .HasColumnName("week_no");
            entity.Property(e => e.WeightOfMaterialMoved)
                .HasPrecision(12, 2)
                .HasColumnName("weight_of_material_moved");
        });

        modelBuilder.Entity<Tbldailyactivityexcel>(entity =>
        {
            entity.HasKey(e => e.ActivityId).HasName("pk_tbldailyactivityexcel");

            entity.ToTable("tbldailyactivityexcel");

            entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            entity.Property(e => e.ActivityDate).HasColumnName("activity_date");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasDefaultValueSql("'Imported'::character varying")
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasMaxLength(50)
                .HasDefaultValueSql("'getdate()'::character varying")
                .HasColumnName("createddate");
            entity.Property(e => e.DownHrs).HasColumnName("down_hrs");
            entity.Property(e => e.DownMin).HasColumnName("down_min");
            entity.Property(e => e.EngineEnd)
                .HasPrecision(18, 2)
                .HasColumnName("engine_end");
            entity.Property(e => e.EngineStart)
                .HasPrecision(18, 2)
                .HasColumnName("engine_start");
            entity.Property(e => e.FuelPrice)
                .HasPrecision(18, 2)
                .HasColumnName("fuel_price");
            entity.Property(e => e.FuelTaken)
                .HasPrecision(12, 2)
                .HasColumnName("fuel_taken");
            entity.Property(e => e.IdlHrs).HasColumnName("idl_hrs");
            entity.Property(e => e.IdlHrsPaid).HasColumnName("idl_hrs_paid");
            entity.Property(e => e.IdlMin).HasColumnName("idl_min");
            entity.Property(e => e.IdlMinPaid).HasColumnName("idl_min_paid");
            entity.Property(e => e.Isapproved)
                .HasDefaultValueSql("false")
                .HasColumnName("isapproved");
            entity.Property(e => e.Isvalid)
                .HasDefaultValueSql("true")
                .HasColumnName("isvalid");
            entity.Property(e => e.OperationalHrs).HasColumnName("operational_hrs");
            entity.Property(e => e.OperationalMin).HasColumnName("operational_min");
            entity.Property(e => e.Operator)
                .HasMaxLength(100)
                .HasColumnName("operator");
            entity.Property(e => e.Operatorid).HasColumnName("operatorid");
            entity.Property(e => e.Operatorname)
                .HasMaxLength(100)
                .HasColumnName("operatorname");
            entity.Property(e => e.PlateNo)
                .HasMaxLength(20)
                .HasColumnName("plate_no");
            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.ReasonDown)
                .HasMaxLength(300)
                .HasColumnName("reason_down");
            entity.Property(e => e.ReasonIdle)
                .HasMaxLength(300)
                .HasColumnName("reason_idle");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasDefaultValueSql("'Valid'::character varying")
                .HasColumnName("remark");
            entity.Property(e => e.Source)
                .HasMaxLength(50)
                .HasDefaultValueSql("'ERP'::character varying")
                .HasColumnName("source");
            entity.Property(e => e.Telephone)
                .HasMaxLength(50)
                .HasColumnName("telephone");
            entity.Property(e => e.TravelledKms)
                .HasPrecision(12, 2)
                .HasColumnName("travelled_kms");
            entity.Property(e => e.Trial697)
                .HasMaxLength(1)
                .HasColumnName("trial697");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasMaxLength(50)
                .HasColumnName("updateddate");
            entity.Property(e => e.Usedby)
                .HasMaxLength(300)
                .HasColumnName("usedby");
            entity.Property(e => e.WeekNo)
                .HasMaxLength(6)
                .HasColumnName("week_no");
        });

        modelBuilder.Entity<Tbldailyactivityrented>(entity =>
        {
            entity.HasKey(e => e.ActivityId).HasName("pk_tbldailyactivityrented");

            entity.ToTable("tbldailyactivityrented");

            entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            entity.Property(e => e.ActivityDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("activity_date");
            entity.Property(e => e.DownHrs)
                .HasPrecision(12, 2)
                .HasColumnName("down_hrs");
            entity.Property(e => e.EqId)
                .HasMaxLength(10)
                .HasColumnName("eq_id");
            entity.Property(e => e.FuelTaken)
                .HasPrecision(12, 2)
                .HasColumnName("fuel_taken");
            entity.Property(e => e.IdlHrs)
                .HasPrecision(12, 2)
                .HasColumnName("idl_hrs");
            entity.Property(e => e.OperationalHrs)
                .HasPrecision(12, 2)
                .HasColumnName("operational_hrs");
            entity.Property(e => e.OperatorId).HasColumnName("operator_id");
            entity.Property(e => e.Reason)
                .HasMaxLength(30)
                .HasColumnName("reason");
            entity.Property(e => e.Reason1)
                .HasMaxLength(30)
                .HasColumnName("reason1");
            entity.Property(e => e.Remark)
                .HasMaxLength(30)
                .HasColumnName("remark");
            entity.Property(e => e.Status)
                .HasMaxLength(8)
                .HasColumnName("status");
            entity.Property(e => e.TravelledKms)
                .HasPrecision(12, 2)
                .HasColumnName("travelled_kms");
            entity.Property(e => e.Trial723)
                .HasMaxLength(1)
                .HasColumnName("trial723");
            entity.Property(e => e.VolumeOfMaterialMoved)
                .HasPrecision(12, 2)
                .HasColumnName("volume_of_material_moved");
            entity.Property(e => e.WeightOfMaterialMoved)
                .HasPrecision(12, 2)
                .HasColumnName("weight_of_material_moved");
        });

        modelBuilder.Entity<Tbldd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbldd");

            entity.Property(e => e.GlAccount)
                .HasMaxLength(50)
                .HasColumnName("gl_account");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Trial723)
                .HasMaxLength(1)
                .HasColumnName("trial723");
        });

        modelBuilder.Entity<TbldlDeduction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tbldl_deduction");

            entity.ToTable("tbldl_deduction");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(100)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.DeductionAmount)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("deduction_amount");
            entity.Property(e => e.DeductionRemark)
                .HasMaxLength(200)
                .HasColumnName("deduction_remark");
            entity.Property(e => e.Employeeid).HasColumnName("employeeid");
            entity.Property(e => e.Employeename)
                .HasMaxLength(100)
                .HasColumnName("employeename");
            entity.Property(e => e.Food)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("food");
            entity.Property(e => e.Isactive)
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved)
                .HasDefaultValueSql("false")
                .HasColumnName("isapproved");
            entity.Property(e => e.Loan)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("loan");
            entity.Property(e => e.Period).HasColumnName("period");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Projectname)
                .HasMaxLength(100)
                .HasColumnName("projectname");
            entity.Property(e => e.ReturnablePenality)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("returnable_penality");
            entity.Property(e => e.TranDate).HasColumnName("tran_date");
            entity.Property(e => e.Trial727)
                .HasMaxLength(1)
                .HasColumnName("trial727");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updateddate");
        });

        modelBuilder.Entity<TbldlJobtitle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tbldl_jobtitle");

            entity.ToTable("tbldl_jobtitle");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(200)
                .HasColumnName("job_title");
            entity.Property(e => e.Trial730)
                .HasMaxLength(1)
                .HasColumnName("trial730");
        });

        modelBuilder.Entity<TbldlRegistry>(entity =>
        {
            entity.HasKey(e => e.Employeeid).HasName("pk_tbldl_registry");

            entity.ToTable("tbldl_registry");

            entity.Property(e => e.Employeeid).HasColumnName("employeeid");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(100)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Createdby)
                .HasMaxLength(100)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.DlAmount)
                .HasPrecision(18, 2)
                .HasColumnName("dl_amount");
            entity.Property(e => e.DlWorkingHrs)
                .HasPrecision(18, 2)
                .HasColumnName("dl_working_hrs");
            entity.Property(e => e.Employeebankaccount)
                .HasMaxLength(100)
                .HasColumnName("employeebankaccount");
            entity.Property(e => e.Employeebankname)
                .HasMaxLength(100)
                .HasColumnName("employeebankname");
            entity.Property(e => e.Employeefamilybankaccount)
                .HasMaxLength(100)
                .HasColumnName("employeefamilybankaccount");
            entity.Property(e => e.Employeefamilybankname)
                .HasMaxLength(100)
                .HasColumnName("employeefamilybankname");
            entity.Property(e => e.Employeefamilyname)
                .HasMaxLength(100)
                .HasColumnName("employeefamilyname");
            entity.Property(e => e.Employeename)
                .HasMaxLength(100)
                .HasColumnName("employeename");
            entity.Property(e => e.ExcludePension)
                .HasDefaultValueSql("false")
                .HasColumnName("exclude_pension");
            entity.Property(e => e.HireDate).HasColumnName("hire_date");
            entity.Property(e => e.Isactive)
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Jobid).HasColumnName("jobid");
            entity.Property(e => e.Jobtitle)
                .HasMaxLength(200)
                .HasColumnName("jobtitle");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Projectmanagername)
                .HasMaxLength(100)
                .HasColumnName("projectmanagername");
            entity.Property(e => e.Projectname)
                .HasMaxLength(100)
                .HasColumnName("projectname");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .HasColumnName("remark");
            entity.Property(e => e.Sectionid).HasColumnName("sectionid");
            entity.Property(e => e.Sectionleader)
                .HasMaxLength(100)
                .HasColumnName("sectionleader");
            entity.Property(e => e.Sectionname)
                .HasMaxLength(100)
                .HasColumnName("sectionname");
            entity.Property(e => e.Trial730)
                .HasMaxLength(1)
                .HasColumnName("trial730");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(100)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updateddate");
        });

        modelBuilder.Entity<TbldlSection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tbldl_section");

            entity.ToTable("tbldl_section");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SectionName)
                .HasMaxLength(200)
                .HasColumnName("section_name");
            entity.Property(e => e.Trial733)
                .HasMaxLength(1)
                .HasColumnName("trial733");
        });

        modelBuilder.Entity<TbldlTimecard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tbldl_timecard");

            entity.ToTable("tbldl_timecard");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(100)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Createdby)
                .HasMaxLength(100)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.DailyPaymentAmount)
                .HasPrecision(18, 2)
                .HasColumnName("daily_payment_amount");
            entity.Property(e => e.DailyWorkedAmount)
                .HasPrecision(18, 2)
                .HasColumnName("daily_worked_amount");
            entity.Property(e => e.Dateworked).HasColumnName("dateworked");
            entity.Property(e => e.DlAmount)
                .HasPrecision(18, 2)
                .HasColumnName("dl_amount");
            entity.Property(e => e.DlWorkingHours).HasColumnName("dl_working_hours");
            entity.Property(e => e.DlWorkingHrs)
                .HasPrecision(18, 2)
                .HasColumnName("dl_working_hrs");
            entity.Property(e => e.Employeeid).HasColumnName("employeeid");
            entity.Property(e => e.Employeename)
                .HasMaxLength(100)
                .HasColumnName("employeename");
            entity.Property(e => e.HireDate).HasColumnName("hire_date");
            entity.Property(e => e.HoursworkedAfternoon)
                .HasPrecision(18, 2)
                .HasColumnName("hoursworked_afternoon");
            entity.Property(e => e.HoursworkedMorning)
                .HasPrecision(18, 2)
                .HasColumnName("hoursworked_morning");
            entity.Property(e => e.Isapproved)
                .HasDefaultValueSql("false")
                .HasColumnName("isapproved");
            entity.Property(e => e.Isreviewed)
                .HasDefaultValueSql("false")
                .HasColumnName("isreviewed");
            entity.Property(e => e.Issendtobill)
                .HasDefaultValueSql("false")
                .HasColumnName("issendtobill");
            entity.Property(e => e.OtHolidayAmount)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("ot_holiday_amount");
            entity.Property(e => e.OtHolidayHrs).HasColumnName("ot_holiday_hrs");
            entity.Property(e => e.OtNightAmount)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("ot_night_amount");
            entity.Property(e => e.OtNightHrs).HasColumnName("ot_night_hrs");
            entity.Property(e => e.OtNormalAmount)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("ot_normal_amount");
            entity.Property(e => e.OtNormalHrs).HasColumnName("ot_normal_hrs");
            entity.Property(e => e.OtWeekendAmount)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("ot_weekend_amount");
            entity.Property(e => e.OtWeekendHrs).HasColumnName("ot_weekend_hrs");
            entity.Property(e => e.PeriodYearmonth).HasColumnName("period_yearmonth");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Projectname)
                .HasMaxLength(100)
                .HasColumnName("projectname");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(100)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Totalhours)
                .HasPrecision(18, 2)
                .HasColumnName("totalhours");
            entity.Property(e => e.Trial733)
                .HasMaxLength(1)
                .HasColumnName("trial733");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(100)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updateddate");
        });

        modelBuilder.Entity<Tbldoccomment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tbldoccomment");

            entity.ToTable("tbldoccomment");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comment)
                .HasMaxLength(150)
                .HasColumnName("comment");
            entity.Property(e => e.Commentby).HasColumnName("commentby");
            entity.Property(e => e.Commentdate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("commentdate");
            entity.Property(e => e.Refdocid).HasColumnName("refdocid");
            entity.Property(e => e.Trial779)
                .HasMaxLength(1)
                .HasColumnName("trial779");
        });

        modelBuilder.Entity<Tbldocref>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tbldocref");

            entity.ToTable("tbldocref");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Refbyusrid).HasColumnName("refbyusrid");
            entity.Property(e => e.Refdate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("refdate");
            entity.Property(e => e.Refdocid).HasColumnName("refdocid");
            entity.Property(e => e.Refstatusid).HasColumnName("refstatusid");
            entity.Property(e => e.Reftousrid).HasColumnName("reftousrid");
            entity.Property(e => e.Trial779)
                .HasMaxLength(1)
                .HasColumnName("trial779");
        });

        modelBuilder.Entity<TbldtDd>(entity =>
        {
            entity.HasKey(e => e.Dd).HasName("pk_tbldt_dd");

            entity.ToTable("tbldt_dd");

            entity.Property(e => e.Dd)
                .HasMaxLength(2)
                .HasColumnName("dd");
            entity.Property(e => e.DdDesc)
                .HasMaxLength(3)
                .HasColumnName("dd_desc");
            entity.Property(e => e.Trial779)
                .HasMaxLength(1)
                .HasColumnName("trial779");
        });

        modelBuilder.Entity<TbldtMm>(entity =>
        {
            entity.HasKey(e => e.Mm).HasName("pk_tbldt_mm");

            entity.ToTable("tbldt_mm");

            entity.Property(e => e.Mm)
                .HasMaxLength(2)
                .HasColumnName("mm");
            entity.Property(e => e.MmDesc)
                .HasMaxLength(3)
                .HasColumnName("mm_desc");
            entity.Property(e => e.MmDescAmharic)
                .HasMaxLength(50)
                .HasColumnName("mm_desc_amharic");
            entity.Property(e => e.Trial779)
                .HasMaxLength(1)
                .HasColumnName("trial779");
        });

        modelBuilder.Entity<TbldtYy>(entity =>
        {
            entity.HasKey(e => e.Yy).HasName("pk_tbl_dt_yy");

            entity.ToTable("tbldt_yy");

            entity.Property(e => e.Yy)
                .HasMaxLength(4)
                .HasColumnName("yy");
            entity.Property(e => e.Trial782)
                .HasMaxLength(1)
                .HasColumnName("trial782");
            entity.Property(e => e.YyDesc)
                .HasMaxLength(4)
                .HasColumnName("yy_desc");
        });

        modelBuilder.Entity<TbldtYy1>(entity =>
        {
            entity.HasKey(e => e.Yy).HasName("pk_tbldt_yy1");

            entity.ToTable("tbldt_yy1");

            entity.Property(e => e.Yy)
                .HasMaxLength(4)
                .HasColumnName("yy");
            entity.Property(e => e.Trial782)
                .HasMaxLength(1)
                .HasColumnName("trial782");
            entity.Property(e => e.YyDesc)
                .HasMaxLength(4)
                .HasColumnName("yy_desc");
        });

        modelBuilder.Entity<TblempJob>(entity =>
        {
            entity.HasKey(e => e.JobId).HasName("pk_tblemp_job_1");

            entity.ToTable("tblemp_job");

            entity.Property(e => e.JobId).HasColumnName("job_id");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(50)
                .HasColumnName("job_title");
            entity.Property(e => e.Trial782)
                .HasMaxLength(1)
                .HasColumnName("trial782");
        });

        modelBuilder.Entity<TblempPerdium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblemp_perdium");

            entity.ToTable("tblemp_perdium");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CostProject).HasColumnName("cost_project");
            entity.Property(e => e.DepartureDate)
                .HasMaxLength(100)
                .HasColumnName("departure_date");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("emp_id");
            entity.Property(e => e.FreightCost)
                .HasPrecision(18, 2)
                .HasColumnName("freight_cost");
            entity.Property(e => e.NoOfDays)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("no_of_days");
            entity.Property(e => e.PerdiumAmount)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("perdium_amount");
            entity.Property(e => e.PerdiumPercent)
                .HasDefaultValueSql("0")
                .HasColumnName("perdium_percent");
            entity.Property(e => e.PerdiumScale)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("perdium_scale");
            entity.Property(e => e.Salary)
                .HasPrecision(18, 2)
                .HasColumnName("salary");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.TrDate).HasColumnName("tr_date");
            entity.Property(e => e.Transport)
                .HasPrecision(18, 2)
                .HasColumnName("transport");
            entity.Property(e => e.TravelFrom)
                .HasMaxLength(100)
                .HasColumnName("travel_from");
            entity.Property(e => e.TravelTo)
                .HasMaxLength(100)
                .HasColumnName("travel_to");
            entity.Property(e => e.Trial782)
                .HasMaxLength(1)
                .HasColumnName("trial782");
            entity.Property(e => e.UserDept).HasColumnName("user_dept");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<TblempPerdiumscale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblemp_perdiumscale");

            entity.ToTable("tblemp_perdiumscale");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EndSalary)
                .HasPrecision(18, 2)
                .HasColumnName("end_salary");
            entity.Property(e => e.PerdiumAmount)
                .HasPrecision(18, 2)
                .HasColumnName("perdium_amount");
            entity.Property(e => e.StartSalary)
                .HasPrecision(18, 2)
                .HasColumnName("start_salary");
            entity.Property(e => e.Trial786)
                .HasMaxLength(1)
                .HasColumnName("trial786");
        });

        modelBuilder.Entity<TblempTimecard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblemp_timecard");

            entity.ToTable("tblemp_timecard");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Dateworked).HasColumnName("dateworked");
            entity.Property(e => e.Employeeid)
                .HasMaxLength(50)
                .HasColumnName("employeeid");
            entity.Property(e => e.Employeename)
                .HasMaxLength(100)
                .HasColumnName("employeename");
            entity.Property(e => e.HoursworkedAfternoon)
                .HasPrecision(18, 2)
                .HasColumnName("hoursworked_afternoon");
            entity.Property(e => e.HoursworkedMorning)
                .HasPrecision(18, 2)
                .HasColumnName("hoursworked_morning");
            entity.Property(e => e.Isapproved)
                .HasDefaultValueSql("false")
                .HasColumnName("isapproved");
            entity.Property(e => e.OtHolidayHrs)
                .HasPrecision(18, 2)
                .HasColumnName("ot_holiday_hrs");
            entity.Property(e => e.OtNightHrs)
                .HasPrecision(18, 2)
                .HasColumnName("ot_night_hrs");
            entity.Property(e => e.OtNormalHrs)
                .HasPrecision(18, 2)
                .HasColumnName("ot_normal_hrs");
            entity.Property(e => e.OtWeekendHrs)
                .HasPrecision(18, 2)
                .HasColumnName("ot_weekend_hrs");
            entity.Property(e => e.PeriodYearmonth).HasColumnName("period_yearmonth");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Projectname)
                .HasMaxLength(100)
                .HasColumnName("projectname");
            entity.Property(e => e.Totalhours)
                .HasPrecision(18, 2)
                .HasColumnName("totalhours");
            entity.Property(e => e.Trial786)
                .HasMaxLength(1)
                .HasColumnName("trial786");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updateddate");
        });

        modelBuilder.Entity<Tblemployee>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasName("pk_tblemployee");

            entity.ToTable("tblemployee");

            entity.Property(e => e.EmpId)
                .HasMaxLength(10)
                .HasColumnName("emp_id");
            entity.Property(e => e.Allowance1)
                .HasPrecision(18, 2)
                .HasColumnName("allowance1");
            entity.Property(e => e.Allowance2)
                .HasPrecision(18, 2)
                .HasColumnName("allowance2");
            entity.Property(e => e.CreatedDate).HasColumnName("created_date");
            entity.Property(e => e.DeptId).HasColumnName("dept_id");
            entity.Property(e => e.EmpDate).HasColumnName("emp_date");
            entity.Property(e => e.EmpName)
                .HasMaxLength(50)
                .HasColumnName("emp_name");
            entity.Property(e => e.Ispermanent)
                .HasMaxLength(10)
                .HasColumnName("ispermanent");
            entity.Property(e => e.JobTitleId).HasColumnName("job_title_id");
            entity.Property(e => e.Project).HasColumnName("project");
            entity.Property(e => e.Salary)
                .HasPrecision(18, 2)
                .HasColumnName("salary");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.Trial786)
                .HasMaxLength(1)
                .HasColumnName("trial786");
            entity.Property(e => e.UserCreated).HasColumnName("user_created");
        });

        modelBuilder.Entity<Tblepaymentmode>(entity =>
        {
            entity.HasKey(e => e.Modeid).HasName("pk_tblepaymentmode");

            entity.ToTable("tblepaymentmode");

            entity.Property(e => e.Modeid).HasColumnName("modeid");
            entity.Property(e => e.Paymentmode)
                .HasMaxLength(20)
                .HasColumnName("paymentmode");
            entity.Property(e => e.Trial789)
                .HasMaxLength(1)
                .HasColumnName("trial789");
        });

        modelBuilder.Entity<Tblfrequency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblfrequency");

            entity.ToTable("tblfrequency");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Freq)
                .HasMaxLength(50)
                .HasColumnName("freq");
            entity.Property(e => e.Trial789)
                .HasMaxLength(1)
                .HasColumnName("trial789");
        });

        modelBuilder.Entity<Tblfuel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblfuel");

            entity.ToTable("tblfuel");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .HasColumnName("name");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Trial792)
                .HasMaxLength(1)
                .HasColumnName("trial792");
        });

        modelBuilder.Entity<Tblgovtax>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblgovtax");

            entity.ToTable("tblgovtax");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GlAccount)
                .HasMaxLength(30)
                .HasColumnName("gl_account");
            entity.Property(e => e.GlDescription)
                .HasMaxLength(300)
                .HasColumnName("gl_description");
            entity.Property(e => e.TaxType)
                .HasMaxLength(50)
                .HasColumnName("tax_type");
            entity.Property(e => e.Trial792)
                .HasMaxLength(1)
                .HasColumnName("trial792");
        });

        modelBuilder.Entity<Tblgrn>(entity =>
        {
            entity.HasKey(e => e.GrnId).HasName("pk_tblgrn");

            entity.ToTable("tblgrn");

            entity.Property(e => e.GrnId).HasColumnName("grn_id");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .HasColumnName("address");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.CommStockUomQty)
                .HasPrecision(18, 2)
                .HasColumnName("comm_stock_uom_qty");
            entity.Property(e => e.CondId).HasColumnName("cond_id");
            entity.Property(e => e.ConversionFactor)
                .HasPrecision(18, 2)
                .HasColumnName("conversion_factor");
            entity.Property(e => e.ConvertedQty)
                .HasPrecision(18, 2)
                .HasColumnName("converted_qty");
            entity.Property(e => e.ConvertedUnitprice)
                .HasPrecision(18, 2)
                .HasColumnName("converted_unitprice");
            entity.Property(e => e.ConvertedUom)
                .HasMaxLength(10)
                .HasColumnName("converted_uom");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Driver)
                .HasMaxLength(30)
                .HasColumnName("driver");
            entity.Property(e => e.Eqtype)
                .HasMaxLength(30)
                .HasColumnName("eqtype");
            entity.Property(e => e.GrnDate1).HasColumnName("grn_date");
            entity.Property(e => e.GrnNo)
                .HasMaxLength(20)
                .HasColumnName("grn_no");
            entity.Property(e => e.Grndate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("grndate");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Iscreditpurchase)
                .HasDefaultValueSql("false")
                .HasColumnName("iscreditpurchase");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.IssUnitprice)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("iss_unitprice");
            entity.Property(e => e.IssuedBy)
                .HasMaxLength(30)
                .HasColumnName("issued_by");
            entity.Property(e => e.Isusedrecord)
                .HasDefaultValueSql("false")
                .HasColumnName("isusedrecord");
            entity.Property(e => e.ItemReceivedby)
                .HasMaxLength(30)
                .HasColumnName("item_receivedby");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.License)
                .HasMaxLength(30)
                .HasColumnName("license");
            entity.Property(e => e.MUnit)
                .HasMaxLength(10)
                .HasColumnName("m_unit");
            entity.Property(e => e.Managerid).HasColumnName("managerid");
            entity.Property(e => e.OldGrnColumnValue)
                .HasMaxLength(20)
                .HasColumnName("old_grn_column_value");
            entity.Property(e => e.PayableAt)
                .HasMaxLength(30)
                .HasColumnName("payable_at");
            entity.Property(e => e.PlateNo)
                .HasMaxLength(30)
                .HasColumnName("plate_no");
            entity.Property(e => e.Project).HasColumnName("project");
            entity.Property(e => e.Purchaserid).HasColumnName("purchaserid");
            entity.Property(e => e.Purchasername)
                .HasMaxLength(200)
                .HasColumnName("purchasername");
            entity.Property(e => e.Qtyrcvd)
                .HasPrecision(12, 3)
                .HasColumnName("qtyrcvd");
            entity.Property(e => e.QuotationId).HasColumnName("quotation_id");
            entity.Property(e => e.RcvStore).HasColumnName("rcv_store");
            entity.Property(e => e.RcvUnitprice)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("rcv_unitprice");
            entity.Property(e => e.RcvdBy).HasColumnName("rcvd_by");
            entity.Property(e => e.RcvdFrom).HasColumnName("rcvd_from");
            entity.Property(e => e.RecType)
                .HasMaxLength(3)
                .HasColumnName("rec_type");
            entity.Property(e => e.Refno)
                .HasMaxLength(20)
                .HasColumnName("refno");
            entity.Property(e => e.Remark)
                .HasMaxLength(150)
                .HasColumnName("remark");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.SivMtvNo)
                .HasMaxLength(20)
                .HasColumnName("siv_mtv_no");
            entity.Property(e => e.StoreId).HasColumnName("store_id");
            entity.Property(e => e.Trial792)
                .HasMaxLength(1)
                .HasColumnName("trial792");
            entity.Property(e => e.Unitprice)
                .HasPrecision(12, 4)
                .HasColumnName("unitprice");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Userid)
                .HasMaxLength(20)
                .HasColumnName("userid");
            entity.Property(e => e.ViewState)
                .HasDefaultValueSql("0")
                .HasColumnName("view_state");
        });

        modelBuilder.Entity<Tblinspection>(entity =>
        {
            entity.HasKey(e => e.JobId).HasName("pk_tblinspection");

            entity.ToTable("tblinspection");

            entity.Property(e => e.JobId)
                .ValueGeneratedNever()
                .HasColumnName("job_id");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(6)
                .HasColumnName("approved_by");
            entity.Property(e => e.CompStatus)
                .HasMaxLength(10)
                .HasColumnName("comp_status");
            entity.Property(e => e.DateOfInspection)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("date_of_inspection");
            entity.Property(e => e.EqId)
                .HasMaxLength(10)
                .HasColumnName("eq_id");
            entity.Property(e => e.InspectionResult)
                .HasMaxLength(50)
                .HasColumnName("inspection_result");
            entity.Property(e => e.QuotationId)
                .HasMaxLength(10)
                .HasColumnName("quotation_id");
            entity.Property(e => e.Recommendation)
                .HasMaxLength(14)
                .HasColumnName("recommendation");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.Trial818)
                .HasMaxLength(1)
                .HasColumnName("trial818");
        });

        modelBuilder.Entity<Tblitem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblitem");

            entity.ToTable("tblitem");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasMaxLength(10)
                .HasDefaultValueSql("'1'::character varying")
                .HasColumnName("active");
            entity.Property(e => e.Avecost)
                .HasPrecision(18, 2)
                .HasColumnName("avecost");
            entity.Property(e => e.CatId).HasColumnName("cat_id");
            entity.Property(e => e.ConvertedQty)
                .HasPrecision(18, 2)
                .HasColumnName("converted_qty");
            entity.Property(e => e.ConvertedUom)
                .HasMaxLength(10)
                .HasColumnName("converted_uom");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("created_date");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.GlInventoryAcc)
                .HasMaxLength(10)
                .HasColumnName("gl_inventory_acc");
            entity.Property(e => e.GlSaleAcc)
                .HasMaxLength(10)
                .HasColumnName("gl_sale_acc");
            entity.Property(e => e.GlSaleCostAcc)
                .HasMaxLength(10)
                .HasColumnName("gl_sale_cost_acc");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .HasColumnName("item_code");
            entity.Property(e => e.ItemDesc)
                .HasMaxLength(50)
                .HasColumnName("item_desc");
            entity.Property(e => e.ItemName)
                .HasMaxLength(60)
                .HasColumnName("item_name");
            entity.Property(e => e.ItemTypeId)
                .HasMaxLength(15)
                .HasColumnName("item_type_id");
            entity.Property(e => e.MUnit)
                .HasMaxLength(10)
                .HasColumnName("m_unit");
            entity.Property(e => e.MinStockLevel).HasColumnName("min_stock_level");
            entity.Property(e => e.OpeningBalance)
                .HasPrecision(18, 2)
                .HasColumnName("opening_balance");
            entity.Property(e => e.OpeningCondition)
                .HasMaxLength(50)
                .HasColumnName("opening_condition");
            entity.Property(e => e.OpeningDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("opening_date");
            entity.Property(e => e.StoreId).HasColumnName("store_id");
            entity.Property(e => e.SubCatId).HasColumnName("sub_cat_id");
            entity.Property(e => e.Trial818)
                .HasMaxLength(1)
                .HasColumnName("trial818");
            entity.Property(e => e.Unitprice)
                .HasPrecision(18, 2)
                .HasColumnName("unitprice");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasMaxLength(50)
                .HasColumnName("updateddate");
        });

        modelBuilder.Entity<TblitemSubcategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblitem_subcategory");

            entity.ToTable("tblitem_subcategory");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CatId).HasColumnName("cat_id");
            entity.Property(e => e.GlInventoryAccount)
                .HasMaxLength(50)
                .HasColumnName("gl_inventory_account");
            entity.Property(e => e.GlSalesAccount)
                .HasMaxLength(50)
                .HasColumnName("gl_sales_account");
            entity.Property(e => e.GlSalesCostAccount)
                .HasMaxLength(50)
                .HasColumnName("gl_sales_cost_account");
            entity.Property(e => e.Isinventoryitem)
                .HasDefaultValueSql("false")
                .HasColumnName("isinventoryitem");
            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            entity.Property(e => e.SubName)
                .HasMaxLength(50)
                .HasColumnName("sub_name");
            entity.Property(e => e.Trial828)
                .HasMaxLength(1)
                .HasColumnName("trial828");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updateddate");
        });

        modelBuilder.Entity<Tblitemcat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblitemcat");

            entity.Property(e => e.CatName)
                .HasMaxLength(100)
                .HasColumnName("cat_name");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Trial828)
                .HasMaxLength(1)
                .HasColumnName("trial828");
        });

        modelBuilder.Entity<Tblitemcategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblitemcategory");

            entity.ToTable("tblitemcategory");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CatName)
                .HasMaxLength(50)
                .HasColumnName("cat_name");
            entity.Property(e => e.Isinventoryitem)
                .HasDefaultValueSql("false")
                .HasColumnName("isinventoryitem");
            entity.Property(e => e.ScItems).HasColumnName("sc_items");
            entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            entity.Property(e => e.Trial828)
                .HasMaxLength(1)
                .HasColumnName("trial828");
        });

        modelBuilder.Entity<Tblitemclass>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblitemclass");

            entity.ToTable("tblitemclass");

            entity.Property(e => e.Id)
                .HasMaxLength(15)
                .HasColumnName("id");
            entity.Property(e => e.Clname)
                .HasMaxLength(20)
                .HasColumnName("clname");
            entity.Property(e => e.Trial828)
                .HasMaxLength(1)
                .HasColumnName("trial828");
        });

        modelBuilder.Entity<Tblitempart>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("pk_tblitempart");

            entity.ToTable("tblitempart");

            entity.Property(e => e.ItemId)
                .ValueGeneratedNever()
                .HasColumnName("item_id");
            entity.Property(e => e.PartNo)
                .HasMaxLength(50)
                .HasColumnName("part_no");
            entity.Property(e => e.Trial831)
                .HasMaxLength(1)
                .HasColumnName("trial831");
        });

        modelBuilder.Entity<Tblitemrequest>(entity =>
        {
            entity.HasKey(e => e.ItemRequestId).HasName("pk_tblitemrequest");

            entity.ToTable("tblitemrequest");

            entity.Property(e => e.ItemRequestId).HasColumnName("item_request_id");
            entity.Property(e => e.ExpectedDate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("expected_date");
            entity.Property(e => e.JobId).HasColumnName("job_id");
            entity.Property(e => e.Refsrno).HasColumnName("refsrno");
            entity.Property(e => e.Remarks)
                .HasMaxLength(150)
                .HasColumnName("remarks");
            entity.Property(e => e.Reqby)
                .HasMaxLength(50)
                .HasColumnName("reqby");
            entity.Property(e => e.RequestStatusId).HasColumnName("request_status_id");
            entity.Property(e => e.RequestedDate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("requested_date");
            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.StatusDate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("status_date");
            entity.Property(e => e.Tier1appby).HasColumnName("tier1appby");
            entity.Property(e => e.Tier2appby).HasColumnName("tier2appby");
            entity.Property(e => e.Tier3appby).HasColumnName("tier3appby");
            entity.Property(e => e.Transactid).HasColumnName("transactid");
            entity.Property(e => e.Trial835)
                .HasMaxLength(1)
                .HasColumnName("trial835");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Tblitemrequestdetail>(entity =>
        {
            entity.HasKey(e => e.ItemRequestDetailId).HasName("pk_tblitemrequestdetail");

            entity.ToTable("tblitemrequestdetail");

            entity.Property(e => e.ItemRequestDetailId).HasColumnName("item_request_detail_id");
            entity.Property(e => e.ApprovedQuantity)
                .HasPrecision(18, 2)
                .HasColumnName("approved_quantity");
            entity.Property(e => e.ExpectedDate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("expected_date");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.ItemRequestId).HasColumnName("item_request_id");
            entity.Property(e => e.ItemTag)
                .HasMaxLength(500)
                .HasColumnName("item_tag");
            entity.Property(e => e.Quantity)
                .HasPrecision(18, 2)
                .HasColumnName("quantity");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .HasColumnName("remarks");
            entity.Property(e => e.RequestStatusId).HasColumnName("request_status_id");
            entity.Property(e => e.StatusDate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("status_date");
            entity.Property(e => e.T1appqty)
                .HasPrecision(18, 2)
                .HasColumnName("t1appqty");
            entity.Property(e => e.T2appqty)
                .HasPrecision(18, 2)
                .HasColumnName("t2appqty");
            entity.Property(e => e.T3appqty)
                .HasPrecision(18, 2)
                .HasColumnName("t3appqty");
            entity.Property(e => e.Tier1appdate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("tier1appdate");
            entity.Property(e => e.Tier1appid).HasColumnName("tier1appid");
            entity.Property(e => e.Tier2appdate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("tier2appdate");
            entity.Property(e => e.Tier2appid).HasColumnName("tier2appid");
            entity.Property(e => e.Tier3appdate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("tier3appdate");
            entity.Property(e => e.Tier3appid).HasColumnName("tier3appid");
            entity.Property(e => e.Trial835)
                .HasMaxLength(1)
                .HasColumnName("trial835");
        });

        modelBuilder.Entity<Tblmaintenance>(entity =>
        {
            entity.HasKey(e => e.JobId).HasName("pk_tblmaintenance_1");

            entity.ToTable("tblmaintenance");

            entity.Property(e => e.JobId)
                .HasMaxLength(10)
                .HasColumnName("job_id");
            entity.Property(e => e.CompletedDate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("completed_date");
            entity.Property(e => e.EqId)
                .HasMaxLength(10)
                .HasColumnName("eq_id");
            entity.Property(e => e.ReceivedBy)
                .HasMaxLength(6)
                .HasColumnName("received_by");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.TimeTaken)
                .HasPrecision(12, 2)
                .HasColumnName("time_taken");
            entity.Property(e => e.Trial838)
                .HasMaxLength(1)
                .HasColumnName("trial838");
            entity.Property(e => e.UnitOfTime)
                .HasMaxLength(8)
                .HasColumnName("unit_of_time");
        });

        modelBuilder.Entity<Tblmanufacturer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblmanufacturer");

            entity.ToTable("tblmanufacturer");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .HasColumnName("name");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Trial838)
                .HasMaxLength(1)
                .HasColumnName("trial838");
        });

        modelBuilder.Entity<Tblmrp>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("pk_tblmrp");

            entity.ToTable("tblmrp");

            entity.Property(e => e.RecId).HasColumnName("rec_id");
            entity.Property(e => e.EqId)
                .HasMaxLength(10)
                .HasColumnName("eq_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.JobId).HasColumnName("job_id");
            entity.Property(e => e.MrpDate).HasColumnName("mrp_date");
            entity.Property(e => e.PlateNo)
                .HasMaxLength(12)
                .HasColumnName("plate_no");
            entity.Property(e => e.QtyRequired)
                .HasPrecision(12, 2)
                .HasColumnName("qty_required");
            entity.Property(e => e.QuotationId)
                .HasMaxLength(10)
                .HasColumnName("quotation_id");
            entity.Property(e => e.Remark)
                .HasMaxLength(30)
                .HasColumnName("remark");
            entity.Property(e => e.Sendtostore)
                .HasMaxLength(3)
                .HasColumnName("sendtostore");
            entity.Property(e => e.Trial841)
                .HasMaxLength(1)
                .HasColumnName("trial841");
        });

        modelBuilder.Entity<Tblmunit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblmunit");

            entity.ToTable("tblmunit");

            entity.Property(e => e.Id)
                .HasMaxLength(15)
                .HasColumnName("id");
            entity.Property(e => e.Trial841)
                .HasMaxLength(1)
                .HasColumnName("trial841");
            entity.Property(e => e.Uname)
                .HasMaxLength(50)
                .HasColumnName("uname");
        });

        modelBuilder.Entity<Tbloperator>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tbloperator");

            entity.ToTable("tbloperator");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Employer)
                .HasMaxLength(10)
                .HasColumnName("employer");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.Tele)
                .HasMaxLength(12)
                .HasColumnName("tele");
            entity.Property(e => e.Trial841)
                .HasMaxLength(1)
                .HasColumnName("trial841");
        });

        modelBuilder.Entity<Tblothrsrate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblothrsrate");

            entity.ToTable("tblothrsrate");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Holidayhrsrate)
                .HasPrecision(18, 2)
                .HasColumnName("holidayhrsrate");
            entity.Property(e => e.Nighthrsrate)
                .HasPrecision(18, 2)
                .HasColumnName("nighthrsrate");
            entity.Property(e => e.Normalhrsrate)
                .HasPrecision(18, 2)
                .HasColumnName("normalhrsrate");
            entity.Property(e => e.Otherhrsrate)
                .HasPrecision(18, 2)
                .HasColumnName("otherhrsrate");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .HasColumnName("remark");
            entity.Property(e => e.Sundayhrsrate)
                .HasPrecision(18, 2)
                .HasColumnName("sundayhrsrate");
            entity.Property(e => e.Trial841)
                .HasMaxLength(1)
                .HasColumnName("trial841");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(100)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updateddate");
        });

        modelBuilder.Entity<Tbloutsource>(entity =>
        {
            entity.HasKey(e => e.JobId).HasName("pk_tbloutsource");

            entity.ToTable("tbloutsource");

            entity.Property(e => e.JobId)
                .ValueGeneratedNever()
                .HasColumnName("job_id");
            entity.Property(e => e.CompletionDate)
                .HasMaxLength(10)
                .HasColumnName("completion_date");
            entity.Property(e => e.EqId)
                .HasMaxLength(10)
                .HasColumnName("eq_id");
            entity.Property(e => e.Fee)
                .HasPrecision(12, 2)
                .HasColumnName("fee");
            entity.Property(e => e.Reference)
                .HasMaxLength(30)
                .HasColumnName("reference");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.ToCompany).HasColumnName("to_company");
            entity.Property(e => e.Trial841)
                .HasMaxLength(1)
                .HasColumnName("trial841");
            entity.Property(e => e.Userid)
                .HasMaxLength(10)
                .HasColumnName("userid");
        });

        modelBuilder.Entity<Tblownership>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblownership");

            entity.ToTable("tblownership");

            entity.Property(e => e.Id)
                .HasMaxLength(1)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Ownership)
                .HasMaxLength(30)
                .HasColumnName("ownership");
            entity.Property(e => e.Trial844)
                .HasMaxLength(1)
                .HasColumnName("trial844");
        });

        modelBuilder.Entity<Tblpart>(entity =>
        {
            entity.HasKey(e => e.PartId).HasName("pk_tblparts_1");

            entity.ToTable("tblparts");

            entity.Property(e => e.PartId).HasColumnName("part_id");
            entity.Property(e => e.EqId)
                .HasMaxLength(10)
                .HasColumnName("eq_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Qty)
                .HasPrecision(12, 2)
                .HasColumnName("qty");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.Trial844)
                .HasMaxLength(1)
                .HasColumnName("trial844");
        });

        modelBuilder.Entity<Tblpaymenttype>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("pk_tblpaymenttype");

            entity.ToTable("tblpaymenttype");

            entity.Property(e => e.Pid)
                .HasMaxLength(3)
                .HasColumnName("pid");
            entity.Property(e => e.PidName)
                .HasMaxLength(20)
                .HasColumnName("pid_name");
            entity.Property(e => e.Trial844)
                .HasMaxLength(1)
                .HasColumnName("trial844");
        });

        modelBuilder.Entity<Tblpayrollcontrol>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblpayrollcontrol");

            entity.ToTable("tblpayrollcontrol");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Isactive)
                .HasDefaultValueSql("false")
                .HasColumnName("isactive");
            entity.Property(e => e.Period).HasColumnName("period");
            entity.Property(e => e.Trial848)
                .HasMaxLength(1)
                .HasColumnName("trial848");
        });

        modelBuilder.Entity<Tblpayrolljournalsetup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblpayrolljournalsetup");

            entity.ToTable("tblpayrolljournalsetup");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GlAccount)
                .HasMaxLength(50)
                .HasColumnName("gl_account");
            entity.Property(e => e.GlDescription)
                .HasMaxLength(150)
                .HasColumnName("gl_description");
            entity.Property(e => e.IsdebitValue)
                .HasDefaultValueSql("true")
                .HasColumnName("isdebit_value");
            entity.Property(e => e.Issummary)
                .HasDefaultValueSql("true")
                .HasColumnName("issummary");
            entity.Property(e => e.ItemName)
                .HasMaxLength(50)
                .HasColumnName("item_name");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Trial848)
                .HasMaxLength(1)
                .HasColumnName("trial848");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updateddate");
        });

        modelBuilder.Entity<TblpeachtreeLedgerArchive>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblpeachtree_ledger_archive");

            entity.Property(e => e.AccountDescription)
                .HasMaxLength(255)
                .HasColumnName("account_description");
            entity.Property(e => e.AccountId)
                .HasMaxLength(255)
                .HasColumnName("account_id");
            entity.Property(e => e.Balance).HasColumnName("balance");
            entity.Property(e => e.CreditAmt).HasColumnName("credit_amt");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(255)
                .HasColumnName("customer_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .HasColumnName("customer_name");
            entity.Property(e => e.Date)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("date");
            entity.Property(e => e.DebitAmt).HasColumnName("debit_amt");
            entity.Property(e => e.Efy).HasColumnName("efy");
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(255)
                .HasColumnName("employee_id");
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(255)
                .HasColumnName("employee_name");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemDescription)
                .HasMaxLength(255)
                .HasColumnName("item_description");
            entity.Property(e => e.ItemId)
                .HasMaxLength(255)
                .HasColumnName("item_id");
            entity.Property(e => e.JobDescription)
                .HasMaxLength(255)
                .HasColumnName("job_description");
            entity.Property(e => e.JobId)
                .HasMaxLength(255)
                .HasColumnName("job_id");
            entity.Property(e => e.Jrnl)
                .HasMaxLength(255)
                .HasColumnName("jrnl");
            entity.Property(e => e.LineDescription)
                .HasMaxLength(255)
                .HasColumnName("line_description");
            entity.Property(e => e.PeachtreeCompany)
                .HasMaxLength(255)
                .HasColumnName("peachtree_company");
            entity.Property(e => e.Reference)
                .HasMaxLength(255)
                .HasColumnName("reference");
            entity.Property(e => e.TranDate).HasColumnName("tran_date");
            entity.Property(e => e.TransAmount).HasColumnName("trans_amount");
            entity.Property(e => e.TransDescription)
                .HasMaxLength(255)
                .HasColumnName("trans_description");
            entity.Property(e => e.Trial848)
                .HasMaxLength(1)
                .HasColumnName("trial848");
            entity.Property(e => e.VendorId)
                .HasMaxLength(255)
                .HasColumnName("vendor_id");
            entity.Property(e => e.VendorName)
                .HasMaxLength(255)
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<TblplateNo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblplate_no");

            entity.Property(e => e.NewPlateNo)
                .HasMaxLength(20)
                .HasColumnName("new_plate_no");
            entity.Property(e => e.OldPlateNo)
                .HasMaxLength(20)
                .HasColumnName("old_plate_no");
            entity.Property(e => e.Trial870)
                .HasMaxLength(1)
                .HasColumnName("trial870");
        });

        modelBuilder.Entity<TblpmCode>(entity =>
        {
            entity.HasKey(e => e.PmId).HasName("pk_tblpm_codes");

            entity.ToTable("tblpm_codes");

            entity.Property(e => e.PmId).HasColumnName("pm_id");
            entity.Property(e => e.PmDesc)
                .HasMaxLength(30)
                .HasColumnName("pm_desc");
            entity.Property(e => e.Trial870)
                .HasMaxLength(1)
                .HasColumnName("trial870");
        });

        modelBuilder.Entity<Tblproblem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblproblems");

            entity.ToTable("tblproblems");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descr)
                .HasMaxLength(30)
                .HasColumnName("descr");
            entity.Property(e => e.Trial874)
                .HasMaxLength(1)
                .HasColumnName("trial874");
        });

        modelBuilder.Entity<Tblproblemproposed>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblproblemproposed");

            entity.ToTable("tblproblemproposed");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ProblemId).HasColumnName("problem_id");
            entity.Property(e => e.QuotationId).HasColumnName("quotation_id");
            entity.Property(e => e.Trial874)
                .HasMaxLength(1)
                .HasColumnName("trial874");
        });

        modelBuilder.Entity<Tblproject>(entity =>
        {
            entity.HasKey(e => e.ProjId).HasName("pk_tblproject");

            entity.ToTable("tblproject");

            entity.Property(e => e.ProjId).HasColumnName("proj_id");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.ContractAmount)
                .HasPrecision(18, 2)
                .HasColumnName("contract_amount");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Descr)
                .HasMaxLength(50)
                .HasColumnName("descr");
            entity.Property(e => e.EstEndDate).HasColumnName("est_end_date");
            entity.Property(e => e.Isactive)
                .HasDefaultValueSql("false")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Jobid)
                .HasMaxLength(100)
                .HasColumnName("jobid");
            entity.Property(e => e.Location)
                .HasMaxLength(30)
                .HasColumnName("location");
            entity.Property(e => e.Owner).HasColumnName("owner");
            entity.Property(e => e.Ownername)
                .HasMaxLength(100)
                .HasColumnName("ownername");
            entity.Property(e => e.Pmanager).HasColumnName("pmanager");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Remarks)
                .HasMaxLength(50)
                .HasColumnName("remarks");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.Trial874)
                .HasMaxLength(1)
                .HasColumnName("trial874");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<Tblpurchass>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblpurchass");

            entity.ToTable("tblpurchass");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Prassstatdate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("prassstatdate");
            entity.Property(e => e.Prassstatid).HasColumnName("prassstatid");
            entity.Property(e => e.PrdId).HasColumnName("prd_id");
            entity.Property(e => e.Processed).HasColumnName("processed");
            entity.Property(e => e.Purchasorid).HasColumnName("purchasorid");
            entity.Property(e => e.Trial874)
                .HasMaxLength(1)
                .HasColumnName("trial874");
        });

        modelBuilder.Entity<Tblpurque>(entity =>
        {
            entity.HasKey(e => e.PurqId).HasName("pk_tblpurque");

            entity.ToTable("tblpurque");

            entity.Property(e => e.PurqId).HasColumnName("purq_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Qdate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("qdate");
            entity.Property(e => e.Qprocessed).HasColumnName("qprocessed");
            entity.Property(e => e.Qqty)
                .HasPrecision(10, 2)
                .HasColumnName("qqty");
            entity.Property(e => e.QstatusDate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("qstatus_date");
            entity.Property(e => e.QstatusId).HasColumnName("qstatus_id");
            entity.Property(e => e.Reqdetailid).HasColumnName("reqdetailid");
            entity.Property(e => e.StoreId).HasColumnName("store_id");
            entity.Property(e => e.Trial877)
                .HasMaxLength(1)
                .HasColumnName("trial877");
        });

        modelBuilder.Entity<TblpvReq>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblpv_req");

            entity.ToTable("tblpv_req");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountCode)
                .HasMaxLength(50)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("account_code");
            entity.Property(e => e.Accountname)
                .HasMaxLength(100)
                .HasColumnName("accountname");
            entity.Property(e => e.Agreementid).HasColumnName("agreementid");
            entity.Property(e => e.Agreementname)
                .HasMaxLength(50)
                .HasColumnName("agreementname");
            entity.Property(e => e.Agreementtypeid).HasColumnName("agreementtypeid");
            entity.Property(e => e.ErpAmount)
                .HasPrecision(18, 2)
                .HasColumnName("erp_amount");
            entity.Property(e => e.Isactive)
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Issubmitted)
                .HasDefaultValueSql("false")
                .HasColumnName("issubmitted");
            entity.Property(e => e.Nameoncheckid).HasColumnName("nameoncheckid");
            entity.Property(e => e.Nameoncheckname)
                .HasMaxLength(200)
                .HasColumnName("nameoncheckname");
            entity.Property(e => e.PaidAmount)
                .HasPrecision(18, 2)
                .HasColumnName("paid_amount");
            entity.Property(e => e.Payeeid).HasColumnName("payeeid");
            entity.Property(e => e.Payeename)
                .HasMaxLength(200)
                .HasColumnName("payeename");
            entity.Property(e => e.Paymenttype)
                .HasMaxLength(10)
                .HasColumnName("paymenttype");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.PvNo)
                .HasMaxLength(20)
                .HasColumnName("pv_no");
            entity.Property(e => e.ReqId).HasColumnName("req_id");
            entity.Property(e => e.Statusofpayee)
                .HasMaxLength(10)
                .HasColumnName("statusofpayee");
            entity.Property(e => e.Trial877)
                .HasMaxLength(1)
                .HasColumnName("trial877");
            entity.Property(e => e.Typeofpayment)
                .HasMaxLength(50)
                .HasColumnName("typeofpayment");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<Tblquotation>(entity =>
        {
            entity.HasKey(e => e.QuotationId).HasName("pk_tblquotation");

            entity.ToTable("tblquotation");

            entity.Property(e => e.QuotationId)
                .ValueGeneratedNever()
                .HasColumnName("quotation_id");
            entity.Property(e => e.ApprovedBy).HasColumnName("approved_by");
            entity.Property(e => e.ApprovedDate).HasColumnName("approved_date");
            entity.Property(e => e.Assigned)
                .HasMaxLength(3)
                .HasColumnName("assigned");
            entity.Property(e => e.AuthorizedBy).HasColumnName("authorized_by");
            entity.Property(e => e.CheckedBy).HasColumnName("checked_by");
            entity.Property(e => e.Completed)
                .HasMaxLength(3)
                .HasDefaultValueSql("'NO'::character varying")
                .HasColumnName("completed");
            entity.Property(e => e.CompletedDate).HasColumnName("completed_date");
            entity.Property(e => e.CurrentLocation).HasColumnName("current_location");
            entity.Property(e => e.EqId)
                .HasMaxLength(10)
                .HasColumnName("eq_id");
            entity.Property(e => e.InspectionResults)
                .HasMaxLength(500)
                .HasColumnName("inspection_results");
            entity.Property(e => e.JobStatus)
                .HasMaxLength(50)
                .HasColumnName("job_status");
            entity.Property(e => e.Maintenanceat)
                .HasMaxLength(20)
                .HasColumnName("maintenanceat");
            entity.Property(e => e.PlateNo)
                .HasMaxLength(20)
                .HasColumnName("plate_no");
            entity.Property(e => e.RejectedReason)
                .HasMaxLength(30)
                .HasColumnName("rejected_reason");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .HasColumnName("remark");
            entity.Property(e => e.RequestDate).HasColumnName("request_date");
            entity.Property(e => e.RequestedBy).HasColumnName("requested_by");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("status");
            entity.Property(e => e.Technician).HasColumnName("technician");
            entity.Property(e => e.TimeTaken)
                .HasMaxLength(100)
                .HasColumnName("time_taken");
            entity.Property(e => e.Trial887)
                .HasMaxLength(1)
                .HasColumnName("trial887");
        });

        modelBuilder.Entity<TblquotationApproval>(entity =>
        {
            entity.HasKey(e => e.JobId).HasName("pk_tblquotation_approval");

            entity.ToTable("tblquotation_approval");

            entity.Property(e => e.JobId).HasColumnName("job_id");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(6)
                .HasColumnName("approved_by");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approved_date");
            entity.Property(e => e.EqId)
                .HasMaxLength(10)
                .HasColumnName("eq_id");
            entity.Property(e => e.QuotationId).HasColumnName("quotation_id");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.Trial890)
                .HasMaxLength(1)
                .HasColumnName("trial890");
        });

        modelBuilder.Entity<Tblrate>(entity =>
        {
            entity.HasKey(e => e.Rateid).HasName("pk_tblerate");

            entity.ToTable("tblrate");

            entity.Property(e => e.Rateid).HasColumnName("rateid");
            entity.Property(e => e.RateDesc)
                .HasMaxLength(20)
                .HasColumnName("rate_desc");
            entity.Property(e => e.Trial890)
                .HasMaxLength(1)
                .HasColumnName("trial890");
        });

        modelBuilder.Entity<TblreasonDown>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblreason_down");

            entity.ToTable("tblreason_down");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DownReason)
                .HasMaxLength(100)
                .HasColumnName("down_reason");
            entity.Property(e => e.Trial890)
                .HasMaxLength(1)
                .HasColumnName("trial890");
        });

        modelBuilder.Entity<TblreasonIdle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblreason_idle");

            entity.ToTable("tblreason_idle");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdleReason)
                .HasMaxLength(100)
                .HasColumnName("idle_reason");
            entity.Property(e => e.Trial893)
                .HasMaxLength(1)
                .HasColumnName("trial893");
        });

        modelBuilder.Entity<Tblrecovery>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("pk_tblrecovery");

            entity.ToTable("tblrecovery");

            entity.Property(e => e.Pid)
                .ValueGeneratedNever()
                .HasColumnName("pid");
            entity.Property(e => e.Cash)
                .HasMaxLength(3)
                .HasColumnName("cash");
            entity.Property(e => e.Paid)
                .HasMaxLength(3)
                .HasColumnName("paid");
            entity.Property(e => e.Project).HasColumnName("project");
            entity.Property(e => e.PvNo).HasColumnName("pv_no");
            entity.Property(e => e.Sc).HasColumnName("sc");
            entity.Property(e => e.Trial893)
                .HasMaxLength(1)
                .HasColumnName("trial893");
        });

        modelBuilder.Entity<Tblrecurringexpense>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblrecurrentbill");

            entity.ToTable("tblrecurringexpense");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasPrecision(18, 2)
                .HasColumnName("amount");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Createddate)
                .HasMaxLength(50)
                .HasColumnName("createddate");
            entity.Property(e => e.Isapproved)
                .HasDefaultValueSql("false")
                .HasColumnName("isapproved");
            entity.Property(e => e.Isterminated)
                .HasDefaultValueSql("false")
                .HasColumnName("isterminated");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.Itemname)
                .HasMaxLength(100)
                .HasColumnName("itemname");
            entity.Property(e => e.Memo)
                .HasMaxLength(200)
                .HasColumnName("memo");
            entity.Property(e => e.Mode)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("mode");
            entity.Property(e => e.ProfileName)
                .HasMaxLength(100)
                .HasColumnName("profile_name");
            entity.Property(e => e.RepeateCount).HasColumnName("repeate_count");
            entity.Property(e => e.RepeateEvery)
                .HasMaxLength(50)
                .HasColumnName("repeate_every");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Trial897)
                .HasMaxLength(1)
                .HasColumnName("trial897");
            entity.Property(e => e.Vendorid).HasColumnName("vendorid");
            entity.Property(e => e.Vendorname)
                .HasMaxLength(100)
                .HasColumnName("vendorname");
        });

        modelBuilder.Entity<TblregistryOwned>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblregistry_owned_1");

            entity.ToTable("tblregistry_owned");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Agreement)
                .HasMaxLength(50)
                .HasColumnName("agreement");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Capacity)
                .HasPrecision(12, 2)
                .HasColumnName("capacity");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.ChassisNo)
                .HasMaxLength(200)
                .HasColumnName("chassis_no");
            entity.Property(e => e.Clientid).HasColumnName("clientid");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .HasColumnName("created_by");
            entity.Property(e => e.Createdby1)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.EngineArrNo)
                .HasMaxLength(30)
                .HasColumnName("engine_arr_no");
            entity.Property(e => e.EngineNo)
                .HasMaxLength(200)
                .HasColumnName("engine_no");
            entity.Property(e => e.EqId)
                .HasMaxLength(20)
                .HasColumnName("eq_id");
            entity.Property(e => e.EqModel)
                .HasMaxLength(20)
                .HasColumnName("eq_model");
            entity.Property(e => e.EqName)
                .HasMaxLength(30)
                .HasColumnName("eq_name");
            entity.Property(e => e.Equipmenttypeid).HasColumnName("equipmenttypeid");
            entity.Property(e => e.ExpiryDate).HasColumnName("expiry_date");
            entity.Property(e => e.FuelType).HasColumnName("fuel_type");
            entity.Property(e => e.Fuelconsumptionrate)
                .HasPrecision(18, 2)
                .HasColumnName("fuelconsumptionrate");
            entity.Property(e => e.Fuelholdingcapacity)
                .HasPrecision(18, 2)
                .HasColumnName("fuelholdingcapacity");
            entity.Property(e => e.Hasvat)
                .HasDefaultValueSql("false")
                .HasColumnName("hasvat");
            entity.Property(e => e.Haswht)
                .HasDefaultValueSql("false")
                .HasColumnName("haswht");
            entity.Property(e => e.HorsePower)
                .HasPrecision(10, 2)
                .HasColumnName("horse_power");
            entity.Property(e => e.IdlerentRate)
                .HasPrecision(12, 2)
                .HasColumnName("idlerent_rate");
            entity.Property(e => e.Isactive)
                .HasDefaultValueSql("false")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Ismachinery)
                .HasDefaultValueSql("true")
                .HasColumnName("ismachinery");
            entity.Property(e => e.Isoperational).HasColumnName("isoperational");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Isvehicletransport)
                .HasDefaultValueSql("false")
                .HasColumnName("isvehicletransport");
            entity.Property(e => e.Machinecapacity)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("machinecapacity");
            entity.Property(e => e.Machinerynumber)
                .HasMaxLength(50)
                .HasColumnName("machinerynumber");
            entity.Property(e => e.ManualFilename)
                .HasMaxLength(30)
                .HasColumnName("manual_filename");
            entity.Property(e => e.Manufacturer).HasColumnName("manufacturer");
            entity.Property(e => e.MinH).HasColumnName("min_h");
            entity.Property(e => e.MinM).HasColumnName("min_m");
            entity.Property(e => e.Odometerreading)
                .HasDefaultValueSql("0")
                .HasColumnName("odometerreading");
            entity.Property(e => e.Operatorid).HasColumnName("operatorid");
            entity.Property(e => e.Operatorname)
                .HasMaxLength(300)
                .HasColumnName("operatorname");
            entity.Property(e => e.Ownership)
                .HasMaxLength(10)
                .HasColumnName("ownership");
            entity.Property(e => e.PlateNo)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("plate_no");
            entity.Property(e => e.PolicyNo)
                .HasMaxLength(30)
                .HasColumnName("policy_no");
            entity.Property(e => e.ProjId).HasColumnName("proj_id");
            entity.Property(e => e.PurchaseDate)
                .HasMaxLength(10)
                .HasColumnName("purchase_date");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Remark)
                .HasMaxLength(30)
                .HasColumnName("remark");
            entity.Property(e => e.RentRate)
                .HasPrecision(12, 2)
                .HasColumnName("rent_rate");
            entity.Property(e => e.RentingCompany)
                .HasMaxLength(50)
                .HasColumnName("renting_company");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.TmNo)
                .HasMaxLength(30)
                .HasColumnName("tm_no");
            entity.Property(e => e.Trial897)
                .HasMaxLength(1)
                .HasColumnName("trial897");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.VatInPercent)
                .HasPrecision(18, 2)
                .HasColumnName("vat_in_percent");
            entity.Property(e => e.WhtInPercent)
                .HasPrecision(18, 2)
                .HasColumnName("wht_in_percent");
            entity.Property(e => e.YearOfManufacturing)
                .HasMaxLength(4)
                .HasColumnName("year_of_manufacturing");
        });

        modelBuilder.Entity<Tblrentalaccountsetup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblrentalaccountsetup");

            entity.ToTable("tblrentalaccountsetup");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EndAccountpayable)
                .HasMaxLength(20)
                .HasColumnName("end_accountpayable");
            entity.Property(e => e.EndGlFuel)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("end_gl_fuel");
            entity.Property(e => e.EndGlMachinery)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("end_gl_machinery");
            entity.Property(e => e.EndGlMaterial)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("end_gl_material");
            entity.Property(e => e.EndGlOperatorsalary)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("end_gl_operatorsalary");
            entity.Property(e => e.EndGlOtherdeduction)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("end_gl_otherdeduction");
            entity.Property(e => e.EndGlRentaladvance)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("end_gl_rentaladvance");
            entity.Property(e => e.EndGlRentaladvancerepayment)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("end_gl_rentaladvancerepayment");
            entity.Property(e => e.EndGlRentalpayment)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("end_gl_rentalpayment");
            entity.Property(e => e.EndGlTransport)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("end_gl_transport");
            entity.Property(e => e.EndGlVehicle)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("end_gl_vehicle");
            entity.Property(e => e.StartAccountpayable)
                .HasMaxLength(20)
                .HasColumnName("start_accountpayable");
            entity.Property(e => e.StartGlFuel)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("start_gl_fuel");
            entity.Property(e => e.StartGlMachinery)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("start_gl_machinery");
            entity.Property(e => e.StartGlMaterial)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("start_gl_material");
            entity.Property(e => e.StartGlOperatorsalary)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("start_gl_operatorsalary");
            entity.Property(e => e.StartGlOtherdeduction)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("start_gl_otherdeduction");
            entity.Property(e => e.StartGlRentaladvance)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("start_gl_rentaladvance");
            entity.Property(e => e.StartGlRentaladvancerepayment)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("start_gl_rentaladvancerepayment");
            entity.Property(e => e.StartGlRentalpayment)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("start_gl_rentalpayment");
            entity.Property(e => e.StartGlTransport)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("start_gl_transport");
            entity.Property(e => e.StartGlVehicle)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("start_gl_vehicle");
            entity.Property(e => e.Trial903)
                .HasMaxLength(1)
                .HasColumnName("trial903");
            entity.Property(e => e.Vat)
                .HasMaxLength(20)
                .HasColumnName("vat");
            entity.Property(e => e.Wht)
                .HasMaxLength(20)
                .HasColumnName("wht");
        });

        modelBuilder.Entity<Tblschedule>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("pk_tblschedule");

            entity.ToTable("tblschedule");

            entity.Property(e => e.RecId).HasColumnName("rec_id");
            entity.Property(e => e.EqId)
                .HasMaxLength(10)
                .HasColumnName("eq_id");
            entity.Property(e => e.PmFrequency)
                .HasPrecision(12, 2)
                .HasColumnName("pm_frequency");
            entity.Property(e => e.PmFrequencyBy).HasColumnName("pm_frequency_by");
            entity.Property(e => e.PmTolorance)
                .HasPrecision(12, 2)
                .HasColumnName("pm_tolorance");
            entity.Property(e => e.PmTypeId).HasColumnName("pm_type_id");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.Trial903)
                .HasMaxLength(1)
                .HasColumnName("trial903");
        });

        modelBuilder.Entity<Tblsiv>(entity =>
        {
            entity.HasKey(e => e.SivId).HasName("pk_tblsiv");

            entity.ToTable("tblsiv");

            entity.Property(e => e.SivId).HasColumnName("siv_id");
            entity.Property(e => e.IssType)
                .HasMaxLength(3)
                .HasColumnName("iss_type");
            entity.Property(e => e.IssdBy).HasColumnName("issd_by");
            entity.Property(e => e.RcvdBy)
                .HasMaxLength(30)
                .HasColumnName("rcvd_by");
            entity.Property(e => e.Refno)
                .HasMaxLength(20)
                .HasColumnName("refno");
            entity.Property(e => e.Remark)
                .HasMaxLength(150)
                .HasColumnName("remark");
            entity.Property(e => e.SivNo)
                .HasMaxLength(20)
                .HasColumnName("siv_no");
            entity.Property(e => e.Sivdate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("sivdate");
            entity.Property(e => e.StoreId).HasColumnName("store_id");
            entity.Property(e => e.Trial903)
                .HasMaxLength(1)
                .HasColumnName("trial903");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<Tblsivdetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblsivdetail");

            entity.ToTable("tblsivdetail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Condid).HasColumnName("condid");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Qtyissd)
                .HasPrecision(12, 2)
                .HasColumnName("qtyissd");
            entity.Property(e => e.Refno)
                .HasMaxLength(20)
                .HasColumnName("refno");
            entity.Property(e => e.SivId).HasColumnName("siv_id");
            entity.Property(e => e.Trial906)
                .HasMaxLength(1)
                .HasColumnName("trial906");
            entity.Property(e => e.Unitprice)
                .HasPrecision(18, 2)
                .HasColumnName("unitprice");
        });

        modelBuilder.Entity<Tblstartdate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblstartdate");

            entity.Property(e => e.Ownerid).HasColumnName("ownerid");
            entity.Property(e => e.Startdate)
                .HasMaxLength(50)
                .HasColumnName("startdate");
            entity.Property(e => e.Trial906)
                .HasMaxLength(1)
                .HasColumnName("trial906");
        });

        modelBuilder.Entity<Tblstatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblstatus");

            entity.ToTable("tblstatus");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StatusName)
                .HasMaxLength(30)
                .HasColumnName("status_name");
            entity.Property(e => e.Trial906)
                .HasMaxLength(1)
                .HasColumnName("trial906");
        });

        modelBuilder.Entity<Tblstore>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblstore");

            entity.Property(e => e.Createdby)
                .HasMaxLength(100)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasMaxLength(50)
                .HasDefaultValueSql("'getdate()'::character varying")
                .HasColumnName("createddate");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Project).HasColumnName("project");
            entity.Property(e => e.Projectname)
                .HasMaxLength(100)
                .HasColumnName("projectname");
            entity.Property(e => e.StoreLocation)
                .HasMaxLength(50)
                .HasColumnName("store_location");
            entity.Property(e => e.StoreName)
                .HasMaxLength(50)
                .HasColumnName("store_name");
            entity.Property(e => e.StoreTelephone)
                .HasMaxLength(50)
                .HasColumnName("store_telephone");
            entity.Property(e => e.Trial906)
                .HasMaxLength(1)
                .HasColumnName("trial906");
        });

        modelBuilder.Entity<Tblstoreass>(entity =>
        {
            entity.HasKey(e => e.StoreassId).HasName("pk_tblstoreass");

            entity.ToTable("tblstoreass");

            entity.Property(e => e.StoreassId).HasColumnName("storeass_id");
            entity.Property(e => e.Appby)
                .HasMaxLength(10)
                .HasColumnName("appby");
            entity.Property(e => e.Appdate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("appdate");
            entity.Property(e => e.Appqty)
                .HasPrecision(12, 2)
                .HasColumnName("appqty");
            entity.Property(e => e.Condid).HasColumnName("condid");
            entity.Property(e => e.Issued).HasColumnName("issued");
            entity.Property(e => e.Reqdetailid).HasColumnName("reqdetailid");
            entity.Property(e => e.SassstatDate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("sassstat_date");
            entity.Property(e => e.SassstatId).HasColumnName("sassstat_id");
            entity.Property(e => e.Sivno)
                .HasMaxLength(10)
                .HasColumnName("sivno");
            entity.Property(e => e.Storeid).HasColumnName("storeid");
            entity.Property(e => e.Trial906)
                .HasMaxLength(1)
                .HasColumnName("trial906");
        });

        modelBuilder.Entity<Tbltechnician>(entity =>
        {
            entity.HasKey(e => e.TecId).HasName("pk_tbltechnicians");

            entity.ToTable("tbltechnicians");

            entity.Property(e => e.TecId).HasColumnName("tec_id");
            entity.Property(e => e.EducationField)
                .HasMaxLength(30)
                .HasColumnName("education_field");
            entity.Property(e => e.EducationLevel)
                .HasMaxLength(10)
                .HasColumnName("education_level");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(30)
                .HasColumnName("job_title");
            entity.Property(e => e.LoginId).HasColumnName("login_id");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.ServiceYear)
                .HasMaxLength(20)
                .HasColumnName("service_year");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.TecName)
                .HasMaxLength(30)
                .HasColumnName("tec_name");
            entity.Property(e => e.Trial910)
                .HasMaxLength(1)
                .HasColumnName("trial910");
        });

        modelBuilder.Entity<TbltechnicianAssignment>(entity =>
        {
            entity.HasKey(e => e.AssId).HasName("pk_tbltechnician_assignment");

            entity.ToTable("tbltechnician_assignment");

            entity.Property(e => e.AssId).HasColumnName("ass_id");
            entity.Property(e => e.AssignedBy)
                .HasMaxLength(6)
                .HasColumnName("assigned_by");
            entity.Property(e => e.AssignedDate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("assigned_date");
            entity.Property(e => e.EqId)
                .HasMaxLength(10)
                .HasColumnName("eq_id");
            entity.Property(e => e.EstimatedTime)
                .HasPrecision(10, 2)
                .HasColumnName("estimated_time");
            entity.Property(e => e.JobId).HasColumnName("job_id");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.TeamLeader)
                .HasMaxLength(3)
                .HasColumnName("team_leader");
            entity.Property(e => e.TecId).HasColumnName("tec_id");
            entity.Property(e => e.Trial910)
                .HasMaxLength(1)
                .HasColumnName("trial910");
            entity.Property(e => e.UnitOfTime)
                .HasMaxLength(4)
                .HasColumnName("unit_of_time");
        });

        modelBuilder.Entity<Tbltool>(entity =>
        {
            entity.HasKey(e => e.ToolsId).HasName("pk_tbltools");

            entity.ToTable("tbltools");

            entity.Property(e => e.ToolsId).HasColumnName("tools_id");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.ToolsName)
                .HasMaxLength(30)
                .HasColumnName("tools_name");
            entity.Property(e => e.Trial910)
                .HasMaxLength(1)
                .HasColumnName("trial910");
        });

        modelBuilder.Entity<Tbltsjournalsetup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tbltsdeductionmapping");

            entity.ToTable("tbltsjournalsetup");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GlNetpayableCr)
                .HasMaxLength(50)
                .HasColumnName("gl_netpayable_cr");
            entity.Property(e => e.GlNetpayableCrDesc)
                .HasMaxLength(200)
                .HasColumnName("gl_netpayable_cr_desc");
            entity.Property(e => e.GlVatDr)
                .HasMaxLength(50)
                .HasColumnName("gl_vat_dr");
            entity.Property(e => e.GlVatDrDesc)
                .HasMaxLength(200)
                .HasColumnName("gl_vat_dr_desc");
            entity.Property(e => e.GlWhtCr)
                .HasMaxLength(50)
                .HasColumnName("gl_wht_cr");
            entity.Property(e => e.GlWhtCrDesc)
                .HasMaxLength(200)
                .HasColumnName("gl_wht_cr_desc");
            entity.Property(e => e.GlWorkedamountDr)
                .HasMaxLength(50)
                .HasColumnName("gl_workedamount_dr");
            entity.Property(e => e.GlWorkedamountDrDesc)
                .HasMaxLength(200)
                .HasColumnName("gl_workedamount_dr_desc");
            entity.Property(e => e.Trial910)
                .HasMaxLength(1)
                .HasColumnName("trial910");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updateddate");
        });

        modelBuilder.Entity<Tbluser>(entity =>
        {
            entity.HasKey(e => e.Userid).HasName("pk_tbluser");

            entity.ToTable("tbluser");

            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Agreement1)
                .HasDefaultValueSql("false")
                .HasColumnName("agreement1");
            entity.Property(e => e.Agreement2)
                .HasDefaultValueSql("false")
                .HasColumnName("agreement2");
            entity.Property(e => e.Agreement3)
                .HasDefaultValueSql("false")
                .HasColumnName("agreement3");
            entity.Property(e => e.Agreement4)
                .HasDefaultValueSql("false")
                .HasColumnName("agreement4");
            entity.Property(e => e.Agreement5)
                .HasDefaultValueSql("false")
                .HasColumnName("agreement5");
            entity.Property(e => e.Approval)
                .HasDefaultValueSql("false")
                .HasColumnName("approval");
            entity.Property(e => e.ApprovalLevel).HasColumnName("approval_level");
            entity.Property(e => e.ApprovalPr)
                .HasDefaultValueSql("false")
                .HasColumnName("approval_pr");
            entity.Property(e => e.ApprovalSr)
                .HasDefaultValueSql("false")
                .HasColumnName("approval_sr");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasMaxLength(50)
                .HasColumnName("approveddate");
            entity.Property(e => e.Audit)
                .HasDefaultValueSql("false")
                .HasColumnName("audit");
            entity.Property(e => e.BankSetup)
                .HasDefaultValueSql("false")
                .HasColumnName("bank_setup");
            entity.Property(e => e.BankTran)
                .HasDefaultValueSql("false")
                .HasColumnName("bank_tran");
            entity.Property(e => e.Bankreconciliation)
                .HasDefaultValueSql("false")
                .HasColumnName("bankreconciliation");
            entity.Property(e => e.Bankstatement)
                .HasDefaultValueSql("false")
                .HasColumnName("bankstatement");
            entity.Property(e => e.Billapproval)
                .HasDefaultValueSql("false")
                .HasColumnName("billapproval");
            entity.Property(e => e.Billreview)
                .HasDefaultValueSql("false")
                .HasColumnName("billreview");
            entity.Property(e => e.Canlogin)
                .HasDefaultValueSql("false")
                .HasColumnName("canlogin");
            entity.Property(e => e.Clientapproval)
                .HasDefaultValueSql("false")
                .HasColumnName("clientapproval");
            entity.Property(e => e.Clientcreation)
                .HasDefaultValueSql("false")
                .HasColumnName("clientcreation");
            entity.Property(e => e.Contracts)
                .HasDefaultValueSql("false")
                .HasColumnName("contracts");
            entity.Property(e => e.Createbill)
                .HasDefaultValueSql("false")
                .HasColumnName("createbill");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Createdbyname)
                .HasMaxLength(50)
                .HasColumnName("createdbyname");
            entity.Property(e => e.Createddate)
                .HasMaxLength(50)
                .HasColumnName("createddate");
            entity.Property(e => e.Createdisbu)
                .HasDefaultValueSql("false")
                .HasColumnName("createdisbu");
            entity.Property(e => e.Createuser)
                .HasDefaultValueSql("false")
                .HasColumnName("createuser");
            entity.Property(e => e.Dataandreports)
                .HasDefaultValueSql("false")
                .HasColumnName("dataandreports");
            entity.Property(e => e.Dataentryonly)
                .HasDefaultValueSql("false")
                .HasColumnName("dataentryonly");
            entity.Property(e => e.DeptId).HasColumnName("dept_id");
            entity.Property(e => e.Disbuapproval)
                .HasDefaultValueSql("false")
                .HasColumnName("disbuapproval");
            entity.Property(e => e.Disbureview)
                .HasDefaultValueSql("false")
                .HasColumnName("disbureview");
            entity.Property(e => e.Employee)
                .HasDefaultValueSql("false")
                .HasColumnName("employee");
            entity.Property(e => e.Engineering)
                .HasDefaultValueSql("false")
                .HasColumnName("engineering");
            entity.Property(e => e.Eqsetup)
                .HasDefaultValueSql("false")
                .HasColumnName("eqsetup");
            entity.Property(e => e.Equipment)
                .HasDefaultValueSql("false")
                .HasColumnName("equipment");
            entity.Property(e => e.Finance)
                .HasDefaultValueSql("false")
                .HasColumnName("finance");
            entity.Property(e => e.Finrequest)
                .HasDefaultValueSql("false")
                .HasColumnName("finrequest");
            entity.Property(e => e.Fullname)
                .HasMaxLength(50)
                .HasColumnName("fullname");
            entity.Property(e => e.Hrm)
                .HasDefaultValueSql("false")
                .HasColumnName("hrm");
            entity.Property(e => e.Inventory)
                .HasDefaultValueSql("false")
                .HasColumnName("inventory");
            entity.Property(e => e.Ipcapprove)
                .HasDefaultValueSql("false")
                .HasColumnName("ipcapprove");
            entity.Property(e => e.Ipccreate)
                .HasDefaultValueSql("false")
                .HasColumnName("ipccreate");
            entity.Property(e => e.Ipcreport)
                .HasDefaultValueSql("false")
                .HasColumnName("ipcreport");
            entity.Property(e => e.Ipcreview)
                .HasDefaultValueSql("false")
                .HasColumnName("ipcreview");
            entity.Property(e => e.Isactive)
                .HasDefaultValueSql("false")
                .HasColumnName("isactive");
            entity.Property(e => e.Isadmin)
                .HasDefaultValueSql("false")
                .HasColumnName("isadmin");
            entity.Property(e => e.Isapproved)
                .HasDefaultValueSql("false")
                .HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted)
                .HasDefaultValueSql("false")
                .HasColumnName("isdeleted");
            entity.Property(e => e.Isprojectsite)
                .HasDefaultValueSql("false")
                .HasColumnName("isprojectsite");
            entity.Property(e => e.Isreviewed)
                .HasDefaultValueSql("false")
                .HasColumnName("isreviewed");
            entity.Property(e => e.Itemsetup)
                .HasDefaultValueSql("false")
                .HasColumnName("itemsetup");
            entity.Property(e => e.Manage)
                .HasDefaultValueSql("false")
                .HasColumnName("manage");
            entity.Property(e => e.Manageadmin)
                .HasDefaultValueSql("false")
                .HasColumnName("manageadmin");
            entity.Property(e => e.Manageapproval)
                .HasDefaultValueSql("false")
                .HasColumnName("manageapproval");
            entity.Property(e => e.Managecreate)
                .HasDefaultValueSql("false")
                .HasColumnName("managecreate");
            entity.Property(e => e.Managereview)
                .HasDefaultValueSql("false")
                .HasColumnName("managereview");
            entity.Property(e => e.Operations)
                .HasDefaultValueSql("false")
                .HasColumnName("operations");
            entity.Property(e => e.Other1)
                .HasDefaultValueSql("false")
                .HasColumnName("other1");
            entity.Property(e => e.Other2)
                .HasDefaultValueSql("false")
                .HasColumnName("other2");
            entity.Property(e => e.Other3)
                .HasDefaultValueSql("false")
                .HasColumnName("other3");
            entity.Property(e => e.Other4)
                .HasDefaultValueSql("false")
                .HasColumnName("other4");
            entity.Property(e => e.Payrolltimesheet)
                .HasDefaultValueSql("false")
                .HasColumnName("payrolltimesheet");
            entity.Property(e => e.Planning)
                .HasDefaultValueSql("false")
                .HasColumnName("planning");
            entity.Property(e => e.PosId).HasColumnName("pos_id");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Projectname)
                .HasMaxLength(200)
                .HasColumnName("projectname");
            entity.Property(e => e.Purchasing)
                .HasDefaultValueSql("false")
                .HasColumnName("purchasing");
            entity.Property(e => e.Qapproval)
                .HasDefaultValueSql("false")
                .HasColumnName("qapproval");
            entity.Property(e => e.Qddh)
                .HasDefaultValueSql("false")
                .HasColumnName("qddh");
            entity.Property(e => e.Qdh)
                .HasDefaultValueSql("false")
                .HasColumnName("qdh");
            entity.Property(e => e.Qinspection)
                .HasDefaultValueSql("false")
                .HasColumnName("qinspection");
            entity.Property(e => e.Qrequest)
                .HasDefaultValueSql("false")
                .HasColumnName("qrequest");
            entity.Property(e => e.Quotation)
                .HasDefaultValueSql("false")
                .HasColumnName("quotation");
            entity.Property(e => e.Qwop)
                .HasDefaultValueSql("false")
                .HasColumnName("qwop");
            entity.Property(e => e.Reportsonly)
                .HasDefaultValueSql("false")
                .HasColumnName("reportsonly");
            entity.Property(e => e.Request)
                .HasDefaultValueSql("false")
                .HasColumnName("request");
            entity.Property(e => e.Reslevel).HasColumnName("reslevel");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasMaxLength(50)
                .HasColumnName("revieweddate");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.Store)
                .HasDefaultValueSql("false")
                .HasColumnName("store");
            entity.Property(e => e.SupervisorId).HasColumnName("supervisor_id");
            entity.Property(e => e.SupervisorName)
                .HasMaxLength(100)
                .HasColumnName("supervisor_name");
            entity.Property(e => e.Trial913)
                .HasMaxLength(1)
                .HasColumnName("trial913");
            entity.Property(e => e.Tsapp1)
                .HasDefaultValueSql("false")
                .HasColumnName("tsapp1");
            entity.Property(e => e.Tsapp2)
                .HasDefaultValueSql("false")
                .HasColumnName("tsapp2");
            entity.Property(e => e.Tsapp3)
                .HasDefaultValueSql("false")
                .HasColumnName("tsapp3");
            entity.Property(e => e.Tsapp5)
                .HasDefaultValueSql("false")
                .HasColumnName("tsapp5");
            entity.Property(e => e.Tsapp6)
                .HasDefaultValueSql("false")
                .HasColumnName("tsapp6");
            entity.Property(e => e.Tsdept)
                .HasDefaultValueSql("false")
                .HasColumnName("tsdept");
            entity.Property(e => e.Tsfin)
                .HasDefaultValueSql("false")
                .HasColumnName("tsfin");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasMaxLength(50)
                .HasColumnName("updateddate");
            entity.Property(e => e.Username)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnName("username");
            entity.Property(e => e.Userpassword)
                .HasMaxLength(100)
                .HasColumnName("userpassword");
        });

        modelBuilder.Entity<Tbluserprovilege>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbluserprovilege");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Pageid).HasColumnName("pageid");
            entity.Property(e => e.Trial913)
                .HasMaxLength(1)
                .HasColumnName("trial913");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<Tblvendor>(entity =>
        {
            entity.HasKey(e => e.Vid).HasName("pk_tblvendor");

            entity.ToTable("tblvendor");

            entity.Property(e => e.Vid).HasColumnName("vid");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .HasDefaultValueSql("'11)-(11'::character varying")
                .HasColumnName("address");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.CEmployer)
                .HasDefaultValueSql("false")
                .HasColumnName("c_employer");
            entity.Property(e => e.COthers)
                .HasDefaultValueSql("false")
                .HasColumnName("c_others");
            entity.Property(e => e.CRealestate)
                .HasDefaultValueSql("false")
                .HasColumnName("c_realestate");
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(50)
                .HasDefaultValueSql("'none'::character varying")
                .HasColumnName("contact_person");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Isactive)
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Iscustomer)
                .HasDefaultValueSql("false")
                .HasColumnName("iscustomer");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isinternal).HasColumnName("isinternal");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Isvendor)
                .HasDefaultValueSql("false")
                .HasColumnName("isvendor");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
            entity.Property(e => e.Rate)
                .HasMaxLength(10)
                .HasColumnName("rate");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Tel)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0911-'::character varying")
                .HasColumnName("tel");
            entity.Property(e => e.Tin)
                .HasMaxLength(10)
                .HasDefaultValueSql("'111'::character varying")
                .HasColumnName("tin");
            entity.Property(e => e.Trial913)
                .HasMaxLength(1)
                .HasColumnName("trial913");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.VEmployee)
                .HasDefaultValueSql("false")
                .HasColumnName("v_employee");
            entity.Property(e => e.VOthers)
                .HasDefaultValueSql("false")
                .HasColumnName("v_others");
            entity.Property(e => e.VPurchaser)
                .HasDefaultValueSql("false")
                .HasColumnName("v_purchaser");
            entity.Property(e => e.VRenter)
                .HasDefaultValueSql("false")
                .HasColumnName("v_renter");
            entity.Property(e => e.VSubcontractor)
                .HasDefaultValueSql("false")
                .HasColumnName("v_subcontractor");
            entity.Property(e => e.VSupplier)
                .HasDefaultValueSql("false")
                .HasColumnName("v_supplier");
            entity.Property(e => e.VTransporter)
                .HasDefaultValueSql("false")
                .HasColumnName("v_transporter");
            entity.Property(e => e.Vat)
                .HasMaxLength(15)
                .HasDefaultValueSql("'111'::character varying")
                .HasColumnName("vat");
        });

        modelBuilder.Entity<Tblvendorcreditregistry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tblvendorcreditregistry");

            entity.ToTable("tblvendorcreditregistry");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PoReqNo).HasColumnName("po_req_no");
            entity.Property(e => e.PvNo)
                .HasMaxLength(10)
                .HasColumnName("pv_no");
            entity.Property(e => e.Rectype)
                .HasMaxLength(50)
                .HasColumnName("rectype");
            entity.Property(e => e.Reqid)
                .HasMaxLength(50)
                .HasColumnName("reqid");
            entity.Property(e => e.Sourceid).HasColumnName("sourceid");
            entity.Property(e => e.TotalAmount)
                .HasPrecision(18, 2)
                .HasColumnName("total_amount");
            entity.Property(e => e.Trial923)
                .HasMaxLength(1)
                .HasColumnName("trial923");
        });

        modelBuilder.Entity<Tblzoholedger>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblzoholedger");

            entity.Property(e => e.Account)
                .HasMaxLength(255)
                .HasColumnName("account");
            entity.Property(e => e.AccountCfOldACNo)
                .HasMaxLength(255)
                .HasColumnName("account_cf_old_a_c_no");
            entity.Property(e => e.AccountCode).HasColumnName("account_code");
            entity.Property(e => e.AccountGroup)
                .HasMaxLength(255)
                .HasColumnName("account_group");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AccountName)
                .HasMaxLength(255)
                .HasColumnName("account_name");
            entity.Property(e => e.AccountType)
                .HasMaxLength(255)
                .HasColumnName("account_type");
            entity.Property(e => e.Checkno)
                .HasMaxLength(255)
                .HasColumnName("checkno");
            entity.Property(e => e.ContactId).HasColumnName("contact_id");
            entity.Property(e => e.ContactName)
                .HasMaxLength(255)
                .HasColumnName("contact_name");
            entity.Property(e => e.Credit).HasColumnName("credit");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(255)
                .HasColumnName("currency_code");
            entity.Property(e => e.Date)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("date");
            entity.Property(e => e.Debit).HasColumnName("debit");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.EntityNumber)
                .HasMaxLength(255)
                .HasColumnName("entity_number");
            entity.Property(e => e.ErpId)
                .HasMaxLength(255)
                .HasColumnName("erp_id");
            entity.Property(e => e.FcyCredit).HasColumnName("fcy_credit");
            entity.Property(e => e.FcyDebit).HasColumnName("fcy_debit");
            entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");
            entity.Property(e => e.NetAmount).HasColumnName("net_amount");
            entity.Property(e => e.OffsetAccountId)
                .HasMaxLength(255)
                .HasColumnName("offset_account_id");
            entity.Property(e => e.OffsetAccountType)
                .HasMaxLength(255)
                .HasColumnName("offset_account_type");
            entity.Property(e => e.Pv)
                .HasMaxLength(255)
                .HasColumnName("pv");
            entity.Property(e => e.QbId)
                .HasMaxLength(255)
                .HasColumnName("qb_id");
            entity.Property(e => e.ReferenceNumber)
                .HasMaxLength(255)
                .HasColumnName("reference_number");
            entity.Property(e => e.TrDate).HasColumnName("tr_date");
            entity.Property(e => e.TransactionDetails)
                .HasMaxLength(255)
                .HasColumnName("transaction_details");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(255)
                .HasColumnName("transaction_id");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(255)
                .HasColumnName("transaction_type");
            entity.Property(e => e.Trial923)
                .HasMaxLength(1)
                .HasColumnName("trial923");
            entity.Property(e => e.ZohoId).HasColumnName("zoho_id");
        });

        modelBuilder.Entity<Tempchartoldnew>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tempchartoldnew");

            entity.Property(e => e.NewGl)
                .HasMaxLength(10)
                .HasColumnName("new_gl");
            entity.Property(e => e.OldGl)
                .HasMaxLength(10)
                .HasColumnName("old_gl");
            entity.Property(e => e.OldGlDescription)
                .HasMaxLength(200)
                .IsFixedLength()
                .HasColumnName("old_gl_description");
            entity.Property(e => e.Trial955)
                .HasMaxLength(1)
                .HasColumnName("trial955");
        });

        modelBuilder.Entity<Temppv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temppv");

            entity.Property(e => e.PvNo).HasColumnName("pv_no");
            entity.Property(e => e.Trial955)
                .HasMaxLength(1)
                .HasColumnName("trial955");
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_vehicle");

            entity.ToTable("vehicle");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Clientid).HasColumnName("clientid");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.Fuelconsumptionrate)
                .HasPrecision(18, 2)
                .HasColumnName("fuelconsumptionrate");
            entity.Property(e => e.Fuelholdingcapacity)
                .HasPrecision(18, 2)
                .HasColumnName("fuelholdingcapacity");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isoperational).HasColumnName("isoperational");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Loadingcapacity)
                .HasPrecision(18, 2)
                .HasColumnName("loadingcapacity");
            entity.Property(e => e.Make)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("make");
            entity.Property(e => e.Model)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("model");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Odometerreading).HasColumnName("odometerreading");
            entity.Property(e => e.Platenumber)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("platenumber");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Trial959)
                .HasMaxLength(1)
                .HasColumnName("trial959");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Vehiclenumber)
                .HasMaxLength(50)
                .HasColumnName("vehiclenumber");
            entity.Property(e => e.Vehicletypeid).HasColumnName("vehicletypeid");
        });

        modelBuilder.Entity<Vehicleactivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_vehicleactivity");

            entity.ToTable("vehicleactivity");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Agreementid).HasColumnName("agreementid");
            entity.Property(e => e.Agreementname)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("agreementname");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Downhours)
                .HasPrecision(18, 2)
                .HasColumnName("downhours");
            entity.Property(e => e.Fuelprice)
                .HasPrecision(18, 2)
                .HasColumnName("fuelprice");
            entity.Property(e => e.Fueltaken)
                .HasPrecision(18, 2)
                .HasColumnName("fueltaken");
            entity.Property(e => e.Fueltype)
                .HasMaxLength(50)
                .HasColumnName("fueltype");
            entity.Property(e => e.Hourlyrate)
                .HasPrecision(18, 2)
                .HasColumnName("hourlyrate");
            entity.Property(e => e.Idlehours)
                .HasPrecision(18, 2)
                .HasColumnName("idlehours");
            entity.Property(e => e.Idlereason)
                .HasMaxLength(250)
                .HasColumnName("idlereason");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Managerid).HasColumnName("managerid");
            entity.Property(e => e.Managername)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("managername");
            entity.Property(e => e.Odometerreading).HasColumnName("odometerreading");
            entity.Property(e => e.Operators)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("operators");
            entity.Property(e => e.Platenumber)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("platenumber");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Projectname)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("projectname");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Reportedby)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("reportedby");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Siteid).HasColumnName("siteid");
            entity.Property(e => e.Sitename)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("sitename");
            entity.Property(e => e.Trial959)
                .HasMaxLength(1)
                .HasColumnName("trial959");
            entity.Property(e => e.Unpaididlehours)
                .HasPrecision(18, 2)
                .HasColumnName("unpaididlehours");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Usedbyid).HasColumnName("usedbyid");
            entity.Property(e => e.Usedbyname)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("usedbyname");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
            entity.Property(e => e.Workingdate)
                .IsRequired()
                .HasColumnName("workingdate");
            entity.Property(e => e.Workinghours)
                .HasPrecision(18, 2)
                .HasColumnName("workinghours");
        });

        modelBuilder.Entity<Vehiclerentalagreement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_vehiclerentalagreement");

            entity.ToTable("vehiclerentalagreement");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppLevel)
                .HasDefaultValueSql("0")
                .HasColumnName("app_level");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Contractedhours).HasColumnName("contractedhours");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Creatoruserid).HasColumnName("creatoruserid");
            entity.Property(e => e.Currentadvanceamount)
                .HasPrecision(18, 2)
                .HasColumnName("currentadvanceamount");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.EndDate1).HasColumnName("end_date");
            entity.Property(e => e.Enddate).HasColumnName("enddate");
            entity.Property(e => e.ErpDate).HasColumnName("erp_date");
            entity.Property(e => e.Hasattachement)
                .HasDefaultValueSql("false")
                .HasColumnName("hasattachement");
            entity.Property(e => e.Hourlyrate)
                .HasPrecision(18, 2)
                .HasColumnName("hourlyrate");
            entity.Property(e => e.Isactive)
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved)
                .HasDefaultValueSql("false")
                .HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isincomegenerating)
                .HasDefaultValueSql("false")
                .HasColumnName("isincomegenerating");
            entity.Property(e => e.Isreviewed)
                .HasDefaultValueSql("false")
                .HasColumnName("isreviewed");
            entity.Property(e => e.IsvatRegistered)
                .HasDefaultValueSql("false")
                .HasColumnName("isvat_registered");
            entity.Property(e => e.Managerid).HasColumnName("managerid");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Odometerreading).HasColumnName("odometerreading");
            entity.Property(e => e.Outstandingadvanceamount)
                .HasPrecision(18, 2)
                .HasColumnName("outstandingadvanceamount");
            entity.Property(e => e.Ownerid).HasColumnName("ownerid");
            entity.Property(e => e.PlateNo)
                .HasMaxLength(20)
                .HasColumnName("plate_no");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(150)
                .HasColumnName("reference_no");
            entity.Property(e => e.Renterid).HasColumnName("renterid");
            entity.Property(e => e.Rentingid).HasColumnName("rentingid");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.StartDate1).HasColumnName("start_date");
            entity.Property(e => e.Startdate).HasColumnName("startdate");
            entity.Property(e => e.Trial962)
                .HasMaxLength(1)
                .HasColumnName("trial962");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");

            entity.HasOne(d => d.Manager).WithMany(p => p.Vehiclerentalagreements)
                .HasForeignKey(d => d.Managerid)
                .HasConstraintName("fk_dbo_vehiclerentalagreement_dbo_manager_managerid");

            entity.HasOne(d => d.Owner).WithMany(p => p.Vehiclerentalagreements)
                .HasForeignKey(d => d.Ownerid)
                .HasConstraintName("fk_dbo_vehiclerentalagreement_dbo_client_ownerid");

            entity.HasOne(d => d.Project).WithMany(p => p.Vehiclerentalagreements)
                .HasForeignKey(d => d.Projectid)
                .HasConstraintName("fk_dbo_vehiclerentalagreement_dbo_project_projectid");
        });

        modelBuilder.Entity<Vehicletransportactivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_vehicletransportactivity");

            entity.ToTable("vehicletransportactivity");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Agreementid).HasColumnName("agreementid");
            entity.Property(e => e.Agreementname)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("agreementname");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Createdby)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.Fuelprice)
                .HasPrecision(18, 2)
                .HasColumnName("fuelprice");
            entity.Property(e => e.Fueltaken)
                .HasPrecision(18, 2)
                .HasColumnName("fueltaken");
            entity.Property(e => e.Fueltype)
                .HasMaxLength(50)
                .HasColumnName("fueltype");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Managerid).HasColumnName("managerid");
            entity.Property(e => e.Managername)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("managername");
            entity.Property(e => e.Odometerreading).HasColumnName("odometerreading");
            entity.Property(e => e.Operators)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("operators");
            entity.Property(e => e.Ownerid).HasColumnName("ownerid");
            entity.Property(e => e.Ownername)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("ownername");
            entity.Property(e => e.Platenumber)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("platenumber");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Projectname)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("projectname");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Reportedby)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("reportedby");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.Transporterid).HasColumnName("transporterid");
            entity.Property(e => e.Transportername)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("transportername");
            entity.Property(e => e.Trial965)
                .HasMaxLength(1)
                .HasColumnName("trial965");
            entity.Property(e => e.Unloadedamount)
                .HasPrecision(18, 2)
                .HasColumnName("unloadedamount");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Usedbyid).HasColumnName("usedbyid");
            entity.Property(e => e.Usedbyname)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("usedbyname");
            entity.Property(e => e.Vat)
                .HasPrecision(18, 2)
                .HasColumnName("vat");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
            entity.Property(e => e.Withholding)
                .HasPrecision(18, 2)
                .HasColumnName("withholding");
            entity.Property(e => e.Workenddate)
                .IsRequired()
                .HasColumnName("workenddate");
            entity.Property(e => e.Workstartdate)
                .IsRequired()
                .HasColumnName("workstartdate");
        });

        modelBuilder.Entity<Vehicletransportagreement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dbo_vehicletransportagreement");

            entity.ToTable("vehicletransportagreement");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppLevel)
                .HasDefaultValueSql("0")
                .HasColumnName("app_level");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("approvedby");
            entity.Property(e => e.Approveddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("approveddate");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("createddate");
            entity.Property(e => e.Creatoruserid).HasColumnName("creatoruserid");
            entity.Property(e => e.Currentadvanceamount)
                .HasPrecision(18, 2)
                .HasColumnName("currentadvanceamount");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.EndDate1).HasColumnName("end_date");
            entity.Property(e => e.Enddate).HasColumnName("enddate");
            entity.Property(e => e.ErpDate).HasColumnName("erp_date");
            entity.Property(e => e.Hasattachement)
                .HasDefaultValueSql("false")
                .HasColumnName("hasattachement");
            entity.Property(e => e.Isactive)
                .HasDefaultValueSql("true")
                .HasColumnName("isactive");
            entity.Property(e => e.Isapproved).HasColumnName("isapproved");
            entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");
            entity.Property(e => e.Isincomegenerating)
                .HasDefaultValueSql("false")
                .HasColumnName("isincomegenerating");
            entity.Property(e => e.Isreviewed).HasColumnName("isreviewed");
            entity.Property(e => e.Loadedamount)
                .HasPrecision(18, 2)
                .HasColumnName("loadedamount");
            entity.Property(e => e.Loadedfrom)
                .HasMaxLength(250)
                .HasColumnName("loadedfrom");
            entity.Property(e => e.Managerid).HasColumnName("managerid");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Odometerreading).HasColumnName("odometerreading");
            entity.Property(e => e.Outstandingadvanceamount)
                .HasPrecision(18, 2)
                .HasColumnName("outstandingadvanceamount");
            entity.Property(e => e.Ownerid).HasColumnName("ownerid");
            entity.Property(e => e.PlateNo)
                .HasMaxLength(20)
                .HasColumnName("plate_no");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Rateperunit)
                .HasPrecision(18, 2)
                .HasColumnName("rateperunit");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .HasColumnName("reason");
            entity.Property(e => e.Renterid).HasColumnName("renterid");
            entity.Property(e => e.Rentingid).HasColumnName("rentingid");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("reviewedby");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("revieweddate");
            entity.Property(e => e.StartDate1).HasColumnName("start_date");
            entity.Property(e => e.Startdate).HasColumnName("startdate");
            entity.Property(e => e.Transporterid).HasColumnName("transporterid");
            entity.Property(e => e.Trial965)
                .HasMaxLength(1)
                .HasColumnName("trial965");
            entity.Property(e => e.Unloadedto)
                .HasMaxLength(250)
                .HasColumnName("unloadedto");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updateddate)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("updateddate");
            entity.Property(e => e.Usedbyid).HasColumnName("usedbyid");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");

            entity.HasOne(d => d.Manager).WithMany(p => p.Vehicletransportagreements)
                .HasForeignKey(d => d.Managerid)
                .HasConstraintName("fk_dbo_vehicletransportagreement_dbo_manager_managerid");

            entity.HasOne(d => d.Owner).WithMany(p => p.Vehicletransportagreements)
                .HasForeignKey(d => d.Ownerid)
                .HasConstraintName("fk_dbo_vehicletransportagreement_dbo_client_ownerid");

            entity.HasOne(d => d.Project).WithMany(p => p.Vehicletransportagreements)
                .HasForeignKey(d => d.Projectid)
                .HasConstraintName("fk_dbo_vehicletransportagreement_dbo_project_projectid");
        });

        modelBuilder.Entity<Xx>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PlateNo)
                .HasMaxLength(20)
                .HasColumnName("plate_no");
            entity.Property(e => e.Trial968)
                .HasMaxLength(1)
                .HasColumnName("trial968");
        });

        modelBuilder.Entity<ZohoErpVendor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zoho_erp_vendor");

            entity.Property(e => e.ErpVendorId).HasColumnName("erp_vendor_id");
            entity.Property(e => e.ErpVendorName)
                .HasMaxLength(255)
                .HasColumnName("erp_vendor_name");
            entity.Property(e => e.Trial968)
                .HasMaxLength(1)
                .HasColumnName("trial968");
            entity.Property(e => e.ZohoVendorId).HasColumnName("zoho_vendor_id");
        });

        modelBuilder.Entity<ZohoLedger>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zoho_ledger");

            entity.Property(e => e.Account)
                .HasMaxLength(255)
                .HasColumnName("account");
            entity.Property(e => e.AccountCfOldACNo)
                .HasMaxLength(255)
                .HasColumnName("account_cf_old_a_c_no");
            entity.Property(e => e.AccountCode).HasColumnName("account_code");
            entity.Property(e => e.AccountGroup)
                .HasMaxLength(255)
                .HasColumnName("account_group");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AccountName)
                .HasMaxLength(255)
                .HasColumnName("account_name");
            entity.Property(e => e.AccountType)
                .HasMaxLength(255)
                .HasColumnName("account_type");
            entity.Property(e => e.Checkno)
                .HasMaxLength(255)
                .HasColumnName("checkno");
            entity.Property(e => e.ContactId).HasColumnName("contact_id");
            entity.Property(e => e.ContactName)
                .HasMaxLength(255)
                .HasColumnName("contact_name");
            entity.Property(e => e.Credit).HasColumnName("credit");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(255)
                .HasColumnName("currency_code");
            entity.Property(e => e.Date)
                .HasColumnType("timestamp(3) without time zone")
                .HasColumnName("date");
            entity.Property(e => e.Debit).HasColumnName("debit");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.EntityNumber)
                .HasMaxLength(255)
                .HasColumnName("entity_number");
            entity.Property(e => e.ErpId).HasColumnName("erp_id");
            entity.Property(e => e.FcyCredit).HasColumnName("fcy_credit");
            entity.Property(e => e.FcyDebit).HasColumnName("fcy_debit");
            entity.Property(e => e.FcyNetAmount).HasColumnName("fcy_net_amount");
            entity.Property(e => e.NetAmount).HasColumnName("net_amount");
            entity.Property(e => e.OffsetAccountId)
                .HasMaxLength(255)
                .HasColumnName("offset_account_id");
            entity.Property(e => e.OffsetAccountType)
                .HasMaxLength(255)
                .HasColumnName("offset_account_type");
            entity.Property(e => e.Pv)
                .HasMaxLength(255)
                .HasColumnName("pv");
            entity.Property(e => e.QbId).HasColumnName("qb_id");
            entity.Property(e => e.ReferenceNumber)
                .HasMaxLength(255)
                .HasColumnName("reference_number");
            entity.Property(e => e.TrDate)
                .HasMaxLength(255)
                .HasColumnName("tr_date");
            entity.Property(e => e.TransactionDetails)
                .HasMaxLength(255)
                .HasColumnName("transaction_details");
            entity.Property(e => e.TransactionId).HasColumnName("transaction_id");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(255)
                .HasColumnName("transaction_type");
            entity.Property(e => e.Trial972)
                .HasMaxLength(1)
                .HasColumnName("trial972");
            entity.Property(e => e.ZohoId).HasColumnName("zoho_id");
        });

        modelBuilder.Entity<Zoholedger1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zoholedger");

            entity.Property(e => e.AccountCfOldacno)
                .HasMaxLength(255)
                .HasColumnName("account_cf_oldacno");
            entity.Property(e => e.AccountCode)
                .HasMaxLength(255)
                .HasColumnName("account_code");
            entity.Property(e => e.AccountGroup)
                .HasMaxLength(255)
                .HasColumnName("account_group");
            entity.Property(e => e.AccountId)
                .HasMaxLength(255)
                .HasColumnName("account_id");
            entity.Property(e => e.AccountName)
                .HasMaxLength(255)
                .HasColumnName("account_name");
            entity.Property(e => e.AccountType)
                .HasMaxLength(255)
                .HasColumnName("account_type");
            entity.Property(e => e.ContactId)
                .HasMaxLength(255)
                .HasColumnName("contact_id");
            entity.Property(e => e.ContactName)
                .HasMaxLength(255)
                .HasColumnName("contact_name");
            entity.Property(e => e.Credit)
                .HasPrecision(18, 2)
                .HasColumnName("credit");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(255)
                .HasColumnName("currency_code");
            entity.Property(e => e.Date)
                .HasMaxLength(255)
                .HasColumnName("date");
            entity.Property(e => e.Debit)
                .HasPrecision(18, 2)
                .HasColumnName("debit");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.EntityNumber)
                .HasMaxLength(255)
                .HasColumnName("entity_number");
            entity.Property(e => e.FcyCredit)
                .HasPrecision(18, 2)
                .HasColumnName("fcy_credit");
            entity.Property(e => e.FcyDebit)
                .HasPrecision(18, 2)
                .HasColumnName("fcy_debit");
            entity.Property(e => e.FcyNetAmount)
                .HasPrecision(18, 2)
                .HasColumnName("fcy_net_amount");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NetAmount)
                .HasPrecision(18, 2)
                .HasColumnName("net_amount");
            entity.Property(e => e.OffsetAccountId)
                .HasMaxLength(255)
                .HasColumnName("offset_account_id");
            entity.Property(e => e.OffsetAccountType)
                .HasMaxLength(255)
                .HasColumnName("offset_account_type");
            entity.Property(e => e.ProjectIds)
                .HasMaxLength(255)
                .HasColumnName("project_ids");
            entity.Property(e => e.Pv).HasColumnName("pv");
            entity.Property(e => e.ReferenceNumber)
                .HasMaxLength(255)
                .HasColumnName("reference_number");
            entity.Property(e => e.ReferenceTransactionId)
                .HasMaxLength(255)
                .HasColumnName("reference_transaction_id");
            entity.Property(e => e.RunningBalance)
                .HasPrecision(18, 2)
                .HasColumnName("running_balance");
            entity.Property(e => e.TranDate).HasColumnName("tran_date");
            entity.Property(e => e.TransactionDetails)
                .HasMaxLength(255)
                .HasColumnName("transaction_details");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(255)
                .HasColumnName("transaction_id");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(255)
                .HasColumnName("transaction_type");
            entity.Property(e => e.Trial991)
                .HasMaxLength(1)
                .HasColumnName("trial991");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
