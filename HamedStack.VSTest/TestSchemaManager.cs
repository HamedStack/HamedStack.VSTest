// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Global

using System.Xml.Serialization;
using Schemas.VisualStudio.TeamTest;

namespace HamedStack.VSTest;

/// <summary>
/// A utility class for managing XML schema conversion operations.
/// </summary>
public static class TestSchemaManager
{
    /// <summary>
    /// Converts a test XML string (TRX) to a TestRunType object.
    /// </summary>
    /// <param name="testRunXml">The XML string representing the TestRun.</param>
    /// <returns>
    /// A TestRunType object if the conversion is successful; otherwise, null.
    /// </returns>
    /// <remarks>
    /// This method deserializes the provided XML string into a TestRunType object.
    /// </remarks>
    public static TestRunType? ConvertToTestRun(string testRunXml)
    {
        var serializer = new XmlSerializer(typeof(TestRunType));
        using TextReader reader = new StringReader(testRunXml);
        return serializer.Deserialize(reader) as TestRunType;
    }
}
