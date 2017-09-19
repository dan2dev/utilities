using System;

namespace Dan2Dev.Utilities {
	public static partial class Util {
		public static string ToCamelCase(this string value) {
			var splited = Split(value);
			string returnValue = "";
			for (int i = 0; i < splited.Length; i++) {
				string part = splited[i];
				if (i == 0) {
					returnValue += part.ToLowerInvariant();
				} else {
					returnValue += part.UppercaseFirstLetter();
				}
			}
			return returnValue;
		}
		public static string ToPascalCase(this string value) {
			var splited = Split(value);
			string returnValue = "";
			foreach (var part in splited) {
				returnValue += UppercaseFirstLetter(part);
			}
			return returnValue;
		}
		private static string[] Split(string value) {
			return value.Replace("_", "-").Replace(".", "-").Split("-");
		}
		public static string UppercaseFirstLetter(this string value) {
			if (string.IsNullOrWhiteSpace(value) || value.Length <= 1) {
				return value.ToUpperInvariant();
			} else {
				return char.ToUpperInvariant(value[0]) + value.Substring(1).ToLowerInvariant();
			}
		}
	}
}
