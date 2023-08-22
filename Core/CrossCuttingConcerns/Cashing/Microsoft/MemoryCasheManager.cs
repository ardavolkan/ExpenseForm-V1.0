﻿using Core.Utilities.IoC;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Core.CrossCuttingConcerns.Cashing.Microsoft
{
    public class MemoryCasheManager : ICasheManager
    {
        IMemoryCache _memoryCashe;

        public MemoryCasheManager()
        {
            _memoryCashe = ServiceTool.ServiceProvider.GetService<IMemoryCache>();
        }
        public void Add(string key, object value, int duration)
        {
            _memoryCashe.Set(key, value, TimeSpan.FromMinutes(duration));  // ne kadar süre verirsek okadar kod cashe'de kalacak.  
        }

        public T Get<T>(string key)
        {
            return _memoryCashe.Get<T>(key);
        }

        public object Get(string key)
        {
            return _memoryCashe.Get(key);
        }

        public bool IsAdd(string key)
        {
            return _memoryCashe.TryGetValue(key, out _);
        }

        public void Remove(string key)
        {
            _memoryCashe.Remove(key);
        }

        public void RemoveByPattern(string pattern)
        {
            var cacheEntriesCollectionDefinition = typeof(MemoryCache).GetProperty("EntriesCollection", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var cacheEntriesCollection = cacheEntriesCollectionDefinition.GetValue(_memoryCashe) as dynamic;
            List<ICacheEntry> cacheCollectionValues = new List<ICacheEntry>();

            foreach (var cacheItem in cacheEntriesCollection)
            {
                ICacheEntry cacheItemValue = cacheItem.GetType().GetProperty("Value").GetValue(cacheItem, null);
                cacheCollectionValues.Add(cacheItemValue);
            }

            var regex = new Regex(pattern, RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var keysToRemove = cacheCollectionValues.Where(d => regex.IsMatch(d.Key.ToString())).Select(d => d.Key).ToList();

            foreach (var key in keysToRemove)
            {
                _memoryCashe.Remove(key);
            }
        }
    }
}
