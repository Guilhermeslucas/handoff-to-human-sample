﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MessageRouting.Resources {
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
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MessageRouting.Resources.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to Hi {0}, I&apos;m connecting you with &quot;{1}&quot; who sent the following message: &quot;{2}&quot;. To end the conversation with the him, just send me an &quot;{3}&quot; message..
        /// </summary>
        internal static string AgentConnectedWithUserMessage {
            get {
                return ResourceManager.GetString("AgentConnectedWithUserMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are not supposed to talk with me unless I ask you to do so..
        /// </summary>
        internal static string AgentNotBusyMessage {
            get {
                return ResourceManager.GetString("AgentNotBusyMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thanks {0}. You are now registered as an agent..
        /// </summary>
        internal static string AgentRegisteredMessage {
            get {
                return ResourceManager.GetString("AgentRegisteredMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to end conversation.
        /// </summary>
        internal static string EndOfConversationCommand {
            get {
                return ResourceManager.GetString("EndOfConversationCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}, thanks for helping {1}. You are now available again..
        /// </summary>
        internal static string EndOfConversationMessageForAgent {
            get {
                return ResourceManager.GetString("EndOfConversationMessageForAgent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thanks for contacting us. I&apos;m glad we were able to help you. Have a good day!.
        /// </summary>
        internal static string EndOfConversationMessageForUser {
            get {
                return ResourceManager.GetString("EndOfConversationMessageForUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to register.
        /// </summary>
        internal static string RegisterCommand {
            get {
                return ResourceManager.GetString("RegisterCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} says: {1}.
        /// </summary>
        internal static string UserToAgentMessage {
            get {
                return ResourceManager.GetString("UserToAgentMessage", resourceCulture);
            }
        }
    }
}