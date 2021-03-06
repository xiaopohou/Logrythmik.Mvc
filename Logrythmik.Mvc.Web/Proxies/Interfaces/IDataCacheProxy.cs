#region Copyright
/*
 * Copyright (c) 2005-2009 Logrythmik Consulting, LLC. - All Rights Reserved.
 *
 * This software and documentation is subject to and made
 * available only pursuant to the terms of an executed license
 * agreement, and may be used only in accordance with the terms
 * of said agreement. This document may not, in whole or in part,
 * be copied, photocopied, reproduced, translated, or reduced to
 * any electronic medium or machine-readable form without
 * prior consent, in writing, from Logrythmik Consulting, LLC.
 *
 * Use, duplication or disclosure by the U.S. Government is subject
 * to restrictions set forth in an executed license agreement
 * and in subparagraph (c)(1) of the Commercial Computer
 * Software-Restricted Rights Clause at FAR 52.227-19; subparagraph
 * (c)(1)(ii) of the Rights in Technical Data and Computer Software
 * clause at DFARS 252.227-7013, subparagraph (d) of the Commercial
 * Computer Software--Licensing clause at NASA FAR supplement
 * 16-52.227-86; or their equivalent.
 *
 * Information in this document is subject to change without notice
 * and does not represent a commitment on the part of IP Commerce.
 *
 */
#endregion

using System;
using System.Web.Caching;

namespace Logrythmik.Mvc.Proxies
{
    public interface IDataCacheProxy
    {
        void SetCache(string cacheKey, object obj);
        
        void SetCache(string cacheKey, object obj, CacheDependency dependency);
        
        void SetCache(string cacheKey, object obj, int slidingExpiration);
        
        void SetCache(string cacheKey, object obj, DateTime absoluteExpiration);

        void SetCache(string cacheKey, object obj, DateTime absoluteExpiration,
            CacheItemRemovedCallback cacheItemRemovedCallback);

        object GetCache(string cacheKey);

        T GetCache<T>(string cacheKey);
        
        void RemoveCache(string cacheKey);
        
        void ClearCacheByKey(string cacheKey);
        
        void ClearGlobalCache();

        T GetCache<T>(string key, Func<T> functionToSet);
        T GetCache<T>(string key, Func<T> functionToSet, DateTime absoluteExpiration);
        T GetCache<T>(string key, Func<T> functionToSet, int slidingExpiration);
        T GetCache<T>(string key, Func<T> functionToSet, CacheDependency cacheDependency);
    }
}