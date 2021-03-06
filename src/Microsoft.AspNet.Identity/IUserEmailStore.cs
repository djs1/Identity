// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNet.Identity
{
    /// <summary>
    ///     Stores a user's email
    /// </summary>
    /// <typeparam name="TUser"></typeparam>
    public interface IUserEmailStore<TUser> : IUserStore<TUser> where TUser : class
    {
        /// <summary>
        ///     Set the user email
        /// </summary>
        /// <param name="user"></param>
        /// <param name="email"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task SetEmailAsync(TUser user, string email, CancellationToken cancellationToken);

        /// <summary>
        ///     Get the user email
        /// </summary>
        /// <param name="user"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<string> GetEmailAsync(TUser user, CancellationToken cancellationToken);

        /// <summary>
        ///     Returns true if the user email is confirmed
        /// </summary>
        /// <param name="user"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<bool> GetEmailConfirmedAsync(TUser user, CancellationToken cancellationToken);

        /// <summary>
        ///     Sets whether the user email is confirmed
        /// </summary>
        /// <param name="user"></param>
        /// <param name="confirmed"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task SetEmailConfirmedAsync(TUser user, bool confirmed, CancellationToken cancellationToken);

        /// <summary>
        ///     Returns the user associated with this email
        /// </summary>
        /// <param name="normalizedEmail"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<TUser> FindByEmailAsync(string normalizedEmail, CancellationToken cancellationToken);

        /// <summary>
        /// Returns the normalized email
        /// </summary>
        /// <param name="user"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<string> GetNormalizedEmailAsync(TUser user, CancellationToken cancellationToken);

        /// <summary>
        ///     Set the normalized email
        /// </summary>
        /// <param name="user"></param>
        /// <param name="normalizedEmail"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task SetNormalizedEmailAsync(TUser user, string normalizedEmail, CancellationToken cancellationToken);
    }
}