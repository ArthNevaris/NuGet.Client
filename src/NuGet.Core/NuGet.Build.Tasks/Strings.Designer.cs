﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGet.Build.Tasks {
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
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGet.Build.Tasks.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to Argument cannot be null or empty.
        /// </summary>
        public static string Argument_Cannot_Be_Null_Or_Empty {
            get {
                return ResourceManager.GetString("Argument_Cannot_Be_Null_Or_Empty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Created DependencyGraphSpec in {0:D2}ms..
        /// </summary>
        public static string CreatedDependencyGraphSpec {
            get {
                return ResourceManager.GetString("CreatedDependencyGraphSpec", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not an exact version like &apos;[1.0.0]&apos;. Only exact versions are allowed with PackageDownload..
        /// </summary>
        public static string Error_PackageDownload_OnlyExactVersionsAreAllowed {
            get {
                return ResourceManager.GetString("Error_PackageDownload_OnlyExactVersionsAreAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error parsing packages.config file at {0}: {1}.
        /// </summary>
        public static string Error_PackagesConfigParseError {
            get {
                return ResourceManager.GetString("Error_PackagesConfigParseError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ProjectReference &apos;{0}&apos; was resolved using &apos;{1}&apos; instead of the project target framework &apos;{2}&apos;. This project may not be fully compatible with your project..
        /// </summary>
        public static string ImportsFallbackWarning {
            get {
                return ResourceManager.GetString("ImportsFallbackWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All packages listed in {0} are already installed..
        /// </summary>
        public static string InstallCommandNothingToInstall {
            get {
                return ResourceManager.GetString("InstallCommandNothingToInstall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Project &apos;{0}&apos; targets &apos;{2}&apos;. It cannot be referenced by a project that targets &apos;{1}&apos;..
        /// </summary>
        public static string NoCompatibleTargetFramework {
            get {
                return ResourceManager.GetString("NoCompatibleTargetFramework", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find a project to restore!.
        /// </summary>
        public static string NoProjectsProvidedToTask {
            get {
                return ResourceManager.GetString("NoProjectsProvidedToTask", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nothing to do. None of the projects specified contain packages to restore..
        /// </summary>
        public static string NoProjectsToRestore {
            get {
                return ResourceManager.GetString("NoProjectsToRestore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Evaluated {0} project(s) in {1:D2}ms ({2} builds, {3} failures)..
        /// </summary>
        public static string ProjectEvaluationSummary {
            get {
                return ResourceManager.GetString("ProjectEvaluationSummary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restore canceled!.
        /// </summary>
        public static string RestoreCanceled {
            get {
                return ResourceManager.GetString("RestoreCanceled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No solution found. Restore against a solution or pass in /p:SolutionDir.
        /// </summary>
        public static string RestoreNoSolutionFound {
            get {
                return ResourceManager.GetString("RestoreNoSolutionFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The project fallback framework &apos;{0}&apos; is not a supported target framework..
        /// </summary>
        public static string UnsupportedFallbackFramework {
            get {
                return ResourceManager.GetString("UnsupportedFallbackFramework", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The project target framework &apos;{0}&apos; is not a supported target framework..
        /// </summary>
        public static string UnsupportedTargetFramework {
            get {
                return ResourceManager.GetString("UnsupportedTargetFramework", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid PackageSaveMode value &apos;{0}&apos;..
        /// </summary>
        public static string Warning_InvalidPackageSaveMode {
            get {
                return ResourceManager.GetString("Warning_InvalidPackageSaveMode", resourceCulture);
            }
        }
    }
}
