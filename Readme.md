# Toogle

Feature toggling for mere mortals.

## Desired Use Cases

__Testing__
When testing the developer should have an easy way to set the feature flag's value.

```c#
public void TestForSomeAwesomeFeature()
{
    Toogles.Get<MyToogle>().ForceEnabled();
    // ... do some testing ...
}
```

__Consuming__
When consuming the toogle values they should be easy to get, either through injection or statically.

```c#
public class Foo
{
    readonly IToogle _toogle;

    public Foo(IToogle toogle)
    {
        _toogle = toogle;
    }

    public void Bar()
    {
        if(_toogle.Get<MyToogle>().IsEnabled())
        {
            // Do stuffs when enabled
        }
        else
        {
            // Do other stuffs when disabled
        }
    }
}
```

Or we can get the toogle directly

```c#
public class Foo
{
    readonly MyToogle _toogle;

    public Foo(MyToogle toogle)
    {
        _toogle = toogle;
    }

    public void Bar()
    {
        if(_toogle.IsEnabled())
        {
            // Do stuffs when enabled
        }
        else
        {
            // Do other stuffs when disabled
        }
    }
}
```

Or we can get the toogle from a static class

```c#
public class Foo
{
    public void Bar()
    {
        if(Toogles.Get<MyToogle>().IsEnabled())
        {
            // Do stuffs when enabled
        }
        else
        {
            // Do other stuffs when disabled
        }
    }
}
```
