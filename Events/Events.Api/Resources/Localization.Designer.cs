﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kvpbldsck.NastolochkiAPI.Events.Api.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Localization {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Localization() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Kvpbldsck.NastolochkiAPI.Events.Api.Resources.Localization", typeof(Localization).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event already exists.
        /// </summary>
        internal static string EventAlredyExists {
            get {
                return ResourceManager.GetString("EventAlredyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event description length should be less than or equal to 2000.
        /// </summary>
        internal static string EventDescriptionTooLong {
            get {
                return ResourceManager.GetString("EventDescriptionTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event {0} already exists.
        /// </summary>
        internal static string EventGuidAlreadyExists {
            get {
                return ResourceManager.GetString("EventGuidAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event name should be set.
        /// </summary>
        internal static string EventNameIsEmpty {
            get {
                return ResourceManager.GetString("EventNameIsEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event name length should be less than or equal to 200.
        /// </summary>
        internal static string EventNameTooLong {
            get {
                return ResourceManager.GetString("EventNameTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event should have partisipants.
        /// </summary>
        internal static string EventNoParticipants {
            get {
                return ResourceManager.GetString("EventNoParticipants", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event {0} not found.
        /// </summary>
        internal static string EventNotFound {
            get {
                return ResourceManager.GetString("EventNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event can&apos;t be scheduled on past date.
        /// </summary>
        internal static string EventOutdated {
            get {
                return ResourceManager.GetString("EventOutdated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event date should be set.
        /// </summary>
        internal static string EventTimeDatesIsEmpty {
            get {
                return ResourceManager.GetString("EventTimeDatesIsEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ooops, something goes wrong.
        /// </summary>
        internal static string InternalError {
            get {
                return ResourceManager.GetString("InternalError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Location address should be set.
        /// </summary>
        internal static string LocationAddressIsEmpty {
            get {
                return ResourceManager.GetString("LocationAddressIsEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Location address length should be less than or equal to 300.
        /// </summary>
        internal static string LocationAddressTooLong {
            get {
                return ResourceManager.GetString("LocationAddressTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Location {0} already exists.
        /// </summary>
        internal static string LocationGuidAlreadyExists {
            get {
                return ResourceManager.GetString("LocationGuidAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Location name length should be less than or equal to 300.
        /// </summary>
        internal static string LocationNameTooLong {
            get {
                return ResourceManager.GetString("LocationNameTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Location {0} not found.
        /// </summary>
        internal static string LocationNotFound {
            get {
                return ResourceManager.GetString("LocationNotFound", resourceCulture);
            }
        }
    }
}
