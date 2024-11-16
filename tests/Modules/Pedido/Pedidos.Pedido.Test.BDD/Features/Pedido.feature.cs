﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:2.0.0.0
//      Reqnroll Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Pedidos.Pedido.Test.BDD.Features
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class PedidoFeature : object, Xunit.IClassFixture<PedidoFeature.FixtureData>, Xunit.IAsyncLifetime
    {
        
        private static global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Pedido.feature"
#line hidden
        
        public PedidoFeature(PedidoFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
        }
        
        public static async System.Threading.Tasks.Task FeatureSetupAsync()
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(null, global::Reqnroll.xUnit.ReqnrollPlugin.XUnitParallelWorkerTracker.Instance.GetWorkerId());
            global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Features", "Pedido", "\tComo usuario\r\n\tQuero criar e atualizar pedidos", global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
            await testRunner.OnFeatureStartAsync(featureInfo);
        }
        
        public static async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
            string testWorkerId = testRunner.TestWorkerId;
            await testRunner.OnFeatureEndAsync();
            testRunner = null;
            global::Reqnroll.xUnit.ReqnrollPlugin.XUnitParallelWorkerTracker.Instance.ReleaseWorker(testWorkerId);
        }
        
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
        }
        
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
        }
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        async System.Threading.Tasks.Task Xunit.IAsyncLifetime.InitializeAsync()
        {
            await this.TestInitializeAsync();
        }
        
        async System.Threading.Tasks.Task Xunit.IAsyncLifetime.DisposeAsync()
        {
            await this.TestTearDownAsync();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="ConfirmarPedido")]
        [Xunit.TraitAttribute("FeatureTitle", "Pedido")]
        [Xunit.TraitAttribute("Description", "ConfirmarPedido")]
        public async System.Threading.Tasks.Task ConfirmarPedido()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("ConfirmarPedido", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 6
 await testRunner.GivenAsync("Pedido onde o Status é Preparando", ((string)(null)), ((global::Reqnroll.Table)(null)), "Dado ");
#line hidden
#line 7
 await testRunner.WhenAsync("Confirmar o pedido", ((string)(null)), ((global::Reqnroll.Table)(null)), "Quando ");
#line hidden
#line 8
 await testRunner.ThenAsync("Lança uma DomainNotificationException", ((string)(null)), ((global::Reqnroll.Table)(null)), "Então ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="ConfirmarPedido2")]
        [Xunit.TraitAttribute("FeatureTitle", "Pedido")]
        [Xunit.TraitAttribute("Description", "ConfirmarPedido2")]
        public async System.Threading.Tasks.Task ConfirmarPedido2()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("ConfirmarPedido2", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 10
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 11
 await testRunner.GivenAsync("Pedido onde o Status é nulo", ((string)(null)), ((global::Reqnroll.Table)(null)), "Dado ");
#line hidden
#line 12
 await testRunner.WhenAsync("Confirmar o pedido", ((string)(null)), ((global::Reqnroll.Table)(null)), "Quando ");
#line hidden
#line 13
 await testRunner.ThenAsync("Status é atualizado para Recebido", ((string)(null)), ((global::Reqnroll.Table)(null)), "Então ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="IniciarPreparo")]
        [Xunit.TraitAttribute("FeatureTitle", "Pedido")]
        [Xunit.TraitAttribute("Description", "IniciarPreparo")]
        public async System.Threading.Tasks.Task IniciarPreparo()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("IniciarPreparo", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 15
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 16
 await testRunner.GivenAsync("Pedido onde o Status é Pronto", ((string)(null)), ((global::Reqnroll.Table)(null)), "Dado ");
#line hidden
#line 17
 await testRunner.WhenAsync("Iniciar Preparo", ((string)(null)), ((global::Reqnroll.Table)(null)), "Quando ");
#line hidden
#line 18
 await testRunner.ThenAsync("Lança uma DomainNotificationException", ((string)(null)), ((global::Reqnroll.Table)(null)), "Então ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="IniciarPreparo2")]
        [Xunit.TraitAttribute("FeatureTitle", "Pedido")]
        [Xunit.TraitAttribute("Description", "IniciarPreparo2")]
        public async System.Threading.Tasks.Task IniciarPreparo2()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("IniciarPreparo2", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 20
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 21
 await testRunner.GivenAsync("Pedido onde o Status é Recebido", ((string)(null)), ((global::Reqnroll.Table)(null)), "Dado ");
#line hidden
#line 22
 await testRunner.WhenAsync("Iniciar Preparo", ((string)(null)), ((global::Reqnroll.Table)(null)), "Quando ");
#line hidden
#line 23
 await testRunner.ThenAsync("Status é atualizado para Preparando", ((string)(null)), ((global::Reqnroll.Table)(null)), "Então ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="FinalizarPreparo")]
        [Xunit.TraitAttribute("FeatureTitle", "Pedido")]
        [Xunit.TraitAttribute("Description", "FinalizarPreparo")]
        public async System.Threading.Tasks.Task FinalizarPreparo()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("FinalizarPreparo", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 25
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 26
 await testRunner.GivenAsync("Pedido onde o Status é Recebido", ((string)(null)), ((global::Reqnroll.Table)(null)), "Dado ");
#line hidden
#line 27
 await testRunner.WhenAsync("Finalizar Preparo", ((string)(null)), ((global::Reqnroll.Table)(null)), "Quando ");
#line hidden
#line 28
 await testRunner.ThenAsync("Lança uma DomainNotificationException", ((string)(null)), ((global::Reqnroll.Table)(null)), "Então ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="FinalizarPreparo2")]
        [Xunit.TraitAttribute("FeatureTitle", "Pedido")]
        [Xunit.TraitAttribute("Description", "FinalizarPreparo2")]
        public async System.Threading.Tasks.Task FinalizarPreparo2()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("FinalizarPreparo2", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 30
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 31
 await testRunner.GivenAsync("Pedido onde o Status é Preparando", ((string)(null)), ((global::Reqnroll.Table)(null)), "Dado ");
#line hidden
#line 32
 await testRunner.WhenAsync("Finalizar Preparo", ((string)(null)), ((global::Reqnroll.Table)(null)), "Quando ");
#line hidden
#line 33
 await testRunner.ThenAsync("Status é atualizado para Pronto", ((string)(null)), ((global::Reqnroll.Table)(null)), "Então ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="FinalizarPedido")]
        [Xunit.TraitAttribute("FeatureTitle", "Pedido")]
        [Xunit.TraitAttribute("Description", "FinalizarPedido")]
        public async System.Threading.Tasks.Task FinalizarPedido()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("FinalizarPedido", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 35
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 36
 await testRunner.GivenAsync("Pedido onde o Status é Recebido", ((string)(null)), ((global::Reqnroll.Table)(null)), "Dado ");
#line hidden
#line 37
 await testRunner.WhenAsync("Finalizar Pedido", ((string)(null)), ((global::Reqnroll.Table)(null)), "Quando ");
#line hidden
#line 38
 await testRunner.ThenAsync("Lança uma DomainNotificationException", ((string)(null)), ((global::Reqnroll.Table)(null)), "Então ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="FinalizarPedido2")]
        [Xunit.TraitAttribute("FeatureTitle", "Pedido")]
        [Xunit.TraitAttribute("Description", "FinalizarPedido2")]
        public async System.Threading.Tasks.Task FinalizarPedido2()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("FinalizarPedido2", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 40
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 41
 await testRunner.GivenAsync("Pedido onde o Status é Pronto", ((string)(null)), ((global::Reqnroll.Table)(null)), "Dado ");
#line hidden
#line 42
 await testRunner.WhenAsync("Finalizar Pedido", ((string)(null)), ((global::Reqnroll.Table)(null)), "Quando ");
#line hidden
#line 43
 await testRunner.ThenAsync("Status é atualizado para Finalizado", ((string)(null)), ((global::Reqnroll.Table)(null)), "Então ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : object, Xunit.IAsyncLifetime
        {
            
            async System.Threading.Tasks.Task Xunit.IAsyncLifetime.InitializeAsync()
            {
                await PedidoFeature.FeatureSetupAsync();
            }
            
            async System.Threading.Tasks.Task Xunit.IAsyncLifetime.DisposeAsync()
            {
                await PedidoFeature.FeatureTearDownAsync();
            }
        }
    }
}
#pragma warning restore
#endregion
