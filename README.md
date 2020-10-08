# CleanView
Clean view is a wrapper for MainLayout for blazor project. As it has customizable components, a wrapper allows easier definition than a replacing MainLayout.


![alt text](https://user-images.githubusercontent.com/8317299/95468150-f21d1200-09c9-11eb-8d77-3bb0239212c9.png)

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
<CleanLayout CopyrightOwner="<Your Name>" CopyrightStart="1936">
    <HeaderCenter>
        <AppHeader />
    </HeaderCenter>
    <LeftMenuPanel>
        <NavMenuLeft />
    </LeftMenuPanel>
    <LeftIcon>
        <span class="oi oi-grid-three-up text-shadow" aria-hidden="true"></span>
    </LeftIcon>
    <RightIcon>
        <span class="oi oi-cog text-shadow" aria-hidden="true"></span>
    </RightIcon>
    <RightMenuPanel>
        <NavMenuRight />
    </RightMenuPanel>
    <Content>
        @Body
    </Content>
</CleanLayout>

```

### NavPanel's 
- NavPanelMenuItems can contain NavPanelMenuItems allowing for nested menu structure.
- NavPanelMenuItems can be treated like anchor elements. Attributes are splattered to the anchor. If css classes are used be aware they will override the default class applied.


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

### BackgroundSetter
- Placing this item on a page will set the background image on initialization.

```

<BackgroundSetter Url="background.jpg" FootNote="Image by Luc Tribolet - unsplash.com" />

```