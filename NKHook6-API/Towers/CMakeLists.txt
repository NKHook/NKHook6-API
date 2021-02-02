target_sources(${CMAKE_PROJECT_NAME} PRIVATE 
    "ITower.cs"
    "ITowerEntity.cs"
)
add_subdirectory(Projectiles)
add_subdirectory(Upgrades)
add_subdirectory(Weapons)