# Require cmake ver & create project
cmake_minimum_required(VERSION 3.17)
project(NKHook6-API VERSION 0.1.0 LANGUAGES CSharp)

# Create a .dll
add_library(NKHook6-API SHARED)

# Set the C# language version to 9
set_target_properties(NKHook6-API PROPERTIES VS_GLOBAL_LangVersion "9.0")

# Set configuration properties
set_property(TARGET ${CMAKE_PROJECT_NAME} PROPERTY VS_DOTNET_TARGET_FRAMEWORK_VERSION "v4.8")
set_property(TARGET ${CMAKE_PROJECT_NAME} PROPERTY WIN32_EXECUTABLE FALSE)
set_property(TARGET ${CMAKE_PROJECT_NAME} PROPERTY VS_CONFIGURATION_TYPE ClassLibrary)
set_property(TARGET ${CMAKE_PROJECT_NAME} PROPERTY VS_DOTNET_REFERENCES_COPY_LOCAL OFF)

# Add references
set_property(TARGET ${CMAKE_PROJECT_NAME} PROPERTY VS_DOTNET_REFERENCES "System.Numerics;System.Numerics.Vectors")

# Add sources
add_subdirectory(NKHook6-API)