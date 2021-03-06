﻿using DotnetSpider.Core.Infrastructure;
using System;

namespace DotnetSpider.Redial
{
	public interface IRedialExecutor : INetworkExecutor
	{
		RedialResult Redial(Action action = null);
		void WaitAll();
		string CreateActionIdentity(string name);
		void DeleteActionIdentity(string identity);
	}
}
