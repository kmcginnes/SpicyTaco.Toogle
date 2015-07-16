# Toogle

Feature toggling for mere mortals.

## Desired Use Cases

When testing the developer should have an easy way to set the feature flag's value.

```c#
public void TestForSomeAwesomeFeature()
{
    Toogles.Get<MyToogle>().ForceEnabled();
    // ... do some testing ...
}
```
