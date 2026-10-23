using IgBlazorSamples.Test;

namespace SettingsTests;

[TestFixture]
public class TestSettingsTests
{
    [Test]
    [Category("SettingsTest")]
    public void AllSettingsEntriesAreUsed()
    {
        var unusedEntries = TestUtils.GetUnusedSettingsEntries();

        if (unusedEntries.Count > 0)
        {
            Assert.Warn($"The following testsettings.json entries are not used:\n{string.Join("\n", unusedEntries)}");
        }
    }
}
