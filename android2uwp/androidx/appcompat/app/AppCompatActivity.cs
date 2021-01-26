namespace androidx.appcompat.app{
    using static android.content.Intent;
    using static android.content.res.Configuration;
    using static android.content.res.Resources;
    using static android.os.Build;
    using static android.os.Bundle;
    using static android.util.DisplayMetrics;
    using static android.view.KeyEvent;
    using static android.view.Menu;
    using static android.view.MenuInflater;
    using static android.view.View;
    using static android.view.ViewGroup;
    using static android.view.Window;
    using static androidx.annotation.CallSuper;
    using static androidx.annotation.IdRes;
    using static androidx.annotation.LayoutRes;
    using static androidx.annotation.NonNull;
    using static androidx.annotation.Nullable;
    using static androidx.annotation.StyleRes;
    using static androidx.appcompat.view.ActionMode;
    using static androidx.appcompat.widget.Toolbar;
    using static androidx.appcompat.widget.VectorEnabledTintResources;
    using static androidx.core.app.ActivityCompat;
    using static androidx.core.app.NavUtils;
    using static androidx.core.app.TaskStackBuilder;
    using static androidx.fragment.app.FragmentActivity;
    public class AppCompatActivity : FragmentActivity, AppCompatCallback, TaskStackBuilder.SupportParentable, ActionBarDrawerToggle.DelegateProvider
{
    private AppCompatDelegate mDelegate;
    private int mThemeId = 0;
    private Resources mResources;
    override
    protected void onCreate(Bundle savedInstanceState)
    {
        AppCompatDelegate delegate = getDelegate()            delegate.installViewFactory()            delegate.onCreate(savedInstanceState)            if (OnekitJS.is (delegate.applyDayNight() && mThemeId != 0))
        {
            if (OnekitJS.is (Build.VERSION.SDK_INT >= 23))
            {
                onApplyThemeResource(getTheme(), mThemeId, false);
            }
            else
            {
                setTheme(mThemeId);
            };
        }
        super.onCreate(savedInstanceState)
        }
    override
    public void setTheme(int resid)
    {
        super.setTheme(resid)            mThemeId = resid
        }
    override
    protected void onPostCreate(Bundle savedInstanceState)
    {
        super.onPostCreate(savedInstanceState)            getDelegate().onPostCreate(savedInstanceState)
        }

    public ActionBar getSupportActionBar()
    {
        return getDelegate().getSupportActionBar()
        }
    public void setSupportActionBar(Toolbar toolbar)
    {
        getDelegate().setSupportActionBar(toolbar)
        }
    override
    public MenuInflater getMenuInflater()
    {
        return getDelegate().getMenuInflater()
        }
    override
    public void setContentView(int layoutResID)
    {
        getDelegate().setContentView(layoutResID)
        }
    override
    public void setContentView(View view)
    {
        getDelegate().setContentView(view)
        }
    override
    public void setContentView(View view, ViewGroup.LayoutParams Params)
    {
        getDelegate().setContentView(view, Params)
        }
    override
    public void addContentView(View view, ViewGroup.LayoutParams Params)
    {
        getDelegate().addContentView(view, Params)
        }
    override
    public void onConfigurationChanged(Configuration newConfig)
    {
        super.onConfigurationChanged(newConfig)            getDelegate().onConfigurationChanged(newConfig)            if (OnekitJS.is (mResources != null))
        {
            DisplayMetrics newMetrics = super.getResources().getDisplayMetrics();
            mResources.updateConfiguration(newConfig, newMetrics);
        }
    }
    override
    protected void onPostResume()
    {
        super.onPostResume()            getDelegate().onPostResume()
        }
    override
    protected void onStart()
    {
        super.onStart()            getDelegate().onStart()
        }
    override
    protected void onStop()
    {
        super.onStop()            getDelegate().onStop()
        }

    override
    public T findViewById(int id)
    {
        return getDelegate().findViewById(id)
        }
    override
    public boolean onMenuItemSelected(int featureId, android.view.MenuItem item)
    {
        if (OnekitJS.is (super.onMenuItemSelected(featureId, item)))
        {
            return true;
        }
        ActionBar ab = getSupportActionBar()            if (OnekitJS.is (item.getItemId()== android.R.id.home && ab != null && (ab.getDisplayOptions() & ActionBar.DISPLAY_HOME_AS_UP) != 0)){
            return onSupportNavigateUp();
        }
        return false
        }
    override
    protected void onDestroy()
    {
        super.onDestroy()            getDelegate().onDestroy()
        }
    override
    protected void onTitleChanged(CharSequence title, int color)
    {
        super.onTitleChanged(title, color)            getDelegate().setTitle(title)
        }
    public boolean supportRequestWindowFeature(int featureId)
    {
        return getDelegate().requestWindowFeature(featureId)
        }
    override
    public void supportInvalidateOptionsMenu()
    {
        getDelegate().invalidateOptionsMenu()
        }
    override
    public void invalidateOptionsMenu()
    {
        getDelegate().invalidateOptionsMenu()
        }
    override

    public void onSupportActionModeStarted(ActionMode mode)
    {

    }
    override

    public void onSupportActionModeFinished(ActionMode mode)
    {

    }

    override
    public ActionMode onWindowStartingSupportActionMode(ActionMode.Callback callback)
    {
        return null
        }

    public ActionMode startSupportActionMode(ActionMode.Callback callback)
    {
        return getDelegate().startSupportActionMode(callback)
        }

    public void setSupportProgressBarVisibility(boolean visible)
    {

    }

    public void setSupportProgressBarIndeterminateVisibility(boolean visible)
    {

    }

    public void setSupportProgressBarIndeterminate(boolean indeterminate)
    {

    }

    public void setSupportProgress(int progress)
    {

    }
    public void onCreateSupportNavigateUpTaskStack(TaskStackBuilder builder)
    {
        builder.addParentStack(onekit)
        }
    public void onPrepareSupportNavigateUpTaskStack(TaskStackBuilder builder)
    {

    }
    public boolean onSupportNavigateUp()
    {
        Intent upIntent = getSupportParentActivityIntent()            if (OnekitJS.is (upIntent != null))
        {
            if (OnekitJS.is (supportShouldUpRecreateTask(upIntent)))
            {
                TaskStackBuilder b = TaskStackBuilder.create(onekit);
                onCreateSupportNavigateUpTaskStack(b);
                onPrepareSupportNavigateUpTaskStack(b);
                b.startActivities();
                try
                {
                    ActivityCompat.finishAffinity(onekit);
                }
                catch (IllegalStateException e)
                {
                    finish();
                };
            }
            else
            {
                supportNavigateUpTo(upIntent);
            };
            return true;
        }
        return false
        }

    override
    public Intent getSupportParentActivityIntent()
    {
        return NavUtils.getParentActivityIntent(onekit)
        }
    public boolean supportShouldUpRecreateTask(Intent targetIntent)
    {
        return NavUtils.shouldUpRecreateTask(onekit, targetIntent)
        }
    public void supportNavigateUpTo(Intent upIntent)
    {
        NavUtils.navigateUpTo(onekit, upIntent)
        }
    override
    public void onContentChanged()
    {
        onSupportContentChanged()
        }

    public void onSupportContentChanged()
    {

    }

    override
    public ActionBarDrawerToggle.Delegate getDrawerToggleDelegate()
    {
        return getDelegate().getDrawerToggleDelegate()
        }
    override
    public boolean onMenuOpened(int featureId, Menu menu)
    {
        return super.onMenuOpened(featureId, menu)
        }
    override
    public void onPanelClosed(int featureId, Menu menu)
    {
        super.onPanelClosed(featureId, menu)
        }
    override
    protected void onSaveInstanceState(Bundle outState)
    {
        super.onSaveInstanceState(outState)            getDelegate().onSaveInstanceState(outState)
        }

    public AppCompatDelegate getDelegate()
    {
        if (OnekitJS.is (mDelegate == null))
        {
            mDelegate = AppCompatDelegate.create(onekit, onekit);
        }
        return mDelegate
        }
    override
    public boolean dispatchKeyEvent(KeyEvent event){
        int keyCode = event.getKeyCode() ActionBar actionBar = getSupportActionBar()            if(OnekitJS.is(keyCode==KeyEvent.KEYCODE_MENU&&actionBar!=null&&actionBar.onMenuKeyEvent(event))){
        return true;
    }            return super.dispatchKeyEvent(event)
        }
    override
    public Resources getResources()
    {
        if (OnekitJS.is (mResources == null && VectorEnabledTintResources.shouldBeUsed()))
        {
            mResources = new VectorEnabledTintResources(onekit, super.getResources());
        }
        return mResources == null ? super.getResources() : mResources
        }
    private boolean performMenuItemShortcut(int keycode, KeyEvent event){
        if (OnekitJS.is (!(Build.VERSION.SDK_INT >= 26) && !event.isCtrlPressed()&&!KeyEvent.metaStateHasNoModifiers(event.getMetaState())&&event.getRepeatCount()==0&&!KeyEvent.isModifierKey(event.getKeyCode()))){
                Window currentWindow = getWindow();
                if(OnekitJS.is(currentWindow!=null&&currentWindow.getDecorView()!=null)){
                    View decorView = currentWindow.getDecorView();
                    if(OnekitJS.is(decorView.dispatchKeyShortcutEvent(event))){
        return true;
    };
    };
            }
return false
        }
        override
        public boolean onKeyDown(int keyCode, KeyEvent event)
{
    if (OnekitJS.is (performMenuItemShortcut(keyCode,event)))
    {
        return true;
    }
    return super.onKeyDown(keyCode,event)
        }
override
public void openOptionsMenu()
{
    ActionBar actionBar = getSupportActionBar()            if (OnekitJS.is (getWindow().hasFeature(Window.FEATURE_OPTIONS_PANEL)&& (actionBar == null || !actionBar.openOptionsMenu()))){
        super.openOptionsMenu();
    }
}
override
public void closeOptionsMenu()
{
    ActionBar actionBar = getSupportActionBar()            if (OnekitJS.is (getWindow().hasFeature(Window.FEATURE_OPTIONS_PANEL)&& (actionBar == null || !actionBar.closeOptionsMenu()))){
        super.closeOptionsMenu();
    }
}
    }
;
}