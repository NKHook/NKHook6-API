target_sources(${CMAKE_PROJECT_NAME} PRIVATE 
    "BTDModStart.cs"
    "Extensions.cs"
)
add_subdirectory(Bloons)
add_subdirectory(Events)
add_subdirectory(Game)
add_subdirectory(Map)
add_subdirectory(Properties)
add_subdirectory(Registry)
add_subdirectory(Towers)