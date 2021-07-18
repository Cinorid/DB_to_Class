Imports System

Namespace Models
	<Dapper.Contrib.Extensions.Table("tblPlaceOstan")>
	Public Class PlaceOstan
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property name As String
		Public Property IdPlaceCountry As Decimal
	End Class

	<Dapper.Contrib.Extensions.Table("tblRequestOperation")>
	Public Class RequestOperation
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdRequest As Decimal
		Public Property IdRequestState As Decimal
		Public Property SDateStart As String
		Public Property TimeStart As String
		Public Property MDateStart As Date
		Public Property SDateEnd As String
		Public Property TimeEnd As String
		Public Property MDateEnd As Date?
		Public Property UserName As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblVosoolOperations")>
	Public Class VosoolOperations
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdtblVosoolOperationType As Decimal
		Public Property IdtblVosoolTalab As Decimal
		Public Property IdtblVosoolCallTypes As Decimal?
		Public Property IdCompanyPersonelsCallerOrVosool As Decimal
		Public Property IdtblCustomersPersonel As Decimal?
		Public Property IdCompanyPersonelsPeygir As Decimal?
		Public Property Note As String
		Public Property PricePaid As Decimal?
		Public Property TimeCall As String
		Public Property SDate As String
		Public Property MDate As Date
		Public Property SDateOperation As String
		Public Property MDateOperation As Date
		Public Property SDatePeygiri As String
		Public Property MDatePeygiri As Date?
		Public Property [CDate] As Date
	End Class

	<Dapper.Contrib.Extensions.Table("tblUsersKind")>
	Public Class UsersKind
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Byte
		Public Property Name As String
		Public Property Olaviyat As Decimal
	End Class

	<Dapper.Contrib.Extensions.Table("tblWebService")>
	Public Class WebService
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdDasti As Decimal
		Public Property Name As String
		Public Property IdWebServiceBaseURL As Decimal
		Public Property Desc As String
		Public Property Parameters As String
		Public Property ResultValues As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblSex")>
	Public Class tblSex
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblCustomersBackup_Install")>
	Public Class tblCustomersBackup_Install
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdCustomersBackup As Decimal
		Public Property IdCustomersPersonel As Decimal
		Public Property MDTInstall As Date
		Public Property SDTInstall As String
		Public Property Version As String
		Public Property Name As String
		Public Property IP As String
		Public Property Desc As String
		Public Property IdCustomersBackup_Type As Decimal
	End Class

	<Dapper.Contrib.Extensions.Table("tblUsersKindGroup")>
	Public Class tblUsersKindGroup
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property Name As String
		Public Property IdKindUser As Byte
		Public Property IdParent As Decimal?
		Public Property Olaviyat As Byte
	End Class

	<Dapper.Contrib.Extensions.Table("tblIsActive")>
	Public Class tblIsActive
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblRequestOperation_CompanyPersonels")>
	Public Class tblRequestOperation_CompanyPersonels
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdRequestOperation As Decimal
		Public Property IdCompanyPersonels As Decimal
	End Class

	<Dapper.Contrib.Extensions.Table("tblUsersLevel")>
	Public Class tblUsersLevel
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property Name As String
		Public Property LevelNo As Decimal
		Public Property IsDefault As Boolean
	End Class

	<Dapper.Contrib.Extensions.Table("tblTempActivity")>
	Public Class tblTempActivity
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdSoftware As Decimal
		Public Property UserName As String
		Public Property SDate As String
		Public Property MDate As Date
		Public Property IdTempActivityGroup As Decimal
		Public Property IdTempActivityOperation As Decimal
		Public Property DescAll As String
		Public Property ComputerName As String
		Public Property IpAddress As String
		Public Property MDateSe As Date
		Public Property MTimeSe As String
	End Class

	<Dapper.Contrib.Extensions.Table("TblProductsGroup")>
	Public Class TblProductsGroup
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdS As String
		Public Property Name As String
		Public Property IdProductsGroupProducer As Decimal
	End Class

	<Dapper.Contrib.Extensions.Table("tblSarnakh")>
	Public Class tblSarnakh
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdCustomers As Decimal
		Public Property IdCustomersPersonel As Decimal
		Public Property IdSarnakhCustomerType As Decimal
		Public Property IdNoeAshnaeai As Decimal
		Public Property IdBazaryab As Decimal
		Public Property IdBazaryabiPriceType As Decimal
		Public Property NoteBazaryabiPrice As String
		Public Property IdNoeFaaliyateSherkat As Decimal
		Public Property PersonelCount As Decimal
		Public Property UserName As String
		Public Property IdCompanyPersonels As Decimal
		Public Property IdSarnakhState As Decimal
		Public Property Note As String
		Public Property SDate As String
		Public Property MDate As Date
		Public Property [CDate] As Date
		Public Property IdSarnakhCurrentSoftwareState As Decimal
		Public Property SarnakhProducts_Desc_1 As String
		Public Property SarnakhProducts_Desc_2 As String
		Public Property SarnakhProducts_Desc_3 As String
		Public Property IdSarnakhStateNextOperation As Decimal
		Public Property IdLastSarnakhOperationType As Decimal
		Public Property SCDateLastSarnakhOperation As String
		Public Property MCDateLastSarnakhOperation As Date
		Public Property SDateNextOperation As String
		Public Property MDateNextOperation As Date
		Public Property SDateNextOperationLastSarnakhOperation As String
		Public Property MDateNextOperationLastSarnakhOperation As Date
		Public Property IdCompanyPersonelsLastSarnakhOperation As Decimal
		Public Property IdLastSarnakhState As Decimal
	End Class

	<Dapper.Contrib.Extensions.Table("tblNoeAshnaeai")>
	Public Class tblNoeAshnaeai
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdDasti As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblProduct")>
	Public Class tblProduct
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdNO As String
		Public Property Name As String
		Public Property IdProductsGroup As Decimal
	End Class

	<Dapper.Contrib.Extensions.Table("tblDesignOfGridDialog")>
	Public Class tblDesignOfGridDialog
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property KeyName As String
		Public Property UserName As String
		Public Property FXML_SaveDesign As Byte()
		Public Property FXML_SaveClmNotVisible As Byte()
		Public Property FXML_SaveDesignWidth As Byte()
	End Class

	<Dapper.Contrib.Extensions.Table("tblNahvePaygiri")>
	Public Class tblNahvePaygiri
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdDasti As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblTaskState")>
	Public Class tblTaskState
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblTempActivityGroup")>
	Public Class tblTempActivityGroup
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblTask")>
	Public Class tblTask
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdDasti As Decimal
		Public Property IdCompanyPersonels As Decimal
		Public Property IdCompanyPersonelsPeygiri As Decimal
		Public Property IdTaskState As Decimal
		Public Property Note As String
		Public Property SDate As String
		Public Property MDate As Date
		Public Property SDateStart As String
		Public Property MDateStart As Date
		Public Property SDateMohlat As String
		Public Property MDateMohlat As Date
		Public Property SDatePeygiriFromPeygiri As String
		Public Property MDatePeygiriFromPeygiri As Date
		Public Property [CDate] As Date
	End Class

	<Dapper.Contrib.Extensions.Table("tblCompanyPersonels")>
	Public Class tblCompanyPersonels
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdNO As String
		Public Property IdSex As Decimal
		Public Property Name As String
		Public Property LName As String
		Public Property Desc As String
		Public Property IsActive As Boolean
		Public Property UserName As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblAmeleEtmamBedoneForoosh")>
	Public Class tblAmeleEtmamBedoneForoosh
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdDasti As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblVersionChangeDesc")>
	Public Class tblVersionChangeDesc
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdSoftware As Decimal
		Public Property Version As String
		Public Property SDate As String
		Public Property Subject As String
		Public Property Detail As String
		Public Property InAllSoftware As Boolean
	End Class

	<Dapper.Contrib.Extensions.Table("tblTaskPeygiri")>
	Public Class tblTaskPeygiri
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdTask As Decimal
		Public Property IdCompanyPersonels As Decimal
		Public Property IdCompanyPersonelsPeygiri As Decimal?
		Public Property IdTaskState As Decimal
		Public Property Note As String
		Public Property SDate As String
		Public Property MDate As Date
		Public Property SDatePeygiri As String
		Public Property MDatePeygiri As Date?
		Public Property [CDate] As Date
	End Class

	<Dapper.Contrib.Extensions.Table("tblNahvePaygiriPishFactor")>
	Public Class tblNahvePaygiriPishFactor
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdDasti As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblTempActivityOperation")>
	Public Class tblTempActivityOperation
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblAmeleTabdilShodanBeFactor")>
	Public Class tblAmeleTabdilShodanBeFactor
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdDasti As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblSaveCustomersProductsState")>
	Public Class tblSaveCustomersProductsState
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblCoPro")>
	Public Class tblCoPro
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property CName As String
		Public Property CNameAll As String
		Public Property Arm As Byte()
		Public Property RTopCenter As String
		Public Property RTopLeft As String
		Public Property RTopRight As String
		Public Property RDownCenter As String
		Public Property RDownLeft As String
		Public Property RDownRight As String
		Public Property IsActive As Boolean
		Public Property IsArm As Boolean
		Public Property IsDate As Boolean
		Public Property IsPCount As Boolean
		Public Property Tel As String
		Public Property Fox As String
		Public Property Address As String
		Public Property Web As String
		Public Property Email As String
		Public Property ShEghtesadi As String
		Public Property ShMeliOrSabt As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblSarnakhOperations")>
	Public Class tblSarnakhOperations
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdSarnakh As Decimal
		Public Property SDate As String
		Public Property MDate As Date
		Public Property [CDate] As Date
		Public Property SCDate As String
		Public Property IdNahvePaygiri As Decimal?
		Public Property Note As String
		Public Property IdCustomersPersonel As Decimal
		Public Property IdCompanyPersonels As Decimal
		Public Property IdSarnakhState As Decimal
		Public Property IdAmeleEtmamBedoneForoosh As Decimal?
		Public Property SDateNextOperation As String
		Public Property MDateNextOperation As Date?
		Public Property FactorNo As Decimal?
		Public Property Price As Decimal?
		Public Property Discount As Decimal?
		Public Property PriceAfterDiscount As Decimal?
		Public Property Tax As Decimal?
		Public Property TotallPrice As Decimal?
		Public Property IdNahvePaygiriPishFactor As Decimal?
		Public Property IdAmeleTabdilShodanBeFactor As Decimal?
		Public Property UserName As String
		Public Property IdSarnakhOperationType As Decimal
		Public Property SDateFactor As String
		Public Property MDateFactor As Date?
		Public Property IdSarnakhSalesType As Decimal?
	End Class

	<Dapper.Contrib.Extensions.Table("tblPlaceCity")>
	Public Class tblPlaceCity
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property Name As String
		Public Property IdPlaceOstan As Decimal
	End Class

	<Dapper.Contrib.Extensions.Table("tblNarmAfzarhayeHamkar")>
	Public Class tblNarmAfzarhayeHamkar
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdDasti As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblCustomersKind")>
	Public Class tblCustomersKind
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdDasti As String
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblCustomersBackup_Esteghrar")>
	Public Class tblCustomersBackup_Esteghrar
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdCustomersBackup As Decimal
		Public Property IdCustomersPersonel As Decimal
		Public Property IdSaveCustomersProducts_Products As Decimal
		Public Property MDTEsteghrar As Date
		Public Property SDTEsteghrar As String
		Public Property Desc As String
		Public Property IdCustomersBackup_Type As Decimal
	End Class

	<Dapper.Contrib.Extensions.Table("tblLockState")>
	Public Class tblLockState
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblCustomersState")>
	Public Class tblCustomersState
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblNoeFaaliyateSherkat")>
	Public Class tblNoeFaaliyateSherkat
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdDasti As Decimal
		Public Property Name As String
		Public Property IdParent As Decimal?
	End Class

	<Dapper.Contrib.Extensions.Table("tblCustomers")>
	Public Class tblCustomers
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdS As String
		Public Property IdCustomersType As Decimal
		Public Property IdCustomersState As Decimal
		Public Property IdPlaceCity As Decimal
		Public Property IdSex As Decimal
		Public Property ComapnyName As String
		Public Property Name As String
		Public Property LName As String
		Public Property Address As String
		Public Property Tel As String
		Public Property Mobile As String
		Public Property Fax As String
		Public Property WebSite As String
		Public Property Email As String
		Public Property UserName As String
		Public Property UserNameE As String
		Public Property MDate As Date
		Public Property MDateU As Date
		Public Property MTime As String
		Public Property MTimeU As String
		Public Property IdCustomersKind As Decimal
		Public Property IdCustomersStatus As Decimal
	End Class

	<Dapper.Contrib.Extensions.Table("tblCustomersBackupQueueSabtType")>
	Public Class tblCustomersBackupQueueSabtType
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblSaveCustomersProducts_Products")>
	Public Class tblSaveCustomersProducts_Products
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdSaveCustomersProducts As Decimal
		Public Property IdProduct As Decimal
		Public Property UserCount As Decimal
		Public Property SSDate As String
		Public Property SEDate As String
		Public Property MSDate As Date?
		Public Property MEDate As Date?
		Public Property IdSaveCustomersProductsState As Decimal
		Public Property Note As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblCustomersBackup_Other")>
	Public Class tblCustomersBackup_Other
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdCustomersBackup As Decimal
		Public Property IdCustomersPersonel As Decimal
		Public Property MDTOther As Date
		Public Property SDTOther As String
		Public Property Desc As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblUserPermissionsTempelete")>
	Public Class tblUserPermissionsTempelete
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdUserKindGroup As Decimal
		Public Property MenuName As String
		Public Property Permitted As Boolean
		Public Property MNew As Boolean
		Public Property MEdit As Boolean
		Public Property MDel As Boolean
		Public Property IdSoftware As Decimal
	End Class

	<Dapper.Contrib.Extensions.Table("tblPathSoftware")>
	Public Class tblPathSoftware
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property UserName As String
		Public Property Path As String
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblSarnakhProducts")>
	Public Class tblSarnakhProducts
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdSarnakh As Decimal
		Public Property IdProduct As Decimal
		Public Property IdSarnakhProductStateType As Decimal
	End Class

	<Dapper.Contrib.Extensions.Table("tblSMSDetail")>
	Public Class tblSMSDetail
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property Tel As String
		Public Property DescSend As String
		Public Property MDtSend As Date
		Public Property SDtSend As String
		Public Property TimeSend As String
		Public Property ResultSend As String
		Public Property IsSend As Boolean
	End Class

	<Dapper.Contrib.Extensions.Table("tblCustomersBackup_Type")>
	Public Class tblCustomersBackup_Type
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblRequestType")>
	Public Class tblRequestType
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblSotooh")>
	Public Class tblSotooh
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
		Public Property Len As Decimal
		Public Property LenDetail As Decimal
		Public Property Tab As Decimal
		Public Property MenuMainName As String
		Public Property MenuName As String
		Public Property MenuDetailName As String
	End Class

	<Dapper.Contrib.Extensions.Table("UserPermissions")>
	Public Class UserPermissions
		Public Property UserName As String
		Public Property MenuName As String
		Public Property Permitted As Boolean
		Public Property MNew As Boolean
		Public Property MEdit As Boolean
		Public Property MDel As Boolean
		Public Property IdSoftware As Decimal
	End Class

	<Dapper.Contrib.Extensions.Table("tblRequestState")>
	Public Class tblRequestState
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblSaveCustomersProducts")>
	Public Class tblSaveCustomersProducts
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdCustomers As Decimal
		Public Property LockNo As String
		Public Property SSDGaranti As String
		Public Property MSDGaranti As Date
		Public Property SEDGaranti As String
		Public Property MEDGaranti As Date
		Public Property UserNo As Decimal
		Public Property IdLockState As Decimal
		Public Property DescLock As String
		Public Property IdtblLocks As Decimal
		Public Property SSDSave As String
		Public Property MSDSave As Date
		Public Property SSDDeActive As String
		Public Property MSDDeActive As Date?
		Public Property UserName As String
		Public Property UserNameE As String
		Public Property [CDate] As Date
		Public Property CTime As String
		Public Property UDate As Date
		Public Property UTime As String
		Public Property Note As String
		Public Property IdSaveCustomersProducts_RegisterState As Decimal
	End Class

	<Dapper.Contrib.Extensions.Table("tblRequestDetailsType")>
	Public Class tblRequestDetailsType
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblTafsilyGroup")>
	Public Class tblTafsilyGroup
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As String
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property IdSotooh As Decimal
		Public Property Name As String
		Public Property UserName As String
		Public Property MDate As Date
		Public Property SDate As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblCustomersBackup_Bak")>
	Public Class tblCustomersBackup_Bak
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdCustomersBackup As Decimal
		Public Property IdCustomersPersonel As Decimal
		Public Property IdSaveCustomersProducts_Products As Decimal
		Public Property MDTBak As Date
		Public Property SDTBak As String
		Public Property Name As String
		Public Property Version As String
		Public Property IP As String
		Public Property IdCompany As String
		Public Property DescDestroy As String
		Public Property DescService As String
		Public Property IdCustomersBackup_Type As Decimal
	End Class

	<Dapper.Contrib.Extensions.Table("tblRequest")>
	Public Class tblRequest
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property Ids As Decimal
		Public Property SDate As String
		Public Property MDate As Date
		Public Property IdProduct As Decimal
		Public Property IdRequestState As Decimal
		Public Property Time As String
		Public Property AttachedFile As Byte()
		Public Property AttachedFileName As String
		Public Property IdRequestType As Decimal
		Public Property IdCompanyPersonels As Decimal
		Public Property DESC As String
		Public Property UserName As String
		Public Property UserNameE As String
		Public Property DescTaeidRequestState As String
		Public Property IsDeleted As Boolean
		Public Property [CDate] As Date
		Public Property CTime As String
		Public Property UDate As Date
		Public Property UTime As String
		Public Property IdRequestGroup As Decimal
		Public Property CustomersList As String
		Public Property SDateTahvilBeMoshtari As String
		Public Property MDateTahvilBeMoshtari As Date?
		Public Property UserNameTahvilBeMoshtari As String
		Public Property Ids2 As Decimal
		Public Property CompanyPersonels_DarDasteEghdam As String
		Public Property SDateDarDasteEghdam As String
		Public Property TimeDarDasteEghdam As String
		Public Property MDateDarDasteEghdam As Date?
		Public Property UserNameDarDasteEghdam As String
		Public Property TimeTahvilBeMoshtari As String
		Public Property SDateTaeid As String
		Public Property TimeTaeid As String
		Public Property MDateTaeid As Date?
		Public Property UserNameTaeid As String
		Public Property SDateAmadeTest As String
		Public Property TimeAmadeTest As String
		Public Property MDateAmadeTest As Date?
		Public Property UserNameAmadeTest As String
		Public Property SDateEtmameTest As String
		Public Property TimeEtmameTest As String
		Public Property MDateEtmameTest As Date?
		Public Property UserNameEtmameTest As String
		Public Property SDateDarEntezareNoskhe As String
		Public Property TimeDarEntezareNoskhe As String
		Public Property MDateDarEntezareNoskhe As Date?
		Public Property UserNameDarEntezareNoskhe As String
		Public Property CompanyPersonels_DarVazeiateTest As String
		Public Property SDateDarVazeiateTest As String
		Public Property TimeDarVazeiateTest As String
		Public Property MDateDarVazeiateTest As Date?
		Public Property UserNameDarVazeiateTest As String
		Public Property DescNewVersionForWeb As String
		Public Property Version As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblBazaryab")>
	Public Class tblBazaryab
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdDasti As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblCustomersBackup_Convert_Type")>
	Public Class tblCustomersBackup_Convert_Type
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblBazaryabiPriceType")>
	Public Class tblBazaryabiPriceType
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblSal_MD")>
	Public Class tblSal_MD
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdSal_MD_S As String
		Public Property IdPayMonth_MD_S As String
		Public Property Day_MD_S As String
		Public Property SSDate_MD As String
		Public Property MSDate_MD As Date
		Public Property IdSal_MD_E As String
		Public Property IdPayMonth_MD_E As String
		Public Property Day_MD_E As String
		Public Property SEDate_MD As String
		Public Property MEDate_MD As Date
		Public Property IsActive_MD As Boolean
		Public Property Desc_MD As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblCustomersBackup_Convert")>
	Public Class tblCustomersBackup_Convert
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdCustomersBackup As Decimal
		Public Property IdCustomersPersonel As Decimal
		Public Property IdSaveCustomersProducts_Products As Decimal
		Public Property IdCustomersBackup_Convert_Type As Decimal
		Public Property IdProduct As Decimal
		Public Property MDate As Date
		Public Property SDate As String
		Public Property Note As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblCustomersStatus")>
	Public Class tblCustomersStatus
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblHardwareLocksState")>
	Public Class tblHardwareLocksState
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblCustomersBackup")>
	Public Class tblCustomersBackup
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdCustomers As Decimal
		Public Property IdSaveCustomersProducts As Decimal
		Public Property ldCustomersContract As Decimal?
		Public Property IdSaveCustomersContract As Decimal?
		Public Property IdCompanyPersonels As Decimal
		Public Property MDate As Date
		Public Property SDate As String
		Public Property MDateS As Date
		Public Property SDateS As String
		Public Property With_Install As Boolean
		Public Property IsPeigiri_Install As Boolean
		Public Property Desc_Install As String
		Public Property With_Edu As Boolean
		Public Property IsPeigiri_Edu As Boolean
		Public Property Desc_Edu As String
		Public Property With_Bak As Boolean
		Public Property IsPeigiri_Bak As Boolean
		Public Property Desc_Bak As String
		Public Property With_Esteghrar As Boolean
		Public Property IsPeigiri_Esteghrar As Boolean
		Public Property Desc_Esteghrar As String
		Public Property With_Other As Boolean
		Public Property IsPeigiri_Other As Boolean
		Public Property Desc_Other As String
		Public Property UserName As String
		Public Property UserNameE As String
		Public Property [CDate] As Date
		Public Property CTime As String
		Public Property UDate As Date
		Public Property UTime As String
		Public Property IdCustomersBackupQueue As Decimal?
		Public Property With_Convert As Boolean
		Public Property IsPeigiri_Convert As Boolean
		Public Property Desc_Convert As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblPayMonth_PaySal")>
	Public Class tblPayMonth_PaySal
		<Dapper.Contrib.Extensions.Computed>
		Public Property Id As Decimal
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property IdPayMonth As String
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property IdSal As String
		Public Property IsActive As Boolean
		Public Property IsSelect As Boolean
		Public Property IsError As Boolean
		Public Property Description As String
		Public Property IdPayMonth_PaySal_RavesheMohasebeheMaliyat As Decimal
	End Class

	<Dapper.Contrib.Extensions.Table("tblServicedCompany")>
	Public Class tblServicedCompany
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdS As String
		Public Property CompanyName As String
		Public Property UserName As String
		Public Property UserNameE As String
		Public Property MDate As Date
		Public Property MDateU As Date
		Public Property MTime As String
		Public Property MTimeU As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblCustomersDegree")>
	Public Class tblCustomersDegree
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblSarnakhCurrentSoftwareState")>
	Public Class tblSarnakhCurrentSoftwareState
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblSarnakhCustomerType")>
	Public Class tblSarnakhCustomerType
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblSarnakhProductStateType")>
	Public Class tblSarnakhProductStateType
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblCustomersBackup_Install_ApplicationSoftware")>
	Public Class tblCustomersBackup_Install_ApplicationSoftware
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdCustomersBackup_Install As Decimal
		Public Property IdApplicationSoftware As Decimal
	End Class

	<Dapper.Contrib.Extensions.Table("tblRequest_Customers")>
	Public Class tblRequest_Customers
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdRequest As Decimal
		Public Property IdCustomers As Decimal
	End Class

	<Dapper.Contrib.Extensions.Table("tblCustomersBackupQueueOperationType")>
	Public Class tblCustomersBackupQueueOperationType
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblSarnakhState")>
	Public Class tblSarnakhState
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblCustomersBackupQueueState")>
	Public Class tblCustomersBackupQueueState
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblVosoolBedehiType")>
	Public Class tblVosoolBedehiType
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblCustomersBackupQueue")>
	Public Class tblCustomersBackupQueue
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdQueue As Decimal
		Public Property SDate As String
		Public Property MDate As Date
		Public Property IdCustomers As Decimal
		Public Property IdCustomersPersonel As Decimal?
		Public Property IdSaveCustomersProducts_Products As Decimal
		Public Property IdCustomersBackupQueueOperationType As Decimal
		Public Property IdCustomersBackupQueueState As Decimal
		Public Property Tel As String
		Public Property DESC As String
		Public Property UserName As String
		Public Property UserNameE As String
		Public Property [CDate] As Date
		Public Property CTime As String
		Public Property UDate As Date
		Public Property UTime As String
		Public Property UserNameBackup As String
		Public Property CDateBackup As Date
		Public Property CTimeBackup As String
		Public Property UserNameSuspend As String
		Public Property CDateSuspend As Date
		Public Property CTimeSuspend As String
		Public Property UserNameInProgress As String
		Public Property CDateInProgress As Date
		Public Property CTimeInProgress As String
		Public Property SDateYadavari As String
		Public Property MDateYadavari As Date?
		Public Property IsFromWeb As Boolean
		Public Property IdWebTicket As Decimal?
		Public Property IdCustomersBackupQueueSabtType As Decimal
	End Class

	<Dapper.Contrib.Extensions.Table("tblVersion")>
	Public Class tblVersion
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Version As Decimal
		Public Property Desc As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblPhoneBook")>
	Public Class tblPhoneBook
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Integer
		Public Property FName As String
		Public Property LName As String
		Public Property Department As String
		Public Property Degree As String
		Public Property Tel1 As String
		Public Property Tel2 As String
		Public Property Tel3 As String
		Public Property InternalTel As String
		Public Property Fax As String
		Public Property Mob1 As String
		Public Property Mob2 As String
		Public Property Address As String
		Public Property EMail As String
		Public Property WebSite As String
		Public Property Title As String
		Public Property Desc As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblVosoolContractState")>
	Public Class tblVosoolContractState
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblApplicationSoftware")>
	Public Class tblApplicationSoftware
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblVosoolTalabType")>
	Public Class tblVosoolTalabType
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblUsers")>
	Public Class tblUsers
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property UserName As String
		Public Property FullName As String
		Public Property Description As String
		Public Property Password As String
		Public Property State As Boolean
		Public Property IsAccess As Boolean
		Public Property canChangePass As Boolean
		Public Property LastDateConnection As String
		Public Property LastDateDisConnection As String
		Public Property IdKindUserGroup As Decimal
		Public Property ComputerIPOrName As String
		<Dapper.Contrib.Extensions.Computed>
		Public Property IdUserName_Identity As Decimal
		Public Property IdUn As Guid
		Public Property ConnectUserDT As Date?
	End Class

	<Dapper.Contrib.Extensions.Table("tblReportFiles")>
	Public Class tblReportFiles
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdS As String
		Public Property Desc As String
		Public Property Report As Byte()
		Public Property IdSoftware As Decimal
		Public Property UserName As String
		Public Property UserNameE As String
		Public Property MDate As Date
		Public Property MDateE As Date
		Public Property MSDate As String
		Public Property MSDateE As String
		Public Property DefaultIndex As Decimal
	End Class

	<Dapper.Contrib.Extensions.Table("tblSarnakhSalesType")>
	Public Class tblSarnakhSalesType
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblRequestDetails")>
	Public Class tblRequestDetails
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdRequest As Decimal
		Public Property IdRequestDetailsType As Decimal
		Public Property IdCompanyPersonels As Decimal
		Public Property SDate As String
		Public Property MDate As Date
		Public Property Time As String
		Public Property DESC As String
		Public Property Version As String
		Public Property AttachedFile As Byte()
		Public Property AttachedFileName As String
		Public Property IsDeleted As Boolean
		Public Property UserName As String
		Public Property UserNameE As String
		Public Property [CDate] As Date
		Public Property CTime As String
		Public Property UDate As Date
		Public Property UTime As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblOneUserForSelectOtherOperation")>
	Public Class tblOneUserForSelectOtherOperation
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property UserName As String
		Public Property Description As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblCustomersType")>
	Public Class tblCustomersType
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblSaveActivateCode")>
	Public Class tblSaveActivateCode
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdtblLocks As Decimal
		Public Property ComputerCode As String
		Public Property ActivatedCode As String
		Public Property IdtblLockState As Decimal
		Public Property SDateInput As String
		Public Property MDateInput As Date
		Public Property SDateStart As String
		Public Property MDateStart As Date
		Public Property SDateEnd As String
		Public Property MDateEnd As Date
		Public Property IdtblSaveCustomersProducts As Decimal
		Public Property IdCustomers As Decimal
		Public Property DESC As String
		Public Property UserName As String
		Public Property UserNameE As String
		Public Property MDate As Date
		Public Property MDateU As Date
		Public Property MTime As String
		Public Property MTimeU As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblUserConnectDetails")>
	Public Class tblUserConnectDetails
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdUn As Guid
		Public Property UserName As String
		Public Property Mdate As Date
		Public Property Desc As String
		Public Property ComputerIPOrName As String
		Public Property IdUserConnectDetailsType As Decimal
	End Class

	<Dapper.Contrib.Extensions.Table("tblContractType")>
	Public Class tblContractType
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblPayMonth")>
	Public Class tblPayMonth
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As String
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblCustomersContract")>
	Public Class tblCustomersContract
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdCustomers As Decimal
		Public Property ContractNo As String
		Public Property SDtSave As String
		Public Property MDtSave As Date
		Public Property SStartDate As String
		Public Property MStartDate As Date
		Public Property SEndDate As String
		Public Property MEndDate As Date
		Public Property IdContractType As Decimal
		Public Property UserName As String
		Public Property UserNameE As String
		Public Property [CDate] As Date
		Public Property CTime As String
		Public Property UDate As Date
		Public Property UTime As String
		Public Property SDateGharardad As String
		Public Property MDateGharardad As Date
	End Class

	<Dapper.Contrib.Extensions.Table("tblPayMonth_PaySal_RavesheMohasebeheMaliyat")>
	Public Class tblPayMonth_PaySal_RavesheMohasebeheMaliyat
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblSaveCustomersContract")>
	Public Class tblSaveCustomersContract
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdSaveCustomersProducts As Decimal
		Public Property IdCustomersContract As Decimal
	End Class

	<Dapper.Contrib.Extensions.Table("tblUserConnectDetailsType")>
	Public Class tblUserConnectDetailsType
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblRequestGroup")>
	Public Class tblRequestGroup
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property Ids As String
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblSoftware")>
	Public Class tblSoftware
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblProductsGroupProducer")>
	Public Class tblProductsGroupProducer
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblLocks")>
	Public Class tblLocks
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property LockNo As String
		Public Property IdtblServicedCompany As Decimal
		Public Property IdtblHardWareLocksState As Decimal
		Public Property UserName As String
		Public Property UserNameE As String
		Public Property MDate As Date
		Public Property MDateU As Date
		Public Property MTime As String
		Public Property MTimeU As String
		Public Property SDateEtebar As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblSal")>
	Public Class tblSal
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As String
		Public Property StartDay As Date
		Public Property EndDay As Date
		Public Property IsActive As Boolean
	End Class

	<Dapper.Contrib.Extensions.Table("tblCustomersBackup_Edu")>
	Public Class tblCustomersBackup_Edu
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdCustomersBackup As Decimal
		Public Property IdCustomersPersonel As Decimal
		Public Property IdSaveCustomersProducts_Products As Decimal
		Public Property MDTEdu As Date
		Public Property SDTEdu As String
		Public Property MMAmoozesh As Decimal
		Public Property HHAmoozesh As Decimal
		Public Property HHMMFormat As String
		Public Property MOnly As Decimal
		Public Property Desc As String
		Public Property IdCustomersBackup_Type As Decimal
	End Class

	<Dapper.Contrib.Extensions.Table("tblEditorAccess")>
	Public Class tblEditorAccess
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property UserName As String
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property FrmName As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblSaveCustomersProducts_RegisterState")>
	Public Class tblSaveCustomersProducts_RegisterState
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblUserPermissions_YadavariUsers")>
	Public Class tblUserPermissions_YadavariUsers
		<Dapper.Contrib.Extensions.Computed>
		Public Property Id As Decimal
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property UserName As String
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property UserNameOther As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblRequest_CompanyPersonels")>
	Public Class tblRequest_CompanyPersonels
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdRequest As Decimal
		Public Property IdCompanyPersonels As Decimal
		Public Property IdRequestState As Decimal
	End Class

	<Dapper.Contrib.Extensions.Table("dtproperties")>
	Public Class dtproperties
		<Dapper.Contrib.Extensions.Key>
		Public Property id As Integer
		Public Property objectid As Integer?
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property [property] As String
		Public Property value As String
		Public Property uvalue As String
		Public Property lvalue As Byte()
		Public Property version As Integer
	End Class

	<Dapper.Contrib.Extensions.Table("tblVosoolCallTypes")>
	Public Class tblVosoolCallTypes
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdDasti As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblCustomize")>
	Public Class tblCustomize
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property ISEditableByName As Boolean
		Public Property SharePathToDefault As String
		Public Property MethodForGhatieIsSanadWithAccept As Boolean
		Public Property UrlPath As String
		Public Property IdCustomizeCreateSanadType As Decimal
		Public Property IsKhalafeMahiatChecked As Boolean
		Public Property IsDescSanad As Boolean
		Public Property IsStartArtiklByMoein As Boolean
		Public Property RTopCenter As String
		Public Property RTopLeft As String
		Public Property RTopRight As String
		Public Property RDownCenter As String
		Public Property RDownLeft As String
		Public Property RDownRight As String
		Public Property IsUseMaxRows As Boolean
		Public Property MaxRowsOfList As Decimal
		Public Property RengeSeni_NozadVaKodak As Decimal
		Public Property IdTafsilyGroup_Fot As String
		Public Property IdSotooh_Fot As Decimal
	End Class

	<Dapper.Contrib.Extensions.Table("tblVosoolStates")>
	Public Class tblVosoolStates
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblSarnakhOperationType")>
	Public Class tblSarnakhOperationType
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblCustomersPersonel")>
	Public Class tblCustomersPersonel
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdCustomers As Decimal
		Public Property IdCustomersDegree As Decimal
		Public Property Name As String
		Public Property LName As String
		Public Property IdSex As Decimal
	End Class

	<Dapper.Contrib.Extensions.Table("tblCustomersBackupQueueUsers")>
	Public Class tblCustomersBackupQueueUsers
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdCustomersBackupQueue As Decimal
		Public Property UserName As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblVosoolOperationType")>
	Public Class tblVosoolOperationType
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblPlaceCountry")>
	Public Class tblPlaceCountry
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property Name As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblUserPermissionToForm")>
	Public Class tblUserPermissionToForm
		<Dapper.Contrib.Extensions.Computed>
		Public Property Id As Decimal
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property UserName As String
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property FrmName As String
	End Class

	<Dapper.Contrib.Extensions.Table("tblVosoolTalab")>
	Public Class tblVosoolTalab
		<Dapper.Contrib.Extensions.Key>
		Public Property Id As Decimal
		Public Property IdDasti As Decimal
		Public Property IdCustomers As Decimal
		Public Property IdCompanyPersonels As Decimal
		Public Property IdCompanyPersonelsPeygiri As Decimal
		Public Property IdVosoolStates As Decimal
		Public Property Price As Decimal
		Public Property PriceMandeh As Decimal
		Public Property Note As String
		Public Property SDate As String
		Public Property MDate As Date
		Public Property SDatePeygiri As String
		Public Property MDatePeygiri As Date
		Public Property SDatePeygiriFromPeygiri As String
		Public Property MDatePeygiriFromPeygiri As Date
		Public Property [CDate] As Date
		Public Property IdVosoolTalabType As Decimal
		Public Property IdVosoolBedehiType As Decimal
		Public Property IdVosoolContractState As Decimal
	End Class

	<Dapper.Contrib.Extensions.Table("tblWebServiceBaseURL")>
	Public Class tblWebServiceBaseURL
		<Dapper.Contrib.Extensions.ExplicitKey>
		Public Property Id As Decimal
		Public Property Name As String
		Public Property Desc As String
	End Class
End Namespace
