target_sources(${CMAKE_PROJECT_NAME} PRIVATE 
    "Event.cs"
    "EventAttribute.cs"
    "EventBaseCancellable.cs"
    "KeyEvent.cs"
    "UnknownEventException.cs"
    "UpdateEvent.cs"
)
add_subdirectory(Bloons)
add_subdirectory(Game)
add_subdirectory(Player)
add_subdirectory(Projectile)
add_subdirectory(Towers)
add_subdirectory(Weapons)