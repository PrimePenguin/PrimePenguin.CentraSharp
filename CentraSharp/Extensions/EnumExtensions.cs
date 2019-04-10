using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace PrimePenguin.CentraSharp.Extensions
{
    /// <summary>
    ///     Enum Extension Method
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        ///     Reads and uses the enum's <see cref="EnumMemberAttribute" /> for serialization.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ToSerializedString(this Enum input)
        {
            var name = input.ToString();
            var info = input.GetType().GetTypeInfo().DeclaredMembers.Where(i => i.Name == name);
            var memberInfos = info as MemberInfo[] ?? info.ToArray();
            if (!memberInfos.Any()) return name.ToLower();
            var attribute = memberInfos.First().GetCustomAttribute<EnumMemberAttribute>();
            return attribute != null ? attribute.Value : name.ToLower();
        }

        /// <summary>
        ///     Convert list of Enums to a comma seperated string
        /// </summary>
        public static string EnumListToString<T>(IEnumerable<T> enumList)
        {
            var list = new List<string>();
            var enumItems = enumList as T[] ?? enumList.ToArray();
            if (!enumItems.Any()) return string.Join(",", list);
            list.AddRange(enumItems.Select(enumItem => (enumItem as Enum).ToSerializedString()));
            return string.Join(",", list);
        }
    }
}