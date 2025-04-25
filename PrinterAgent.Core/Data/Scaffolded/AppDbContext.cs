using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Action> Actions { get; set; }

    public virtual DbSet<ActiveItem> ActiveItems { get; set; }

    public virtual DbSet<AllowedMealsPerBoard> AllowedMealsPerBoards { get; set; }

    public virtual DbSet<AllowedMealsPerBoardDetail> AllowedMealsPerBoardDetails { get; set; }

    public virtual DbSet<AssignedPosition> AssignedPositions { get; set; }

    public virtual DbSet<Attendance> Attendances { get; set; }

    public virtual DbSet<AttendanceTimezone> AttendanceTimezones { get; set; }

    public virtual DbSet<AuthorizedGroup> AuthorizedGroups { get; set; }

    public virtual DbSet<AuthorizedGroupDetail> AuthorizedGroupDetails { get; set; }

    public virtual DbSet<Baendofday> Baendofdays { get; set; }

    public virtual DbSet<Baguest> Baguests { get; set; }

    public virtual DbSet<Bareport> Bareports { get; set; }

    public virtual DbSet<BareportsTable> BareportsTables { get; set; }

    public virtual DbSet<BoAction> BoActions { get; set; }

    public virtual DbSet<BoDaPageSetStoreAssoc> BoDaPageSetStoreAssocs { get; set; }

    public virtual DbSet<BoDaPriceListStoreAssoc> BoDaPriceListStoreAssocs { get; set; }

    public virtual DbSet<BoDaProductStoreAssoc> BoDaProductStoreAssocs { get; set; }

    public virtual DbSet<BoOption> BoOptions { get; set; }

    public virtual DbSet<BoRole> BoRoles { get; set; }

    public virtual DbSet<BoRoleAction> BoRoleActions { get; set; }

    public virtual DbSet<BoUser> BoUsers { get; set; }

    public virtual DbSet<BoardMeal> BoardMeals { get; set; }

    public virtual DbSet<BoxProductsMapping> BoxProductsMappings { get; set; }

    public virtual DbSet<BoxTimeTableV2> BoxTimeTableV2s { get; set; }

    public virtual DbSet<CategoriesForBox> CategoriesForBoxes { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<ChoicesForBox> ChoicesForBoxes { get; set; }

    public virtual DbSet<ClientPo> ClientPos { get; set; }

    public virtual DbSet<Combo> Combos { get; set; }

    public virtual DbSet<ComboDetail> ComboDetails { get; set; }

    public virtual DbSet<CoverWithMeal> CoverWithMeals { get; set; }

    public virtual DbSet<CreditAccount> CreditAccounts { get; set; }

    public virtual DbSet<CreditAccountsHist> CreditAccountsHists { get; set; }

    public virtual DbSet<CreditAccountsView> CreditAccountsViews { get; set; }

    public virtual DbSet<CreditCode> CreditCodes { get; set; }

    public virtual DbSet<CreditCodesHist> CreditCodesHists { get; set; }

    public virtual DbSet<CreditCodesView> CreditCodesViews { get; set; }

    public virtual DbSet<CreditTransaction> CreditTransactions { get; set; }

    public virtual DbSet<CreditTransactionsHist> CreditTransactionsHists { get; set; }

    public virtual DbSet<CreditTransactionsView> CreditTransactionsViews { get; set; }

    public virtual DbSet<DaAddress> DaAddresses { get; set; }

    public virtual DbSet<DaCustomer> DaCustomers { get; set; }

    public virtual DbSet<DaCustomerCompany> DaCustomerCompanies { get; set; }

    public virtual DbSet<DaCustomerJob> DaCustomerJobs { get; set; }

    public virtual DbSet<DaCustomerMessage> DaCustomerMessages { get; set; }

    public virtual DbSet<DaCustomersToken> DaCustomersTokens { get; set; }

    public virtual DbSet<DaGeoPolygon> DaGeoPolygons { get; set; }

    public virtual DbSet<DaGeoPolygonsDetail> DaGeoPolygonsDetails { get; set; }

    public virtual DbSet<DaLoyalConfig> DaLoyalConfigs { get; set; }

    public virtual DbSet<DaLoyalGainAmountRange> DaLoyalGainAmountRanges { get; set; }

    public virtual DbSet<DaLoyalGainAmountRatio> DaLoyalGainAmountRatios { get; set; }

    public virtual DbSet<DaLoyalPoint> DaLoyalPoints { get; set; }

    public virtual DbSet<DaLoyalPointsHist> DaLoyalPointsHists { get; set; }

    public virtual DbSet<DaLoyalRedeemDiscount> DaLoyalRedeemDiscounts { get; set; }

    public virtual DbSet<DaLoyalRedeemFreeProduct> DaLoyalRedeemFreeProducts { get; set; }

    public virtual DbSet<DaMainMessage> DaMainMessages { get; set; }

    public virtual DbSet<DaMessage> DaMessages { get; set; }

    public virtual DbSet<DaMessagesDetail> DaMessagesDetails { get; set; }

    public virtual DbSet<DaOpeningHour> DaOpeningHours { get; set; }

    public virtual DbSet<DaOrder> DaOrders { get; set; }

    public virtual DbSet<DaOrderDetail> DaOrderDetails { get; set; }

    public virtual DbSet<DaOrderDetailsExtra> DaOrderDetailsExtras { get; set; }

    public virtual DbSet<DaOrderNo> DaOrderNos { get; set; }

    public virtual DbSet<DaOrderStatus> DaOrderStatuses { get; set; }

    public virtual DbSet<DaPageSetStoreAssoc> DaPageSetStoreAssocs { get; set; }

    public virtual DbSet<DaScheduledTaske> DaScheduledTaskes { get; set; }

    public virtual DbSet<DaShortageProd> DaShortageProds { get; set; }

    public virtual DbSet<DaStore> DaStores { get; set; }

    public virtual DbSet<DaStoresWoltAssoc> DaStoresWoltAssocs { get; set; }

    public virtual DbSet<DastorePriceListAssoc> DastorePriceListAssocs { get; set; }

    public virtual DbSet<DeliveryAddressType> DeliveryAddressTypes { get; set; }

    public virtual DbSet<DeliveryCustomer> DeliveryCustomers { get; set; }

    public virtual DbSet<DeliveryCustomersBillingAddress> DeliveryCustomersBillingAddresses { get; set; }

    public virtual DbSet<DeliveryCustomersPhone> DeliveryCustomersPhones { get; set; }

    public virtual DbSet<DeliveryCustomersPhonesAndAddress> DeliveryCustomersPhonesAndAddresses { get; set; }

    public virtual DbSet<DeliveryCustomersShippingAddress> DeliveryCustomersShippingAddresses { get; set; }

    public virtual DbSet<DeliveryCustomersType> DeliveryCustomersTypes { get; set; }

    public virtual DbSet<DeliveryPhoneType> DeliveryPhoneTypes { get; set; }

    public virtual DbSet<DeliveryRouting> DeliveryRoutings { get; set; }

    public virtual DbSet<DeliveryRoutingHist> DeliveryRoutingHists { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<DigitalSignature> DigitalSignatures { get; set; }

    public virtual DbSet<Discount> Discounts { get; set; }

    public virtual DbSet<DiscountType> DiscountTypes { get; set; }

    public virtual DbSet<DiscountTypeResult> DiscountTypeResults { get; set; }

    public virtual DbSet<DiscountTypeRule> DiscountTypeRules { get; set; }

    public virtual DbSet<EcrConfigurationPosAssoc> EcrConfigurationPosAssocs { get; set; }

    public virtual DbSet<EfoodBucket> EfoodBuckets { get; set; }

    public virtual DbSet<EftposTransaction> EftposTransactions { get; set; }

    public virtual DbSet<EmailConfig> EmailConfigs { get; set; }

    public virtual DbSet<EndOfDay> EndOfDays { get; set; }

    public virtual DbSet<EndOfDayDetail> EndOfDayDetails { get; set; }

    public virtual DbSet<EndOfDayDetailHist> EndOfDayDetailHists { get; set; }

    public virtual DbSet<EndOfDayDetailView> EndOfDayDetailViews { get; set; }

    public virtual DbSet<EndOfDayHist> EndOfDayHists { get; set; }

    public virtual DbSet<EndOfDayPaymentAnalysis> EndOfDayPaymentAnalyses { get; set; }

    public virtual DbSet<EndOfDayPaymentAnalysisHist> EndOfDayPaymentAnalysisHists { get; set; }

    public virtual DbSet<EndOfDayPaymentAnalysisView> EndOfDayPaymentAnalysisViews { get; set; }

    public virtual DbSet<EndOfDayView> EndOfDayViews { get; set; }

    public virtual DbSet<EndOfDayVoidsAnalysis> EndOfDayVoidsAnalyses { get; set; }

    public virtual DbSet<EndOfDayVoidsAnalysisHist> EndOfDayVoidsAnalysisHists { get; set; }

    public virtual DbSet<EndOfDayVoidsAnalysisView> EndOfDayVoidsAnalysisViews { get; set; }

    public virtual DbSet<EndOfYear> EndOfYears { get; set; }

    public virtual DbSet<EnvironmentalFee> EnvironmentalFees { get; set; }

    public virtual DbSet<EodaccountToPmsTransfer> EodaccountToPmsTransfers { get; set; }

    public virtual DbSet<EodaccountToPmsTransferHist> EodaccountToPmsTransferHists { get; set; }

    public virtual DbSet<EodaccountToPmsTransferView> EodaccountToPmsTransferViews { get; set; }

    public virtual DbSet<ExternalLostOrder> ExternalLostOrders { get; set; }

    public virtual DbSet<ExternalLostOrdersHist> ExternalLostOrdersHists { get; set; }

    public virtual DbSet<ExternalLostOrdersView> ExternalLostOrdersViews { get; set; }

    public virtual DbSet<ExternalProductMapping> ExternalProductMappings { get; set; }

    public virtual DbSet<ExternalStateMatch> ExternalStateMatches { get; set; }

    public virtual DbSet<ExternalUser> ExternalUsers { get; set; }

    public virtual DbSet<ForexService> ForexServices { get; set; }

    public virtual DbSet<Guest> Guests { get; set; }

    public virtual DbSet<GuestFuture> GuestFutures { get; set; }

    public virtual DbSet<HitPosCustomer> HitPosCustomers { get; set; }

    public virtual DbSet<HitPosOrder> HitPosOrders { get; set; }

    public virtual DbSet<HitPosOrdersHist> HitPosOrdersHists { get; set; }

    public virtual DbSet<HitPosOrdersView> HitPosOrdersViews { get; set; }

    public virtual DbSet<HotelCustomMessage> HotelCustomMessages { get; set; }

    public virtual DbSet<HotelCustomerDataConfig> HotelCustomerDataConfigs { get; set; }

    public virtual DbSet<HotelInfo> HotelInfos { get; set; }

    public virtual DbSet<HotelMacro> HotelMacros { get; set; }

    public virtual DbSet<HotelMacroResult> HotelMacroResults { get; set; }

    public virtual DbSet<HotelMacroRule> HotelMacroRules { get; set; }

    public virtual DbSet<HotelMacroTimezone> HotelMacroTimezones { get; set; }

    public virtual DbSet<HotelMacrosHist> HotelMacrosHists { get; set; }

    public virtual DbSet<Ingredient> Ingredients { get; set; }

    public virtual DbSet<IngredientCategory> IngredientCategories { get; set; }

    public virtual DbSet<IngredientProdCategoryAssoc> IngredientProdCategoryAssocs { get; set; }

    public virtual DbSet<InitialItem> InitialItems { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<InvoiceGroubByInvoiceTypeAndAccount> InvoiceGroubByInvoiceTypeAndAccounts { get; set; }

    public virtual DbSet<InvoiceGuestsTran> InvoiceGuestsTrans { get; set; }

    public virtual DbSet<InvoiceGuestsTransHist> InvoiceGuestsTransHists { get; set; }

    public virtual DbSet<InvoiceGuestsTransView> InvoiceGuestsTransViews { get; set; }

    public virtual DbSet<InvoiceHtmlReceipt> InvoiceHtmlReceipts { get; set; }

    public virtual DbSet<InvoiceQr> InvoiceQrs { get; set; }

    public virtual DbSet<InvoiceShippingDetail> InvoiceShippingDetails { get; set; }

    public virtual DbSet<InvoiceShippingDetailsHist> InvoiceShippingDetailsHists { get; set; }

    public virtual DbSet<InvoiceShippingDetailsView> InvoiceShippingDetailsViews { get; set; }

    public virtual DbSet<InvoiceType> InvoiceTypes { get; set; }

    public virtual DbSet<InvoicesHist> InvoicesHists { get; set; }

    public virtual DbSet<InvoicesView> InvoicesViews { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<Kd> Kds { get; set; }

    public virtual DbSet<Kitchen> Kitchens { get; set; }

    public virtual DbSet<KitchenInstruction> KitchenInstructions { get; set; }

    public virtual DbSet<KitchenInstructionHist> KitchenInstructionHists { get; set; }

    public virtual DbSet<KitchenInstructionLogger> KitchenInstructionLoggers { get; set; }

    public virtual DbSet<KitchenInstructionLoggerHist> KitchenInstructionLoggerHists { get; set; }

    public virtual DbSet<KitchenInstructionLoggerView> KitchenInstructionLoggerViews { get; set; }

    public virtual DbSet<KitchenRegion> KitchenRegions { get; set; }

    public virtual DbSet<Locker> Lockers { get; set; }

    public virtual DbSet<LockersHist> LockersHists { get; set; }

    public virtual DbSet<LockersView> LockersViews { get; set; }

    public virtual DbSet<Loyalty> Loyalties { get; set; }

    public virtual DbSet<LoyaltyHist> LoyaltyHists { get; set; }

    public virtual DbSet<LoyaltyPointsRedeemed> LoyaltyPointsRedeemeds { get; set; }

    public virtual DbSet<LoyaltyView> LoyaltyViews { get; set; }

    public virtual DbSet<MainProductForBox> MainProductForBoxes { get; set; }

    public virtual DbSet<ManualLoyaltyPoint> ManualLoyaltyPoints { get; set; }

    public virtual DbSet<MealConsumption> MealConsumptions { get; set; }

    public virtual DbSet<MealConsumptionHist> MealConsumptionHists { get; set; }

    public virtual DbSet<MealConsumptionView> MealConsumptionViews { get; set; }

    public virtual DbSet<MetadataTable> MetadataTables { get; set; }

    public virtual DbSet<Nfccard> Nfccards { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<OnlineRegistration> OnlineRegistrations { get; set; }

    public virtual DbSet<OnlineRegistrationConfig> OnlineRegistrationConfigs { get; set; }

    public virtual DbSet<OnlineRegistrationHist> OnlineRegistrationHists { get; set; }

    public virtual DbSet<OnlineRegistrationView> OnlineRegistrationViews { get; set; }

    public virtual DbSet<Openremark> Openremarks { get; set; }

    public virtual DbSet<OpenremarksOnly> OpenremarksOnlies { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<OrderDetailHist> OrderDetailHists { get; set; }

    public virtual DbSet<OrderDetailIgredient> OrderDetailIgredients { get; set; }

    public virtual DbSet<OrderDetailIgredientVatAnal> OrderDetailIgredientVatAnals { get; set; }

    public virtual DbSet<OrderDetailIgredientVatAnalHist> OrderDetailIgredientVatAnalHists { get; set; }

    public virtual DbSet<OrderDetailIgredientVatAnalView> OrderDetailIgredientVatAnalViews { get; set; }

    public virtual DbSet<OrderDetailIgredientsHist> OrderDetailIgredientsHists { get; set; }

    public virtual DbSet<OrderDetailIgredientsKd> OrderDetailIgredientsKds { get; set; }

    public virtual DbSet<OrderDetailIgredientsView> OrderDetailIgredientsViews { get; set; }

    public virtual DbSet<OrderDetailInvoice> OrderDetailInvoices { get; set; }

    public virtual DbSet<OrderDetailInvoicesHist> OrderDetailInvoicesHists { get; set; }

    public virtual DbSet<OrderDetailInvoicesView> OrderDetailInvoicesViews { get; set; }

    public virtual DbSet<OrderDetailVatAnal> OrderDetailVatAnals { get; set; }

    public virtual DbSet<OrderDetailVatAnalHist> OrderDetailVatAnalHists { get; set; }

    public virtual DbSet<OrderDetailVatAnalView> OrderDetailVatAnalViews { get; set; }

    public virtual DbSet<OrderHist> OrderHists { get; set; }

    public virtual DbSet<OrderMonitoring> OrderMonitorings { get; set; }

    public virtual DbSet<OrderSimply> OrderSimplies { get; set; }

    public virtual DbSet<OrderStatus> OrderStatuses { get; set; }

    public virtual DbSet<OrderStatusHist> OrderStatusHists { get; set; }

    public virtual DbSet<OrderStatusView> OrderStatusViews { get; set; }

    public virtual DbSet<OrdersAnalysis> OrdersAnalyses { get; set; }

    public virtual DbSet<OrdersStaff> OrdersStaffs { get; set; }

    public virtual DbSet<OrdersStaffHist> OrdersStaffHists { get; set; }

    public virtual DbSet<OrdersStaffView> OrdersStaffViews { get; set; }

    public virtual DbSet<Page> Pages { get; set; }

    public virtual DbSet<PageButton> PageButtons { get; set; }

    public virtual DbSet<PageButtonDetail> PageButtonDetails { get; set; }

    public virtual DbSet<PagePosAssoc> PagePosAssocs { get; set; }

    public virtual DbSet<PageSet> PageSets { get; set; }

    public virtual DbSet<Payrole> Payroles { get; set; }

    public virtual DbSet<PayrollNew> PayrollNews { get; set; }

    public virtual DbSet<PdaModule> PdaModules { get; set; }

    public virtual DbSet<PdaModuleDetail> PdaModuleDetails { get; set; }

    public virtual DbSet<PdaPrinterOption> PdaPrinterOptions { get; set; }

    public virtual DbSet<PdaSurveyAnswer> PdaSurveyAnswers { get; set; }

    public virtual DbSet<PdaSurveyQuestion> PdaSurveyQuestions { get; set; }

    public virtual DbSet<PointsPerStore> PointsPerStores { get; set; }

    public virtual DbSet<PosInfo> PosInfos { get; set; }

    public virtual DbSet<PosInfoDetail> PosInfoDetails { get; set; }

    public virtual DbSet<PosInfoDetailExcludedAccount> PosInfoDetailExcludedAccounts { get; set; }

    public virtual DbSet<PosInfoDetailPricelistAssoc> PosInfoDetailPricelistAssocs { get; set; }

    public virtual DbSet<PosInfoKdsAssoc> PosInfoKdsAssocs { get; set; }

    public virtual DbSet<PosInfoKitchenInstructionAssoc> PosInfoKitchenInstructionAssocs { get; set; }

    public virtual DbSet<PosInfoPricelistAssoc> PosInfoPricelistAssocs { get; set; }

    public virtual DbSet<PosInfoRegionAssoc> PosInfoRegionAssocs { get; set; }

    public virtual DbSet<PosInfoStaffPositinAssoc> PosInfoStaffPositinAssocs { get; set; }

    public virtual DbSet<PosSalesAnalysis> PosSalesAnalyses { get; set; }

    public virtual DbSet<PosSalesAnalysis2> PosSalesAnalysis2s { get; set; }

    public virtual DbSet<PosSalesAnalysis3> PosSalesAnalysis3s { get; set; }

    public virtual DbSet<PredefinedCredit> PredefinedCredits { get; set; }

    public virtual DbSet<PriceListEffectiveHour> PriceListEffectiveHours { get; set; }

    public virtual DbSet<PriceListTimezone> PriceListTimezones { get; set; }

    public virtual DbSet<Pricelist> Pricelists { get; set; }

    public virtual DbSet<PricelistDetail> PricelistDetails { get; set; }

    public virtual DbSet<PricelistMaster> PricelistMasters { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductBarcode> ProductBarcodes { get; set; }

    public virtual DbSet<ProductCategory> ProductCategories { get; set; }

    public virtual DbSet<ProductExtra> ProductExtras { get; set; }

    public virtual DbSet<ProductForBarcodeEod> ProductForBarcodeEods { get; set; }

    public virtual DbSet<ProductRecipe> ProductRecipes { get; set; }

    public virtual DbSet<ProductSalesHistoryPerDay> ProductSalesHistoryPerDays { get; set; }

    public virtual DbSet<ProductsForEod> ProductsForEods { get; set; }

    public virtual DbSet<PromotionsCombo> PromotionsCombos { get; set; }

    public virtual DbSet<PromotionsDiscount> PromotionsDiscounts { get; set; }

    public virtual DbSet<PromotionsHeader> PromotionsHeaders { get; set; }

    public virtual DbSet<PromotionsPricelist> PromotionsPricelists { get; set; }

    public virtual DbSet<ProtelAirLastTransaction> ProtelAirLastTransactions { get; set; }

    public virtual DbSet<Quantity> Quantities { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<RegionLockerProduct> RegionLockerProducts { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<ReportEntity> ReportEntities { get; set; }

    public virtual DbSet<ReportList> ReportLists { get; set; }

    public virtual DbSet<SalesMothnly> SalesMothnlies { get; set; }

    public virtual DbSet<SalesType> SalesTypes { get; set; }

    public virtual DbSet<SalesTypePosAssoc> SalesTypePosAssocs { get; set; }

    public virtual DbSet<SalesTypePricelistMasterAssoc> SalesTypePricelistMasterAssocs { get; set; }

    public virtual DbSet<SelectionsForBox> SelectionsForBoxes { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<StaffAuthorization> StaffAuthorizations { get; set; }

    public virtual DbSet<StaffCash> StaffCashes { get; set; }

    public virtual DbSet<StaffPosition> StaffPositions { get; set; }

    public virtual DbSet<StaffSchedule> StaffSchedules { get; set; }

    public virtual DbSet<StaffSecheduleDetail> StaffSecheduleDetails { get; set; }

    public virtual DbSet<StatisticsMenu> StatisticsMenus { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<StoreMessage> StoreMessages { get; set; }

    public virtual DbSet<StoreMessagesHist> StoreMessagesHists { get; set; }

    public virtual DbSet<StoreMessagesView> StoreMessagesViews { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<Table> Tables { get; set; }

    public virtual DbSet<TablePaySuggestion> TablePaySuggestions { get; set; }

    public virtual DbSet<TablePaySuggestionHist> TablePaySuggestionHists { get; set; }

    public virtual DbSet<TablePaySuggestionView> TablePaySuggestionViews { get; set; }

    public virtual DbSet<Tax> Taxes { get; set; }

    public virtual DbSet<Timezone> Timezones { get; set; }

    public virtual DbSet<TrCapacity> TrCapacities { get; set; }

    public virtual DbSet<TrConfig> TrConfigs { get; set; }

    public virtual DbSet<TrExcludeDay> TrExcludeDays { get; set; }

    public virtual DbSet<TrExcludeRestriction> TrExcludeRestrictions { get; set; }

    public virtual DbSet<TrOvewrittenCapacity> TrOvewrittenCapacities { get; set; }

    public virtual DbSet<TrReservation> TrReservations { get; set; }

    public virtual DbSet<TrReservationCustomer> TrReservationCustomers { get; set; }

    public virtual DbSet<TrReservationType> TrReservationTypes { get; set; }

    public virtual DbSet<TrRestaurant> TrRestaurants { get; set; }

    public virtual DbSet<TrRestriction> TrRestrictions { get; set; }

    public virtual DbSet<TrRestrictionsRestaurantsAssoc> TrRestrictionsRestaurantsAssocs { get; set; }

    public virtual DbSet<TrTradingHour> TrTradingHours { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    public virtual DbSet<TransactionType> TransactionTypes { get; set; }

    public virtual DbSet<TransactionsHist> TransactionsHists { get; set; }

    public virtual DbSet<TransactionsView> TransactionsViews { get; set; }

    public virtual DbSet<TransferMapping> TransferMappings { get; set; }

    public virtual DbSet<TransferMappingDetail> TransferMappingDetails { get; set; }

    public virtual DbSet<TransferMappingDetailsHist> TransferMappingDetailsHists { get; set; }

    public virtual DbSet<TransferMappingsHist> TransferMappingsHists { get; set; }

    public virtual DbSet<TransferToPm> TransferToPms { get; set; }

    public virtual DbSet<TransferToPmsHist> TransferToPmsHists { get; set; }

    public virtual DbSet<TransferToPmsLastId> TransferToPmsLastIds { get; set; }

    public virtual DbSet<TransferToPmsView> TransferToPmsViews { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<ValidModule> ValidModules { get; set; }

    public virtual DbSet<Vat> Vats { get; set; }

    public virtual DbSet<Version> Versions { get; set; }

    public virtual DbSet<ViewDispatchPoint> ViewDispatchPoints { get; set; }

    public virtual DbSet<ViewRpt01InvoiceHeader> ViewRpt01InvoiceHeaders { get; set; }

    public virtual DbSet<ViewRpt01InvoiceHeaderReport> ViewRpt01InvoiceHeaderReports { get; set; }

    public virtual DbSet<ViewRpt02InvoiceProduct> ViewRpt02InvoiceProducts { get; set; }

    public virtual DbSet<ViewRpt03InvoiceExtra> ViewRpt03InvoiceExtras { get; set; }

    public virtual DbSet<ViewRpt04InvoicePayment> ViewRpt04InvoicePayments { get; set; }

    public virtual DbSet<ViewRpt05InvoicePaymentsGuest> ViewRpt05InvoicePaymentsGuests { get; set; }

    public virtual DbSet<ViewRpt06InvoiceRelatedReceipt> ViewRpt06InvoiceRelatedReceipts { get; set; }

    public virtual DbSet<ViewRpt07InvoiceSalesType> ViewRpt07InvoiceSalesTypes { get; set; }

    public virtual DbSet<ViewRpt08InvoiceRemark> ViewRpt08InvoiceRemarks { get; set; }

    public virtual DbSet<ViewRpt09PrintZXMaster> ViewRpt09PrintZXMasters { get; set; }

    public virtual DbSet<ViewRpt10PrintZXPaymentAnalysis> ViewRpt10PrintZXPaymentAnalyses { get; set; }

    public virtual DbSet<ViewRpt11PrintZXVatsAnalysis> ViewRpt11PrintZXVatsAnalyses { get; set; }

    public virtual DbSet<ViewRpt12PrintZXVoidsAnalysis> ViewRpt12PrintZXVoidsAnalyses { get; set; }

    public virtual DbSet<ViewRpt13PrintZXCardsAnalysis> ViewRpt13PrintZXCardsAnalyses { get; set; }

    public virtual DbSet<ViewRpt14PrintZXLocker> ViewRpt14PrintZXLockers { get; set; }

    public virtual DbSet<ViewRpt15PrintZXInvoicesAnalisi> ViewRpt15PrintZXInvoicesAnalises { get; set; }

    public virtual DbSet<ViewRpt15PrintZXInvoicesAnalysis> ViewRpt15PrintZXInvoicesAnalyses { get; set; }

    public virtual DbSet<ViewRpt16PrintZXInvoiceTypeAnalisi> ViewRpt16PrintZXInvoiceTypeAnalises { get; set; }

    public virtual DbSet<ViewRpt16PrintZXInvoiceTypeAnalysis> ViewRpt16PrintZXInvoiceTypeAnalyses { get; set; }

    public virtual DbSet<ViewSimpleDriversReceip> ViewSimpleDriversReceips { get; set; }

    public virtual DbSet<ViewSimpleTameio> ViewSimpleTameios { get; set; }

    public virtual DbSet<Vodafone11Detail> Vodafone11Details { get; set; }

    public virtual DbSet<Vodafone11Header> Vodafone11Headers { get; set; }

    public virtual DbSet<WebReport> WebReports { get; set; }

    public virtual DbSet<WebReportsView> WebReportsViews { get; set; }

    public virtual DbSet<WebReportsViewAll> WebReportsViewAlls { get; set; }

    public virtual DbSet<WebposreposTable> WebposreposTables { get; set; }

    public virtual DbSet<WorkSheet> WorkSheets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=demosrv;Database=webpos_it;User Id=sa;Password=hitprotel;trustservercertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.Property(e => e.CardOnly).HasDefaultValue(false);
            entity.Property(e => e.IsDefault).HasDefaultValue(false);
            entity.Property(e => e.KeyboardType).HasDefaultValue((short)1);
        });

        modelBuilder.Entity<Action>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<ActiveItem>(entity =>
        {
            entity.ToView("ActiveItems");
        });

        modelBuilder.Entity<AllowedMealsPerBoard>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.PriceList).WithMany(p => p.AllowedMealsPerBoards).HasConstraintName("FK_AllowedMealsPerBoard_Pricelist");
        });

        modelBuilder.Entity<AllowedMealsPerBoardDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.AllowedMealsPerBoard).WithMany(p => p.AllowedMealsPerBoardDetails).HasConstraintName("FK_AllowedMealsPerBoardDetails_AllowedMealsPerBoard");

            entity.HasOne(d => d.ProductCategory).WithMany(p => p.AllowedMealsPerBoardDetails).HasConstraintName("FK_AllowedMealsPerBoardDetails_ProductCategories");
        });

        modelBuilder.Entity<AssignedPosition>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.StaffId, "IX_AssignedPositions_StaffId").HasFillFactor(90);

            entity.HasOne(d => d.Staff).WithMany(p => p.AssignedPositions).HasConstraintName("FK_AssignedPositions_Staff");

            entity.HasOne(d => d.StaffPosition).WithMany(p => p.AssignedPositions).HasConstraintName("FK_AssignedPositions_StaffPosition");
        });

        modelBuilder.Entity<Attendance>(entity =>
        {
            entity.HasOne(d => d.AttendanceTimezone).WithMany(p => p.Attendances).HasConstraintName("FK_Attendances_AttendanceTimezones");

            entity.HasOne(d => d.Department).WithMany(p => p.Attendances).HasConstraintName("FK_Attendances_Department");
        });

        modelBuilder.Entity<AuthorizedGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<AuthorizedGroupDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Action).WithMany(p => p.AuthorizedGroupDetails).HasConstraintName("FK_AuthorizedGroupDetail_Actions");

            entity.HasOne(d => d.AuthorizedGroup).WithMany(p => p.AuthorizedGroupDetails).HasConstraintName("FK_AuthorizedGroupDetail_AuthorizedGroup");
        });

        modelBuilder.Entity<Baendofday>(entity =>
        {
            entity.ToView("BAendofday");
        });

        modelBuilder.Entity<Baguest>(entity =>
        {
            entity.ToView("BAGuests");
        });

        modelBuilder.Entity<Bareport>(entity =>
        {
            entity.ToView("BAReports");
        });

        modelBuilder.Entity<BoDaPageSetStoreAssoc>(entity =>
        {
            entity.HasOne(d => d.DaStore).WithMany(p => p.BoDaPageSetStoreAssocs).HasConstraintName("FK_BO_DA_PageSetStoreAssoc_DA_Stores");

            entity.HasOne(d => d.PageSet).WithMany(p => p.BoDaPageSetStoreAssocs).HasConstraintName("FK_BO_DA_PageSetStoreAssocc_PageSet");
        });

        modelBuilder.Entity<BoDaPriceListStoreAssoc>(entity =>
        {
            entity.HasOne(d => d.Dastore).WithMany(p => p.BoDaPriceListStoreAssocs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BO_DA_PriceListStoreAssoc_DA_Stores");

            entity.HasOne(d => d.PriceList).WithMany(p => p.BoDaPriceListStoreAssocs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BO_DA_PriceListStoreAssoc_Pricelist");
        });

        modelBuilder.Entity<BoDaProductStoreAssoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BO_DA_PoductStoreAssoc");

            entity.HasOne(d => d.Dastore).WithMany(p => p.BoDaProductStoreAssocs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BO_DA_ProductStoreAssoc_DA_Stores");

            entity.HasOne(d => d.PageSet).WithMany(p => p.BoDaProductStoreAssocs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BO_DA_ProductStoreAssoc_PageSet");

            entity.HasOne(d => d.Product).WithMany(p => p.BoDaProductStoreAssocs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BO_DA_ProductStoreAssoc_Product");
        });

        modelBuilder.Entity<BoOption>(entity =>
        {
            entity.HasOne(d => d.Action).WithMany(p => p.BoOptions).HasConstraintName("FK_BO_Options_BO_Actions");
        });

        modelBuilder.Entity<BoRoleAction>(entity =>
        {
            entity.HasOne(d => d.Action).WithMany(p => p.BoRoleActions).HasConstraintName("FK_BO_RoleActions_BO_Actions");

            entity.HasOne(d => d.Option).WithMany(p => p.BoRoleActions).HasConstraintName("FK_BO_RoleActions_BO_Options");

            entity.HasOne(d => d.Role).WithMany(p => p.BoRoleActions).HasConstraintName("FK_BO_RoleActions_BO_Roles");
        });

        modelBuilder.Entity<BoUser>(entity =>
        {
            entity.HasOne(d => d.Role).WithMany(p => p.BoUsers).HasConstraintName("FK_BO_Users_BO_Roles");
        });

        modelBuilder.Entity<BoardMeal>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Product).WithMany(p => p.BoardMeals).HasConstraintName("FK_BoardMeals_Product");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<ChoicesForBox>(entity =>
        {
            entity.HasOne(d => d.SelectionsForBox).WithMany(p => p.ChoicesForBoxes).HasConstraintName("FK_ChoicesForBox_SelectionsForBox");
        });

        modelBuilder.Entity<ClientPo>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.PosInfo).WithMany(p => p.ClientPos)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_ClientPos_PosInfo");
        });

        modelBuilder.Entity<Combo>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Department).WithMany(p => p.Combos).HasConstraintName("FK_Combo_Department");

            entity.HasOne(d => d.ProductCombo).WithMany(p => p.Combos).HasConstraintName("FK_Combo_Product");
        });

        modelBuilder.Entity<ComboDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Combo).WithMany(p => p.ComboDetails).HasConstraintName("FK_ComboDetail_Combo");

            entity.HasOne(d => d.ProductComboItem).WithMany(p => p.ComboDetails).HasConstraintName("FK_ComboDetail_Product");
        });

        modelBuilder.Entity<CoverWithMeal>(entity =>
        {
            entity.ToView("CoverWithMeals");
        });

        modelBuilder.Entity<CreditAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.EndOfDay).WithMany(p => p.CreditAccounts).HasConstraintName("FK_CreditAccounts_EndOfDay");
        });

        modelBuilder.Entity<CreditAccountsHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);
        });

        modelBuilder.Entity<CreditAccountsView>(entity =>
        {
            entity.ToView("CreditAccounts_View");
        });

        modelBuilder.Entity<CreditCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.CreditAccount).WithMany(p => p.CreditCodes).HasConstraintName("FK_CreditCodes_CreditAccounts");
        });

        modelBuilder.Entity<CreditCodesHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);
        });

        modelBuilder.Entity<CreditCodesView>(entity =>
        {
            entity.ToView("CreditCodes_View");
        });

        modelBuilder.Entity<CreditTransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.EndOfDayId, "IX_CreditTransactions_EndOfDayId").HasFillFactor(90);

            entity.HasIndex(e => new { e.EndOfDayId, e.PosInfoId }, "IX_CreditTransactions_EndOfDayId_PosInfoId").HasFillFactor(90);

            entity.HasIndex(e => e.TransactionId, "IX_TransactionId").HasFillFactor(90);

            entity.HasOne(d => d.CreditAccount).WithMany(p => p.CreditTransactions).HasConstraintName("FK_CreditTransactions_CreditAccounts");

            entity.HasOne(d => d.CreditCode).WithMany(p => p.CreditTransactions).HasConstraintName("FK_CreditTransactions_CreditCodes");

            entity.HasOne(d => d.EndOfDay).WithMany(p => p.CreditTransactions).HasConstraintName("FK_CreditTransactions_EndOfDay");

            entity.HasOne(d => d.Invoice).WithMany(p => p.CreditTransactions).HasConstraintName("FK_CreditTransactions_Invoices");

            entity.HasOne(d => d.PosInfo).WithMany(p => p.CreditTransactions).HasConstraintName("FK_CreditTransactions_PosInfo");

            entity.HasOne(d => d.Staff).WithMany(p => p.CreditTransactions).HasConstraintName("FK_CreditTransactions_Staff");

            entity.HasOne(d => d.Transaction).WithMany(p => p.CreditTransactions).HasConstraintName("FK_dbo.CreditTransactions_dbo.Transactions_TransactionId");
        });

        modelBuilder.Entity<CreditTransactionsHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.TransactionId }, "IX_Hist_TransactionId").HasFillFactor(90);
        });

        modelBuilder.Entity<CreditTransactionsView>(entity =>
        {
            entity.ToView("CreditTransactions_View");
        });

        modelBuilder.Entity<DaAddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => new { e.AddressStreet, e.Area }, "IX_DA_Addresses_AddressArea").HasFillFactor(90);

            entity.HasIndex(e => new { e.AddressStreet, e.City }, "IX_DA_Addresses_AddressCity").HasFillFactor(90);

            entity.HasIndex(e => e.ExtId1, "IX_DA_Addresses_ExtId1").HasFillFactor(90);

            entity.HasIndex(e => e.ExtId2, "IX_DA_Addresses_ExtId2").HasFillFactor(90);

            entity.HasIndex(e => new { e.OwnerId, e.AddressType }, "IX_DA_Addresses_OwnAddType").HasFillFactor(90);

            entity.HasIndex(e => new { e.OwnerId, e.AddressType, e.IsDeleted }, "IX_DA_Addresses_OwnAddTypeIsDel").HasFillFactor(90);

            entity.HasIndex(e => e.OwnerId, "IX_DA_Addresses_OwnerId").HasFillFactor(90);

            entity.HasIndex(e => e.Zipcode, "IX_DA_Addresses_ZipCode").HasFillFactor(90);
        });

        modelBuilder.Entity<DaCustomer>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.Email, "IX_DA_CustomersEmail").HasFillFactor(90);

            entity.HasIndex(e => new { e.Email, e.Password }, "IX_DA_CustomersEmailPass").HasFillFactor(90);

            entity.HasIndex(e => e.LastName, "IX_DA_CustomersLastName").HasFillFactor(90);

            entity.HasIndex(e => new { e.LastName, e.Phone1 }, "IX_DA_CustomersLastNamePhone").HasFillFactor(90);

            entity.HasIndex(e => e.Mobile, "IX_DA_CustomersMobile").HasFillFactor(90);

            entity.HasIndex(e => e.Phone1, "IX_DA_CustomersPhone").HasFillFactor(90);

            entity.HasIndex(e => e.VatNo, "IX_DA_CustomersVatNo").HasFillFactor(90);

            entity.HasIndex(e => e.AuthToken, "IX_DA_Customers_AuthToken").HasFillFactor(90);

            entity.HasIndex(e => new { e.Email, e.IsDeleted }, "IX_DA_Customers_Email_IsDel").HasFillFactor(90);

            entity.HasIndex(e => new { e.Email, e.SessionKey, e.IsDeleted }, "IX_DA_Customers_Email_Sess_IsDel").HasFillFactor(90);

            entity.HasIndex(e => e.ExtId1, "IX_DA_Customers_ExtId1").HasFillFactor(90);

            entity.HasIndex(e => e.ExtId2, "IX_DA_Customers_ExtId2").HasFillFactor(90);

            entity.HasIndex(e => e.ExtId3, "IX_DA_Customers_ExtId3").HasFillFactor(90);

            entity.HasIndex(e => e.ExtId4, "IX_DA_Customers_ExtId4").HasFillFactor(90);

            entity.HasIndex(e => new { e.LastName, e.FirstName, e.Mobile }, "IX_DA_Customers_LastFirstMobile").HasFillFactor(90);

            entity.HasIndex(e => new { e.LastName, e.FirstName }, "IX_DA_Customers_LastFirstName").HasFillFactor(90);

            entity.HasIndex(e => new { e.LastName, e.FirstName, e.Phone1 }, "IX_DA_Customers_LastFirstPhone1").HasFillFactor(90);

            entity.HasIndex(e => new { e.LastName, e.FirstName, e.Phone2 }, "IX_DA_Customers_LastFirstPhone2").HasFillFactor(90);

            entity.HasIndex(e => new { e.Phone1, e.Mobile, e.Phone2 }, "IX_DA_Customers_Phone1MobilePhone2").HasFillFactor(90);

            entity.HasIndex(e => new { e.Phone1, e.Mobile, e.Phone2, e.IsDeleted }, "IX_DA_Customers_Phone1MobilePhone2IsDel").HasFillFactor(90);

            entity.HasOne(d => d.DaCustomerCompany).WithMany(p => p.DaCustomers).HasConstraintName("FK_DA_Customers_DA_CustomerJobs");
        });

        modelBuilder.Entity<DaCustomerCompany>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CustomerCompanies");
        });

        modelBuilder.Entity<DaCustomerJob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CustomerJobs");
        });

        modelBuilder.Entity<DaCustomerMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Customer).WithMany(p => p.DaCustomerMessages).HasConstraintName("FK_DA_CustomerMessages_DA_Customers");

            entity.HasOne(d => d.MainDamessage).WithMany(p => p.DaCustomerMessages).HasConstraintName("FK_DA_CustomerMessages_DA_MainMessages");

            entity.HasOne(d => d.MessageDetails).WithMany(p => p.DaCustomerMessages).HasConstraintName("FK_DA_CustomerMessages_DA_MessagesDetails");

            entity.HasOne(d => d.Message).WithMany(p => p.DaCustomerMessages).HasConstraintName("FK_DA_CustomerMessages_DA_Messages");

            entity.HasOne(d => d.Order).WithMany(p => p.DaCustomerMessages).HasConstraintName("FK_DA_CustomerMessages_DA_Orders");

            entity.HasOne(d => d.Store).WithMany(p => p.DaCustomerMessages).HasConstraintName("FK_DA_CustomerMessages_DA_Stores");
        });

        modelBuilder.Entity<DaCustomersToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Customer).WithMany(p => p.DaCustomersTokens).HasConstraintName("FK_DA_CustomersTokens_DA_Customers");
        });

        modelBuilder.Entity<DaGeoPolygon>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.Name, "IX_DA_GeoPolygonsName").HasFillFactor(90);

            entity.HasIndex(e => e.StoreId, "IX_DA_GeoPolygonsStoreId").HasFillFactor(90);

            entity.HasIndex(e => new { e.StoreId, e.Name }, "IX_DA_GeoPolygonsStoreIdName").HasFillFactor(90);

            entity.HasIndex(e => e.IsActive, "IX_DA_GeoPolygons_Active").HasFillFactor(90);

            entity.HasOne(d => d.Store).WithMany(p => p.DaGeoPolygons).HasConstraintName("FK_DA_GeoPolygons_DA_Stores");
        });

        modelBuilder.Entity<DaGeoPolygonsDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.PolygId, "IX_DA_GeoPolygonsDetailsPolygonId").HasFillFactor(90);

            entity.HasOne(d => d.Polyg).WithMany(p => p.DaGeoPolygonsDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DA_GeoPolygonsDetails_DA_GeoPolygons");
        });

        modelBuilder.Entity<DaLoyalGainAmountRange>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<DaLoyalPoint>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.CustomerId, "IX_DA_LoyalPointsCustomerId").HasFillFactor(90);

            entity.HasIndex(e => new { e.CustomerId, e.OrderId }, "IX_DA_LoyalPointsCustomerIdOrderId").HasFillFactor(90);

            entity.HasIndex(e => e.Date, "IX_DA_LoyalPointsDate").HasFillFactor(90);

            entity.HasIndex(e => new { e.Date, e.CustomerId }, "IX_DA_LoyalPointsDateCustomerId").HasFillFactor(90);

            entity.HasIndex(e => new { e.Date, e.OrderId }, "IX_DA_LoyalPointsDateOrderId").HasFillFactor(90);

            entity.HasIndex(e => e.OrderId, "IX_DA_LoyalPointsOrderId").HasFillFactor(90);

            entity.HasIndex(e => new { e.OrderId, e.StoreId }, "IX_DA_LoyalPoints_Owner_Store").HasFillFactor(90);

            entity.HasOne(d => d.Customer).WithMany(p => p.DaLoyalPoints)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DA_LoyalPoints_DA_Customers");

            entity.HasOne(d => d.Staff).WithMany(p => p.DaLoyalPoints).HasConstraintName("FK_DA_LoyalPoints_Staff");
        });

        modelBuilder.Entity<DaLoyalPointsHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);
        });

        modelBuilder.Entity<DaLoyalRedeemFreeProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.Points, "IX_DA_LoyalRedeemFreeProduct_Points").HasFillFactor(90);

            entity.HasOne(d => d.ProdCategory).WithMany(p => p.DaLoyalRedeemFreeProducts).HasConstraintName("FK_DA_LoyalRedeemFreeProduct_ProductCategories");

            entity.HasOne(d => d.Product).WithMany(p => p.DaLoyalRedeemFreeProducts).HasConstraintName("FK_DA_LoyalRedeemFreeProduct_Product");
        });

        modelBuilder.Entity<DaMainMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<DaMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.MainDamessages).WithMany(p => p.DaMessages).HasConstraintName("FK_DA_Messages_DA_MainMessages");
        });

        modelBuilder.Entity<DaMessagesDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Header).WithMany(p => p.DaMessagesDetails).HasConstraintName("FK_DA_MesaggesDetails_DA_Messages");
        });

        modelBuilder.Entity<DaOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.BillingDate, "IX_DA_OrdersBillingDate").HasFillFactor(90);

            entity.HasIndex(e => e.CustomerId, "IX_DA_OrdersCustomerId").HasFillFactor(90);

            entity.HasIndex(e => new { e.CustomerId, e.StoreId }, "IX_DA_OrdersCustomerStoreId").HasFillFactor(90);

            entity.HasIndex(e => e.Duration, "IX_DA_OrdersDuration").HasFillFactor(90);

            entity.HasIndex(e => e.EstBillingDate, "IX_DA_OrdersEstBillingDate").HasFillFactor(90);

            entity.HasIndex(e => e.EstTakeoutDate, "IX_DA_OrdersEstTakeoutDate").HasFillFactor(90);

            entity.HasIndex(e => e.FinishDate, "IX_DA_OrdersFinishDate").HasFillFactor(90);

            entity.HasIndex(e => e.OrderDate, "IX_DA_OrdersOrderDate").HasFillFactor(90);

            entity.HasIndex(e => e.ShippingAddressId, "IX_DA_OrdersShippingAddressId").HasFillFactor(90);

            entity.HasIndex(e => e.StoreId, "IX_DA_OrdersStoreId").HasFillFactor(90);

            entity.HasIndex(e => e.TakeoutDate, "IX_DA_OrdersTakeoutDate").HasFillFactor(90);

            entity.HasIndex(e => new { e.CustomerId, e.ShippingAddressId }, "IX_DA_Orders_Cust_Ship").HasFillFactor(90);

            entity.HasIndex(e => e.ExtId1, "IX_DA_Orders_ExtId1").HasFillFactor(90);

            entity.HasIndex(e => e.ExtId2, "IX_DA_Orders_ExtId2").HasFillFactor(90);

            entity.HasIndex(e => e.IsSend, "IX_DA_Orders_IsSend").HasFillFactor(90);

            entity.HasIndex(e => new { e.IsSend, e.Id }, "IX_DA_Orders_IsSend_Id").HasFillFactor(90);

            entity.HasOne(d => d.Customer).WithMany(p => p.DaOrders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DA_Orders_DA_Customers");

            entity.HasOne(d => d.ShippingAddress).WithMany(p => p.DaOrders).HasConstraintName("FK_DA_Orders_DA_Addresses");

            entity.HasOne(d => d.Store).WithMany(p => p.DaOrders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DA_Orders_DA_Stores");
        });

        modelBuilder.Entity<DaOrderDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.DaorderId, "IX_DA_OrderDetails_OrderId").HasFillFactor(90);

            entity.HasIndex(e => new { e.DaorderId, e.ProductId }, "IX_DA_OrderDetails_OrderIdProduct").HasFillFactor(90);

            entity.HasIndex(e => new { e.DaorderId, e.ProductId, e.PriceListId }, "IX_DA_OrderDetails_OrderIdProductPriceList").HasFillFactor(90);

            entity.HasIndex(e => new { e.ProductId, e.PriceListId }, "IX_DA_OrderDetails_ProductIdPriceListId").HasFillFactor(90);

            entity.HasOne(d => d.Daorder).WithMany(p => p.DaOrderDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DA_OrderDetails_DA_Orders");

            entity.HasOne(d => d.Product).WithMany(p => p.DaOrderDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DA_OrderDetails_Product");
        });

        modelBuilder.Entity<DaOrderDetailsExtra>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.OrderDetailId, "IX_DA_OrderDetailsExtrasOrderDetId").HasFillFactor(90);

            entity.HasIndex(e => e.ExtrasId, "IX_DA_OrderDetailsExtrasOrderExtrasId").HasFillFactor(90);

            entity.HasIndex(e => new { e.OrderDetailId, e.ExtrasId }, "IX_DA_OrderDetailsExtrasOrderOrderDetIdExtrasId").HasFillFactor(90);

            entity.HasOne(d => d.OrderDetail).WithMany(p => p.DaOrderDetailsExtras)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DA_OrderDetailsExtras_DA_OrderDetails");
        });

        modelBuilder.Entity<DaOrderStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.OrderDaid, "IX_DA_OrderStatus_OrderDAId").HasFillFactor(90);

            entity.HasOne(d => d.OrderDa).WithMany(p => p.DaOrderStatuses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DA_OrderStatus_DA_Orders");
        });

        modelBuilder.Entity<DaPageSetStoreAssoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PageSetStoreAssoc");

            entity.HasOne(d => d.DaStore).WithMany(p => p.DaPageSetStoreAssocs).HasConstraintName("FK_PageSetStoreAssoc_DA_Stores");

            entity.HasOne(d => d.PageSet).WithMany(p => p.DaPageSetStoreAssocs).HasConstraintName("FK_PageSetStoreAssoc_PageSet");
        });

        modelBuilder.Entity<DaScheduledTaske>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.FaildNo, "IX_DA_ScheduledTaskes_Failed").HasFillFactor(90);

            entity.HasIndex(e => new { e.StoreId, e.Action, e.Short }, "IX_DA_ScheduledTaskes_Store_Action_Short").HasFillFactor(90);
        });

        modelBuilder.Entity<DaShortageProd>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => new { e.ProductId, e.StoreId }, "IX_DA_ShortageProdsProductStore").HasFillFactor(90);

            entity.HasIndex(e => new { e.ProductId, e.StoreId, e.ShortType }, "IX_DA_ShortageProdsProductStoreShort").HasFillFactor(90);

            entity.HasIndex(e => new { e.ProductId, e.StoreId, e.ShortType }, "IX_DA_ShortageProdsShortType").HasFillFactor(90);

            entity.HasIndex(e => e.ProductId, "IX_DA_ShortageProds_ProdId").HasFillFactor(90);

            entity.HasIndex(e => e.StoreId, "IX_DA_ShortageProds_StoreId").HasFillFactor(90);

            entity.HasIndex(e => new { e.StoreId, e.ShortType }, "IX_DA_ShortageProds_Store_ShortType").HasFillFactor(90);

            entity.HasOne(d => d.Product).WithMany(p => p.DaShortageProds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DA_ShortageProds_Product");

            entity.HasOne(d => d.Store).WithMany(p => p.DaShortageProds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DA_ShortageProds_DA_Stores");
        });

        modelBuilder.Entity<DaStore>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.Code, "IX_DA_StoresCode").HasFillFactor(90);

            entity.HasIndex(e => new { e.Username, e.Password }, "IX_DA_StoresUserPass").HasFillFactor(90);

            entity.HasIndex(e => e.CronScheduler, "IX_DA_Stores_CronSceduler").HasFillFactor(90);

            entity.Property(e => e.CronScheduler).HasDefaultValue("");

            entity.HasOne(d => d.Address).WithMany(p => p.DaStores).HasConstraintName("FK_DA_Stores_DA_Addresses");
        });

        modelBuilder.Entity<DaStoresWoltAssoc>(entity =>
        {
            entity.HasOne(d => d.DaStore).WithMany(p => p.DaStoresWoltAssocs).HasConstraintName("FK_DA_StoresWoltAssoc_DA_Stores");
        });

        modelBuilder.Entity<DastorePriceListAssoc>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_PriceList_DAStoreAssoc")
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.PriceListId, e.DastoreId }, "IX_DAStore_PriceListAssocPriceListStore").HasFillFactor(90);

            entity.HasOne(d => d.Dastore).WithMany(p => p.DastorePriceListAssocs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DAStore_PriceListAssoc_DA_Stores");

            entity.HasOne(d => d.PriceList).WithMany(p => p.DastorePriceListAssocs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DAStore_PriceListAssoc_Pricelist");
        });

        modelBuilder.Entity<DeliveryAddressType>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.Property(e => e.Descr).HasComment("Home, Company ...");
        });

        modelBuilder.Entity<DeliveryCustomer>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => new { e.ExtType, e.ExtCustId }, "IX_Delivery_Customers_ExtType_ExtCust").HasFillFactor(90);

            entity.HasOne(d => d.CustomerTypeNavigation).WithMany(p => p.DeliveryCustomers).HasConstraintName("FK_Delivery_Customers_Delivery_CustomersTypes");
        });

        modelBuilder.Entity<DeliveryCustomersBillingAddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => new { e.CustomerId, e.ExtKey, e.ExtType }, "IX_Delivery_CustomersBillingAddress_Cust_ExtKey_ExtType").HasFillFactor(90);

            entity.HasIndex(e => new { e.Id, e.CustomerId }, "IX_Delivery_CustomersBillingAddress_Id_Cust").HasFillFactor(90);

            entity.HasOne(d => d.Customer).WithMany(p => p.DeliveryCustomersBillingAddresses).HasConstraintName("FK_Delivery_CustomersBillingAddress_Delivery_Customers");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.DeliveryCustomersBillingAddresses).HasConstraintName("FK_Delivery_CustomersBillingAddress_Delivery_AddressTypes");
        });

        modelBuilder.Entity<DeliveryCustomersPhone>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => new { e.CustomerId, e.Id }, "IX_Delivery_CustomersPhones_Cust_Id").HasFillFactor(90);

            entity.HasIndex(e => new { e.CustomerId, e.PhoneNumber }, "IX_Delivery_CustomersPhones_Cust_Phone").HasFillFactor(90);

            entity.HasOne(d => d.Customer).WithMany(p => p.DeliveryCustomersPhones).HasConstraintName("FK_Delivery_CustomersPhones_Delivery_Customers");

            entity.HasOne(d => d.PhoneTypeNavigation).WithMany(p => p.DeliveryCustomersPhones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Delivery_CustomersPhones_Delivery_PhoneTypes");
        });

        modelBuilder.Entity<DeliveryCustomersPhonesAndAddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => new { e.CustomerId, e.PhoneId, e.AddressId, e.IsShipping }, "IX_Delivery_CustomersPhonesAndAddress").HasFillFactor(90);

            entity.HasOne(d => d.Customer).WithMany(p => p.DeliveryCustomersPhonesAndAddresses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Delivery_CustomersPhonesAndAddress_Delivery_Customers");

            entity.HasOne(d => d.Phone).WithMany(p => p.DeliveryCustomersPhonesAndAddresses).HasConstraintName("FK_Delivery_CustomersPhonesAndAddress_Delivery_CustomersPhones");
        });

        modelBuilder.Entity<DeliveryCustomersShippingAddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => new { e.CustomerId, e.ExtKey, e.ExtType }, "IX_Delivery_CustomersShippingAddress_Cust_ExtKey_ExtType").HasFillFactor(90);

            entity.HasIndex(e => new { e.Id, e.CustomerId }, "IX_Delivery_CustomersShippingAddress_Id_Cust").HasFillFactor(90);

            entity.HasOne(d => d.Customer).WithMany(p => p.DeliveryCustomersShippingAddresses).HasConstraintName("FK_Delivery_CustomersShippingAddress_Delivery_Customers");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.DeliveryCustomersShippingAddresses).HasConstraintName("FK_Delivery_CustomersShippingAddress_Delivery_AddressTypes");
        });

        modelBuilder.Entity<DeliveryCustomersType>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<DeliveryPhoneType>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<DeliveryRouting>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.CreateDate, "IX_DeliveryRouting_CreateDate").HasFillFactor(90);

            entity.HasIndex(e => new { e.StaffId, e.AssignStatus }, "IX_DeliveryRouting_StaffId_AssignStatus").HasFillFactor(90);

            entity.HasIndex(e => e.Status, "IX_DeliveryRouting_Status").HasFillFactor(90);
        });

        modelBuilder.Entity<DeliveryRoutingHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<DigitalSignature>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<Discount>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.Property(e => e.Type).HasComment("0 : Draxmiki - 1 : Posostiaia");
        });

        modelBuilder.Entity<DiscountTypeResult>(entity =>
        {
            entity.HasOne(d => d.DiscountType).WithMany(p => p.DiscountTypeResults).HasConstraintName("FK_DiscountTypeResults_DiscountType");
        });

        modelBuilder.Entity<DiscountTypeRule>(entity =>
        {
            entity.HasOne(d => d.DiscountType).WithMany(p => p.DiscountTypeRules).HasConstraintName("FK_DiscountTypeRules_DiscountType");
        });

        modelBuilder.Entity<EftposTransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EFT_Pos_Transactions");
        });

        modelBuilder.Entity<EmailConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<EndOfDay>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.PosInfo).WithMany(p => p.EndOfDays).HasConstraintName("FK_EndOfDay_PosInfo");
        });

        modelBuilder.Entity<EndOfDayDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.EndOfday).WithMany(p => p.EndOfDayDetails)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_EndOfDayDetail_EndOfDay");

            entity.HasOne(d => d.Tax).WithMany(p => p.EndOfDayDetails).HasConstraintName("FK_EndOfDayDetail_Tax");

            entity.HasOne(d => d.Vat).WithMany(p => p.EndOfDayDetails).HasConstraintName("FK_EndOfDayDetail_Vat");
        });

        modelBuilder.Entity<EndOfDayDetailHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);
        });

        modelBuilder.Entity<EndOfDayDetailView>(entity =>
        {
            entity.ToView("EndOfDayDetail_View");
        });

        modelBuilder.Entity<EndOfDayHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);
        });

        modelBuilder.Entity<EndOfDayPaymentAnalysis>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Account).WithMany(p => p.EndOfDayPaymentAnalyses).HasConstraintName("FK_EndOfDayPaymentAnalysis_Accounts");

            entity.HasOne(d => d.EndOfDay).WithMany(p => p.EndOfDayPaymentAnalyses).HasConstraintName("FK_EndOfDayPaymentAnalysis_EndOfDay");
        });

        modelBuilder.Entity<EndOfDayPaymentAnalysisHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);
        });

        modelBuilder.Entity<EndOfDayPaymentAnalysisView>(entity =>
        {
            entity.ToView("EndOfDayPaymentAnalysis_View");
        });

        modelBuilder.Entity<EndOfDayView>(entity =>
        {
            entity.ToView("EndOfDay_View");
        });

        modelBuilder.Entity<EndOfDayVoidsAnalysis>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_EndOfDayVoids")
                .HasFillFactor(90);

            entity.HasOne(d => d.Account).WithMany(p => p.EndOfDayVoidsAnalyses)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_EndOfDayVoids_Accounts");

            entity.HasOne(d => d.EndOfDay).WithMany(p => p.EndOfDayVoidsAnalyses)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_EndOfDayVoids_EndOfDay");
        });

        modelBuilder.Entity<EndOfDayVoidsAnalysisHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id })
                .HasName("PK_EndOfDayVoids_Hist")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<EndOfDayVoidsAnalysisView>(entity =>
        {
            entity.ToView("EndOfDayVoidsAnalysis_View");
        });

        modelBuilder.Entity<EndOfYear>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<EnvironmentalFee>(entity =>
        {
            entity.HasOne(d => d.Product).WithMany(p => p.EnvironmentalFees).HasConstraintName("FK_EnvironmentalFee_Product");

            entity.HasOne(d => d.SalesType).WithMany(p => p.EnvironmentalFees).HasConstraintName("FK_EnvironmentalFee_SalesType");
        });

        modelBuilder.Entity<EodaccountToPmsTransfer>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Account).WithMany(p => p.EodaccountToPmsTransfers).HasConstraintName("FK_EODAccountToPmsTransfer_Accounts");

            entity.HasOne(d => d.PosInfo).WithMany(p => p.EodaccountToPmsTransfers).HasConstraintName("FK_EODAccountToPmsTransfer_PosInfo");
        });

        modelBuilder.Entity<EodaccountToPmsTransferHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);
        });

        modelBuilder.Entity<EodaccountToPmsTransferView>(entity =>
        {
            entity.ToView("EODAccountToPmsTransfer_View");
        });

        modelBuilder.Entity<ExternalLostOrder>(entity =>
        {
            entity.HasKey(e => new { e.OrderNo, e.ExtType }).HasFillFactor(90);
        });

        modelBuilder.Entity<ExternalLostOrdersHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.OrderNo, e.ExtType }).HasFillFactor(90);
        });

        modelBuilder.Entity<ExternalLostOrdersView>(entity =>
        {
            entity.ToView("ExternalLostOrders_View");
        });

        modelBuilder.Entity<ExternalProductMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.Property(e => e.ProductEnumType).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.ProductId).HasDefaultValueSql("(NULL)");

            entity.HasOne(d => d.Product).WithMany(p => p.ExternalProductMappings).HasConstraintName("FK_ExternalProductMapping_Product");
        });

        modelBuilder.Entity<ExternalStateMatch>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.Property(e => e.ExtType).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.MatchValue).HasDefaultValueSql("(NULL)");
        });

        modelBuilder.Entity<ExternalUser>(entity =>
        {
            entity.HasKey(e => e.Username).HasFillFactor(90);
        });

        modelBuilder.Entity<ForexService>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<Guest>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.ProfileNo, "IX_Guest_Profile").HasFillFactor(90);

            entity.HasIndex(e => e.Id, "_dta_index_Guest_12_549576996__K1_5_6_9_10_11_12").HasFillFactor(90);
        });

        modelBuilder.Entity<GuestFuture>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<HitPosCustomer>(entity =>
        {
            entity.HasKey(e => e.CurId)
                .HasName("HitPosCustomers_PK")
                .IsClustered(false);

            entity.Property(e => e.Address2).IsFixedLength();
            entity.Property(e => e.Contact).IsFixedLength();
            entity.Property(e => e.Remarks).IsFixedLength();
            entity.Property(e => e.Vip).IsFixedLength();
            entity.Property(e => e.Zipcode).IsFixedLength();
        });

        modelBuilder.Entity<HitPosOrder>(entity =>
        {
            entity.HasKey(e => e.CurId)
                .HasName("HitPosOrders_PK")
                .IsClustered(false);
        });

        modelBuilder.Entity<HitPosOrdersHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.CurId })
                .HasName("HitPosOrders_Hist_PK")
                .HasFillFactor(90);
        });

        modelBuilder.Entity<HitPosOrdersView>(entity =>
        {
            entity.ToView("HitPosOrders_View");
        });

        modelBuilder.Entity<HotelCustomMessage>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<HotelCustomerDataConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<HotelInfo>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK__HotelInf__3214EC076C6E1476")
                .HasFillFactor(90);

            entity.HasOne(d => d.Store).WithMany(p => p.HotelInfos)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__HotelInfo__Store__6E565CE8");
        });

        modelBuilder.Entity<HotelMacro>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<HotelMacroResult>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<HotelMacroRule>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<HotelMacroTimezone>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<HotelMacrosHist>(entity =>
        {
            entity.HasKey(e => e.HisId).HasFillFactor(90);
        });

        modelBuilder.Entity<Ingredient>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.Daid, "IX_Ingredients_DAId").HasFillFactor(90);

            entity.HasOne(d => d.IngredientCategory).WithMany(p => p.Ingredients).HasConstraintName("FK_Ingredients_IngredientCategories");

            entity.HasOne(d => d.Item).WithMany(p => p.Ingredients).HasConstraintName("FK_Ingredients_Ingredients");

            entity.HasOne(d => d.Unit).WithMany(p => p.Ingredients).HasConstraintName("FK_Ingredients_Units");
        });

        modelBuilder.Entity<IngredientCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<IngredientProdCategoryAssoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.Hashcode, "HashCode").HasFillFactor(90);

            entity.HasIndex(e => new { e.EndOfDayId, e.PosInfoId }, "IX_Invoices_EndOfDayId_PosInfoId").HasFillFactor(90);

            entity.HasIndex(e => new { e.EndOfDayId, e.IsDeleted }, "InvoicesEndOfDayIsDeleted_IDX").HasFillFactor(90);

            entity.HasIndex(e => new { e.PosInfoId, e.EndOfDayId, e.IsDeleted }, "InvoicesPosInfoIdEndOfDayIdIsDeleted_IDX").HasFillFactor(90);

            entity.HasIndex(e => new { e.PosInfoId, e.IsDeleted }, "InvoicesPosInfoIdIsDeleted-IDX").HasFillFactor(90);

            entity.HasIndex(e => new { e.Id, e.EndOfDayId, e.IsDeleted, e.InvoiceTypeId, e.StaffId }, "_dta_index_Invoices_116_366624349__K1_K19_K22_K3_K13").HasFillFactor(90);

            entity.HasIndex(e => new { e.Id, e.EndOfDayId, e.IsDeleted, e.InvoiceTypeId, e.PosInfoId, e.StaffId }, "_dta_index_Invoices_116_366624349__K1_K19_K22_K3_K16_K13").HasFillFactor(90);

            entity.HasIndex(e => new { e.InvoiceTypeId, e.EndOfDayId, e.IsDeleted, e.PosInfoId, e.StaffId, e.Id }, "_dta_index_Invoices_116_366624349__K3_K19_K22_K16_K13_K1_4_5_6_8_9_10_12_14_17_18_20_21_23").HasFillFactor(90);

            entity.HasIndex(e => new { e.PosInfoId, e.EndOfDayId, e.IsDeleted, e.Id, e.InvoiceTypeId, e.StaffId }, "_dta_index_Invoices_6_1061578820__K16_K19_K22_K1_K3_K13_4_5_6_8_9_10_12_14_17_18_20_21_23").HasFillFactor(90);

            entity.HasIndex(e => new { e.PosInfoId, e.IsDeleted, e.InvoiceTypeId }, "_dta_index_Invoices_8_997578592__K16_K22_K3_1_4_5_6_8_9_10_12_13_14_17_18_19_20_21_23").HasFillFactor(90);

            entity.HasIndex(e => new { e.Id, e.IsDeleted, e.InvoiceTypeId }, "_dta_index_Invoices_8_997578592__K1_K22_K3_16_19_20").HasFillFactor(90);

            entity.HasOne(d => d.ClientPos).WithMany(p => p.Invoices).HasConstraintName("FK_Invoices_ClientPos");

            entity.HasOne(d => d.EndOfDay).WithMany(p => p.Invoices).HasConstraintName("FK_Invoices_EndOfDay");

            entity.HasOne(d => d.Guest).WithMany(p => p.Invoices).HasConstraintName("FK_Invoices_Guest");

            entity.HasOne(d => d.InvoiceType).WithMany(p => p.Invoices).HasConstraintName("FK_Invoices_InvoiceTypes");

            entity.HasOne(d => d.PdaModule).WithMany(p => p.Invoices).HasConstraintName("FK_Invoices_PdaModule");

            entity.HasOne(d => d.PosInfo).WithMany(p => p.Invoices).HasConstraintName("FK_Invoices_PosInfo");

            entity.HasOne(d => d.Staff).WithMany(p => p.Invoices).HasConstraintName("FK_Invoices_Staff");

            entity.HasOne(d => d.Table).WithMany(p => p.Invoices).HasConstraintName("FK_Invoices_Table");
        });

        modelBuilder.Entity<InvoiceGroubByInvoiceTypeAndAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<InvoiceGuestsTran>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.TransactionId, "Invoice_Guests_TransTransactionId_IDX").HasFillFactor(90);

            entity.HasIndex(e => new { e.TransactionId, e.Id, e.GuestId }, "_dta_index_Invoice_Guests_Trans_6_1029578706__K4_K1_K3").HasFillFactor(90);

            entity.HasIndex(e => new { e.GuestId, e.TransactionId }, "_dta_index_Invoice_Guests_Trans_8_965578478__K3_K4_2").HasFillFactor(90);

            entity.HasIndex(e => new { e.GuestId, e.TransactionId }, "_dta_index_Invoice_Guests_Trans_9_677577452__K3_K4").HasFillFactor(90);

            entity.HasOne(d => d.DeliveryCustomer).WithMany(p => p.InvoiceGuestsTrans).HasConstraintName("FK_Invoice_Guests_Trans_Delivery_Customers");

            entity.HasOne(d => d.Guest).WithMany(p => p.InvoiceGuestsTrans).HasConstraintName("FK_Invoice_Guests_Trans_Guest");

            entity.HasOne(d => d.Invoice).WithMany(p => p.InvoiceGuestsTrans).HasConstraintName("FK_Invoice_Guests_Trans_Invoices");

            entity.HasOne(d => d.Transaction).WithMany(p => p.InvoiceGuestsTrans).HasConstraintName("FK_Invoice_Guests_Trans_Transactions");
        });

        modelBuilder.Entity<InvoiceGuestsTransHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.GuestId, e.TransactionId }, "IX_Hist_Year_Guest_Transac").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.GuestId, e.TransactionId }, "IX_Hist_Year_Guest_Transac_Inv").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.TransactionId }, "IX_Hist_Year_Transac").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.TransactionId, e.GuestId }, "IX_Hist_Year_Transac_Guest").HasFillFactor(90);
        });

        modelBuilder.Entity<InvoiceGuestsTransView>(entity =>
        {
            entity.ToView("Invoice_Guests_Trans_View");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InvoiceHtmlReceipt>(entity =>
        {
            entity.HasOne(d => d.Invoice).WithMany(p => p.InvoiceHtmlReceipts).HasConstraintName("FK_InvoiceHtmlReceipt_InvoiceId");
        });

        modelBuilder.Entity<InvoiceQr>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.InvoiceId, "IX_InvoiceQR_InvoiceId").HasFillFactor(90);

            entity.HasOne(d => d.Invoice).WithMany(p => p.InvoiceQrs).HasConstraintName("FK_InvoiceQR_InvoiceId");
        });

        modelBuilder.Entity<InvoiceShippingDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.InvoicesId, "IX_InvoiceShippingDetails_Invoice").HasFillFactor(90);

            entity.HasIndex(e => new { e.InvoicesId, e.ShippingAddress }, "InvoiceShippingDetails_InvoicesId_ShippingAddess").HasFillFactor(90);

            entity.HasOne(d => d.Invoices).WithMany(p => p.InvoiceShippingDetails)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_InvoiceShippingDetails_Invoices");
        });

        modelBuilder.Entity<InvoiceShippingDetailsHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);
        });

        modelBuilder.Entity<InvoiceShippingDetailsView>(entity =>
        {
            entity.ToView("InvoiceShippingDetails_View");
        });

        modelBuilder.Entity<InvoiceType>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => new { e.Id, e.Type }, "IX_InvoiceTypes_Id_Type").HasFillFactor(90);
        });

        modelBuilder.Entity<InvoicesHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.IsDeleted, e.InvoiceTypeId }, "IX_Hist_Year_Del_Type").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.EndOfDayId, e.IsDeleted }, "IX_Hist_Year_EOD_Del").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.EndOfDayId, e.IsDeleted, e.InvoiceTypeId, e.PosInfoId, e.StaffId }, "IX_Hist_Year_EOD_Del_Type_Pos_Staff").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.EndOfDayId, e.IsDeleted, e.InvoiceTypeId, e.StaffId }, "IX_Hist_Year_EOD_Del_Type_Staff").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.PosInfoId, e.IsDeleted }, "IX_Hist_Year_Pos_Del").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.PosInfoId, e.IsDeleted, e.InvoiceTypeId }, "IX_Hist_Year_Pos_Del_Type").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.PosInfoId, e.EndOfDayId, e.IsDeleted }, "IX_Hist_Year_Pos_EOD_Del").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.PosInfoId, e.EndOfDayId, e.IsDeleted, e.InvoiceTypeId, e.StaffId }, "IX_Hist_Year_Pos_EOD_Del_Type_Staff").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.InvoiceTypeId, e.EndOfDayId, e.IsDeleted, e.PosInfoId, e.StaffId }, "IX_Hist_Year_Type_EOD_Del_Pos_Staff").HasFillFactor(90);
        });

        modelBuilder.Entity<InvoicesView>(entity =>
        {
            entity.ToView("Invoices_View");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Unit).WithMany(p => p.Items).HasConstraintName("FK_Items_Units");

            entity.HasOne(d => d.Vat).WithMany(p => p.Items).HasConstraintName("FK_Items_Vat");
        });

        modelBuilder.Entity<Kd>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.PosInfo).WithMany(p => p.Kds).HasConstraintName("FK_Kds_PosInfo");
        });

        modelBuilder.Entity<Kitchen>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<KitchenInstruction>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<KitchenInstructionHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);
        });

        modelBuilder.Entity<KitchenInstructionLogger>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.EndOfDayId, "IX_KitchenInstructionLogger_EndOfDayId").HasFillFactor(90);

            entity.HasIndex(e => new { e.EndOfDayId, e.PosInfoId }, "IX_KitchenInstructionLogger_EndOfDayId_PosInfoId").HasFillFactor(90);

            entity.HasOne(d => d.EndOfDay).WithMany(p => p.KitchenInstructionLoggers).HasConstraintName("FK_KitchenInstructionLogger_EndOfDay");

            entity.HasOne(d => d.KicthcenInstuction).WithMany(p => p.KitchenInstructionLoggers).HasConstraintName("FK_KitchenInstructionLogger_KitchenInstructionLogger");
        });

        modelBuilder.Entity<KitchenInstructionLoggerHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);
        });

        modelBuilder.Entity<KitchenInstructionLoggerView>(entity =>
        {
            entity.ToView("KitchenInstructionLogger_View");
        });

        modelBuilder.Entity<KitchenRegion>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<Locker>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_dbo.Lockers")
                .HasFillFactor(90);

            entity.HasIndex(e => e.EndOfDayId, "IX_EndOfDayId").HasFillFactor(90);

            entity.HasOne(d => d.EndOfDay).WithMany(p => p.Lockers).HasConstraintName("FK_Lockers_EndOfDay");

            entity.HasOne(d => d.PosInfo).WithMany(p => p.Lockers).HasConstraintName("FK_Lockers_PosInfo");
        });

        modelBuilder.Entity<LockersHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);
        });

        modelBuilder.Entity<LockersView>(entity =>
        {
            entity.ToView("Lockers_View");
        });

        modelBuilder.Entity<Loyalty>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Daorder).WithMany(p => p.Loyalties).HasConstraintName("FK_Loyalty_DA_Orders");

            entity.HasOne(d => d.Invoices).WithMany(p => p.Loyalties).HasConstraintName("FK_Loyalty_Invoices");
        });

        modelBuilder.Entity<LoyaltyHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);
        });

        modelBuilder.Entity<LoyaltyPointsRedeemed>(entity =>
        {
            entity.ToView("LoyaltyPointsRedeemed");
        });

        modelBuilder.Entity<LoyaltyView>(entity =>
        {
            entity.ToView("Loyalty_View");
        });

        modelBuilder.Entity<MainProductForBox>(entity =>
        {
            entity.HasOne(d => d.CategoriesForBox).WithMany(p => p.MainProductForBoxes).HasConstraintName("FK_MainProductForBox_CategoriesForBox");
        });

        modelBuilder.Entity<ManualLoyaltyPoint>(entity =>
        {
            entity.ToView("ManualLoyaltyPoints");
        });

        modelBuilder.Entity<MealConsumption>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.EndOfDayId, "IX_MealConsumption_EndOfDayId").HasFillFactor(90);

            entity.HasIndex(e => new { e.EndOfDayId, e.PosInfoId }, "IX_MealConsumption_EndOfDayId_PosInfoId").HasFillFactor(90);

            entity.HasOne(d => d.Department).WithMany(p => p.MealConsumptions).HasConstraintName("FK_MealConsumption_Department");

            entity.HasOne(d => d.EndOfDay).WithMany(p => p.MealConsumptions).HasConstraintName("FK_MealConsumption_EndOfDay");

            entity.HasOne(d => d.Guest).WithMany(p => p.MealConsumptions).HasConstraintName("FK_MealConsumption_Guest");

            entity.HasOne(d => d.PosInfo).WithMany(p => p.MealConsumptions).HasConstraintName("FK_MealConsumption_PosInfo");

            entity.HasOne(d => d.Staff).WithMany(p => p.MealConsumptions).HasConstraintName("FK_MealConsumption_Staff");
        });

        modelBuilder.Entity<MealConsumptionHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);
        });

        modelBuilder.Entity<MealConsumptionView>(entity =>
        {
            entity.ToView("MealConsumption_View");
        });

        modelBuilder.Entity<MetadataTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<Nfccard>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.PosInfo).WithMany(p => p.Notifications)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Notifications_Notifications");

            entity.HasOne(d => d.Store).WithMany(p => p.Notifications)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Notifications_Store");
        });

        modelBuilder.Entity<OnlineRegistration>(entity =>
        {
            entity.HasKey(e => e.BarCode).HasFillFactor(90);

            entity.HasIndex(e => e.FirtName, "IX_OnlineRegistration_FirstName").HasFillFactor(90);

            entity.HasIndex(e => e.LastName, "IX_OnlineRegistration_LastName").HasFillFactor(90);

            entity.HasIndex(e => e.Status, "IX_OnlineRegistration_Status").HasFillFactor(90);
        });

        modelBuilder.Entity<OnlineRegistrationHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.BarCode }).HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.FirtName }, "IX_Hist_Year_FirstName").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.LastName }, "IX_Hist_Year_LastName").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.Status }, "IX_Hist_Year_Status").HasFillFactor(90);
        });

        modelBuilder.Entity<OnlineRegistrationView>(entity =>
        {
            entity.ToView("OnlineRegistration_View");
        });

        modelBuilder.Entity<Openremark>(entity =>
        {
            entity.ToView("openremarks");
        });

        modelBuilder.Entity<OpenremarksOnly>(entity =>
        {
            entity.ToView("openremarks_only");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.DeliveryRoutingId, "IX_Order_DeliveryRoutingId").HasFillFactor(90);

            entity.HasIndex(e => e.EndOfDayId, "IX_Order_EndOfDayId").HasFillFactor(90);

            entity.HasIndex(e => new { e.EndOfDayId, e.PosId }, "IX_Order_EndOfDayId_PosId").HasFillFactor(90);

            entity.HasIndex(e => new { e.ExtType, e.ExtKey }, "IX_Order_ExtType_ExtKey").HasFillFactor(90);

            entity.HasIndex(e => new { e.ExtType, e.ExtKey, e.PosId }, "IX_Order_ExtType_ExtKey_PosId").HasFillFactor(90);

            entity.HasIndex(e => new { e.ExtType, e.ExtKey, e.StaffId }, "IX_Order_ExtType_ExtKey_StaffId").HasFillFactor(90);

            entity.HasIndex(e => e.EndOfDayId, "OrderEODIDX").HasFillFactor(90);

            entity.HasIndex(e => new { e.Id, e.OrderNo }, "_dta_index_Order_6_1317579732__K1_K2").HasFillFactor(90);

            entity.HasOne(d => d.DeliveryRouting).WithMany(p => p.OrdersNavigation).HasConstraintName("FK_Order_DeliveryRouting");

            entity.HasOne(d => d.EndOfDay).WithMany(p => p.Orders)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Order_EndOfDay");

            entity.HasOne(d => d.MacroGuid).WithMany(p => p.Orders).HasConstraintName("FK_Order_MacroGuid");

            entity.HasOne(d => d.PdaModule).WithMany(p => p.Orders).HasConstraintName("FK_Order_PdaModule");

            entity.HasOne(d => d.Pos).WithMany(p => p.Orders).HasConstraintName("FK_Order_PosInfo");

            entity.HasOne(d => d.Staff).WithMany(p => p.Orders).HasConstraintName("FK_Order_Staff");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_OrderDetailId")
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.IsDeleted, e.Status }, "<Name of Missing Index, sysname,>").HasFillFactor(90);

            entity.HasIndex(e => e.OrderId, "IX_OrderDetail_OrderId").HasFillFactor(90);

            entity.HasIndex(e => e.IsDeleted, "OrderDetailInvoicesReceiptDetails_IDX").HasFillFactor(90);

            entity.HasIndex(e => e.IsDeleted, "OrderDetailIsDeleted").HasFillFactor(90);

            entity.HasIndex(e => e.IsDeleted, "OrderDetailIsDeleted_IDX").HasFillFactor(90);

            entity.HasIndex(e => new { e.OrderId, e.IsDeleted }, "OrderDetailOrderIdIsDelettedIDX").HasFillFactor(90);

            entity.HasIndex(e => new { e.ProductId, e.IsDeleted }, "OrderDetailProductIdIsDeleted_IDX").HasFillFactor(90);

            entity.HasIndex(e => new { e.SalesTypeId, e.IsDeleted }, "OrderDetailSalesTypeIdIsDeleted_IDX").HasFillFactor(90);

            entity.HasIndex(e => new { e.IsDeleted, e.Status }, "Test1_IDX").HasFillFactor(90);

            entity.HasIndex(e => new { e.OrderId, e.IsDeleted }, "Test3_IDX").HasFillFactor(90);

            entity.HasIndex(e => new { e.PaidStatus, e.Status, e.Id, e.OrderId, e.KitchenId, e.KdsId, e.PreparationTime, e.TableId }, "_dta_index_OrderDetail_116_1602104748__K15_K8_K1_K2_K4_K5_K6_K7_3_11_12_14_17_21").HasFillFactor(90);

            entity.HasIndex(e => new { e.Id, e.TableId, e.Status, e.PaidStatus, e.IsDeleted, e.OrderId }, "_dta_index_OrderDetail_116_1602104748__K1_K7_K8_K15_K21_K2").HasFillFactor(90);

            entity.HasIndex(e => new { e.TableId, e.PaidStatus, e.Status, e.Id, e.OrderId, e.ProductId, e.PriceListDetailId, e.IsDeleted, e.TotalAfterDiscount, e.Qty, e.Discount, e.KitchenId, e.KdsId, e.PreparationTime, e.Guid }, "_dta_index_OrderDetail_116_1602104748__K7_K15_K8_K1_K2_K3_K11_K21_K17_K12_K14_K4_K5_K6_K20").HasFillFactor(90);

            entity.HasIndex(e => new { e.TableId, e.Status, e.PaidStatus, e.IsDeleted }, "_dta_index_OrderDetail_116_1602104748__K7_K8_K15_K21_1_2").HasFillFactor(90);

            entity.HasIndex(e => new { e.Id, e.OrderId }, "_dta_index_OrderDetail_6_1349579846__K1_K2").HasFillFactor(90);

            entity.HasIndex(e => new { e.Id, e.IsDeleted, e.TotalAfterDiscount }, "_dta_index_OrderDetail_6_1349579846__K1_K21_K17").HasFillFactor(90);

            entity.Property(e => e.StatusTs).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Guest).WithMany(p => p.OrderDetails).HasConstraintName("FK_OrderDetail_Guest");

            entity.HasOne(d => d.LoginStaff).WithMany(p => p.OrderDetails).HasConstraintName("FK_OrderDetail_Staff");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_OrderDetail_Order");

            entity.HasOne(d => d.PriceListDetail).WithMany(p => p.OrderDetails).HasConstraintName("FK_OrderDetail_PricelistDetail");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderDetails).HasConstraintName("FK_OrderDetail_Product");

            entity.HasOne(d => d.SalesType).WithMany(p => p.OrderDetails).HasConstraintName("FK_OrderDetail_SalesType");

            entity.HasOne(d => d.Table).WithMany(p => p.OrderDetails)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_OrderDetail_Table");

            entity.HasOne(d => d.Transaction).WithMany(p => p.OrderDetails).HasConstraintName("FK_OrderDetail_Transactions");
        });

        modelBuilder.Entity<OrderDetailHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id })
                .HasName("PK_OrderDetailId_Hist")
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.IsDeleted }, "IX_Hist_Year_Del_Incl_1").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.IsDeleted }, "IX_Hist_Year_Del_Incl_2").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.IsDeleted }, "IX_Hist_Year_Del_Incl_3").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.IsDeleted, e.Status }, "IX_Hist_Year_Del_Stat").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.IsDeleted, e.TotalAfterDiscount }, "IX_Hist_Year_Del_Tot").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.OrderId }, "IX_Hist_Year_Order").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.OrderId, e.IsDeleted }, "IX_Hist_Year_Order_Del").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.OrderId, e.IsDeleted }, "IX_Hist_Year_Order_Del_Incl").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.PaidStatus, e.Status, e.OrderId, e.KitchenId, e.KdsId, e.PreparationTime, e.TableId }, "IX_Hist_Year_Paid_Stat_Order_Kitc_Kds_Prep_Tbl").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.ProductId, e.IsDeleted }, "IX_Hist_Year_Prod_Del").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.SalesTypeId, e.IsDeleted }, "IX_Hist_Year_Sal_Del").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.TableId, e.PaidStatus, e.Status, e.OrderId, e.ProductId, e.PriceListDetailId, e.IsDeleted, e.TotalAfterDiscount, e.Qty, e.Discount, e.KitchenId, e.KdsId, e.PreparationTime, e.Guid }, "IX_Hist_Year_Tbl_Paid_Stat_Order_Prod_Price_Del_Tot_Qty_Disc_Kitc_Prep_Guid").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.TableId, e.Status, e.PaidStatus, e.IsDeleted, e.OrderId }, "IX_Hist_Year_Tbl_Stat_Paid_Del_Order").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.TableId, e.Status, e.PaidStatus, e.IsDeleted }, "IX_Hist_Year_Tbl_Stat_Peid_Del").HasFillFactor(90);
        });

        modelBuilder.Entity<OrderDetailIgredient>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.OrderDetailId, "OrderDetailIgredientsOrderDetailId_IDX").HasFillFactor(90);

            entity.HasIndex(e => new { e.OrderDetailId, e.TotalAfterDiscount, e.IngredientId, e.Qty, e.Discount, e.IsDeleted }, "_dta_index_OrderDetailIgredients_116_1906105831__K6_K9_K2_K3_K8_K10_1_7").HasFillFactor(90);

            entity.HasOne(d => d.Ingredient).WithMany(p => p.OrderDetailIgredients).HasConstraintName("FK_OrderDetailIgredients_Ingredients");

            entity.HasOne(d => d.OrderDetail).WithMany(p => p.OrderDetailIgredients)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_OrderDetailIgredients_OrderDetail");

            entity.HasOne(d => d.PriceListDetail).WithMany(p => p.OrderDetailIgredients).HasConstraintName("FK_OrderDetailIgredients_PricelistDetail");
        });

        modelBuilder.Entity<OrderDetailIgredientVatAnal>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => new { e.OrderDetailIgredientsId, e.VatId, e.Net, e.VatAmount, e.TaxId, e.TaxAmount }, "_dta_index_OrderDetailIgredientVatAnal_116_2050106344__K2_K7_K4_K6_K8_K9_5").HasFillFactor(90);

            entity.HasIndex(e => new { e.VatId, e.OrderDetailIgredientsId, e.Net, e.VatAmount, e.TaxId, e.TaxAmount }, "_dta_index_OrderDetailIgredientVatAnal_116_2050106344__K7_K2_K4_K6_K8_K9_5").HasFillFactor(90);

            entity.HasOne(d => d.OrderDetailIgredients).WithMany(p => p.OrderDetailIgredientVatAnals)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_OrderDetailIgredientVatAnal_OrderDetailIgredients");

            entity.HasOne(d => d.Tax).WithMany(p => p.OrderDetailIgredientVatAnals)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_OrderDetailIgredientVatAnal_Tax");
        });

        modelBuilder.Entity<OrderDetailIgredientVatAnalHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.OrderDetailIgredientsId, e.VatId, e.Net, e.VatAmount, e.TaxId, e.TaxAmount }, "IX_Hist_Year_OrdetDetIng_Vat_Net_VatAm_Tax_TaxAm").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.VatId, e.OrderDetailIgredientsId, e.Net, e.VatAmount, e.TaxId, e.TaxAmount }, "IX_Hist_Year_Vat_OrderDetIng_Net_VatAm_Tax_TaxAm").HasFillFactor(90);
        });

        modelBuilder.Entity<OrderDetailIgredientVatAnalView>(entity =>
        {
            entity.ToView("OrderDetailIgredientVatAnal_View");
        });

        modelBuilder.Entity<OrderDetailIgredientsHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);
        });

        modelBuilder.Entity<OrderDetailIgredientsKd>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<OrderDetailIgredientsView>(entity =>
        {
            entity.ToView("OrderDetailIgredients_View");
        });

        modelBuilder.Entity<OrderDetailInvoice>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.EndOfDayId, "IX_EndOfDayId").HasFillFactor(90);

            entity.HasIndex(e => e.OrderDetailIgredientsId, "IX_OrderDetailIgredientsId").HasFillFactor(90);

            entity.HasIndex(e => e.InvoicesId, "IX_OrderDetailInvoicesInvoicesId").HasFillFactor(90);

            entity.HasIndex(e => new { e.EndOfDayId, e.PosInfoId }, "IX_OrderDetailInvoices_EndOfDayId_PosInfoId").HasFillFactor(90);

            entity.HasIndex(e => e.OrderDetailId, "IX_OrderDetailInvoices_OrderDetail").HasFillFactor(90);

            entity.HasIndex(e => e.EndOfDayId, "idx_OrderDetailInvoices_4").HasFillFactor(90);

            entity.HasIndex(e => e.InvoicesId, "idx_OrderDetailInvoices_OrderDetailId").HasFillFactor(90);

            entity.HasIndex(e => e.InvoicesId, "idx_OrderDetailInvoices_PricelistId").HasFillFactor(90);

            entity.HasOne(d => d.EndOfDay).WithMany(p => p.OrderDetailInvoices).HasConstraintName("FK_dbo.OrderDetailInvoices_dbo.EndOfDay_EndOfDayId");

            entity.HasOne(d => d.Invoices).WithMany(p => p.OrderDetailInvoices).HasConstraintName("FK_OrderDetailInvoices_Invoices");

            entity.HasOne(d => d.OrderDetail).WithMany(p => p.OrderDetailInvoices)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_OrderDetailInvoices_OrderDetail");

            entity.HasOne(d => d.OrderDetailIgredients).WithMany(p => p.OrderDetailInvoices).HasConstraintName("FK_dbo.OrderDetailInvoices_dbo.OrderDetailIgredients_OrderDetailIgredientsId");

            entity.HasOne(d => d.PosInfoDetail).WithMany(p => p.OrderDetailInvoices)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_OrderDetailInvoices_PosInfoDetail");

            entity.HasOne(d => d.Pricelist).WithMany(p => p.OrderDetailInvoices).HasConstraintName("FK_dbo.OrderDetailInvoices_dbo.Pricelist_PricelistId");

            entity.HasOne(d => d.Staff).WithMany(p => p.OrderDetailInvoices)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_OrderDetailInvoices_Staff");
        });

        modelBuilder.Entity<OrderDetailInvoicesHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.EndOfDayId }, "IX_Hist_Year_EndOfDayId").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.OrderDetailIgredientsId }, "IX_Hist_Year_OrderDetailIgredientsId").HasFillFactor(90);
        });

        modelBuilder.Entity<OrderDetailInvoicesView>(entity =>
        {
            entity.ToView("OrderDetailInvoices_View");
        });

        modelBuilder.Entity<OrderDetailVatAnal>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.OrderDetailId, "OrderDetailVatAnalOrderIdVatId_IDX").HasFillFactor(90);

            entity.HasIndex(e => new { e.VatId, e.OrderDetailId, e.Net, e.VatAmount, e.TaxId, e.TaxAmount }, "_dta_index_OrderDetailVatAnal_116_2018106230__K7_K2_K4_K6_K8_K9_5").HasFillFactor(90);

            entity.HasIndex(e => new { e.OrderDetailId, e.TaxId, e.VatId, e.Net, e.VatAmount, e.TaxAmount }, "_dta_index_OrderDetailVatAnal_6_1477580302__K2_K8_K7_K4_K6_K9_5").HasFillFactor(90);

            entity.HasOne(d => d.OrderDetail).WithMany(p => p.OrderDetailVatAnals)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_OrderDetailVatAnal_OrderDetail");

            entity.HasOne(d => d.Tax).WithMany(p => p.OrderDetailVatAnals)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_OrderDetailVatAnal_Tax");
        });

        modelBuilder.Entity<OrderDetailVatAnalHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.OrderDetailId }, "IX_Hist_Year_OrderDet").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.OrderDetailId, e.TaxId, e.VatId, e.Net, e.VatAmount, e.TaxAmount }, "IX_Hist_Year_OrderDet_Tax_Vat_Net_VatAm_TaxAm").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.VatId, e.OrderDetailId, e.Net, e.VatAmount, e.TaxId, e.TaxAmount }, "IX_Hist_Year_Vat_OrderDet_Net_VatAm_Tax_TaxAm").HasFillFactor(90);
        });

        modelBuilder.Entity<OrderDetailVatAnalView>(entity =>
        {
            entity.ToView("OrderDetailVatAnal_View");
        });

        modelBuilder.Entity<OrderHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.EndOfDayId }, "IX_Hist_Year_EOD").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.OrderNo }, "IX_Hist_Year_OrderNo").HasFillFactor(90);
        });

        modelBuilder.Entity<OrderMonitoring>(entity =>
        {
            entity.HasOne(d => d.Order).WithMany(p => p.OrderMonitorings).HasConstraintName("FK_OrderMonitoring_Order");
        });

        modelBuilder.Entity<OrderSimply>(entity =>
        {
            entity.ToView("OrderSimply");
        });

        modelBuilder.Entity<OrderStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("OrderStatus", tb => tb.HasTrigger("OrderStatusOnKds"));

            entity.HasIndex(e => e.TimeChanged, "IX_OrderStatus_Time").HasFillFactor(90);

            entity.HasIndex(e => e.OrderId, "OrderStatusOrderId_IDX").HasFillFactor(90);

            entity.Property(e => e.ExtState).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.TimeChanged).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderStatuses)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_OrderStatus_Order");

            entity.HasOne(d => d.Staff).WithMany(p => p.OrderStatuses).HasConstraintName("FK_OrderStatus_Staff");
        });

        modelBuilder.Entity<OrderStatusHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.OrderId }, "IX_Hist_Year_Order").HasFillFactor(90);
        });

        modelBuilder.Entity<OrderStatusView>(entity =>
        {
            entity.ToView("OrderStatus_View");
        });

        modelBuilder.Entity<OrdersAnalysis>(entity =>
        {
            entity.ToView("OrdersAnalysis");
        });

        modelBuilder.Entity<OrdersStaff>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Order).WithMany(p => p.OrdersStaffs)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_OrdersStaff_Order");

            entity.HasOne(d => d.Staff).WithMany(p => p.OrdersStaffs)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_OrdersStaff_Staff");
        });

        modelBuilder.Entity<OrdersStaffHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);
        });

        modelBuilder.Entity<OrdersStaffView>(entity =>
        {
            entity.ToView("OrdersStaff_View");
        });

        modelBuilder.Entity<Page>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.PageSet).WithMany(p => p.Pages).HasConstraintName("FK_Pages_PageSet");
        });

        modelBuilder.Entity<PageButton>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_PageProducts")
                .HasFillFactor(90);

            entity.HasOne(d => d.Page).WithMany(p => p.PageButtons)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PageButton_Pages");

            entity.HasOne(d => d.Product).WithMany(p => p.PageButtons).HasConstraintName("FK_PageButton_Product");
        });

        modelBuilder.Entity<PageButtonDetail>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_PageProductsDetail")
                .HasFillFactor(90);

            entity.Property(e => e.Type).HasComment("0-Receipe, 1-Extras");

            entity.HasOne(d => d.PageButton).WithMany(p => p.PageButtonDetails)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PageButtonDetail_PageButton");
        });

        modelBuilder.Entity<PagePosAssoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.PageSet).WithMany(p => p.PagePosAssocs).HasConstraintName("FK_PagePosAssoc_PageSet");

            entity.HasOne(d => d.PosInfo).WithMany(p => p.PagePosAssocs)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_PagePosAssoc_PosInfo");
        });

        modelBuilder.Entity<PageSet>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<Payrole>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.ActionDate, "IX_Payrole_ActionDate").HasFillFactor(90);

            entity.HasIndex(e => new { e.ActionDate, e.ShopId, e.StaffId, e.PosInfoId }, "IX_Payrole_DayStaff").HasFillFactor(90);

            entity.HasIndex(e => e.Identification, "IX_Payrole_Identification").HasFillFactor(90);

            entity.HasIndex(e => e.StaffId, "IX_Payrole_StaffId").HasFillFactor(90);

            entity.HasOne(d => d.PosInfo).WithMany(p => p.Payroles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payrole_PosInfo");

            entity.HasOne(d => d.Staff).WithMany(p => p.Payroles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payrole_Staff");
        });

        modelBuilder.Entity<PayrollNew>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.DateFrom, "IX_PayrollNew_DateFrom").HasFillFactor(90);

            entity.HasIndex(e => e.PosInfoId, "IX_PayrollNew_PosInfoId").HasFillFactor(90);

            entity.HasIndex(e => e.StaffId, "IX_PayrollNew_StaffId").HasFillFactor(90);

            entity.HasOne(d => d.PosInfo).WithMany(p => p.PayrollNews)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollNew_PosInfo");

            entity.HasOne(d => d.Staff).WithMany(p => p.PayrollNews)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollNew_Staff");
        });

        modelBuilder.Entity<PdaModule>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.PageSet).WithMany(p => p.PdaModules)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_PdaModule_PageSet");

            entity.HasOne(d => d.PosInfo).WithMany(p => p.PdaModules)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_PdaModule_PosInfo");
        });

        modelBuilder.Entity<PdaModuleDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.PdaModule).WithMany(p => p.PdaModuleDetails)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_PdaModuleDetail_PdaModule");
        });

        modelBuilder.Entity<PdaSurveyAnswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Guest).WithMany(p => p.PdaSurveyAnswers).HasConstraintName("FK_Pda_SurveyAnswer_Guest");

            entity.HasOne(d => d.HotelInfo).WithMany(p => p.PdaSurveyAnswers).HasConstraintName("FK_Pda_SurveyAnswer_HotelInfo");

            entity.HasOne(d => d.PosInfo).WithMany(p => p.PdaSurveyAnswers).HasConstraintName("FK_Pda_SurveyAnswer_PosInfo");
        });

        modelBuilder.Entity<PdaSurveyQuestion>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.PosInfo).WithMany(p => p.PdaSurveyQuestions).HasConstraintName("FK_Pda_SurveyQuestion_PosInfo");
        });

        modelBuilder.Entity<PointsPerStore>(entity =>
        {
            entity.ToView("PointsPerStore");
        });

        modelBuilder.Entity<PosInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Account).WithMany(p => p.PosInfos).HasConstraintName("FK_PosInfo_Accounts");

            entity.HasOne(d => d.Department).WithMany(p => p.PosInfos)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_PosInfo_Department");
        });

        modelBuilder.Entity<PosInfoDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.InvoicesType).WithMany(p => p.PosInfoDetails).HasConstraintName("FK_PosInfoDetail_InvoiceTypes");

            entity.HasOne(d => d.PosInfo).WithMany(p => p.PosInfoDetails)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PosInfoDetail_PosInfo");
        });

        modelBuilder.Entity<PosInfoDetailExcludedAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Account).WithMany(p => p.PosInfoDetailExcludedAccounts)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_PosInfoDetail_Excluded_Accounts_Accounts");

            entity.HasOne(d => d.PosInfoDetail).WithMany(p => p.PosInfoDetailExcludedAccounts).HasConstraintName("FK_PosInfoDetail_Excluded_Accounts_PosInfoDetail");
        });

        modelBuilder.Entity<PosInfoDetailPricelistAssoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.PosInfoDetail).WithMany(p => p.PosInfoDetailPricelistAssocs)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PosInfoDetail_Pricelist_Assoc_PosInfoDetail");

            entity.HasOne(d => d.Pricelist).WithMany(p => p.PosInfoDetailPricelistAssocs)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PosInfoDetail_Pricelist_Assoc_Pricelist");
        });

        modelBuilder.Entity<PosInfoKdsAssoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Kds).WithMany(p => p.PosInfoKdsAssocs)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PosInfoKdsAssoc_Kds");

            entity.HasOne(d => d.PosInfo).WithMany(p => p.PosInfoKdsAssocs)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PosInfoKdsAssoc_PosInfo");
        });

        modelBuilder.Entity<PosInfoKitchenInstructionAssoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.KitchenInstruction).WithMany(p => p.PosInfoKitchenInstructionAssocs).HasConstraintName("FK_PosInfo_KitchenInstruction_Assoc_KitchenInstruction");

            entity.HasOne(d => d.PosInfo).WithMany(p => p.PosInfoKitchenInstructionAssocs).HasConstraintName("FK_PosInfo_KitchenInstruction_Assoc_PosInfo");
        });

        modelBuilder.Entity<PosInfoPricelistAssoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.PosInfo).WithMany(p => p.PosInfoPricelistAssocs)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PosInfo_Pricelist_Assoc_PosInfo");

            entity.HasOne(d => d.Pricelist).WithMany(p => p.PosInfoPricelistAssocs)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PosInfo_Pricelist_Assoc_Pricelist");
        });

        modelBuilder.Entity<PosInfoRegionAssoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.PosInfo).WithMany(p => p.PosInfoRegionAssocs).HasConstraintName("FK_PosInfo_Region_Assoc_PosInfo");

            entity.HasOne(d => d.Region).WithMany(p => p.PosInfoRegionAssocs).HasConstraintName("FK_PosInfo_Region_Assoc_Region");
        });

        modelBuilder.Entity<PosInfoStaffPositinAssoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.PosInfo).WithMany(p => p.PosInfoStaffPositinAssocs)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PosInfo_StaffPositin_Assoc_PosInfo");

            entity.HasOne(d => d.StaffPosition).WithMany(p => p.PosInfoStaffPositinAssocs)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PosInfo_StaffPositin_Assoc_StaffPosition");
        });

        modelBuilder.Entity<PosSalesAnalysis>(entity =>
        {
            entity.ToView("pos_sales_analysis");
        });

        modelBuilder.Entity<PosSalesAnalysis2>(entity =>
        {
            entity.ToView("pos_sales_analysis2");
        });

        modelBuilder.Entity<PosSalesAnalysis3>(entity =>
        {
            entity.ToView("pos_sales_analysis3");
        });

        modelBuilder.Entity<PredefinedCredit>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.InvoiceType).WithMany(p => p.PredefinedCredits).HasConstraintName("FK_PredefinedCredits_InvoiceTypes");
        });

        modelBuilder.Entity<PriceListEffectiveHour>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Pricelist).WithMany(p => p.PriceListEffectiveHours).HasConstraintName("FK_PriceList_EffectiveHours_Pricelist");
        });

        modelBuilder.Entity<Pricelist>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.Daid, "IX_Pricelist_DAId").HasFillFactor(90);

            entity.HasOne(d => d.PricelistMaster).WithMany(p => p.Pricelists)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Pricelist_PricelistMaster");
        });

        modelBuilder.Entity<PricelistDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => new { e.ProductId, e.PricelistId }, "IX_PricelistDetail_Prod_PrLst").HasFillFactor(90);

            entity.HasIndex(e => new { e.Id, e.PricelistId, e.Price }, "_dta_index_PricelistDetail_116_802101898__K1_K2_K5").HasFillFactor(90);

            entity.HasIndex(e => new { e.IngredientId, e.Price }, "_dta_index_PricelistDetail_12_1861581670__K4_K5").HasFillFactor(90);

            entity.HasOne(d => d.Ingredient).WithMany(p => p.PricelistDetails).HasConstraintName("FK_PricelistDetail_Ingredients");

            entity.HasOne(d => d.Pricelist).WithMany(p => p.PricelistDetails)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PricelistDetail_Pricelist");

            entity.HasOne(d => d.Product).WithMany(p => p.PricelistDetails).HasConstraintName("FK_PricelistDetail_Product");

            entity.HasOne(d => d.Tax).WithMany(p => p.PricelistDetails).HasConstraintName("FK_PricelistDetail_Tax");

            entity.HasOne(d => d.Vat).WithMany(p => p.PricelistDetails).HasConstraintName("FK_PricelistDetail_Vat");
        });

        modelBuilder.Entity<PricelistMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.Daid, "IX_Product_DAId").HasFillFactor(90);

            entity.HasIndex(e => e.ProductCategoryId, "ProductProductCategoryId-IDX").HasFillFactor(90);

            entity.HasIndex(e => new { e.ProductCategoryId, e.Id }, "_dta_index_Product_12_1925581898__K11_K1").HasFillFactor(90);

            entity.HasOne(d => d.Kds).WithMany(p => p.Products).HasConstraintName("FK_Product_Kds");

            entity.HasOne(d => d.Kitchen).WithMany(p => p.Products).HasConstraintName("FK_Product_Kitchen");

            entity.HasOne(d => d.KitchenRegion).WithMany(p => p.Products).HasConstraintName("FK_Product_KitchenRegion");

            entity.HasOne(d => d.ProductCategory).WithMany(p => p.Products).HasConstraintName("FK_Product_ProductCategories");

            entity.HasOne(d => d.Unit).WithMany(p => p.Products).HasConstraintName("FK_Product_Units");
        });

        modelBuilder.Entity<ProductBarcode>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Product).WithMany(p => p.ProductBarcodes)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ProductBarcodes_Product");
        });

        modelBuilder.Entity<ProductCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Category).WithMany(p => p.ProductCategories).HasConstraintName("FK_ProductCategories_Categories");
        });

        modelBuilder.Entity<ProductExtra>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Ingredient).WithMany(p => p.ProductExtras).HasConstraintName("FK_ProductExtras_Ingredients");

            entity.HasOne(d => d.Items).WithMany(p => p.ProductExtras).HasConstraintName("FK_ProductExtras_Items");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductExtras).HasConstraintName("FK_ProductExtras_Product");

            entity.HasOne(d => d.Unit).WithMany(p => p.ProductExtras).HasConstraintName("FK_ProductExtras_Units");
        });

        modelBuilder.Entity<ProductForBarcodeEod>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Product).WithMany(p => p.ProductForBarcodeEods)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductForBarcodeEod_Product");
        });

        modelBuilder.Entity<ProductRecipe>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Ingredient).WithMany(p => p.ProductRecipes).HasConstraintName("FK_ProductRecipe_Ingredients");

            entity.HasOne(d => d.Items).WithMany(p => p.ProductRecipes).HasConstraintName("FK_ProductRecipe_Items");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductRecipes).HasConstraintName("FK_ProductRecipe_Product");

            entity.HasOne(d => d.Unit).WithMany(p => p.ProductRecipes).HasConstraintName("FK_ProductRecipe_Units");
        });

        modelBuilder.Entity<ProductSalesHistoryPerDay>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<ProductsForEod>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Product).WithMany(p => p.ProductsForEods).HasConstraintName("FK_ProductsForEOD_Product");
        });

        modelBuilder.Entity<PromotionsCombo>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Header).WithMany(p => p.PromotionsCombos).HasConstraintName("FK_Promotions_Combos_Promotions_Headers");
        });

        modelBuilder.Entity<PromotionsDiscount>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Header).WithMany(p => p.PromotionsDiscounts).HasConstraintName("FK_Promotions_Discounts_Promotions_Headers");
        });

        modelBuilder.Entity<PromotionsHeader>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<PromotionsPricelist>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Pricelist).WithMany(p => p.PromotionsPricelists).HasConstraintName("FK_Promotions_Pricelists_Pricelist");
        });

        modelBuilder.Entity<Quantity>(entity =>
        {
            entity.HasOne(d => d.Pos).WithMany(p => p.Quantities).HasConstraintName("FK_Quantities_PosInfo");

            entity.HasOne(d => d.Product).WithMany(p => p.Quantities).HasConstraintName("FK_Quantities_Product");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.PosInfo).WithMany(p => p.Regions).HasConstraintName("FK_Region_PosInfo");
        });

        modelBuilder.Entity<RegionLockerProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.PosInfo).WithMany(p => p.RegionLockerProducts).HasConstraintName("FK_RegionLockerProduct_PosInfo");

            entity.HasOne(d => d.PriceList).WithMany(p => p.RegionLockerProducts).HasConstraintName("FK_RegionLockerProduct_Pricelist");

            entity.HasOne(d => d.Product).WithMany(p => p.RegionLockerProducts).HasConstraintName("FK_RegionLockerProduct_Product");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.ToView("Reports");
        });

        modelBuilder.Entity<ReportEntity>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.Url, "IX_ReportEntity")
                .IsUnique()
                .HasFillFactor(90);
        });

        modelBuilder.Entity<ReportList>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<SalesMothnly>(entity =>
        {
            entity.ToView("SalesMothnly");
        });

        modelBuilder.Entity<SalesType>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<SalesTypePricelistMasterAssoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.PricelistMaster).WithMany(p => p.SalesTypePricelistMasterAssocs)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SalesType_PricelistMaster_Assoc_PricelistMaster");

            entity.HasOne(d => d.SalesType).WithMany(p => p.SalesTypePricelistMasterAssocs)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SalesType_PricelistMaster_Assoc_SalesType_PricelistMaster_Assoc");
        });

        modelBuilder.Entity<SelectionsForBox>(entity =>
        {
            entity.HasOne(d => d.MainProductForBox).WithMany(p => p.SelectionsForBoxes).HasConstraintName("FK_SelectionsForBox_MainProductForBox");
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_Personnel")
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.Code, e.Password }, "IX_Staff_Code_Pass").HasFillFactor(90);

            entity.Property(e => e.Identification).HasDefaultValue("");
        });

        modelBuilder.Entity<StaffAuthorization>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.AuthorizedGroup).WithMany(p => p.StaffAuthorizations).HasConstraintName("FK_StaffAuthorization_AuthorizedGroup");

            entity.HasOne(d => d.Staff).WithMany(p => p.StaffAuthorizations).HasConstraintName("FK_StaffAuthorization_Staff");
        });

        modelBuilder.Entity<StaffCash>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.EndOfDay).WithMany(p => p.StaffCashes).HasConstraintName("FK_StaffCash_EndOfDay");

            entity.HasOne(d => d.Staff).WithMany(p => p.StaffCashes).HasConstraintName("FK_StaffCash_Staff");
        });

        modelBuilder.Entity<StaffPosition>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<StaffSchedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Department).WithMany(p => p.StaffSchedules).HasConstraintName("FK_StaffSchedule_Department");
        });

        modelBuilder.Entity<StaffSecheduleDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Staff).WithMany(p => p.StaffSecheduleDetails).HasConstraintName("FK_StaffSecheduleDetails_Staff");

            entity.HasOne(d => d.StaffScedule).WithMany(p => p.StaffSecheduleDetails).HasConstraintName("FK_StaffSecheduleDetails_StaffSchedule");
        });

        modelBuilder.Entity<StatisticsMenu>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_SatisticsMenus")
                .HasFillFactor(90);

            entity.HasOne(d => d.ReportList).WithMany(p => p.StatisticsMenus).HasConstraintName("FK_SatisticsMenus_ReportList");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<StoreMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Store).WithMany(p => p.StoreMessages)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_StoreMessages_Store");
        });

        modelBuilder.Entity<StoreMessagesHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);
        });

        modelBuilder.Entity<StoreMessagesView>(entity =>
        {
            entity.ToView("StoreMessages_View");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<Table>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Region).WithMany(p => p.Tables)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Table_Region");
        });

        modelBuilder.Entity<TablePaySuggestion>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Account).WithMany(p => p.TablePaySuggestions)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TablePaySuggestion_Accounts");

            entity.HasOne(d => d.CreditCode).WithMany(p => p.TablePaySuggestions)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_TablePaySuggestion_CreditCodes");

            entity.HasOne(d => d.Guest).WithMany(p => p.TablePaySuggestions)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TablePaySuggestion_Guest");

            entity.HasOne(d => d.OrderDetail).WithMany(p => p.TablePaySuggestions)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TablePaySuggestion_OrderDetail");
        });

        modelBuilder.Entity<TablePaySuggestionHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);
        });

        modelBuilder.Entity<TablePaySuggestionView>(entity =>
        {
            entity.ToView("TablePaySuggestion_View");
        });

        modelBuilder.Entity<Tax>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<TrCapacity>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.Property(e => e.Id).HasComment("Id Key Record");
            entity.Property(e => e.Capacity).HasComment("num of max customers");
            entity.Property(e => e.RestId).HasComment("TR_Restaurants.Id");
            entity.Property(e => e.Time).HasComment("Time ex: 23:30");
            entity.Property(e => e.Type).HasComment("0:AllDay,1:Lunch,2:Dinner");

            entity.HasOne(d => d.Rest).WithMany(p => p.TrCapacities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TR_Capacities_TR_Restaurants");
        });

        modelBuilder.Entity<TrConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.DefaultHotel).WithMany(p => p.TrConfigs).HasConstraintName("FK_TR_Config_HotelInfo");
        });

        modelBuilder.Entity<TrExcludeDay>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.Property(e => e.Id).HasComment("Id Record key");
            entity.Property(e => e.Date).HasComment("Date of Unavailability");
            entity.Property(e => e.RestId).HasComment("TR_Restaurants.Id");
            entity.Property(e => e.Type).HasComment("0:AllDay,1:Lunch,2:Dinner");

            entity.HasOne(d => d.Rest).WithMany(p => p.TrExcludeDays)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TR_ExcludeDays_TR_Restaurants");
        });

        modelBuilder.Entity<TrExcludeRestriction>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => new { e.RestRestrictAssocId, e.Date }, "PK_TR_ExcludeRestrictions_Unique")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.RestId, e.RestRestrictAssocId, e.Date }, "TR_ExcludeRestrictions_Unique2")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id).HasComment("Id Record key");
            entity.Property(e => e.RestId).HasComment("TR_Restaurants.Id");

            entity.HasOne(d => d.Rest).WithMany(p => p.TrExcludeRestrictions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TR_ExcludeRestrictions_TR_Restaurants");

            entity.HasOne(d => d.RestRestrictAssoc).WithMany(p => p.TrExcludeRestrictions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TR_ExcludeRestrictions_TR_Restrictions_Restaurants_Assoc");
        });

        modelBuilder.Entity<TrOvewrittenCapacity>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => new { e.RestId, e.Date, e.CapacityId }, "PK_TR_OvewrittenCapacities_Unique")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id).HasComment("Id Record key");
            entity.Property(e => e.Capacity).HasComment("num of max customers");
            entity.Property(e => e.CapacityId).HasComment("TR_Capacities.Id");
            entity.Property(e => e.Date).HasComment("Date of overwrite");
            entity.Property(e => e.RestId).HasComment("TR_Restaurants.Id");

            entity.HasOne(d => d.CapacityNavigation).WithMany(p => p.TrOvewrittenCapacities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TR_OvewrittenCapacities_TR_Capacities");

            entity.HasOne(d => d.Rest).WithMany(p => p.TrOvewrittenCapacities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TR_OvewrittenCapacities_TR_Restaurants");
        });

        modelBuilder.Entity<TrReservation>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.Property(e => e.Id).HasComment("Id record key");
            entity.Property(e => e.CapacityId).HasComment("TR_Capacities.Id");
            entity.Property(e => e.Couver).HasComment("Num of people");
            entity.Property(e => e.ReservationDate).HasComment("Reservation Date");
            entity.Property(e => e.ReservationTime).HasComment("TR_Capacities.Time");
            entity.Property(e => e.RestId).HasComment("TR_Restaurants.Id");
            entity.Property(e => e.Status).HasComment("0: Active, 1: Cancel");

            entity.HasOne(d => d.Capacity).WithMany(p => p.TrReservations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TR_Reservations_TR_Capacities");
        });

        modelBuilder.Entity<TrReservationCustomer>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.ReservationId, "PK_TR_ReservationCustomers_ReservationId").HasFillFactor(90);

            entity.Property(e => e.Id).HasComment("Id Record Key");
            entity.Property(e => e.Email).HasComment("email (encrypted)");
            entity.Property(e => e.ProtelId).HasComment("Protel Profile Id");
            entity.Property(e => e.ProtelName).HasComment("ProtelName (encrypted)");
            entity.Property(e => e.ReservationId).HasComment("TR_Reservations.Id");
            entity.Property(e => e.ReservationName).HasComment("Name given by the customer (encrypted)");
            entity.Property(e => e.RoomNum).HasComment("Room number");

            entity.HasOne(d => d.Hotel).WithMany(p => p.TrReservationCustomers).HasConstraintName("FK_TR_ReservationCustomers_HotelInfo");

            entity.HasOne(d => d.Reservation).WithMany(p => p.TrReservationCustomers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TR_ReservationCustomers_TR_Reservations");
        });

        modelBuilder.Entity<TrReservationType>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<TrRestaurant>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<TrRestriction>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("HardCode Id");
        });

        modelBuilder.Entity<TrRestrictionsRestaurantsAssoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => new { e.RestId, e.RestrictId }, "PK__Restrictions_Restaurants_Assoc_Unique")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id).HasComment("Id Record key");
            entity.Property(e => e.N).HasComment("Restriction number");
            entity.Property(e => e.RestId).HasComment("TR_Restaurants.Id");
            entity.Property(e => e.RestrictId).HasComment("TR_Restrictions.Id");

            entity.HasOne(d => d.Rest).WithMany(p => p.TrRestrictionsRestaurantsAssocs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TR_Restrictions_Restaurants_Assoc_TR_Restaurants");

            entity.HasOne(d => d.Restrict).WithMany(p => p.TrRestrictionsRestaurantsAssocs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TR_Restrictions_Restaurants_Assoc_TR_Restrictions");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => e.EndOfDayId, "IX_EndOfDayId").HasFillFactor(90);

            entity.HasIndex(e => new { e.EndOfDayId, e.PosInfoId }, "IX_Transactions_EndOfDayId_PosInfoId").HasFillFactor(90);

            entity.HasIndex(e => new { e.PosInfoId, e.TransactionType, e.EndOfDayId }, "PosInfoIdTransactionTypeEndOfDayId_IDX").HasFillFactor(90);

            entity.HasIndex(e => e.InvoicesId, "TransactionInvoiceId_IDX").HasFillFactor(90);

            entity.HasIndex(e => new { e.AccountId, e.InvoicesId, e.IsDeleted }, "TransactionsAccountIdInvoicesIdIsDeleted_IDX").HasFillFactor(90);

            entity.HasIndex(e => new { e.InvoicesId, e.IsDeleted }, "TransactionsInvoicesIdIsDeleted_IDX").HasFillFactor(90);

            entity.HasIndex(e => new { e.InvoicesId, e.IsDeleted, e.Id, e.AccountId, e.PosInfoId }, "_dta_index_Transactions_116_1442104178__K18_K19_K1_K10_K3_6_7_16").HasFillFactor(90);

            entity.HasIndex(e => new { e.InvoicesId, e.Id, e.AccountId, e.PosInfoId, e.IsDeleted }, "_dta_index_Transactions_6_706101556__K18_K1_K10_K3_K19_6_7_16").HasFillFactor(90);

            entity.HasIndex(e => new { e.AccountId, e.IsDeleted, e.PosInfoId, e.Id }, "_dta_index_Transactions_9_290100074__K10_K19_K3_K1_6_7_16_18").HasFillFactor(90);

            entity.HasOne(d => d.Account).WithMany(p => p.Transactions).HasConstraintName("FK_Transactions_Accounts");

            entity.HasOne(d => d.Department).WithMany(p => p.Transactions).HasConstraintName("FK_Transactions_Department");

            entity.HasOne(d => d.EndOfDay).WithMany(p => p.Transactions).HasConstraintName("FK_dbo.Transactions_dbo.EndOfDay_EndOfDayId");

            entity.HasOne(d => d.Invoices).WithMany(p => p.Transactions).HasConstraintName("FK_Transactions_Invoices");

            entity.HasOne(d => d.Order).WithMany(p => p.Transactions).HasConstraintName("FK_Transactions_Order");

            entity.HasOne(d => d.PosInfo).WithMany(p => p.Transactions)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Transactions_PosInfo");

            entity.HasOne(d => d.Staff).WithMany(p => p.Transactions).HasConstraintName("FK_Transactions_Staff");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Transactions).HasConstraintName("FK_Transactions_Suppliers");
        });

        modelBuilder.Entity<TransactionType>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<TransactionsHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.AccountId, e.IsDeleted, e.PosInfoId }, "IX_Hist_Year_Acc_Del_Pos").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.AccountId, e.InvoicesId, e.IsDeleted }, "IX_Hist_Year_Acc_Inv_Del").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.EndOfDayId }, "IX_Hist_Year_EndOfDayId").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.InvoicesId }, "IX_Hist_Year_Inv").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.InvoicesId, e.AccountId, e.PosInfoId, e.IsDeleted }, "IX_Hist_Year_Inv_Acc_Pos_Del").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.InvoicesId, e.IsDeleted }, "IX_Hist_Year_Inv_Del").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.InvoicesId, e.IsDeleted, e.AccountId, e.PosInfoId }, "IX_Hist_Year_Inv_Del_Acc_Pos").HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.PosInfoId, e.TransactionType, e.EndOfDayId }, "IX_Hist_Year_Pos_Transac_EOD").HasFillFactor(90);
        });

        modelBuilder.Entity<TransactionsView>(entity =>
        {
            entity.ToView("Transactions_View");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TransferMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.PosDepartment).WithMany(p => p.TransferMappings).HasConstraintName("FK_TransferMappings_Department");

            entity.HasOne(d => d.PriceList).WithMany(p => p.TransferMappings).HasConstraintName("FK_TransferMappings_Pricelist");

            entity.HasOne(d => d.ProductCategory).WithMany(p => p.TransferMappings).HasConstraintName("FK_TransferMappings_ProductCategories");

            entity.HasOne(d => d.Product).WithMany(p => p.TransferMappings).HasConstraintName("FK_TransferMappings_Product1");

            entity.HasOne(d => d.SalesType).WithMany(p => p.TransferMappings).HasConstraintName("FK_TransferMappings_SalesType1");
        });

        modelBuilder.Entity<TransferMappingDetail>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_dbo.TransferMappingDetails")
                .HasFillFactor(90);

            entity.HasIndex(e => e.TransferMappingsId, "IX_TransferMappingsId").HasFillFactor(90);

            entity.HasOne(d => d.TransferMappings).WithMany(p => p.TransferMappingDetails).HasConstraintName("FK_dbo.TransferMappingDetails_dbo.TransferMappings_TransferMappingsId");
        });

        modelBuilder.Entity<TransferMappingDetailsHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id })
                .HasName("PK_dbo.TransferMappingDetails_Hist")
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.TransferMappingsId }, "IX_Hist_Year_TransfMap").HasFillFactor(90);
        });

        modelBuilder.Entity<TransferMappingsHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);
        });

        modelBuilder.Entity<TransferToPm>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable(tb => tb.HasTrigger("date_udpdate"));

            entity.HasIndex(e => e.EndOfDayId, "IX_EndOfDayId").HasFillFactor(90);

            entity.HasIndex(e => new { e.EndOfDayId, e.PosInfoId }, "IX_TransferToPms_EndOfDayId_PosInfoId").HasFillFactor(90);

            entity.Property(e => e.TransferType).HasComment("0-Xrewstiko, 1-endOfDay");

            entity.HasOne(d => d.EndOfDay).WithMany(p => p.TransferToPms).HasConstraintName("FK_dbo.TransferToPms_dbo.EndOfDay_EndOfDayId");

            entity.HasOne(d => d.Transaction).WithMany(p => p.TransferToPms)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TransferToPms_Transactions");
        });

        modelBuilder.Entity<TransferToPmsHist>(entity =>
        {
            entity.HasKey(e => new { e.NYear, e.Id }).HasFillFactor(90);

            entity.HasIndex(e => new { e.NYear, e.EndOfDayId }, "IX_Hist_Year_EOD_ID").HasFillFactor(90);
        });

        modelBuilder.Entity<TransferToPmsLastId>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<TransferToPmsView>(entity =>
        {
            entity.ToView("TransferToPms_View");
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<ValidModule>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.Property(e => e.ModuleType).HasComment("Enum for \nPOS\nKDS\nTABLES\nDELIVERY");
        });

        modelBuilder.Entity<Vat>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<Version>(entity =>
        {
            entity.HasKey(e => e.Version1).HasFillFactor(90);
        });

        modelBuilder.Entity<ViewDispatchPoint>(entity =>
        {
            entity.ToView("View_DispatchPoints");
        });

        modelBuilder.Entity<ViewRpt01InvoiceHeader>(entity =>
        {
            entity.ToView("VIEW_RPT01_InvoiceHeader");
        });

        modelBuilder.Entity<ViewRpt01InvoiceHeaderReport>(entity =>
        {
            entity.ToView("VIEW_RPT01_InvoiceHeader_Report");
        });

        modelBuilder.Entity<ViewRpt02InvoiceProduct>(entity =>
        {
            entity.ToView("VIEW_RPT02_InvoiceProducts");
        });

        modelBuilder.Entity<ViewRpt03InvoiceExtra>(entity =>
        {
            entity.ToView("VIEW_RPT03_InvoiceExtras");
        });

        modelBuilder.Entity<ViewRpt04InvoicePayment>(entity =>
        {
            entity.ToView("VIEW_RPT04_InvoicePayments");
        });

        modelBuilder.Entity<ViewRpt05InvoicePaymentsGuest>(entity =>
        {
            entity.ToView("VIEW_RPT05_InvoicePaymentsGuest");
        });

        modelBuilder.Entity<ViewRpt06InvoiceRelatedReceipt>(entity =>
        {
            entity.ToView("VIEW_RPT06_InvoiceRelatedReceipts");
        });

        modelBuilder.Entity<ViewRpt07InvoiceSalesType>(entity =>
        {
            entity.ToView("VIEW_RPT07_InvoiceSalesTypes");
        });

        modelBuilder.Entity<ViewRpt08InvoiceRemark>(entity =>
        {
            entity.ToView("VIEW_RPT08_InvoiceRemarks");
        });

        modelBuilder.Entity<ViewRpt09PrintZXMaster>(entity =>
        {
            entity.ToView("VIEW_RPT09_PrintZ_X_Master");
        });

        modelBuilder.Entity<ViewRpt10PrintZXPaymentAnalysis>(entity =>
        {
            entity.ToView("VIEW_RPT10_PrintZ_X_PaymentAnalysis");
        });

        modelBuilder.Entity<ViewRpt11PrintZXVatsAnalysis>(entity =>
        {
            entity.ToView("VIEW_RPT11_PrintZ_X_VatsAnalysis");
        });

        modelBuilder.Entity<ViewRpt12PrintZXVoidsAnalysis>(entity =>
        {
            entity.ToView("VIEW_RPT12_PrintZ_X_VoidsAnalysis");
        });

        modelBuilder.Entity<ViewRpt13PrintZXCardsAnalysis>(entity =>
        {
            entity.ToView("VIEW_RPT13_PrintZ_X_CardsAnalysis");
        });

        modelBuilder.Entity<ViewRpt14PrintZXLocker>(entity =>
        {
            entity.ToView("VIEW_RPT14_PrintZ_X_Lockers");
        });

        modelBuilder.Entity<ViewRpt15PrintZXInvoicesAnalisi>(entity =>
        {
            entity.ToView("VIEW_RPT15_PrintZ_X_InvoicesAnalisis");
        });

        modelBuilder.Entity<ViewRpt15PrintZXInvoicesAnalysis>(entity =>
        {
            entity.ToView("VIEW_RPT15_PrintZ_X_InvoicesAnalysis");
        });

        modelBuilder.Entity<ViewRpt16PrintZXInvoiceTypeAnalisi>(entity =>
        {
            entity.ToView("VIEW_RPT16_PrintZ_X_InvoiceTypeAnalisis");
        });

        modelBuilder.Entity<ViewRpt16PrintZXInvoiceTypeAnalysis>(entity =>
        {
            entity.ToView("VIEW_RPT16_PrintZ_X_InvoiceTypeAnalysis");
        });

        modelBuilder.Entity<ViewSimpleDriversReceip>(entity =>
        {
            entity.ToView("View_SimpleDriversReceips");
        });

        modelBuilder.Entity<ViewSimpleTameio>(entity =>
        {
            entity.ToView("View_SimpleTameio");
        });

        modelBuilder.Entity<Vodafone11Detail>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<Vodafone11Header>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);
        });

        modelBuilder.Entity<WebReport>(entity =>
        {
            entity.ToView("WebReports");

            entity.Property(e => e.RecTime).UseCollation("Greek_CI_AI");
        });

        modelBuilder.Entity<WebReportsView>(entity =>
        {
            entity.ToView("WebReports_view");

            entity.Property(e => e.RecTime).UseCollation("Greek_CI_AI");
        });

        modelBuilder.Entity<WebReportsViewAll>(entity =>
        {
            entity.ToView("WebReports_view_all");

            entity.Property(e => e.RecTime).UseCollation("Greek_CI_AI");
        });

        modelBuilder.Entity<WebposreposTable>(entity =>
        {
            entity.Property(e => e.RecTime).UseCollation("Greek_CI_AI");
        });

        modelBuilder.Entity<WorkSheet>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasOne(d => d.Department).WithMany(p => p.WorkSheets).HasConstraintName("FK_WorkSheet_Department");

            entity.HasOne(d => d.Staff).WithMany(p => p.WorkSheets).HasConstraintName("FK_WorkSheet_Staff");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
