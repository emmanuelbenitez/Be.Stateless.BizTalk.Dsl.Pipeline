﻿#region Copyright & License

// Copyright © 2012 - 2020 François Chabot
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Be.Stateless.BizTalk.Dsl.Pipeline
{
	[SuppressMessage("Design", "CA1724:Type names should not match namespaces")]
	public abstract class Pipeline<T> : IFluentInterface, IVisitable<IPipelineVisitor> where T : IPipelineStageList
	{
		[SuppressMessage("Design", "CA1065:Do not raise exceptions in unexpected locations")]
		static Pipeline()
		{
			if (!typeof(IReceivePipelineStageList).IsAssignableFrom(typeof(T)) && !typeof(ISendPipelineStageList).IsAssignableFrom(typeof(T)))
				throw new ArgumentException(
					$"A pipeline does not support {typeof(T).Name} as a stage container because it does not derive from either IReceivePipelineStageList or ISendPipelineStageList.");
		}

		protected Pipeline(T stages)
		{
			Stages = stages;
			Version = new Version(1, 0);
			VersionDependentGuid = Guid.NewGuid();
		}

		#region IFluentInterface Members

		[EditorBrowsable(EditorBrowsableState.Never)]
		[SuppressMessage("ReSharper", "BaseObjectEqualsIsObjectEquals")]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[SuppressMessage("ReSharper", "BaseObjectGetHashCodeCallInGetHashCode")]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		#endregion

		#region IVisitable<IPipelineVisitor> Members

		[SuppressMessage("Design", "CA1033:Interface methods should be callable by child types")]
		void IVisitable<IPipelineVisitor>.Accept(IPipelineVisitor visitor)
		{
			visitor.VisitPipeline(this);
			((IVisitable<IPipelineVisitor>) Stages).Accept(visitor);
		}

		#endregion

		public string Description { get; protected set; }

		public T Stages { get; }

		public Version Version { get; protected set; }

		public Guid VersionDependentGuid { get; set; }
	}
}
