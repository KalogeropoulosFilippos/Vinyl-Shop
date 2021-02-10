Implemeneted using C#,ASP.NET FRAMEWORK,SIGNALR API and PAYPAL API.

First restore the database using the .bak file that you can find at: ~\OnlineShoppingStore\Database files
If you get the "~/bin/roslyn.exe does not exist" error then copy paste the following lines into the OnlineShopppingStore.csproj file


<Target Name="CopyRoslynFiles" AfterTargets="AfterBuild" Condition="!$(Disable_CopyWebApplication) And '$(OutDir)' != '$(OutputPath)'">
    <ItemGroup>
      <RoslynFiles Include="$(CscToolPath)\*" />
    </ItemGroup>
    <MakeDir Directories="$(WebProjectOutputDir)\bin\roslyn" />
    <Copy SourceFiles="@(RoslynFiles)" DestinationFolder="$(WebProjectOutputDir)\bin\roslyn" SkipUnchangedFiles="true" Retries="$(CopyRetryCount)" RetryDelayMilliseconds="$(CopyRetryDelayMilliseconds)" />
</Target>



