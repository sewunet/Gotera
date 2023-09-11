using System;
using System.Collections.Generic;

namespace Gotera.Infrastructure.Persistence;

public partial class EngfinTimesheet
{
    public int Id { get; set; }

    public int? ProjId { get; set; }

    public int? ScId { get; set; }

    public string PlateNo { get; set; }

    public string EqName { get; set; }

    public int? DateRent { get; set; }

    public int? PeriodYearmonth { get; set; }

    public decimal? Rate { get; set; }

    public decimal? IdleRate { get; set; }

    public string Owner { get; set; }

    public int? TranDate { get; set; }

    public int? MorningstH { get; set; }

    public int? MorningstM { get; set; }

    public int? MorningetH { get; set; }

    public int? MorningetM { get; set; }

    public int? MorningOpHrs { get; set; }

    public int? MorningOpMin { get; set; }

    public int? AfternoonstH { get; set; }

    public int? AfternoonstM { get; set; }

    public int? AfternoonetH { get; set; }

    public int? AfternoonetM { get; set; }

    public int? AfternoonOpHr { get; set; }

    public int? AfternoonOpMin { get; set; }

    public int? TotalOpH { get; set; }

    public int? TotalOpM { get; set; }

    public int? IdleHUnpaid { get; set; }

    public int? IdleMUnpaid { get; set; }

    public int? IdleHPaid { get; set; }

    public int? IdleMPaid { get; set; }

    public string ReasonIdle { get; set; }

    public int? DownH { get; set; }

    public int? DownM { get; set; }

    public string ReasonDown { get; set; }

    public int? MinH { get; set; }

    public int? MinM { get; set; }

    public string RemarkType { get; set; }

    public int? CreatedBy { get; set; }

    public string CreatedTime { get; set; }

    public int? ApprovedBy { get; set; }

    public string ApprovedTime { get; set; }

    public int? AuthorizedBy { get; set; }

    public string AuthorizedTime { get; set; }

    public decimal? Amount { get; set; }

    public string Operator { get; set; }

    public int? Status { get; set; }

    public string Mcomment { get; set; }

    public bool? ChkNight { get; set; }

    public decimal? Fueltaken { get; set; }

    public string Fueltype { get; set; }

    public decimal? Fuelprice { get; set; }

    public int? Odometerreading { get; set; }

    public string Reportedby { get; set; }

    public bool? Isdeleted { get; set; }

    public string Reason { get; set; }

    public DateTime? Createddate { get; set; }

    public string Createdby1 { get; set; }

    public bool? Isreviewed { get; set; }

    public DateTime? Revieweddate { get; set; }

    public string Reviewedby { get; set; }

    public bool? Isapproved { get; set; }

    public DateTime? Approveddate { get; set; }

    public string Approvedby1 { get; set; }

    public DateTime? Updateddate { get; set; }

    public string Updatedby { get; set; }

    public int? Siteid { get; set; }

    public int? Machineryid { get; set; }

    public int? Managerid { get; set; }

    public string Projectname { get; set; }

    public string Sitename { get; set; }

    public int? Agreementid { get; set; }

    public string Agreementname { get; set; }

    public string Managername { get; set; }

    public string Usedbyname { get; set; }

    public bool? Issendtobill { get; set; }

    public int? Ownerid { get; set; }

    public bool? Isdatafromsite { get; set; }

    public string LocationStart { get; set; }

    public string LocationEnd { get; set; }

    public string Payitem { get; set; }

    public string PayitemDescr { get; set; }

    public string Billgroupid { get; set; }

    public char? Trial351 { get; set; }
}
