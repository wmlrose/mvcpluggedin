﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Geocrest.Web.Mvc.Resources {
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
    public class FormMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal FormMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Geocrest.Web.Mvc.Resources.FormMessages", typeof(FormMessages).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Something went wrong while removing the {0}: {1}.
        /// </summary>
        public static string DeleteFailure {
            get {
                return ResourceManager.GetString("DeleteFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have successfully removed the {0}..
        /// </summary>
        public static string DeleteSuccess {
            get {
                return ResourceManager.GetString("DeleteSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Comment deleted..
        /// </summary>
        public static string FeedbackDeleteSuccess {
            get {
                return ResourceManager.GetString("FeedbackDeleteSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thank you for your feedback..
        /// </summary>
        public static string FeedbackPostSuccess {
            get {
                return ResourceManager.GetString("FeedbackPostSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Something went wrong while adding the {0}: {1}.
        /// </summary>
        public static string PostFailure {
            get {
                return ResourceManager.GetString("PostFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have successfully added your {0} to the list..
        /// </summary>
        public static string PostSuccess {
            get {
                return ResourceManager.GetString("PostSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Something went wrong while updating the {0}: {1}.
        /// </summary>
        public static string PutFailure {
            get {
                return ResourceManager.GetString("PutFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your {0} has been successfully updated..
        /// </summary>
        public static string PutSuccess {
            get {
                return ResourceManager.GetString("PutSuccess", resourceCulture);
            }
        }
    }
}
