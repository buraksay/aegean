<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE module PUBLIC "-//Puppy Crawl//DTD Check Configuration 1.3//EN" "http://www.puppycrawl.com/dtds/configuration_1_3.dtd">

<!--
    This configuration file was written by the eclipse-cs plugin configuration editor
-->
<!--
    Checkstyle-Configuration: Aegean Checkstyle
    Description: none
-->
<module name="Checker">
  <property name="severity" value="warning"/>
  <module name="TreeWalker">
    <property name="tabWidth" value="4"/>
    <module name="JavadocMethod">
      <property name="excludeScope" value="private"/>
      <property name="allowMissingPropertyJavadoc" value="true"/>
      <property name="suppressLoadErrors" value="true"/>
    </module>
    <module name="JavadocType"/>
    <module name="JavadocVariable">
      <property name="severity" value="ignore"/>
      <metadata name="net.sf.eclipsecs.core.lastEnabledSeverity" value="inherit"/>
    </module>
    <module name="JavadocStyle"/>
    <module name="ConstantName"/>
    <module name="LocalFinalVariableName"/>
    <module name="LocalVariableName"/>
    <module name="MemberName"/>
    <module name="MethodName"/>
    <module name="PackageName"/>
    <module name="ParameterName"/>
    <module name="StaticVariableName"/>
    <module name="TypeName"/>
    <module name="AvoidStarImport"/>
    <module name="IllegalImport"/>
    <module name="RedundantImport"/>
    <module name="UnusedImports"/>
    <module name="LineLength">
      <property name="max" value="140"/>
      <property name="tabWidth" value="4"/>
    </module>
    <module name="MethodLength">
      <property name="severity" value="ignore"/>
      <metadata name="net.sf.eclipsecs.core.lastEnabledSeverity" value="inherit"/>
    </module>
    <module name="ParameterNumber"/>
    <module name="EmptyForIteratorPad"/>
    <module name="MethodParamPad"/>
    <module name="NoWhitespaceAfter">
      <property name="tokens" value="BNOT,DEC,DOT,INC,LNOT,UNARY_MINUS,UNARY_PLUS"/>
    </module>
    <module name="NoWhitespaceBefore"/>
    <module name="OperatorWrap"/>
    <module name="ParenPad"/>
    <module name="TypecastParenPad"/>
    <module name="WhitespaceAfter"/>
    <module name="WhitespaceAround"/>
    <module name="ModifierOrder"/>
    <module name="RedundantModifier"/>
    <module name="AvoidNestedBlocks"/>
    <module name="EmptyBlock"/>
    <module name="LeftCurly"/>
    <module name="NeedBraces"/>
    <module name="RightCurly"/>
    <module name="AvoidInlineConditionals">
      <property name="severity" value="ignore"/>
      <metadata name="net.sf.eclipsecs.core.lastEnabledSeverity" value="inherit"/>
    </module>
    <module name="EmptyStatement"/>
    <module name="EqualsHashCode"/>
    <module name="HiddenField">
      <property name="tokens" value="VARIABLE_DEF"/>
    </module>
    <module name="IllegalInstantiation"/>
    <module name="InnerAssignment"/>
    <module name="MagicNumber">
      <property name="severity" value="ignore"/>
      <metadata name="net.sf.eclipsecs.core.lastEnabledSeverity" value="inherit"/>
    </module>
    <module name="MissingSwitchDefault"/>
    <module name="RedundantThrows">
      <property name="suppressLoadErrors" value="true"/>
    </module>
    <module name="SimplifyBooleanExpression"/>
    <module name="SimplifyBooleanReturn"/>
    <module name="DesignForExtension">
      <property name="severity" value="ignore"/>
      <metadata name="net.sf.eclipsecs.core.lastEnabledSeverity" value="inherit"/>
    </module>
    <module name="FinalClass"/>
    <module name="HideUtilityClassConstructor"/>
    <module name="InterfaceIsType"/>
    <module name="VisibilityModifier">
      <property name="protectedAllowed" value="true"/>
    </module>
    <module name="ArrayTypeStyle"/>
    <module name="FinalParameters"/>
    <module name="TodoComment">
      <property name="severity" value="ignore"/>
      <metadata name="net.sf.eclipsecs.core.lastEnabledSeverity" value="inherit"/>
    </module>
    <module name="UpperEll"/>
  </module>
  <module name="JavadocPackage">
    <property name="severity" value="ignore"/>
    <metadata name="net.sf.eclipsecs.core.lastEnabledSeverity" value="inherit"/>
  </module>
  <module name="NewlineAtEndOfFile">
    <property name="severity" value="ignore"/>
    <metadata name="net.sf.eclipsecs.core.lastEnabledSeverity" value="inherit"/>
  </module>
  <module name="Translation"/>
  <module name="FileLength"/>
  <module name="FileTabCharacter">
    <property name="severity" value="ignore"/>
    <metadata name="net.sf.eclipsecs.core.lastEnabledSeverity" value="inherit"/>
  </module>
  <module name="RegexpSingleline">
    <property name="severity" value="ignore"/>
    <property name="format" value="\s+$"/>
    <property name="message" value="Line has trailing spaces."/>
    <metadata name="net.sf.eclipsecs.core.lastEnabledSeverity" value="inherit"/>
  </module>
</module>
