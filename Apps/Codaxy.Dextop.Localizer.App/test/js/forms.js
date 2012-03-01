Ext.define('MoneyMarket.shared.ChangePasswordWindowBase.form.ChangePassword', {
	extend: 'Dextop.ItemFactory',
	getDictionary: function(options){
		options = options || {};
		options.data = options.data || {};
		var dict = {};
		dict["OldPassword"] = {
			name: 'OldPassword',
			fieldLabel: this.OldPasswordFieldLabelText,
			xtype: 'textfield',
			anchor: '0',
			inputType: 'password',
			value: options.data['OldPassword']
		};
		dict["NewPassword"] = {
			name: 'NewPassword',
			fieldLabel: this.NewPasswordFieldLabelText,
			xtype: 'textfield',
			anchor: '0',
			inputType: 'password',
			value: options.data['NewPassword']
		};
		dict["ConfirmPassword"] = {
			name: 'ConfirmPassword',
			fieldLabel: this.ConfirmPasswordFieldLabelText,
			xtype: 'textfield',
			anchor: '0',
			inputType: 'password',
			value: options.data['ConfirmPassword']
		};
		return dict;

	},
	buildItems: function(dict){
		return [dict['OldPassword'], dict['NewPassword'], dict['ConfirmPassword']];
	},
	OldPasswordFieldLabelText: 'Old password',
	NewPasswordFieldLabelText: 'New password',
	ConfirmPasswordFieldLabelText: 'Confirm password'
});

Ext.define('MoneyMarket.shared.MemberSecurityQuotesWindowBase.form.MemberSecurityQuote', {
	extend: 'Dextop.ItemFactory',
	getDictionary: function(options){
		options = options || {};
		options.data = options.data || {};
		var dict = {};
		dict["Date"] = {
			name: 'Date',
			fieldLabel: this.DateFieldLabelText,
			xtype: 'datefield',
			allowBlank: false,
			value: options.data['Date']
		};
		dict["Account"] = {
			name: 'Account',
			fieldLabel: this.AccountFieldLabelText,
			xtype: 'textfield',
			allowBlank: false,
			value: options.data['Account'],
			regex: /^[a-zA-Z][0-9]{1,8}$/
		};
		dict["SecurityCode"] = {
			name: 'SecurityCode',
			fieldLabel: this.SecurityCodeFieldLabelText,
			xtype: 'combo',
			anchor: '0',
			allowBlank: false,
			value: options.data['SecurityCode'],
			store: options.remote.createStore('SecurityCode'),
			valueField: 'SecurityCode',
			queryMode: 'remote',
			forceSelection: true,
			disableKeyFilter: false,
			editable: true,
			displayField: 'SecurityCodeDescription',
			minChars: 1
		};
		dict["BidPrice"] = {
			name: 'BidPrice',
			fieldLabel: this.BidPriceFieldLabelText,
			xtype: 'numberfield',
			value: options.data['BidPrice'],
			decimalPrecision: 4
		};
		dict["BidYTM"] = {
			name: 'BidYTM',
			fieldLabel: this.BidYTMFieldLabelText,
			xtype: 'numberfield',
			value: options.data['BidYTM']
		};
		dict["BidDateNegotiable"] = {
			name: 'BidDateNegotiable',
			xtype: 'checkboxfield',
			boxLabel: this.BidDateNegotiableBoxLabelText,
			checked: options.data['BidDateNegotiable'],
			hideEmptyLabel: false
		};
		dict["BidRepoNegotiable"] = {
			name: 'BidRepoNegotiable',
			xtype: 'checkboxfield',
			boxLabel: this.BidRepoNegotiableBoxLabelText,
			checked: options.data['BidRepoNegotiable'],
			hideEmptyLabel: false
		};
		dict["AskPrice"] = {
			name: 'AskPrice',
			fieldLabel: this.AskPriceFieldLabelText,
			xtype: 'numberfield',
			anchor: '0',
			value: options.data['AskPrice'],
			decimalPrecision: 4
		};
		dict["AskYTM"] = {
			name: 'AskYTM',
			fieldLabel: this.AskYTMFieldLabelText,
			xtype: 'numberfield',
			anchor: '0',
			value: options.data['AskYTM']
		};
		dict["AskDateNegotiable"] = {
			name: 'AskDateNegotiable',
			xtype: 'checkboxfield',
			boxLabel: this.AskDateNegotiableBoxLabelText,
			checked: options.data['AskDateNegotiable'],
			hideEmptyLabel: false
		};
		dict["AskRepoNegotiable"] = {
			name: 'AskRepoNegotiable',
			xtype: 'checkboxfield',
			boxLabel: this.AskRepoNegotiableBoxLabelText,
			checked: options.data['AskRepoNegotiable'],
			hideEmptyLabel: false
		};
		return dict;

	},
	buildItems: function(dict){
		return [dict['Date'], dict['Account'], dict['SecurityCode'], {
			layout: 'hbox',
			border: false,
			anchor: '0',
			items: [{
				border: false,
				items: [dict['BidPrice'], dict['BidYTM'], dict['BidDateNegotiable'], dict['BidRepoNegotiable']]
			}, {
				bodyStyle: 'padding-left: 20px;',
				border: false,
				anchor: '0',
				items: [dict['AskPrice'], dict['AskYTM'], dict['AskDateNegotiable'], dict['AskRepoNegotiable']]
			}]
		}];
	},
	DateFieldLabelText: 'Date',
	AccountFieldLabelText: 'Account',
	SecurityCodeFieldLabelText: 'Symbol',
	BidPriceFieldLabelText: 'Bid Price',
	BidYTMFieldLabelText: 'Bid YTM [%]',
	BidDateNegotiableBoxLabelText: 'Date Negotiable',
	BidRepoNegotiableBoxLabelText: 'REPO Negotiable',
	AskPriceFieldLabelText: 'Ask Price',
	AskYTMFieldLabelText: 'Ask YTM [%]',
	AskDateNegotiableBoxLabelText: 'Date Negotiable',
	AskRepoNegotiableBoxLabelText: 'REPO Negotiable'
});

Ext.define('MoneyMarket.shared.LoginWindow.form.Login', {
	extend: 'Dextop.ItemFactory',
	getDictionary: function(options){
		options = options || {};
		options.data = options.data || {};
		var dict = {};
		dict["username"] = {
			name: 'username',
			fieldLabel: this.usernameFieldLabelText,
			xtype: 'textfield',
			anchor: '0',
			value: options.data['username'],
			labelWidth: 80
		};
		dict["password"] = {
			name: 'password',
			fieldLabel: this.passwordFieldLabelText,
			xtype: 'textfield',
			anchor: '0',
			inputType: 'password',
			value: options.data['password'],
			labelWidth: 80
		};
		return dict;

	},
	buildItems: function(dict){
		return [dict['username'], dict['password']];
	},
	usernameFieldLabelText: 'Username',
	passwordFieldLabelText: 'Password'
});

Ext.define('MoneyMarket.admin.SettingsWindow.form.Settings', {
	extend: 'Dextop.ItemFactory',
	getDictionary: function(options){
		options = options || {};
		options.data = options.data || {};
		var dict = {};
		dict["MinimalReportedTradeVolume"] = {
			name: 'MinimalReportedTradeVolume',
			fieldLabel: this.MinimalReportedTradeVolumeFieldLabelText,
			xtype: 'numberfield',
			value: options.data['MinimalReportedTradeVolume']
		};
		dict["TradingIntervalStartTime"] = {
			name: 'TradingIntervalStartTime',
			fieldLabel: this.TradingIntervalStartTimeFieldLabelText,
			xtype: 'timefield',
			anchor: '0',
			value: options.data['TradingIntervalStartTime']
		};
		dict["TradingIntervalEndTime"] = {
			name: 'TradingIntervalEndTime',
			fieldLabel: this.TradingIntervalEndTimeFieldLabelText,
			xtype: 'timefield',
			anchor: '0',
			value: options.data['TradingIntervalEndTime']
		};
		return dict;

	},
	buildItems: function(dict){
		return [dict['MinimalReportedTradeVolume'], dict['TradingIntervalStartTime'], dict['TradingIntervalEndTime']];
	},
	MinimalReportedTradeVolumeFieldLabelText: 'Minumum reported trade volume',
	TradingIntervalStartTimeFieldLabelText: 'Trading Start',
	TradingIntervalEndTimeFieldLabelText: 'Trading End'
});

Ext.define('MoneyMarket.broker.TradeNegotiationWindow.form.TradeNegotiationStatement', {
	extend: 'Dextop.ItemFactory',
	getDictionary: function(options){
		options = options || {};
		options.data = options.data || {};
		var dict = {};
		dict["Account"] = {
			name: 'Account',
			fieldLabel: this.AccountFieldLabelText,
			xtype: 'textfield',
			anchor: '0',
			allowBlank: false,
			value: options.data['Account'],
			regex: /^[a-zA-Z][0-9]{1,8}$/
		};
		dict["Reference"] = {
			name: 'Reference',
			fieldLabel: this.ReferenceFieldLabelText,
			xtype: 'textfield',
			anchor: '0',
			value: options.data['Reference']
		};
		dict["Volume"] = {
			name: 'Volume',
			fieldLabel: this.VolumeFieldLabelText,
			xtype: 'numberfield',
			anchor: '0',
			allowBlank: false,
			value: options.data['Volume']
		};
		dict["TradeDate"] = {
			name: 'TradeDate',
			fieldLabel: this.TradeDateFieldLabelText,
			xtype: 'datefield',
			anchor: '0',
			value: options.data['TradeDate']
		};
		dict["Price"] = {
			name: 'Price',
			fieldLabel: this.PriceFieldLabelText,
			xtype: 'numberfield',
			anchor: '0',
			value: options.data['Price'],
			decimalPrecision: 4
		};
		dict["YTM"] = {
			name: 'YTM',
			fieldLabel: this.YTMFieldLabelText,
			xtype: 'numberfield',
			anchor: '0',
			value: options.data['YTM']
		};
		dict["REPO"] = {
			name: 'REPO',
			xtype: 'checkboxfield',
			boxLabel: this.REPOBoxLabelText,
			anchor: '0',
			checked: options.data['REPO'],
			hideEmptyLabel: false
		};
		dict["RepoTradeDate"] = {
			name: 'RepoTradeDate',
			fieldLabel: this.RepoTradeDateFieldLabelText,
			xtype: 'datefield',
			anchor: '0',
			allowBlank: false,
			value: options.data['RepoTradeDate']
		};
		dict["RepoPrice"] = {
			name: 'RepoPrice',
			fieldLabel: this.RepoPriceFieldLabelText,
			xtype: 'numberfield',
			anchor: '0',
			value: options.data['RepoPrice'],
			decimalPrecision: 4
		};
		dict["RepoYTM"] = {
			name: 'RepoYTM',
			fieldLabel: this.RepoYTMFieldLabelText,
			xtype: 'numberfield',
			anchor: '0',
			value: options.data['RepoYTM']
		};
		dict["Comment"] = {
			name: 'Comment',
			fieldLabel: this.CommentFieldLabelText,
			xtype: 'textarea',
			anchor: '0',
			value: options.data['Comment'],
			height: 80
		};
		return dict;

	},
	buildItems: function(dict){
		return [{
			layout: 'hbox',
			border: false,
			items: [{
				layout: 'anchor',
				style: 'padding-right: 10px',
				border: false,
				flex: 1,
				items: [dict['Account']]
			}, {
				layout: 'anchor',
				style: 'padding-left: 10px',
				border: false,
				flex: 1,
				items: [dict['Reference']]
			}]
		}, {
			layout: 'hbox',
			border: false,
			items: [{
				layout: 'anchor',
				style: 'padding-right: 10px',
				border: false,
				flex: 1,
				items: [dict['Volume'], dict['TradeDate'], dict['Price'], dict['YTM']]
			}, {
				layout: 'anchor',
				style: 'padding-left: 10px',
				border: false,
				flex: 1,
				items: [dict['REPO'], dict['RepoTradeDate'], dict['RepoPrice'], dict['RepoYTM']]
			}]
		}, {
			layout: 'anchor',
			border: false,
			items: [dict['Comment']]
		}];
	},
	AccountFieldLabelText: 'Account',
	ReferenceFieldLabelText: 'Reference',
	VolumeFieldLabelText: 'Volume',
	TradeDateFieldLabelText: 'Trade Date',
	PriceFieldLabelText: 'Price',
	YTMFieldLabelText: 'YTM',
	REPOBoxLabelText: 'REPO',
	RepoTradeDateFieldLabelText: 'REPO Date',
	RepoPriceFieldLabelText: 'REPO Price',
	RepoYTMFieldLabelText: 'REPO YTM',
	CommentFieldLabelText: 'Comment'
});

Ext.define('MoneyMarket.shared.ReportedTradesWindowBase.form.ReportedTrade', {
	extend: 'Dextop.ItemFactory',
	getDictionary: function(options){
		options = options || {};
		options.data = options.data || {};
		var dict = {};
		dict["BuyerMemberCode"] = {
			name: 'BuyerMemberCode',
			xtype: 'combo',
			boxLabel: this.BuyerMemberCodeBoxLabelText,
			allowBlank: false,
			value: options.data['BuyerMemberCode'],
			store: options.remote.createStore('MemberCode'),
			valueField: 'id',
			queryMode: 'local',
			forceSelection: true,
			disableKeyFilter: true,
			editable: false
		};
		dict["BuyerAccount"] = {
			name: 'BuyerAccount',
			fieldLabel: this.BuyerAccountFieldLabelText,
			xtype: 'textfield',
			allowBlank: false,
			value: options.data['BuyerAccount']
		};
		dict["BuyerReference"] = {
			name: 'BuyerReference',
			fieldLabel: this.BuyerReferenceFieldLabelText,
			xtype: 'textfield',
			value: options.data['BuyerReference']
		};
		dict["SellerMemberCode"] = {
			name: 'SellerMemberCode',
			xtype: 'combo',
			boxLabel: this.SellerMemberCodeBoxLabelText,
			allowBlank: false,
			value: options.data['SellerMemberCode'],
			store: options.remote.createStore('MemberCode'),
			valueField: 'id',
			queryMode: 'local',
			forceSelection: true,
			disableKeyFilter: true,
			editable: false
		};
		dict["SellerAccount"] = {
			name: 'SellerAccount',
			fieldLabel: this.SellerAccountFieldLabelText,
			xtype: 'textfield',
			allowBlank: false,
			value: options.data['SellerAccount']
		};
		dict["SellerReference"] = {
			name: 'SellerReference',
			fieldLabel: this.SellerReferenceFieldLabelText,
			xtype: 'textfield',
			value: options.data['SellerReference']
		};
		dict["ReportedTradeTypeId"] = {
			name: 'ReportedTradeTypeId',
			xtype: 'combo',
			boxLabel: this.ReportedTradeTypeIdBoxLabelText,
			value: options.data['ReportedTradeTypeId'],
			store: options.remote.createStore('ReportedTradeTypeId'),
			valueField: 'id',
			queryMode: 'local',
			forceSelection: true,
			disableKeyFilter: true,
			editable: false
		};
		dict["SecurityCode"] = {
			name: 'SecurityCode',
			fieldLabel: this.SecurityCodeFieldLabelText,
			xtype: 'combo',
			anchor: '0',
			allowBlank: false,
			value: options.data['SecurityCode'],
			store: options.remote.createStore('SecurityCode'),
			valueField: 'SecurityCode',
			queryMode: 'remote',
			forceSelection: true,
			disableKeyFilter: false,
			editable: true,
			displayField: 'SecurityCodeDescription',
			minChars: 1
		};
		dict["Volume"] = {
			name: 'Volume',
			fieldLabel: this.VolumeFieldLabelText,
			xtype: 'numberfield',
			allowBlank: false,
			value: options.data['Volume']
		};
		dict["DueDate"] = {
			name: 'DueDate',
			fieldLabel: this.DueDateFieldLabelText,
			xtype: 'datefield',
			allowBlank: false,
			value: options.data['DueDate']
		};
		dict["Price"] = {
			name: 'Price',
			fieldLabel: this.PriceFieldLabelText,
			xtype: 'numberfield',
			allowBlank: false,
			value: options.data['Price'],
			decimalPrecision: 4
		};
		dict["RepoDate"] = {
			name: 'RepoDate',
			fieldLabel: this.RepoDateFieldLabelText,
			xtype: 'datefield',
			value: options.data['RepoDate']
		};
		dict["RepoPrice"] = {
			name: 'RepoPrice',
			fieldLabel: this.RepoPriceFieldLabelText,
			xtype: 'numberfield',
			value: options.data['RepoPrice'],
			decimalPrecision: 4
		};
		return dict;

	},
	buildItems: function(dict){
		return [{
			layout: 'column',
			items: [{
				xtype: 'fieldset',
				title: 'Buyer Information',
				style: 'padding-right: 10px',
				anchor: '0',
				items: [dict['BuyerMemberCode'], dict['BuyerAccount'], dict['BuyerReference']]
			}, {
				xtype: 'fieldset',
				title: 'Seller Information',
				style: 'padding-left: 10px',
				anchor: '0',
				items: [dict['SellerMemberCode'], dict['SellerAccount'], dict['SellerReference']]
			}, {
				xtype: 'fieldset',
				title: 'Trade Information',
				items: [dict['ReportedTradeTypeId'], dict['SecurityCode'], dict['Volume']]
			}]
		}, {
			layout: 'column',
			items: [{
				xtype: 'fieldset',
				title: 'Trade',
				style: 'padding-right: 10px',
				anchor: '0',
				items: [dict['DueDate'], dict['Price']]
			}, {
				xtype: 'fieldset',
				title: 'REPO',
				style: 'padding-left: 10px',
				anchor: '0',
				items: [dict['RepoDate'], dict['RepoPrice']]
			}]
		}];
	},
	BuyerMemberCodeBoxLabelText: 'Buyer',
	BuyerAccountFieldLabelText: 'Account',
	BuyerReferenceFieldLabelText: 'Reference',
	SellerMemberCodeBoxLabelText: 'Seller',
	SellerAccountFieldLabelText: 'Account',
	SellerReferenceFieldLabelText: 'Reference',
	ReportedTradeTypeIdBoxLabelText: 'Type',
	SecurityCodeFieldLabelText: 'Symbol',
	VolumeFieldLabelText: 'Volume',
	DueDateFieldLabelText: 'Due Date',
	PriceFieldLabelText: 'Price',
	RepoDateFieldLabelText: 'REPO Date',
	RepoPriceFieldLabelText: 'Repo Price'
});

Ext.define('MoneyMarket.admin.MembersWindow.form.Member', {
	extend: 'Dextop.ItemFactory',
	getDictionary: function(options){
		options = options || {};
		options.data = options.data || {};
		var dict = {};
		dict["Deleted"] = {
			name: 'Deleted',
			xtype: 'checkboxfield',
			boxLabel: this.DeletedBoxLabelText,
			checked: options.data['Deleted']
		};
		dict["Code"] = {
			name: 'Code',
			fieldLabel: this.CodeFieldLabelText,
			xtype: 'textfield',
			anchor: '0',
			allowBlank: false,
			value: options.data['Code']
		};
		dict["Description"] = {
			name: 'Description',
			fieldLabel: this.DescriptionFieldLabelText,
			xtype: 'textfield',
			anchor: '0',
			allowBlank: false,
			value: options.data['Description']
		};
		dict["AuthorizedPerson"] = {
			name: 'AuthorizedPerson',
			fieldLabel: this.AuthorizedPersonFieldLabelText,
			xtype: 'textfield',
			anchor: '0',
			value: options.data['AuthorizedPerson']
		};
		dict["Phone"] = {
			name: 'Phone',
			fieldLabel: this.PhoneFieldLabelText,
			xtype: 'textfield',
			value: options.data['Phone']
		};
		dict["Fax"] = {
			name: 'Fax',
			fieldLabel: this.FaxFieldLabelText,
			xtype: 'textfield',
			value: options.data['Fax']
		};
		dict["EMail"] = {
			name: 'EMail',
			fieldLabel: this.EMailFieldLabelText,
			xtype: 'textfield',
			value: options.data['EMail']
		};
		dict["PostalCode"] = {
			name: 'PostalCode',
			fieldLabel: this.PostalCodeFieldLabelText,
			xtype: 'textfield',
			value: options.data['PostalCode']
		};
		dict["Street"] = {
			name: 'Street',
			fieldLabel: this.StreetFieldLabelText,
			xtype: 'textfield',
			value: options.data['Street']
		};
		dict["City"] = {
			name: 'City',
			fieldLabel: this.CityFieldLabelText,
			xtype: 'textfield',
			value: options.data['City']
		};
		dict["State"] = {
			name: 'State',
			fieldLabel: this.StateFieldLabelText,
			xtype: 'textfield',
			value: options.data['State']
		};
		dict["Country"] = {
			name: 'Country',
			fieldLabel: this.CountryFieldLabelText,
			xtype: 'textfield',
			value: options.data['Country']
		};
		dict["WebSite"] = {
			name: 'WebSite',
			fieldLabel: this.WebSiteFieldLabelText,
			xtype: 'textfield',
			value: options.data['WebSite']
		};
		dict["ContactPerson"] = {
			name: 'ContactPerson',
			fieldLabel: this.ContactPersonFieldLabelText,
			xtype: 'textfield',
			value: options.data['ContactPerson']
		};
		dict["BankName"] = {
			name: 'BankName',
			fieldLabel: this.BankNameFieldLabelText,
			xtype: 'textfield',
			value: options.data['BankName']
		};
		dict["BankAccountNumber"] = {
			name: 'BankAccountNumber',
			fieldLabel: this.BankAccountNumberFieldLabelText,
			xtype: 'textfield',
			value: options.data['BankAccountNumber']
		};
		dict["BankAccountReference"] = {
			name: 'BankAccountReference',
			fieldLabel: this.BankAccountReferenceFieldLabelText,
			xtype: 'textfield',
			value: options.data['BankAccountReference']
		};
		return dict;

	},
	buildItems: function(dict){
		return [{
			xtype: 'fieldset',
			title: 'Member Information',
			items: [dict['Deleted'], dict['Code'], dict['Description'], dict['AuthorizedPerson']]
		}, {
			xtype: 'fieldset',
			title: 'Contact',
			defaults: {flex: 1},
			items: [dict['Phone'], dict['Fax'], dict['EMail'], dict['PostalCode'], dict['Street'], dict['City'], dict['State'], dict['Country'], dict['WebSite'], dict['ContactPerson']]
		}, {
			xtype: 'fieldset',
			title: 'Bank Account',
			fieldDefaults: {anchor: 0},
			items: [dict['BankName'], dict['BankAccountNumber'], dict['BankAccountReference']]
		}];
	},
	DeletedBoxLabelText: 'Deleted',
	CodeFieldLabelText: 'Code',
	DescriptionFieldLabelText: 'Name',
	AuthorizedPersonFieldLabelText: 'Authorized Person',
	PhoneFieldLabelText: 'Phone',
	FaxFieldLabelText: 'Fax',
	EMailFieldLabelText: 'e-mail',
	PostalCodeFieldLabelText: 'Postal Code',
	StreetFieldLabelText: 'Street',
	CityFieldLabelText: 'City',
	StateFieldLabelText: 'State',
	CountryFieldLabelText: 'Country',
	WebSiteFieldLabelText: 'Web Site',
	ContactPersonFieldLabelText: 'Contact Person',
	BankNameFieldLabelText: 'Bank',
	BankAccountNumberFieldLabelText: 'Account Number',
	BankAccountReferenceFieldLabelText: 'Account Reference'
});

Ext.define('MoneyMarket.admin.SecuritiesWindow.form.Security', {
	extend: 'Dextop.ItemFactory',
	getDictionary: function(options){
		options = options || {};
		options.data = options.data || {};
		var dict = {};
		return dict;

	},
	buildItems: function(dict){
		return [];
	}
});

Ext.define('MoneyMarket.admin.MailerTestWindow.form.MailTest', {
	extend: 'Dextop.ItemFactory',
	getDictionary: function(options){
		options = options || {};
		options.data = options.data || {};
		var dict = {};
		dict["To"] = {
			name: 'To',
			fieldLabel: this.ToFieldLabelText,
			xtype: 'textfield',
			anchor: '0',
			value: options.data['To']
		};
		dict["Subject"] = {
			name: 'Subject',
			fieldLabel: this.SubjectFieldLabelText,
			xtype: 'textfield',
			anchor: '0',
			value: options.data['Subject']
		};
		dict["Body"] = {
			name: 'Body',
			fieldLabel: this.BodyFieldLabelText,
			xtype: 'textarea',
			anchor: '0',
			value: options.data['Body'],
			height: 200
		};
		return dict;

	},
	buildItems: function(dict){
		return [dict['To'], dict['Subject'], dict['Body']];
	},
	ToFieldLabelText: 'To',
	SubjectFieldLabelText: 'Subject',
	BodyFieldLabelText: 'Body'
});

Ext.define('MoneyMarket.shared.TradesWindowBase.form.TradeFilter', {
	extend: 'Dextop.ItemFactory',
	getDictionary: function(options){
		options = options || {};
		options.data = options.data || {};
		var dict = {};
		dict["SecurityCode"] = {
			name: 'SecurityCode',
			fieldLabel: this.SecurityCodeFieldLabelText,
			xtype: 'textfield',
			anchor: '-5',
			value: options.data['SecurityCode']
		};
		dict["Account"] = {
			name: 'Account',
			fieldLabel: this.AccountFieldLabelText,
			xtype: 'textfield',
			anchor: '-5',
			value: options.data['Account']
		};
		dict["Member"] = {
			name: 'Member',
			fieldLabel: this.MemberFieldLabelText,
			xtype: 'textfield',
			anchor: '-5',
			value: options.data['Member']
		};
		dict["FromDate"] = {
			name: 'FromDate',
			fieldLabel: this.FromDateFieldLabelText,
			xtype: 'datefield',
			anchor: '-5',
			value: options.data['FromDate']
		};
		dict["ToDate"] = {
			name: 'ToDate',
			fieldLabel: this.ToDateFieldLabelText,
			xtype: 'datefield',
			anchor: '-5',
			value: options.data['ToDate']
		};
		return dict;

	},
	buildItems: function(dict){
		return [{
			xtype: 'fieldset',
			title: 'Filter by',
			items: [dict['SecurityCode'], dict['Account'], dict['Member'], dict['FromDate'], dict['ToDate']]
		}];
	},
	SecurityCodeFieldLabelText: 'Symbol',
	AccountFieldLabelText: 'Account',
	MemberFieldLabelText: 'Member',
	FromDateFieldLabelText: 'From date',
	ToDateFieldLabelText: 'To date'
});

Ext.define('MoneyMarket.admin.UsersWindow.form.User', {
	extend: 'Dextop.ItemFactory',
	getDictionary: function(options){
		options = options || {};
		options.data = options.data || {};
		var dict = {};
		dict["Deleted"] = {
			name: 'Deleted',
			xtype: 'checkboxfield',
			boxLabel: this.DeletedBoxLabelText,
			checked: options.data['Deleted'],
			hideEmptyLabel: false
		};
		dict["DisplayName"] = {
			name: 'DisplayName',
			fieldLabel: this.DisplayNameFieldLabelText,
			xtype: 'textfield',
			anchor: '0',
			allowBlank: false,
			value: options.data['DisplayName']
		};
		dict["Admin"] = {
			name: 'Admin',
			xtype: 'checkboxfield',
			boxLabel: this.AdminBoxLabelText,
			checked: options.data['Admin'],
			hideEmptyLabel: false
		};
		dict["Surveillance"] = {
			name: 'Surveillance',
			xtype: 'checkboxfield',
			boxLabel: this.SurveillanceBoxLabelText,
			checked: options.data['Surveillance'],
			hideEmptyLabel: false
		};
		dict["Broker"] = {
			name: 'Broker',
			xtype: 'checkboxfield',
			boxLabel: this.BrokerBoxLabelText,
			checked: options.data['Broker'],
			hideEmptyLabel: false
		};
		dict["MemberCode"] = {
			name: 'MemberCode',
			fieldLabel: this.MemberCodeFieldLabelText,
			xtype: 'combo',
			value: options.data['MemberCode'],
			store: options.remote.createStore('MemberCode'),
			valueField: 'id',
			queryMode: 'local',
			forceSelection: true,
			disableKeyFilter: true,
			editable: false
		};
		dict["MemberAccount"] = {
			name: 'MemberAccount',
			fieldLabel: this.MemberAccountFieldLabelText,
			xtype: 'textfield',
			value: options.data['MemberAccount'],
			regex: /^[a-zA-Z][0-9]{1,8}$/
		};
		dict["CredentialLoginEnabled"] = {
			name: 'CredentialLoginEnabled',
			xtype: 'checkboxfield',
			boxLabel: this.CredentialLoginEnabledBoxLabelText,
			checked: options.data['CredentialLoginEnabled'],
			hideEmptyLabel: false
		};
		dict["Username"] = {
			name: 'Username',
			fieldLabel: this.UsernameFieldLabelText,
			xtype: 'textfield',
			anchor: '0',
			value: options.data['Username']
		};
		dict["PasswordExpiryDate"] = {
			name: 'PasswordExpiryDate',
			fieldLabel: this.PasswordExpiryDateFieldLabelText,
			xtype: 'datefield',
			readOnly: true,
			value: options.data['PasswordExpiryDate']
		};
		dict["CertificateLoginEnabled"] = {
			name: 'CertificateLoginEnabled',
			xtype: 'checkboxfield',
			boxLabel: this.CertificateLoginEnabledBoxLabelText,
			checked: options.data['CertificateLoginEnabled'],
			hideEmptyLabel: false
		};
		dict["CertificateName"] = {
			name: 'CertificateName',
			fieldLabel: this.CertificateNameFieldLabelText,
			xtype: 'textfield',
			anchor: '0',
			readOnly: true,
			value: options.data['CertificateName']
		};
		dict["CertificateExpiryDate"] = {
			name: 'CertificateExpiryDate',
			fieldLabel: this.CertificateExpiryDateFieldLabelText,
			xtype: 'datefield',
			readOnly: true,
			value: options.data['CertificateExpiryDate']
		};
		return dict;

	},
	buildItems: function(dict){
		return [dict['Deleted'], dict['DisplayName'], {
			xtype: 'fieldset',
			title: 'Rights',
			items: [dict['Admin'], dict['Surveillance'], dict['Broker'], dict['MemberCode'], dict['MemberAccount']]
		}, {
			xtype: 'fieldset',
			title: 'Login',
			items: [dict['CredentialLoginEnabled'], dict['Username'], dict['PasswordExpiryDate'], dict['CertificateLoginEnabled'], dict['CertificateName'], dict['CertificateExpiryDate']]
		}];
	},
	DeletedBoxLabelText: 'Deleted',
	DisplayNameFieldLabelText: 'Name',
	AdminBoxLabelText: 'Administrator',
	SurveillanceBoxLabelText: 'Surveillance',
	BrokerBoxLabelText: 'Broker',
	MemberCodeFieldLabelText: 'Member',
	MemberAccountFieldLabelText: 'Account',
	CredentialLoginEnabledBoxLabelText: 'Username/Password Login',
	UsernameFieldLabelText: 'Username',
	PasswordExpiryDateFieldLabelText: 'Password Expiry',
	CertificateLoginEnabledBoxLabelText: 'Certificate Login',
	CertificateNameFieldLabelText: 'Certificate',
	CertificateExpiryDateFieldLabelText: 'Certificate Expiry'
});

Ext.define('MoneyMarket.admin.UsersWindow.form.ResetPassword', {
	extend: 'Dextop.ItemFactory',
	getDictionary: function(options){
		options = options || {};
		options.data = options.data || {};
		var dict = {};
		dict["Password"] = {
			name: 'Password',
			fieldLabel: this.PasswordFieldLabelText,
			xtype: 'textfield',
			anchor: '0',
			allowBlank: false,
			inputType: 'password',
			value: options.data['Password']
		};
		dict["Confirm"] = {
			name: 'Confirm',
			fieldLabel: this.ConfirmFieldLabelText,
			xtype: 'textfield',
			anchor: '0',
			allowBlank: false,
			inputType: 'password',
			value: options.data['Confirm']
		};
		return dict;

	},
	buildItems: function(dict){
		return [dict['Password'], dict['Confirm']];
	},
	PasswordFieldLabelText: 'New password',
	ConfirmFieldLabelText: 'Confirm password'
});

Ext.define('MoneyMarket.admin.UsersWindow.form.UploadCertificate', {
	extend: 'Dextop.ItemFactory',
	getDictionary: function(options){
		options = options || {};
		options.data = options.data || {};
		var dict = {};
		dict["Certificate"] = {
			name: 'Certificate',
			fieldLabel: this.CertificateFieldLabelText,
			xtype: 'filefield',
			anchor: '0',
			value: options.data['Certificate'],
			buttonText: 'Choose certificate...'
		};
		return dict;

	},
	buildItems: function(dict){
		return [dict['Certificate']];
	},
	CertificateFieldLabelText: 'Certificate'
});

Ext.define('MoneyMarket.admin.MemberAccountsWindow.form.MemberAccount', {
	extend: 'Dextop.ItemFactory',
	getDictionary: function(options){
		options = options || {};
		options.data = options.data || {};
		var dict = {};
		dict["Deleted"] = {
			name: 'Deleted',
			xtype: 'checkboxfield',
			boxLabel: this.DeletedBoxLabelText,
			checked: options.data['Deleted']
		};
		dict["AccountNumber"] = {
			name: 'AccountNumber',
			fieldLabel: this.AccountNumberFieldLabelText,
			xtype: 'textfield',
			allowBlank: false,
			value: options.data['AccountNumber'],
			regex: /^[a-zA-Z][0-9]{1,8}$/
		};
		dict["MemberCode"] = {
			name: 'MemberCode',
			fieldLabel: this.MemberCodeFieldLabelText,
			xtype: 'combo',
			anchor: '0',
			allowBlank: false,
			value: options.data['MemberCode'],
			store: options.remote.createStore('MemberCode'),
			valueField: 'id',
			queryMode: 'local',
			forceSelection: true,
			disableKeyFilter: true,
			editable: false
		};
		dict["MemberAlias"] = {
			name: 'MemberAlias',
			fieldLabel: this.MemberAliasFieldLabelText,
			xtype: 'textfield',
			value: options.data['MemberAlias']
		};
		dict["Description"] = {
			name: 'Description',
			fieldLabel: this.DescriptionFieldLabelText,
			xtype: 'textfield',
			anchor: '0',
			allowBlank: false,
			value: options.data['Description']
		};
		dict["AuthorizedPerson"] = {
			name: 'AuthorizedPerson',
			fieldLabel: this.AuthorizedPersonFieldLabelText,
			xtype: 'textfield',
			anchor: '0',
			value: options.data['AuthorizedPerson']
		};
		dict["Phone"] = {
			name: 'Phone',
			fieldLabel: this.PhoneFieldLabelText,
			xtype: 'textfield',
			value: options.data['Phone']
		};
		dict["Fax"] = {
			name: 'Fax',
			fieldLabel: this.FaxFieldLabelText,
			xtype: 'textfield',
			value: options.data['Fax']
		};
		dict["EMail"] = {
			name: 'EMail',
			fieldLabel: this.EMailFieldLabelText,
			xtype: 'textfield',
			value: options.data['EMail']
		};
		dict["PostalCode"] = {
			name: 'PostalCode',
			fieldLabel: this.PostalCodeFieldLabelText,
			xtype: 'textfield',
			value: options.data['PostalCode']
		};
		dict["Street"] = {
			name: 'Street',
			fieldLabel: this.StreetFieldLabelText,
			xtype: 'textfield',
			value: options.data['Street']
		};
		dict["City"] = {
			name: 'City',
			fieldLabel: this.CityFieldLabelText,
			xtype: 'textfield',
			value: options.data['City']
		};
		dict["State"] = {
			name: 'State',
			fieldLabel: this.StateFieldLabelText,
			xtype: 'textfield',
			value: options.data['State']
		};
		dict["Country"] = {
			name: 'Country',
			fieldLabel: this.CountryFieldLabelText,
			xtype: 'textfield',
			value: options.data['Country']
		};
		dict["WebSite"] = {
			name: 'WebSite',
			fieldLabel: this.WebSiteFieldLabelText,
			xtype: 'textfield',
			value: options.data['WebSite']
		};
		dict["ContactPerson"] = {
			name: 'ContactPerson',
			fieldLabel: this.ContactPersonFieldLabelText,
			xtype: 'textfield',
			value: options.data['ContactPerson']
		};
		dict["BankName"] = {
			name: 'BankName',
			fieldLabel: this.BankNameFieldLabelText,
			xtype: 'textfield',
			value: options.data['BankName']
		};
		dict["BankAccountNumber"] = {
			name: 'BankAccountNumber',
			fieldLabel: this.BankAccountNumberFieldLabelText,
			xtype: 'textfield',
			value: options.data['BankAccountNumber']
		};
		dict["BankAccountReference"] = {
			name: 'BankAccountReference',
			fieldLabel: this.BankAccountReferenceFieldLabelText,
			xtype: 'textfield',
			value: options.data['BankAccountReference']
		};
		return dict;

	},
	buildItems: function(dict){
		return [{
			xtype: 'fieldset',
			title: 'Member Account Information',
			items: [dict['Deleted'], dict['AccountNumber'], dict['MemberCode'], dict['MemberAlias'], dict['Description'], dict['AuthorizedPerson']]
		}, {
			xtype: 'fieldset',
			title: 'Contact',
			anchor: '0',
			items: [dict['Phone'], dict['Fax'], dict['EMail'], dict['PostalCode'], dict['Street'], dict['City'], dict['State'], dict['Country'], dict['WebSite'], dict['ContactPerson']]
		}, {
			xtype: 'fieldset',
			title: 'Bank',
			anchor: '0',
			items: [dict['BankName'], dict['BankAccountNumber'], dict['BankAccountReference']]
		}];
	},
	DeletedBoxLabelText: 'Deleted',
	AccountNumberFieldLabelText: 'Account',
	MemberCodeFieldLabelText: 'Member',
	MemberAliasFieldLabelText: 'Alias',
	DescriptionFieldLabelText: 'Name',
	AuthorizedPersonFieldLabelText: 'Authorized Person',
	PhoneFieldLabelText: 'Phone',
	FaxFieldLabelText: 'Fax',
	EMailFieldLabelText: 'e-mail',
	PostalCodeFieldLabelText: 'Postal Code',
	StreetFieldLabelText: 'Street',
	CityFieldLabelText: 'City',
	StateFieldLabelText: 'State',
	CountryFieldLabelText: 'Country',
	WebSiteFieldLabelText: 'Web Site',
	ContactPersonFieldLabelText: 'Contact Person',
	BankNameFieldLabelText: 'Bank',
	BankAccountNumberFieldLabelText: 'Account Number',
	BankAccountReferenceFieldLabelText: 'Account Reference'
});

