﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ExceptionStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ExceptionStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Geocrest.Web.Mvc.Resources.ExceptionStrings", typeof(ExceptionStrings).Assembly);
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
        ///   Looks up a localized string similar to Cannot set an empty value as {0}..
        /// </summary>
        internal static string CannotSetEmptyValue {
            get {
                return ResourceManager.GetString("CannotSetEmptyValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The controller discovery process has already run and the {0} cannot be changed anymore..
        /// </summary>
        internal static string ControllerDiscoveryProcessAlreadyRun {
            get {
                return ResourceManager.GetString("ControllerDiscoveryProcessAlreadyRun", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No route providing a controller name was found to match request URI &apos;{0}&apos;.
        /// </summary>
        internal static string ControllerNameNotFound {
            get {
                return ResourceManager.GetString("ControllerNameNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to did not return a controller.
        /// </summary>
        internal static string ControllerNotFoundCheck {
            get {
                return ResourceManager.GetString("ControllerNotFoundCheck", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple types were found that match the controller named &apos;{0}&apos;. This can happen if the route that services this request (&apos;{1}&apos;) found multiple controllers defined with the same name but differing namespaces, which is not supported.{3}{3}The request for &apos;{0}&apos; has found the following matching controllers:{2}.
        /// </summary>
        internal static string DefaultControllerFactory_ControllerNameAmbiguous_WithRouteTemplate {
            get {
                return ResourceManager.GetString("DefaultControllerFactory_ControllerNameAmbiguous_WithRouteTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No type was found that matches the controller named &apos;{0}&apos;..
        /// </summary>
        internal static string DefaultControllerFactory_ControllerNameNotFound {
            get {
                return ResourceManager.GetString("DefaultControllerFactory_ControllerNameNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MVC Error: The requested url &apos;{0}&apos; could not be found.
        /// </summary>
        internal static string MVC404 {
            get {
                return ResourceManager.GetString("MVC404", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A potentially dangerous Request.Path value was detected from the client.
        /// </summary>
        internal static string PotentialDanger {
            get {
                return ResourceManager.GetString("PotentialDanger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unfortunately, something went wrong during your request. The issue has been logged and we will fix it as soon as possible..
        /// </summary>
        internal static string ProductionErrorMessage {
            get {
                return ResourceManager.GetString("ProductionErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The VersionedApiExplorer class requires the default implementation of IHttpControllerSelector to be an IVersionedHttpControllerSelector.
        /// </summary>
        internal static string RequiresIVersionedHttpControllerSelector {
            get {
                return ResourceManager.GetString("RequiresIVersionedHttpControllerSelector", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No HTTP resource was found that matches the request URI &apos;{0}&apos;..
        /// </summary>
        internal static string ResourceNotFound {
            get {
                return ResourceManager.GetString("ResourceNotFound", resourceCulture);
            }
        }
    }
}
