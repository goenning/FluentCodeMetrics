﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.269
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace FluentCodeMetrics.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Calcular Acoplamento Eferente (Ce)")]
    public partial class CalcularAcoplamentoEferenteCeFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "EfferentCoupling.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Calcular Acoplamento Eferente (Ce)", @"
Acomplamento Eferente é uma métrica que indica a quantidade
de referências de um tipo para outros.

Entram na contagem: classe base, interfaces implementadas, 
tipos dos variáveis locais, atributos e das propriedades, 
tipos dos parâmetros em métodos e construtores, exceptions,
propriedades e métodos estáticos (obrigado @pedroreys),
eventos e atributos (obrigado @IsraelAece).

Importante destacar que Nested Types devem ser ignorados 
(obrigado @wnoizumi)

Como o objetivo é identificar a ""complexidade"" de um tipo,
considero também as referências ""herdadas"".", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calcular Acoplamento Eferente para um tipo")]
        [NUnit.Framework.TestCaseAttribute("Samples.EmptyClass", "8", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Samples.SingleArgCtor", "9", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Samples.SingleArgVoidMethod", "9", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Samples.FeeMethod", "9", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Samples.DateTimeArgDateTimeMethod", "9", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Samples.SingleProperty", "10", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Samples.SingleField", "9", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Samples.ExceptionRaiser", "9", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Samples.SingleNonAutoProperty", "9", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Samples.SingleEvent", "9", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Samples.Attributes", "12", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Samples.StaticMember", "10", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Samples.ClassDependsOnASubClass", "8", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Samples.StaticPropertyAndMethodCall", "10", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Samples.TryCatch", "9", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Samples.TryCatchWithUndefinedType", "8", new string[0])]
        public virtual void CalcularAcoplamentoEferenteParaUmTipo(string tipo, string ce, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calcular Acoplamento Eferente para um tipo", exampleTags);
#line 20
 this.ScenarioSetup(scenarioInfo);
#line 21
  testRunner.Given(string.Format("que tenho um {0}", tipo));
#line 22
  testRunner.When("desejo obter seu acoplamento eferente");
#line 23
  testRunner.Then(string.Format("obtenho {0}", ce));
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
