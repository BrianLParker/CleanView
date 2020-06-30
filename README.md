# CleanView
Clean view is a wrapper for MainLayout for blazor project. As it has customizable components, a wrapper allows easier definition than a replacing MainLayout.

## You need to:
1. Import the styles from "_content/CleanView/styles.css"
2. Add a using statement to _Imports.razor
3. Update your MainLayour razor to use the wapper.

## Index.html or _Host.cshtml

```
<head>
    ...
    <link href="_content/CleanView/styles.css" rel="stylesheet" />
</head>

```

## _Imports.razor

```
@using CleanView
```


## MainLayout.razor

```
@inherits LayoutComponentBase
<CleanLayout CopyrightOwner="<Your Name>">
    <HeaderCenter>
    </HeaderCenter>

    <LeftMenuPanel>

        <div class="m-0 text-dark p-2 bg-white">

            <NavPanel>
                <NavPanelMenuItem Name="Home" Icon="oi-home" href="" />
                <NavPanelMenuItem Name="Counter" Icon="oi-plus" href="counter" />
                <NavPanelMenuItem Name="Fetch data" Icon="oi-list-rich" href="fetchdata" />
            </NavPanel>

        </div>

    </LeftMenuPanel>
    <LeftIcon>
        <span class="oi oi-grid-three-up text-shadow" aria-hidden="true"></span>
    </LeftIcon>
    <RightIcon>
        <span class="oi oi-cog text-shadow" aria-hidden="true"></span>
    </RightIcon>
    <RightMenuPanel>

        <div class="m-0 text-dark p-2 bg-white">
            <NavPanel>
                <LoginDisplay/>
            </NavPanel>
        </div>

    </RightMenuPanel>
    <Content>
        @Body
    </Content>
</CleanLayout>

```

### Note: 
- NavPanelMenuItems can contain NavPanelMenuItems allowing for nested menu structure.
- NavPanelMenuItems can be treated like anchor ```<a />``` elements. Attributes are splattered to the anchor. If css classes are used be aware they will override the default class applied.


```
<NavPanel>

    <NavPanelMenuItem Name="Home" Icon="oi-home" href="" />
    <NavPanelMenuItem Name="Sub Menu" Icon="">
        <NavPanelMenuItem Name="Counter" Icon="oi-plus" href="counter" />
        <AuthorizeView>
            <NavPanelMenuItem Name="Fetch data" Icon="oi-list-rich" href="fetchdata" />
            <NavPanelMenuItem Name="Log out" Icon="oi-account-logout" @onclick="BeginSignOut" />
        </AuthorizeView>
    </NavPanelMenuItem> 
    
</NavPanel>

```
