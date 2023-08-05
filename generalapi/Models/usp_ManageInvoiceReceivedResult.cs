﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace generalapi.Models
{
    public partial class usp_ManageInvoiceReceivedResult
    {
        public int InternalId { get; set; }
        public string ID { get; set; }
        public DateTime? IssueDate { get; set; }
        public string IssueTime { get; set; }
        public string Notes { get; set; }
        public string CurrencyCode { get; set; }
        public string CUFE { get; set; }
        public string InvoiceAuthorization { get; set; }
        public string InvoiceAuthorizationStartDate { get; set; }
        public string InvoiceAuthorizationEndDate { get; set; }
        public string InvoiceAuthorizationPrefix { get; set; }
        public string InvoiceAuthorizationFrom { get; set; }
        public string InvoiceAuthorizationTo { get; set; }
        public string QRCode { get; set; }
        public string RegistrationName { get; set; }
        public string CompanyID { get; set; }
        public string TaxLevelCode { get; set; }
        public string CityID { get; set; }
        public string CityName { get; set; }
        public string CountrySubentity { get; set; }
        public string CountrySubentityCode { get; set; }
        public string AddressLine { get; set; }
        public string CountryIdentification { get; set; }
        public string CountryName { get; set; }
        public string TaxSchemaId { get; set; }
        public string TaxSchemaName { get; set; }
        public string Telephone { get; set; }
        public string ElectronicMail { get; set; }
        public string PaymentMeansId { get; set; }
        public string PaymentMeansCode { get; set; }
        public string PaymentId { get; set; }
        public string PaymentTermsReferenceEventCode { get; set; }
        public string AllowanceChargeId { get; set; }
        public bool? AllowanceChargeIndicator { get; set; }
        public string AllowanceChargeReason { get; set; }
        public decimal AllowanceChargeMultiplierFactorNumeric { get; set; }
        public decimal AllowanceChargeAmount { get; set; }
        public decimal AllowanceChargeBaseAmount { get; set; }
        public string PaymentExchangeRateSourceCurrencyCode { get; set; }
        public decimal PaymentExchangeRateSourceCurrencyBaseRate { get; set; }
        public string PaymentExchangeRateTargetCurrencyCode { get; set; }
        public decimal PaymentExchangeRateTargetCurrencyBaseRate { get; set; }
        public decimal PaymentExchangeRateCalculationRate { get; set; }
        public DateTime? PaymentExchangeRateDate { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal RoundingAmount { get; set; }
        public decimal TaxableAmount { get; set; }
        public decimal TaxCategoryPercent { get; set; }
        public string TaxCategoryTaxSchemeID { get; set; }
        public string TaxCategoryTaxSchemeName { get; set; }
        public decimal LineExtensionAmount { get; set; }
        public decimal TaxExclusiveAmount { get; set; }
        public decimal TaxInclusiveAmount { get; set; }
        public decimal AllowanceTotalAmount { get; set; }
        public decimal ChargeTotalAmount { get; set; }
        public decimal PayableAmount { get; set; }
        public DateTime? DueDate { get; set; }
        public string SchemeId { get; set; }
        public string OrderReference { get; set; }
        public DateTime? OrderReferenceIssueDate { get; set; }
        public string PdfFileName { get; set; }
        public string AdFileName { get; set; }
        public string PrepaidPaymentCurrency { get; set; }
        public decimal PrepaidPaymentValue { get; set; }
        public string PrepaidPaymentID { get; set; }
        public decimal ReteRenta { get; set; }
        public decimal ReteICA { get; set; }
        public decimal ReteIVA { get; set; }
        public string PaymentMeans { get; set; }
        public string LatestEvent { get; set; }
        public string Acuse { get; set; }
        public string Recibo { get; set; }
        public string AceptacionExp { get; set; }
        public string Reclamo { get; set; }
        public string SENDER { get; set; }
        public string TemplateId { get; set; }
        public string FromID { get; set; }
        public string FromName { get; set; }
        public string CustomizationID { get; set; }
        public int? FechaRecibo { get; set; }
    }
}
