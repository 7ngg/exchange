namespace Exchange.Entities.Exceptions;

public class MissingConfigurationException(string key)
    : Exception($"Missing required configurations: {key}") { }
