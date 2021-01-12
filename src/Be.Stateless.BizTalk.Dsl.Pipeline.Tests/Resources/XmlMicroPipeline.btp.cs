﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Be.Stateless.BizTalk.Dummies
{
	
	
	public sealed class XmlMicroPipeline : Microsoft.BizTalk.PipelineOM.SendPipeline
	{
		
		public XmlMicroPipeline()
		{
			Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(Microsoft.BizTalk.PipelineOM.Stage.Any, Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
			Microsoft.BizTalk.Component.Interop.IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Be.Stateless.BizTalk.Component.FailedMessageRoutingEnablerComponent, Be.Stateless.BizTalk.Pipeline.Components, Version=2.0.0.0, Culture=neutral, PublicKeyToken=3707daa0b119fc14");
			if (comp0.GetType().IsInstanceOfType(typeof(Microsoft.BizTalk.Component.Interop.IPersistPropertyBag)))
			{
				((Microsoft.BizTalk.Component.Interop.IPersistPropertyBag)(comp0)).Load(new Microsoft.BizTalk.PipelineOM.PropertyBag(new System.Collections.ArrayList(new Microsoft.BizTalk.PipelineOM.PropertyContents[] {
									new Microsoft.BizTalk.PipelineOM.PropertyContents("Enabled", true),
									new Microsoft.BizTalk.PipelineOM.PropertyContents("EnableFailedMessageRouting", true),
									new Microsoft.BizTalk.PipelineOM.PropertyContents("SuppressRoutingFailureReport", false)})), 0);
			}
			this.AddComponent(stage, comp0);
			Microsoft.BizTalk.Component.Interop.IBaseComponent comp1 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Be.Stateless.BizTalk.Component.MicroPipelineComponent, Be.Stateless.BizTalk.Pipeline.Components, Version=2.0.0.0, Culture=neutral, PublicKeyToken=3707daa0b119fc14");
			if (comp1.GetType().IsInstanceOfType(typeof(Microsoft.BizTalk.Component.Interop.IPersistPropertyBag)))
			{
				((Microsoft.BizTalk.Component.Interop.IPersistPropertyBag)(comp1)).Load(new Microsoft.BizTalk.PipelineOM.PropertyBag(new System.Collections.ArrayList(new Microsoft.BizTalk.PipelineOM.PropertyContents[] {
									new Microsoft.BizTalk.PipelineOM.PropertyContents("Enabled", true),
									new Microsoft.BizTalk.PipelineOM.PropertyContents("Components", "<mComponents><mComponent name='Be.Stateless.BizTalk.MicroComponent.ContextPropertyExtractor, Be.Stateless.BizTalk.Pipeline.MicroComponents, Version=2.0.0.0, Culture=neutral, PublicKeyToken=3707daa0b119fc14'><Extractors><s0:Properties xmlns:s0='urn:schemas.stateless.be:biztalk:annotations:2013:01' xmlns:s1='urn:schemas.stateless.be:biztalk:properties:system:2012:04'><s1:MapTypeName mode='promote' xpath='/letter/*/from' /><s1:MessageType xpath='/letter/*/paragraph' /></s0:Properties></Extractors></mComponent></mComponents>")})), 0);
			}
			this.AddComponent(stage, comp1);
			stage = this.AddStage(Microsoft.BizTalk.PipelineOM.Stage.AssemblingSerializer, Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
			Microsoft.BizTalk.Component.Interop.IBaseComponent comp2 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.XmlAsmComp, Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");
			if (comp2.GetType().IsInstanceOfType(typeof(Microsoft.BizTalk.Component.Interop.IPersistPropertyBag)))
			{
				((Microsoft.BizTalk.Component.Interop.IPersistPropertyBag)(comp2)).Load(new Microsoft.BizTalk.PipelineOM.PropertyBag(new System.Collections.ArrayList(new Microsoft.BizTalk.PipelineOM.PropertyContents[] {
									new Microsoft.BizTalk.PipelineOM.PropertyContents("EnvelopeDocSpecNames", ""),
									new Microsoft.BizTalk.PipelineOM.PropertyContents("EnvelopeSpecTargetNamespaces", ""),
									new Microsoft.BizTalk.PipelineOM.PropertyContents("DocumentSpecNames", ""),
									new Microsoft.BizTalk.PipelineOM.PropertyContents("DocumentSpecTargetNamespaces", ""),
									new Microsoft.BizTalk.PipelineOM.PropertyContents("XmlAsmProcessingInstructions", ""),
									new Microsoft.BizTalk.PipelineOM.PropertyContents("ProcessingInstructionsOptions", Microsoft.BizTalk.Component.XmlAsmComp.ProcessingInstructionsOptions.Append),
									new Microsoft.BizTalk.PipelineOM.PropertyContents("ProcessingInstructionsScope", Microsoft.BizTalk.Component.XmlAsmComp.ProcessingInstructionsScopes.Document),
									new Microsoft.BizTalk.PipelineOM.PropertyContents("AddXmlDeclaration", true),
									new Microsoft.BizTalk.PipelineOM.PropertyContents("TargetCharset", ""),
									new Microsoft.BizTalk.PipelineOM.PropertyContents("TargetCodePage", 0),
									new Microsoft.BizTalk.PipelineOM.PropertyContents("PreserveBom", true),
									new Microsoft.BizTalk.PipelineOM.PropertyContents("HiddenProperties", "EnvelopeSpecTargetNamespaces,DocumentSpecTargetNamespaces,TargetCodePage")})), 0);
			}
			this.AddComponent(stage, comp2);
			stage = this.AddStage(Microsoft.BizTalk.PipelineOM.Stage.Encoder, Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
			Microsoft.BizTalk.Component.Interop.IBaseComponent comp3 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Be.Stateless.BizTalk.Component.MicroPipelineComponent, Be.Stateless.BizTalk.Pipeline.Components, Version=2.0.0.0, Culture=neutral, PublicKeyToken=3707daa0b119fc14");
			if (comp3.GetType().IsInstanceOfType(typeof(Microsoft.BizTalk.Component.Interop.IPersistPropertyBag)))
			{
				((Microsoft.BizTalk.Component.Interop.IPersistPropertyBag)(comp3)).Load(new Microsoft.BizTalk.PipelineOM.PropertyBag(new System.Collections.ArrayList(new Microsoft.BizTalk.PipelineOM.PropertyContents[] {
									new Microsoft.BizTalk.PipelineOM.PropertyContents("Enabled", true),
									new Microsoft.BizTalk.PipelineOM.PropertyContents("Components", "")})), 0);
			}
			this.AddComponent(stage, comp3);
		}
		
		public override string XmlContent
		{
			get
			{
				return _strPipeline;
			}
		}
		
		private const string _strPipeline = @"$$PipelineRuntimeDocument$$";
		
		public override System.Guid VersionDependentGuid
		{
			get
			{
				return new System.Guid(_versionDependentGuid);
			}
		}
		
		private const string _versionDependentGuid = "55a6e50d-1750-4ccd-8995-e5151b049a01";
	}
}
