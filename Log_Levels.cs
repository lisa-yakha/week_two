//task: https://exercism.org/tracks/csharp/exercises/log-levels
//first iteration:
using System;

static class LogLine
{
	public static string Message(string logLine)
	{
		int first = logLine.IndexOf(" ") + 1;
		int last = logLine.Length;
		string res = logLine.Substring(first, last - first);
		string ResTrimmed = res.Trim();
		return ResTrimmed;
	}

	public static string LogLevel(string logLine)
	{
		int first = 1;
		int last = logLine.IndexOf(":") - 1;
		string res = logLine.Substring(first, last - first);
		string ResSmall = res.ToLower();
		return ResSmall;
	}

	public static string Reformat(string logLine)
	{
		//string mes = mes.Message(logLine);
		//string level = level.LogLevel(logLine);
		//string res = message + " (" + level + ")";
		//return res;

		int first = logLine.IndexOf(" ") + 1;
		int last = logLine.Length;
		string res1 = logLine.Substring(first, last - first);
		string message = res1.Trim();
		first = 1;
		last = logLine.IndexOf(":") - 1;
		string res2 = logLine.Substring(first, last - first);
		string level = res2.ToLower();
		string res = message + " (" + level + ")";
		return res;

	}
}

//second improved iteration:
using System;

static class LogLine
{
	public static string Message(string logLine)
	{
		return logLine.Substring(logLine.IndexOf(" ") + 1).Trim();
	}

	public static string LogLevel(string logLine)
	{
		return logLine.Substring(1, logLine.IndexOf(":") - 2).Trim().ToLower();
	}

	public static string Reformat(string logLine)
	{
		return $"{Message(logLine)} ({LogLevel(logLine)})";
	}
}