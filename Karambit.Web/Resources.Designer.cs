﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Karambit.Web {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Karambit.Web.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] mimes {
            get {
                object obj = ResourceManager.GetObject("mimes", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///	&quot;200&quot; : &quot;OK&quot;,
        ///	&quot;201&quot; : &quot;Created&quot;,
        ///	&quot;204&quot; : &quot;No Content&quot;,
        ///	&quot;300&quot; : &quot;Multiple Choices&quot;,
        ///	&quot;301&quot; : &quot;Moved Permanently&quot;,
        ///	&quot;302&quot; : &quot;Found&quot;,
        ///	&quot;304&quot; : &quot;Not Modified&quot;,
        ///	&quot;307&quot; : &quot;Temporary Redirect&quot;,
        ///	&quot;400&quot; : &quot;Bad Request&quot;,
        ///	&quot;401&quot; : &quot;Unauthorized&quot;,
        ///	&quot;403&quot; : &quot;Forbidden&quot;,
        ///	&quot;404&quot; : &quot;Not Found&quot;,
        ///	&quot;410&quot; : &quot;Gone&quot;,
        ///	&quot;500&quot; : &quot;Internal Server Error&quot;,
        ///	&quot;501&quot; : &quot;Not Implemented&quot;,
        ///	&quot;503&quot; : &quot;Service Unavailable&quot;,
        ///	&quot;550&quot; : &quot;Permission Denied&quot;
        ///}.
        /// </summary>
        internal static string status {
            get {
                return ResourceManager.GetString("status", resourceCulture);
            }
        }
    }
}
