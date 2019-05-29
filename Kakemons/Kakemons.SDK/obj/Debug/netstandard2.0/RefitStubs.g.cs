﻿// <auto-generated />
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading.Tasks;
using Kakemons.Common.Requests;
using Kakemons.Common.Responses;
using Refit;
using Kakemons.Common.Dtos;
using Kakemons.Common.Models;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

#pragma warning disable
namespace Kakemons.SDK.RefitInternalGenerated
{
    [ExcludeFromCodeCoverage]
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {

        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
    }
}
#pragma warning restore

namespace Kakemons.SDK.ApiContracts
{
    using Kakemons.SDK.RefitInternalGenerated;

    /// <inheritdoc />
    [ExcludeFromCodeCoverage]
    [DebuggerNonUserCode]
    [Preserve]
    partial class AutoGeneratedIAccountApi : IAccountApi        {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedIAccountApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<LoginUserResponse> Login(LoginRequest model)
        {
            var arguments = new object[] { model };
            var func = requestBuilder.BuildRestResultFuncForMethod("Login", new Type[] { typeof(LoginRequest) });
            return (Task<LoginUserResponse>)func(Client, arguments);
        }

    }
}

namespace Kakemons.SDK.ApiContracts
{
    using Kakemons.SDK.RefitInternalGenerated;

    /// <inheritdoc />
    [ExcludeFromCodeCoverage]
    [DebuggerNonUserCode]
    [Preserve]
    partial class AutoGeneratedIBakerApi : IBakerApi        {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedIBakerApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<BakerDto> Get(string id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("Get", new Type[] { typeof(string) });
            return (Task<BakerDto>)func(Client, arguments);
        }

    }
}

namespace Kakemons.SDK.ApiContracts
{
    using Kakemons.SDK.RefitInternalGenerated;

    /// <inheritdoc />
    [ExcludeFromCodeCoverage]
    [DebuggerNonUserCode]
    [Preserve]
    partial class AutoGeneratedICakeApi : ICakeApi        {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedICakeApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task<IEnumerable<CakeDto>> GetNearbyCakes(DbPosition argPosition)
        {
            var arguments = new object[] { argPosition };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetNearbyCakes", new Type[] { typeof(DbPosition) });
            return (Task<IEnumerable<CakeDto>>)func(Client, arguments);
        }

    }
}

namespace Kakemons.SDK.ApiContracts
{
    using Kakemons.SDK.RefitInternalGenerated;

    /// <inheritdoc />
    [ExcludeFromCodeCoverage]
    [DebuggerNonUserCode]
    [Preserve]
    partial class AutoGeneratedIChatApi : IChatApi        {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedIChatApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        public virtual Task DeleteMessage(int id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("DeleteMessage", new Type[] { typeof(int) });
            return (Task)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task<IEnumerable<ChatMessageDto>> GetChatsForUser(string id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetChatsForUser", new Type[] { typeof(string) });
            return (Task<IEnumerable<ChatMessageDto>>)func(Client, arguments);
        }

        /// <inheritdoc />
        public virtual Task SendMessage(ChatMessageDto chatMessage)
        {
            var arguments = new object[] { chatMessage };
            var func = requestBuilder.BuildRestResultFuncForMethod("SendMessage", new Type[] { typeof(ChatMessageDto) });
            return (Task)func(Client, arguments);
        }

    }
}
