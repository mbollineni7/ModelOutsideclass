using System;

namespace DSHS.CMBHS.Model
{
    

    public class SystemUserListBase : AbstractDomainObject
    {

        #region SystemUserListViewBase Constructor

        public SystemUserListBase()
            : base()
        {

        }

        #endregion

        #region Table Attribute Accessors

        public string OrderBy { get; set; }
        public virtual int PersonNbr { get; set; }
        public virtual string MiddleName { get; set; }
        #region MiddleNameSpecified property accessor
        /// <summary>
        /// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
        /// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
        /// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
        /// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
        /// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
        /// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public virtual bool MiddleNameSpecified
        {
            get { return MiddleName != string.Empty; }
        }

        #endregion MiddleNameSpecified property accessor
        public virtual string Name { get; set; }
        #region NameSpecified property accessor
        /// <summary>
        /// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
        /// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
        /// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
        /// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
        /// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
        /// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public virtual bool NameSpecified
        {
            get { return Name != string.Empty; }
        }

        #endregion NameSpecified property accessor
        public virtual string UserId { get; set; }
        #region UserIdSpecified property accessor
        /// <summary>
        /// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
        /// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
        /// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
        /// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
        /// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
        /// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public virtual bool UserIdSpecified
        {
            get { return UserId != string.Empty; }
        }

        #endregion UserIdSpecified property accessor

        public virtual string PersonTitle { get; set; }

        #region PersonTitleSpecified property accessor
        /// <summary>
        /// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
        /// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
        /// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
        /// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
        /// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
        /// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public virtual bool PersonTitleSpecified
        {
            get { return PersonTitle != string.Empty; }
        }

        #endregion PersonTitleSpecified property accessor


        public virtual DateTime DateOfBirth { get; set; }

        #region DateOfBirthSpecified property accessor
        /// <summary>
        /// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
        /// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
        /// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
        /// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
        /// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
        /// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public virtual bool DateOfBirthSpecified
        {
            get { return DateOfBirth != DateTime.MinValue; }
        }

        #endregion DateOfBirthSpecified property accessor


        public virtual short AccountStatus { get; set; }

        public virtual string AccountStatusText { get; set; }

        #region AccountStatusTextSpecified property accessor
        /// <summary>
        /// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
        /// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
        /// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
        /// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
        /// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
        /// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public virtual bool AccountStatusTextSpecified
        {
            get { return AccountStatusText != string.Empty; }
        }

        #endregion AccountStatusTextSpecified property accessor


        public virtual string UpperAccountStatusText { get; set; }

        #region UpperAccountStatusTextSpecified property accessor
        /// <summary>
        /// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
        /// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
        /// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
        /// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
        /// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
        /// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public virtual bool UpperAccountStatusTextSpecified
        {
            get { return UpperAccountStatusText != string.Empty; }
        }

        #endregion UpperAccountStatusTextSpecified property accessor


        [DSHS.CMBHS.Model.CustomAttribute.ReferencedClass("DSHS.CMBHS.Model.OrganizationBase,DSHS.CMBHS.Model")]
        public virtual int OrganizationNbr { get; set; }

        public virtual string OrganizationName { get; set; }

        [DSHS.CMBHS.Model.CustomAttribute.ReferencedClass("DSHS.CMBHS.Model.OrganizationBase,DSHS.CMBHS.Model")]
        public virtual int ParentOrganizationNbr { get; set; }

        #region ParentOrganizationNbrSpecified property accessor
        /// <summary>
        /// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
        /// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
        /// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
        /// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
        /// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
        /// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public virtual bool ParentOrganizationNbrSpecified
        {
            get { return ParentOrganizationNbr != int.MinValue; }
        }

        #endregion ParentOrganizationNbrSpecified property accessor


        public virtual string Roles { get; set; }

        public virtual string PhoneNumber { get; set; }

        #region PhoneNumberSpecified property accessor
        /// <summary>
        /// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
        /// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
        /// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
        /// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
        /// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
        /// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public virtual bool PhoneNumberSpecified
        {
            get { return PhoneNumber != string.Empty; }
        }

        #endregion PhoneNumberSpecified property accessor


        public virtual string ParentOrganizationName { get; set; }

        public virtual string PrimaryOrganization { get; set; }
        #endregion Table Attribute Accessors
    }
}
