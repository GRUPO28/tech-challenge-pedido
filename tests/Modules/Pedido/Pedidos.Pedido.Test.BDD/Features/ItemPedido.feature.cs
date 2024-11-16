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
    public partial class ItemPedidoFeature : object, Xunit.IClassFixture<ItemPedidoFeature.FixtureData>, Xunit.IAsyncLifetime
    {
        
        private static global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "ItemPedido.feature"
#line hidden
        
        public ItemPedidoFeature(ItemPedidoFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
        }
        
        public static async System.Threading.Tasks.Task FeatureSetupAsync()
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(null, global::Reqnroll.xUnit.ReqnrollPlugin.XUnitParallelWorkerTracker.Instance.GetWorkerId());
            global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Features", "ItemPedido", "\tComo usuario\r\n\tQuero criar Itens de Pedidos", global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
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
        
        [Xunit.SkippableFactAttribute(DisplayName="CriarItem1")]
        [Xunit.TraitAttribute("FeatureTitle", "ItemPedido")]
        [Xunit.TraitAttribute("Description", "CriarItem1")]
        public async System.Threading.Tasks.Task CriarItem1()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("CriarItem1", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
 await testRunner.GivenAsync("Que a quantidade é 0", ((string)(null)), ((global::Reqnroll.Table)(null)), "Dado ");
#line hidden
#line 7
 await testRunner.WhenAsync("Eu tentar criar um item de pedido", ((string)(null)), ((global::Reqnroll.Table)(null)), "Quando ");
#line hidden
#line 8
 await testRunner.ThenAsync("Lança uma DomainNotificationException para o Item", ((string)(null)), ((global::Reqnroll.Table)(null)), "Então ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="CriarItem2")]
        [Xunit.TraitAttribute("FeatureTitle", "ItemPedido")]
        [Xunit.TraitAttribute("Description", "CriarItem2")]
        public async System.Threading.Tasks.Task CriarItem2()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("CriarItem2", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
 await testRunner.GivenAsync("Que a quantidade é -1", ((string)(null)), ((global::Reqnroll.Table)(null)), "Dado ");
#line hidden
#line 12
 await testRunner.WhenAsync("Eu tentar criar um item de pedido", ((string)(null)), ((global::Reqnroll.Table)(null)), "Quando ");
#line hidden
#line 13
 await testRunner.ThenAsync("Lança uma DomainNotificationException para o Item", ((string)(null)), ((global::Reqnroll.Table)(null)), "Então ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="CriarItem3")]
        [Xunit.TraitAttribute("FeatureTitle", "ItemPedido")]
        [Xunit.TraitAttribute("Description", "CriarItem3")]
        public async System.Threading.Tasks.Task CriarItem3()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("CriarItem3", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
 await testRunner.GivenAsync("Que a quantidade é 1", ((string)(null)), ((global::Reqnroll.Table)(null)), "Dado ");
#line hidden
#line 17
 await testRunner.WhenAsync("Eu tentar criar um item de pedido", ((string)(null)), ((global::Reqnroll.Table)(null)), "Quando ");
#line hidden
#line 18
 await testRunner.ThenAsync("Item é criado com sucesso", ((string)(null)), ((global::Reqnroll.Table)(null)), "Então ");
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
                await ItemPedidoFeature.FeatureSetupAsync();
            }
            
            async System.Threading.Tasks.Task Xunit.IAsyncLifetime.DisposeAsync()
            {
                await ItemPedidoFeature.FeatureTearDownAsync();
            }
        }
    }
}
#pragma warning restore
#endregion