# XamarinAutofac
Using Autofac DI/IoC Container in Xamarin.Forms iOS &amp; Android and Windows 10 UWP Version 2004, Build 19041.

## UPDATE 2021
Upgrade to using `Xamarin.Forms 5.0.0.2012` and latest `Autofac 6.2.0`.

``` xml
  <ItemGroup>
    <PackageReference Include="Autofac" Version="6.2.0" />
    <PackageReference Include="Autofac.Extras.CommonServiceLocator" Version="6.0.1" />
    <PackageReference Include="SomeExternalServices" Version="1.0.0" />
    <PackageReference Include="Xamarin.Forms" Version="5.0.0.2012" />
    <PackageReference Include="Xamarin.Essentials" Version="1.6.1" />
  </ItemGroup>
```

## UPDATE 2017
Added the **MobileClient.UWP** for Windows 10 Fall Creators Update. Must install **Windows 10 SDK (16299.15)**. Here is the ```.csproj``` for the UWP project:

``` xml
  <ItemGroup>
    <PackageReference Include="Autofac">
      <Version>4.6.2</Version>
    </PackageReference>
    <PackageReference Include="Autofac.Extras.CommonServiceLocator">
      <Version>5.0.0</Version>
    </PackageReference>
    <PackageReference Include="CommonServiceLocator">
      <Version>2.0.1</Version>
    </PackageReference>
    <PackageReference Include="Microsoft.NETCore.UniversalWindowsPlatform">
      <Version>6.0.1</Version>
    </PackageReference>
    <PackageReference Include="SomeExternalServices">
      <Version>1.0.0</Version>
    </PackageReference>
    <PackageReference Include="Xamarin.Forms">
      <Version>2.4.0.282</Version>
    </PackageReference>
  </ItemGroup>
```

Youtube: [Demo of this source code](https://www.youtube.com/watch?v=ICjKv-N8ILU)

Twitter: [@rizamarhaban](https://twitter.com/rizamarhaban)
