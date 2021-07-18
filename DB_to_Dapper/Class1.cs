using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
	[Dapper.Contrib.Extensions.Table("tblPlaceOstan")]
	public class tblPlaceOstan
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public string name { get; set; }
		public decimal IdPlaceCountry { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblRequestOperation")]
	public class tblRequestOperation
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdRequest { get; set; }
		public decimal IdRequestState { get; set; }
		public string SDateStart { get; set; }
		public string TimeStart { get; set; }
		public System.DateTime MDateStart { get; set; }
		public string SDateEnd { get; set; }
		public string TimeEnd { get; set; }
		public System.DateTime? MDateEnd { get; set; }
		public string UserName { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblVosoolOperations")]
	public class tblVosoolOperations
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdtblVosoolOperationType { get; set; }
		public decimal IdtblVosoolTalab { get; set; }
		public decimal? IdtblVosoolCallTypes { get; set; }
		public decimal IdCompanyPersonelsCallerOrVosool { get; set; }
		public decimal? IdtblCustomersPersonel { get; set; }
		public decimal? IdCompanyPersonelsPeygir { get; set; }
		public string Note { get; set; }
		public decimal? PricePaid { get; set; }
		public string TimeCall { get; set; }
		public string SDate { get; set; }
		public System.DateTime MDate { get; set; }
		public string SDateOperation { get; set; }
		public System.DateTime MDateOperation { get; set; }
		public string SDatePeygiri { get; set; }
		public System.DateTime? MDatePeygiri { get; set; }
		public System.DateTime CDate { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblUsersKind")]
	public class tblUsersKind
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public byte Id { get; set; }
		public string Name { get; set; }
		public decimal Olaviyat { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblWebService")]
	public class tblWebService
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdDasti { get; set; }
		public string Name { get; set; }
		public decimal IdWebServiceBaseURL { get; set; }
		public string Desc { get; set; }
		public string Parameters { get; set; }
		public string ResultValues { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblSex")]
	public class tblSex
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblCustomersBackup_Install")]
	public class tblCustomersBackup_Install
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdCustomersBackup { get; set; }
		public decimal IdCustomersPersonel { get; set; }
		public System.DateTime MDTInstall { get; set; }
		public string SDTInstall { get; set; }
		public string Version { get; set; }
		public string Name { get; set; }
		public string IP { get; set; }
		public string Desc { get; set; }
		public decimal IdCustomersBackup_Type { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblUsersKindGroup")]
	public class tblUsersKindGroup
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public string Name { get; set; }
		public byte IdKindUser { get; set; }
		public decimal? IdParent { get; set; }
		public byte Olaviyat { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblIsActive")]
	public class tblIsActive
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblRequestOperation_CompanyPersonels")]
	public class tblRequestOperation_CompanyPersonels
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdRequestOperation { get; set; }
		public decimal IdCompanyPersonels { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblUsersLevel")]
	public class tblUsersLevel
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public string Name { get; set; }
		public decimal LevelNo { get; set; }
		public bool IsDefault { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblTempActivity")]
	public class tblTempActivity
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdSoftware { get; set; }
		public string UserName { get; set; }
		public string SDate { get; set; }
		public System.DateTime MDate { get; set; }
		public decimal IdTempActivityGroup { get; set; }
		public decimal IdTempActivityOperation { get; set; }
		public string DescAll { get; set; }
		public string ComputerName { get; set; }
		public string IpAddress { get; set; }
		public System.DateTime MDateSe { get; set; }
		public string MTimeSe { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("TblProductsGroup")]
	public class TblProductsGroup
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public string IdS { get; set; }
		public string Name { get; set; }
		public decimal IdProductsGroupProducer { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblSarnakh")]
	public class tblSarnakh
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdCustomers { get; set; }
		public decimal IdCustomersPersonel { get; set; }
		public decimal IdSarnakhCustomerType { get; set; }
		public decimal IdNoeAshnaeai { get; set; }
		public decimal IdBazaryab { get; set; }
		public decimal IdBazaryabiPriceType { get; set; }
		public string NoteBazaryabiPrice { get; set; }
		public decimal IdNoeFaaliyateSherkat { get; set; }
		public decimal PersonelCount { get; set; }
		public string UserName { get; set; }
		public decimal IdCompanyPersonels { get; set; }
		public decimal IdSarnakhState { get; set; }
		public string Note { get; set; }
		public string SDate { get; set; }
		public System.DateTime MDate { get; set; }
		public System.DateTime CDate { get; set; }
		public decimal IdSarnakhCurrentSoftwareState { get; set; }
		public string SarnakhProducts_Desc_1 { get; set; }
		public string SarnakhProducts_Desc_2 { get; set; }
		public string SarnakhProducts_Desc_3 { get; set; }
		public decimal IdSarnakhStateNextOperation { get; set; }
		public decimal IdLastSarnakhOperationType { get; set; }
		public string SCDateLastSarnakhOperation { get; set; }
		public System.DateTime MCDateLastSarnakhOperation { get; set; }
		public string SDateNextOperation { get; set; }
		public System.DateTime MDateNextOperation { get; set; }
		public string SDateNextOperationLastSarnakhOperation { get; set; }
		public System.DateTime MDateNextOperationLastSarnakhOperation { get; set; }
		public decimal IdCompanyPersonelsLastSarnakhOperation { get; set; }
		public decimal IdLastSarnakhState { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblNoeAshnaeai")]
	public class tblNoeAshnaeai
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdDasti { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblProduct")]
	public class tblProduct
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public string IdNO { get; set; }
		public string Name { get; set; }
		public decimal IdProductsGroup { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblDesignOfGridDialog")]
	public class tblDesignOfGridDialog
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public string KeyName { get; set; }
		public string UserName { get; set; }
		public byte[] FXML_SaveDesign { get; set; }
		public byte[] FXML_SaveClmNotVisible { get; set; }
		public byte[] FXML_SaveDesignWidth { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblNahvePaygiri")]
	public class tblNahvePaygiri
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdDasti { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblTaskState")]
	public class tblTaskState
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblTempActivityGroup")]
	public class tblTempActivityGroup
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblTask")]
	public class tblTask
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdDasti { get; set; }
		public decimal IdCompanyPersonels { get; set; }
		public decimal IdCompanyPersonelsPeygiri { get; set; }
		public decimal IdTaskState { get; set; }
		public string Note { get; set; }
		public string SDate { get; set; }
		public System.DateTime MDate { get; set; }
		public string SDateStart { get; set; }
		public System.DateTime MDateStart { get; set; }
		public string SDateMohlat { get; set; }
		public System.DateTime MDateMohlat { get; set; }
		public string SDatePeygiriFromPeygiri { get; set; }
		public System.DateTime MDatePeygiriFromPeygiri { get; set; }
		public System.DateTime CDate { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblCompanyPersonels")]
	public class tblCompanyPersonels
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public string IdNO { get; set; }
		public decimal IdSex { get; set; }
		public string Name { get; set; }
		public string LName { get; set; }
		public string Desc { get; set; }
		public bool IsActive { get; set; }
		public string UserName { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblAmeleEtmamBedoneForoosh")]
	public class tblAmeleEtmamBedoneForoosh
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdDasti { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblVersionChangeDesc")]
	public class tblVersionChangeDesc
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdSoftware { get; set; }
		public string Version { get; set; }
		public string SDate { get; set; }
		public string Subject { get; set; }
		public string Detail { get; set; }
		public bool InAllSoftware { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblTaskPeygiri")]
	public class tblTaskPeygiri
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdTask { get; set; }
		public decimal IdCompanyPersonels { get; set; }
		public decimal? IdCompanyPersonelsPeygiri { get; set; }
		public decimal IdTaskState { get; set; }
		public string Note { get; set; }
		public string SDate { get; set; }
		public System.DateTime MDate { get; set; }
		public string SDatePeygiri { get; set; }
		public System.DateTime? MDatePeygiri { get; set; }
		public System.DateTime CDate { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblNahvePaygiriPishFactor")]
	public class tblNahvePaygiriPishFactor
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdDasti { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblTempActivityOperation")]
	public class tblTempActivityOperation
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblAmeleTabdilShodanBeFactor")]
	public class tblAmeleTabdilShodanBeFactor
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdDasti { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblSaveCustomersProductsState")]
	public class tblSaveCustomersProductsState
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblCoPro")]
	public class tblCoPro
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string CName { get; set; }
		public string CNameAll { get; set; }
		public byte[] Arm { get; set; }
		public string RTopCenter { get; set; }
		public string RTopLeft { get; set; }
		public string RTopRight { get; set; }
		public string RDownCenter { get; set; }
		public string RDownLeft { get; set; }
		public string RDownRight { get; set; }
		public bool IsActive { get; set; }
		public bool IsArm { get; set; }
		public bool IsDate { get; set; }
		public bool IsPCount { get; set; }
		public string Tel { get; set; }
		public string Fox { get; set; }
		public string Address { get; set; }
		public string Web { get; set; }
		public string Email { get; set; }
		public string ShEghtesadi { get; set; }
		public string ShMeliOrSabt { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblSarnakhOperations")]
	public class tblSarnakhOperations
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdSarnakh { get; set; }
		public string SDate { get; set; }
		public System.DateTime MDate { get; set; }
		public System.DateTime CDate { get; set; }
		public string SCDate { get; set; }
		public decimal? IdNahvePaygiri { get; set; }
		public string Note { get; set; }
		public decimal IdCustomersPersonel { get; set; }
		public decimal IdCompanyPersonels { get; set; }
		public decimal IdSarnakhState { get; set; }
		public decimal? IdAmeleEtmamBedoneForoosh { get; set; }
		public string SDateNextOperation { get; set; }
		public System.DateTime? MDateNextOperation { get; set; }
		public decimal? FactorNo { get; set; }
		public decimal? Price { get; set; }
		public decimal? Discount { get; set; }
		public decimal? PriceAfterDiscount { get; set; }
		public decimal? Tax { get; set; }
		public decimal? TotallPrice { get; set; }
		public decimal? IdNahvePaygiriPishFactor { get; set; }
		public decimal? IdAmeleTabdilShodanBeFactor { get; set; }
		public string UserName { get; set; }
		public decimal IdSarnakhOperationType { get; set; }
		public string SDateFactor { get; set; }
		public System.DateTime? MDateFactor { get; set; }
		public decimal? IdSarnakhSalesType { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblPlaceCity")]
	public class tblPlaceCity
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public string Name { get; set; }
		public decimal IdPlaceOstan { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblNarmAfzarhayeHamkar")]
	public class tblNarmAfzarhayeHamkar
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdDasti { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblCustomersKind")]
	public class tblCustomersKind
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public string IdDasti { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblCustomersBackup_Esteghrar")]
	public class tblCustomersBackup_Esteghrar
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdCustomersBackup { get; set; }
		public decimal IdCustomersPersonel { get; set; }
		public decimal IdSaveCustomersProducts_Products { get; set; }
		public System.DateTime MDTEsteghrar { get; set; }
		public string SDTEsteghrar { get; set; }
		public string Desc { get; set; }
		public decimal IdCustomersBackup_Type { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblLockState")]
	public class tblLockState
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblCustomersState")]
	public class tblCustomersState
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblNoeFaaliyateSherkat")]
	public class tblNoeFaaliyateSherkat
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdDasti { get; set; }
		public string Name { get; set; }
		public decimal? IdParent { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblCustomers")]
	public class tblCustomers
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public string IdS { get; set; }
		public decimal IdCustomersType { get; set; }
		public decimal IdCustomersState { get; set; }
		public decimal IdPlaceCity { get; set; }
		public decimal IdSex { get; set; }
		public string ComapnyName { get; set; }
		public string Name { get; set; }
		public string LName { get; set; }
		public string Address { get; set; }
		public string Tel { get; set; }
		public string Mobile { get; set; }
		public string Fax { get; set; }
		public string WebSite { get; set; }
		public string Email { get; set; }
		public string UserName { get; set; }
		public string UserNameE { get; set; }
		public System.DateTime MDate { get; set; }
		public System.DateTime MDateU { get; set; }
		public string MTime { get; set; }
		public string MTimeU { get; set; }
		public decimal IdCustomersKind { get; set; }
		public decimal IdCustomersStatus { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblCustomersBackupQueueSabtType")]
	public class tblCustomersBackupQueueSabtType
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblSaveCustomersProducts_Products")]
	public class tblSaveCustomersProducts_Products
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdSaveCustomersProducts { get; set; }
		public decimal IdProduct { get; set; }
		public decimal UserCount { get; set; }
		public string SSDate { get; set; }
		public string SEDate { get; set; }
		public System.DateTime? MSDate { get; set; }
		public System.DateTime? MEDate { get; set; }
		public decimal IdSaveCustomersProductsState { get; set; }
		public string Note { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblCustomersBackup_Other")]
	public class tblCustomersBackup_Other
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdCustomersBackup { get; set; }
		public decimal IdCustomersPersonel { get; set; }
		public System.DateTime MDTOther { get; set; }
		public string SDTOther { get; set; }
		public string Desc { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblUserPermissionsTempelete")]
	public class tblUserPermissionsTempelete
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdUserKindGroup { get; set; }
		public string MenuName { get; set; }
		public bool Permitted { get; set; }
		public bool MNew { get; set; }
		public bool MEdit { get; set; }
		public bool MDel { get; set; }
		public decimal IdSoftware { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblPathSoftware")]
	public class tblPathSoftware
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public string UserName { get; set; }
		public string Path { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblSarnakhProducts")]
	public class tblSarnakhProducts
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdSarnakh { get; set; }
		public decimal IdProduct { get; set; }
		public decimal IdSarnakhProductStateType { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblSMSDetail")]
	public class tblSMSDetail
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public string Tel { get; set; }
		public string DescSend { get; set; }
		public System.DateTime MDtSend { get; set; }
		public string SDtSend { get; set; }
		public string TimeSend { get; set; }
		public string ResultSend { get; set; }
		public bool IsSend { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblCustomersBackup_Type")]
	public class tblCustomersBackup_Type
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblRequestType")]
	public class tblRequestType
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblSotooh")]
	public class tblSotooh
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
		public decimal Len { get; set; }
		public decimal LenDetail { get; set; }
		public decimal Tab { get; set; }
		public string MenuMainName { get; set; }
		public string MenuName { get; set; }
		public string MenuDetailName { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("UserPermissions")]
	public class UserPermissions
	{
		public string UserName { get; set; }
		public string MenuName { get; set; }
		public bool Permitted { get; set; }
		public bool MNew { get; set; }
		public bool MEdit { get; set; }
		public bool MDel { get; set; }
		public decimal IdSoftware { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblRequestState")]
	public class tblRequestState
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblSaveCustomersProducts")]
	public class tblSaveCustomersProducts
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdCustomers { get; set; }
		public string LockNo { get; set; }
		public string SSDGaranti { get; set; }
		public System.DateTime MSDGaranti { get; set; }
		public string SEDGaranti { get; set; }
		public System.DateTime MEDGaranti { get; set; }
		public decimal UserNo { get; set; }
		public decimal IdLockState { get; set; }
		public string DescLock { get; set; }
		public decimal IdtblLocks { get; set; }
		public string SSDSave { get; set; }
		public System.DateTime MSDSave { get; set; }
		public string SSDDeActive { get; set; }
		public System.DateTime? MSDDeActive { get; set; }
		public string UserName { get; set; }
		public string UserNameE { get; set; }
		public System.DateTime CDate { get; set; }
		public string CTime { get; set; }
		public System.DateTime UDate { get; set; }
		public string UTime { get; set; }
		public string Note { get; set; }
		public decimal IdSaveCustomersProducts_RegisterState { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblRequestDetailsType")]
	public class tblRequestDetailsType
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblTafsilyGroup")]
	public class tblTafsilyGroup
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public string Id { get; set; }
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal IdSotooh { get; set; }
		public string Name { get; set; }
		public string UserName { get; set; }
		public System.DateTime MDate { get; set; }
		public string SDate { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblCustomersBackup_Bak")]
	public class tblCustomersBackup_Bak
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdCustomersBackup { get; set; }
		public decimal IdCustomersPersonel { get; set; }
		public decimal IdSaveCustomersProducts_Products { get; set; }
		public System.DateTime MDTBak { get; set; }
		public string SDTBak { get; set; }
		public string Name { get; set; }
		public string Version { get; set; }
		public string IP { get; set; }
		public string IdCompany { get; set; }
		public string DescDestroy { get; set; }
		public string DescService { get; set; }
		public decimal IdCustomersBackup_Type { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblRequest")]
	public class tblRequest
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal Ids { get; set; }
		public string SDate { get; set; }
		public System.DateTime MDate { get; set; }
		public decimal IdProduct { get; set; }
		public decimal IdRequestState { get; set; }
		public string Time { get; set; }
		public byte[] AttachedFile { get; set; }
		public string AttachedFileName { get; set; }
		public decimal IdRequestType { get; set; }
		public decimal IdCompanyPersonels { get; set; }
		public string DESC { get; set; }
		public string UserName { get; set; }
		public string UserNameE { get; set; }
		public string DescTaeidRequestState { get; set; }
		public bool IsDeleted { get; set; }
		public System.DateTime CDate { get; set; }
		public string CTime { get; set; }
		public System.DateTime UDate { get; set; }
		public string UTime { get; set; }
		public decimal IdRequestGroup { get; set; }
		public string CustomersList { get; set; }
		public string SDateTahvilBeMoshtari { get; set; }
		public System.DateTime? MDateTahvilBeMoshtari { get; set; }
		public string UserNameTahvilBeMoshtari { get; set; }
		public decimal Ids2 { get; set; }
		public string CompanyPersonels_DarDasteEghdam { get; set; }
		public string SDateDarDasteEghdam { get; set; }
		public string TimeDarDasteEghdam { get; set; }
		public System.DateTime? MDateDarDasteEghdam { get; set; }
		public string UserNameDarDasteEghdam { get; set; }
		public string TimeTahvilBeMoshtari { get; set; }
		public string SDateTaeid { get; set; }
		public string TimeTaeid { get; set; }
		public System.DateTime? MDateTaeid { get; set; }
		public string UserNameTaeid { get; set; }
		public string SDateAmadeTest { get; set; }
		public string TimeAmadeTest { get; set; }
		public System.DateTime? MDateAmadeTest { get; set; }
		public string UserNameAmadeTest { get; set; }
		public string SDateEtmameTest { get; set; }
		public string TimeEtmameTest { get; set; }
		public System.DateTime? MDateEtmameTest { get; set; }
		public string UserNameEtmameTest { get; set; }
		public string SDateDarEntezareNoskhe { get; set; }
		public string TimeDarEntezareNoskhe { get; set; }
		public System.DateTime? MDateDarEntezareNoskhe { get; set; }
		public string UserNameDarEntezareNoskhe { get; set; }
		public string CompanyPersonels_DarVazeiateTest { get; set; }
		public string SDateDarVazeiateTest { get; set; }
		public string TimeDarVazeiateTest { get; set; }
		public System.DateTime? MDateDarVazeiateTest { get; set; }
		public string UserNameDarVazeiateTest { get; set; }
		public string DescNewVersionForWeb { get; set; }
		public string Version { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblBazaryab")]
	public class tblBazaryab
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdDasti { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblCustomersBackup_Convert_Type")]
	public class tblCustomersBackup_Convert_Type
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblBazaryabiPriceType")]
	public class tblBazaryabiPriceType
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblSal_MD")]
	public class tblSal_MD
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public string IdSal_MD_S { get; set; }
		public string IdPayMonth_MD_S { get; set; }
		public string Day_MD_S { get; set; }
		public string SSDate_MD { get; set; }
		public System.DateTime MSDate_MD { get; set; }
		public string IdSal_MD_E { get; set; }
		public string IdPayMonth_MD_E { get; set; }
		public string Day_MD_E { get; set; }
		public string SEDate_MD { get; set; }
		public System.DateTime MEDate_MD { get; set; }
		public bool IsActive_MD { get; set; }
		public string Desc_MD { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblCustomersBackup_Convert")]
	public class tblCustomersBackup_Convert
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdCustomersBackup { get; set; }
		public decimal IdCustomersPersonel { get; set; }
		public decimal IdSaveCustomersProducts_Products { get; set; }
		public decimal IdCustomersBackup_Convert_Type { get; set; }
		public decimal IdProduct { get; set; }
		public System.DateTime MDate { get; set; }
		public string SDate { get; set; }
		public string Note { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblCustomersStatus")]
	public class tblCustomersStatus
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblHardwareLocksState")]
	public class tblHardwareLocksState
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblCustomersBackup")]
	public class tblCustomersBackup
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdCustomers { get; set; }
		public decimal IdSaveCustomersProducts { get; set; }
		public decimal? ldCustomersContract { get; set; }
		public decimal? IdSaveCustomersContract { get; set; }
		public decimal IdCompanyPersonels { get; set; }
		public System.DateTime MDate { get; set; }
		public string SDate { get; set; }
		public System.DateTime MDateS { get; set; }
		public string SDateS { get; set; }
		public bool With_Install { get; set; }
		public bool IsPeigiri_Install { get; set; }
		public string Desc_Install { get; set; }
		public bool With_Edu { get; set; }
		public bool IsPeigiri_Edu { get; set; }
		public string Desc_Edu { get; set; }
		public bool With_Bak { get; set; }
		public bool IsPeigiri_Bak { get; set; }
		public string Desc_Bak { get; set; }
		public bool With_Esteghrar { get; set; }
		public bool IsPeigiri_Esteghrar { get; set; }
		public string Desc_Esteghrar { get; set; }
		public bool With_Other { get; set; }
		public bool IsPeigiri_Other { get; set; }
		public string Desc_Other { get; set; }
		public string UserName { get; set; }
		public string UserNameE { get; set; }
		public System.DateTime CDate { get; set; }
		public string CTime { get; set; }
		public System.DateTime UDate { get; set; }
		public string UTime { get; set; }
		public decimal? IdCustomersBackupQueue { get; set; }
		public bool With_Convert { get; set; }
		public bool IsPeigiri_Convert { get; set; }
		public string Desc_Convert { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblPayMonth_PaySal")]
	public class tblPayMonth_PaySal
	{
		[Dapper.Contrib.Extensions.Computed]
		public decimal Id { get; set; }
		[Dapper.Contrib.Extensions.ExplicitKey]
		public string IdPayMonth { get; set; }
		[Dapper.Contrib.Extensions.ExplicitKey]
		public string IdSal { get; set; }
		public bool IsActive { get; set; }
		public bool IsSelect { get; set; }
		public bool IsError { get; set; }
		public string Description { get; set; }
		public decimal IdPayMonth_PaySal_RavesheMohasebeheMaliyat { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblServicedCompany")]
	public class tblServicedCompany
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public string IdS { get; set; }
		public string CompanyName { get; set; }
		public string UserName { get; set; }
		public string UserNameE { get; set; }
		public System.DateTime MDate { get; set; }
		public System.DateTime MDateU { get; set; }
		public string MTime { get; set; }
		public string MTimeU { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblCustomersDegree")]
	public class tblCustomersDegree
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblSarnakhCurrentSoftwareState")]
	public class tblSarnakhCurrentSoftwareState
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblSarnakhCustomerType")]
	public class tblSarnakhCustomerType
	{
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblSarnakhProductStateType")]
	public class tblSarnakhProductStateType
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblCustomersBackup_Install_ApplicationSoftware")]
	public class tblCustomersBackup_Install_ApplicationSoftware
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdCustomersBackup_Install { get; set; }
		public decimal IdApplicationSoftware { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblRequest_Customers")]
	public class tblRequest_Customers
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdRequest { get; set; }
		public decimal IdCustomers { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblCustomersBackupQueueOperationType")]
	public class tblCustomersBackupQueueOperationType
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblSarnakhState")]
	public class tblSarnakhState
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblCustomersBackupQueueState")]
	public class tblCustomersBackupQueueState
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblVosoolBedehiType")]
	public class tblVosoolBedehiType
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblCustomersBackupQueue")]
	public class tblCustomersBackupQueue
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdQueue { get; set; }
		public string SDate { get; set; }
		public System.DateTime MDate { get; set; }
		public decimal IdCustomers { get; set; }
		public decimal? IdCustomersPersonel { get; set; }
		public decimal IdSaveCustomersProducts_Products { get; set; }
		public decimal IdCustomersBackupQueueOperationType { get; set; }
		public decimal IdCustomersBackupQueueState { get; set; }
		public string Tel { get; set; }
		public string DESC { get; set; }
		public string UserName { get; set; }
		public string UserNameE { get; set; }
		public System.DateTime CDate { get; set; }
		public string CTime { get; set; }
		public System.DateTime UDate { get; set; }
		public string UTime { get; set; }
		public string UserNameBackup { get; set; }
		public System.DateTime CDateBackup { get; set; }
		public string CTimeBackup { get; set; }
		public string UserNameSuspend { get; set; }
		public System.DateTime CDateSuspend { get; set; }
		public string CTimeSuspend { get; set; }
		public string UserNameInProgress { get; set; }
		public System.DateTime CDateInProgress { get; set; }
		public string CTimeInProgress { get; set; }
		public string SDateYadavari { get; set; }
		public System.DateTime? MDateYadavari { get; set; }
		public bool IsFromWeb { get; set; }
		public decimal? IdWebTicket { get; set; }
		public decimal IdCustomersBackupQueueSabtType { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblVersion")]
	public class tblVersion
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public decimal Version { get; set; }
		public string Desc { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblPhoneBook")]
	public class tblPhoneBook
	{
		[Dapper.Contrib.Extensions.Key]
		public int Id { get; set; }
		public string FName { get; set; }
		public string LName { get; set; }
		public string Department { get; set; }
		public string Degree { get; set; }
		public string Tel1 { get; set; }
		public string Tel2 { get; set; }
		public string Tel3 { get; set; }
		public string InternalTel { get; set; }
		public string Fax { get; set; }
		public string Mob1 { get; set; }
		public string Mob2 { get; set; }
		public string Address { get; set; }
		public string EMail { get; set; }
		public string WebSite { get; set; }
		public string Title { get; set; }
		public string Desc { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblVosoolContractState")]
	public class tblVosoolContractState
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblApplicationSoftware")]
	public class tblApplicationSoftware
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblVosoolTalabType")]
	public class tblVosoolTalabType
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblUsers")]
	public class tblUsers
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public string UserName { get; set; }
		public string FullName { get; set; }
		public string Description { get; set; }
		public string Password { get; set; }
		public bool State { get; set; }
		public bool IsAccess { get; set; }
		public bool canChangePass { get; set; }
		public string LastDateConnection { get; set; }
		public string LastDateDisConnection { get; set; }
		public decimal IdKindUserGroup { get; set; }
		public string ComputerIPOrName { get; set; }
		[Dapper.Contrib.Extensions.Computed]
		public decimal IdUserName_Identity { get; set; }
		public System.Guid IdUn { get; set; }
		public System.DateTime? ConnectUserDT { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblReportFiles")]
	public class tblReportFiles
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public string IdS { get; set; }
		public string Desc { get; set; }
		public byte[] Report { get; set; }
		public decimal IdSoftware { get; set; }
		public string UserName { get; set; }
		public string UserNameE { get; set; }
		public System.DateTime MDate { get; set; }
		public System.DateTime MDateE { get; set; }
		public string MSDate { get; set; }
		public string MSDateE { get; set; }
		public decimal DefaultIndex { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblSarnakhSalesType")]
	public class tblSarnakhSalesType
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblRequestDetails")]
	public class tblRequestDetails
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdRequest { get; set; }
		public decimal IdRequestDetailsType { get; set; }
		public decimal IdCompanyPersonels { get; set; }
		public string SDate { get; set; }
		public System.DateTime MDate { get; set; }
		public string Time { get; set; }
		public string DESC { get; set; }
		public string Version { get; set; }
		public byte[] AttachedFile { get; set; }
		public string AttachedFileName { get; set; }
		public bool IsDeleted { get; set; }
		public string UserName { get; set; }
		public string UserNameE { get; set; }
		public System.DateTime CDate { get; set; }
		public string CTime { get; set; }
		public System.DateTime UDate { get; set; }
		public string UTime { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblOneUserForSelectOtherOperation")]
	public class tblOneUserForSelectOtherOperation
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string UserName { get; set; }
		public string Description { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblCustomersType")]
	public class tblCustomersType
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblSaveActivateCode")]
	public class tblSaveActivateCode
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdtblLocks { get; set; }
		public string ComputerCode { get; set; }
		public string ActivatedCode { get; set; }
		public decimal IdtblLockState { get; set; }
		public string SDateInput { get; set; }
		public System.DateTime MDateInput { get; set; }
		public string SDateStart { get; set; }
		public System.DateTime MDateStart { get; set; }
		public string SDateEnd { get; set; }
		public System.DateTime MDateEnd { get; set; }
		public decimal IdtblSaveCustomersProducts { get; set; }
		public decimal IdCustomers { get; set; }
		public string DESC { get; set; }
		public string UserName { get; set; }
		public string UserNameE { get; set; }
		public System.DateTime MDate { get; set; }
		public System.DateTime MDateU { get; set; }
		public string MTime { get; set; }
		public string MTimeU { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblUserConnectDetails")]
	public class tblUserConnectDetails
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public System.Guid IdUn { get; set; }
		public string UserName { get; set; }
		public System.DateTime Mdate { get; set; }
		public string Desc { get; set; }
		public string ComputerIPOrName { get; set; }
		public decimal IdUserConnectDetailsType { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblContractType")]
	public class tblContractType
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblPayMonth")]
	public class tblPayMonth
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public string Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblCustomersContract")]
	public class tblCustomersContract
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdCustomers { get; set; }
		public string ContractNo { get; set; }
		public string SDtSave { get; set; }
		public System.DateTime MDtSave { get; set; }
		public string SStartDate { get; set; }
		public System.DateTime MStartDate { get; set; }
		public string SEndDate { get; set; }
		public System.DateTime MEndDate { get; set; }
		public decimal IdContractType { get; set; }
		public string UserName { get; set; }
		public string UserNameE { get; set; }
		public System.DateTime CDate { get; set; }
		public string CTime { get; set; }
		public System.DateTime UDate { get; set; }
		public string UTime { get; set; }
		public string SDateGharardad { get; set; }
		public System.DateTime MDateGharardad { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblPayMonth_PaySal_RavesheMohasebeheMaliyat")]
	public class tblPayMonth_PaySal_RavesheMohasebeheMaliyat
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblSaveCustomersContract")]
	public class tblSaveCustomersContract
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdSaveCustomersProducts { get; set; }
		public decimal IdCustomersContract { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblUserConnectDetailsType")]
	public class tblUserConnectDetailsType
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblRequestGroup")]
	public class tblRequestGroup
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public string Ids { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblSoftware")]
	public class tblSoftware
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblProductsGroupProducer")]
	public class tblProductsGroupProducer
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblLocks")]
	public class tblLocks
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public string LockNo { get; set; }
		public decimal IdtblServicedCompany { get; set; }
		public decimal IdtblHardWareLocksState { get; set; }
		public string UserName { get; set; }
		public string UserNameE { get; set; }
		public System.DateTime MDate { get; set; }
		public System.DateTime MDateU { get; set; }
		public string MTime { get; set; }
		public string MTimeU { get; set; }
		public string SDateEtebar { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblSal")]
	public class tblSal
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public string Id { get; set; }
		public System.DateTime StartDay { get; set; }
		public System.DateTime EndDay { get; set; }
		public bool IsActive { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblCustomersBackup_Edu")]
	public class tblCustomersBackup_Edu
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdCustomersBackup { get; set; }
		public decimal IdCustomersPersonel { get; set; }
		public decimal IdSaveCustomersProducts_Products { get; set; }
		public System.DateTime MDTEdu { get; set; }
		public string SDTEdu { get; set; }
		public decimal MMAmoozesh { get; set; }
		public decimal HHAmoozesh { get; set; }
		public string HHMMFormat { get; set; }
		public decimal MOnly { get; set; }
		public string Desc { get; set; }
		public decimal IdCustomersBackup_Type { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblEditorAccess")]
	public class tblEditorAccess
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		[Dapper.Contrib.Extensions.ExplicitKey]
		public string UserName { get; set; }
		[Dapper.Contrib.Extensions.ExplicitKey]
		public string FrmName { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblSaveCustomersProducts_RegisterState")]
	public class tblSaveCustomersProducts_RegisterState
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblUserPermissions_YadavariUsers")]
	public class tblUserPermissions_YadavariUsers
	{
		[Dapper.Contrib.Extensions.Computed]
		public decimal Id { get; set; }
		[Dapper.Contrib.Extensions.ExplicitKey]
		public string UserName { get; set; }
		[Dapper.Contrib.Extensions.ExplicitKey]
		public string UserNameOther { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblRequest_CompanyPersonels")]
	public class tblRequest_CompanyPersonels
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdRequest { get; set; }
		public decimal IdCompanyPersonels { get; set; }
		public decimal IdRequestState { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("dtproperties")]
	public class dtproperties
	{
		[Dapper.Contrib.Extensions.Key]
		public int id { get; set; }
		public int? objectid { get; set; }
		[Dapper.Contrib.Extensions.ExplicitKey]
		public string property { get; set; }
		public string value { get; set; }
		public string uvalue { get; set; }
		public byte[] lvalue { get; set; }
		public int version { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblVosoolCallTypes")]
	public class tblVosoolCallTypes
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdDasti { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblCustomize")]
	public class tblCustomize
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public bool ISEditableByName { get; set; }
		public string SharePathToDefault { get; set; }
		public bool MethodForGhatieIsSanadWithAccept { get; set; }
		public string UrlPath { get; set; }
		public decimal IdCustomizeCreateSanadType { get; set; }
		public bool IsKhalafeMahiatChecked { get; set; }
		public bool IsDescSanad { get; set; }
		public bool IsStartArtiklByMoein { get; set; }
		public string RTopCenter { get; set; }
		public string RTopLeft { get; set; }
		public string RTopRight { get; set; }
		public string RDownCenter { get; set; }
		public string RDownLeft { get; set; }
		public string RDownRight { get; set; }
		public bool IsUseMaxRows { get; set; }
		public decimal MaxRowsOfList { get; set; }
		public decimal RengeSeni_NozadVaKodak { get; set; }
		public string IdTafsilyGroup_Fot { get; set; }
		public decimal IdSotooh_Fot { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblVosoolStates")]
	public class tblVosoolStates
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblSarnakhOperationType")]
	public class tblSarnakhOperationType
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblCustomersPersonel")]
	public class tblCustomersPersonel
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdCustomers { get; set; }
		public decimal IdCustomersDegree { get; set; }
		public string Name { get; set; }
		public string LName { get; set; }
		public decimal IdSex { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblCustomersBackupQueueUsers")]
	public class tblCustomersBackupQueueUsers
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdCustomersBackupQueue { get; set; }
		public string UserName { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblVosoolOperationType")]
	public class tblVosoolOperationType
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblPlaceCountry")]
	public class tblPlaceCountry
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public string Name { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblUserPermissionToForm")]
	public class tblUserPermissionToForm
	{
		[Dapper.Contrib.Extensions.Computed]
		public decimal Id { get; set; }
		[Dapper.Contrib.Extensions.ExplicitKey]
		public string UserName { get; set; }
		[Dapper.Contrib.Extensions.ExplicitKey]
		public string FrmName { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblVosoolTalab")]
	public class tblVosoolTalab
	{
		[Dapper.Contrib.Extensions.Key]
		public decimal Id { get; set; }
		public decimal IdDasti { get; set; }
		public decimal IdCustomers { get; set; }
		public decimal IdCompanyPersonels { get; set; }
		public decimal IdCompanyPersonelsPeygiri { get; set; }
		public decimal IdVosoolStates { get; set; }
		public decimal Price { get; set; }
		public decimal PriceMandeh { get; set; }
		public string Note { get; set; }
		public string SDate { get; set; }
		public System.DateTime MDate { get; set; }
		public string SDatePeygiri { get; set; }
		public System.DateTime MDatePeygiri { get; set; }
		public string SDatePeygiriFromPeygiri { get; set; }
		public System.DateTime MDatePeygiriFromPeygiri { get; set; }
		public System.DateTime CDate { get; set; }
		public decimal IdVosoolTalabType { get; set; }
		public decimal IdVosoolBedehiType { get; set; }
		public decimal IdVosoolContractState { get; set; }
	}

	[Dapper.Contrib.Extensions.Table("tblWebServiceBaseURL")]
	public class tblWebServiceBaseURL
	{
		[Dapper.Contrib.Extensions.ExplicitKey]
		public decimal Id { get; set; }
		public string Name { get; set; }
		public string Desc { get; set; }
	}

}

