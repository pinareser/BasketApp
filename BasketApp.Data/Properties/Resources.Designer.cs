//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BasketApp.Data.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BasketApp.Data.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to DROP DATABASE [BasketAppDb]
        ///GO
        ///
        ///.
        /// </summary>
        internal static string SeedData_Down {
            get {
                return ResourceManager.GetString("SeedData_Down", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///SET IDENTITY_INSERT [dbo].[TB_Basket] ON 
        ///
        ///INSERT [dbo].[TB_Basket] ([Id], [ProductVariantId], [CustomerId], [Count], [CreateDate]) VALUES (1, 5, 1, 1, CAST(N&apos;2021-05-12T22:17:45.420&apos; AS DateTime))
        ///INSERT [dbo].[TB_Basket] ([Id], [ProductVariantId], [CustomerId], [Count], [CreateDate]) VALUES (2, 10, 1, 2, CAST(N&apos;2021-05-12T22:17:52.397&apos; AS DateTime))
        ///INSERT [dbo].[TB_Basket] ([Id], [ProductVariantId], [CustomerId], [Count], [CreateDate]) VALUES (3, 2, 2, 1, CAST(N&apos;2021-05-12T22:18:22.517&apos; AS DateTime [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SeedData_Up {
            get {
                return ResourceManager.GetString("SeedData_Up", resourceCulture);
            }
        }
    }
}
