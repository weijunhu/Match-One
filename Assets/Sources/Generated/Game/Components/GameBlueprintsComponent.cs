//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity blueprintsEntity { get { return GetGroup(GameMatcher.Blueprints).GetSingleEntity(); } }
    public BlueprintsComponent blueprints { get { return blueprintsEntity.blueprints; } }
    public bool hasBlueprints { get { return blueprintsEntity != null; } }

    public GameEntity SetBlueprints(Entitas.Blueprints.Unity.Blueprints newValue) {
        if(hasBlueprints) {
            throw new Entitas.EntitasException("Could not set Blueprints!\n" + this + " already has an entity with BlueprintsComponent!",
                "You should check if the context already has a blueprintsEntity before setting it or use context.ReplaceBlueprints().");
        }
        var entity = CreateEntity();
        entity.AddBlueprints(newValue);
        return entity;
    }

    public void ReplaceBlueprints(Entitas.Blueprints.Unity.Blueprints newValue) {
        var entity = blueprintsEntity;
        if(entity == null) {
            entity = SetBlueprints(newValue);
        } else {
            entity.ReplaceBlueprints(newValue);
        }
    }

    public void RemoveBlueprints() {
        DestroyEntity(blueprintsEntity);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public BlueprintsComponent blueprints { get { return (BlueprintsComponent)GetComponent(GameComponentsLookup.Blueprints); } }
    public bool hasBlueprints { get { return HasComponent(GameComponentsLookup.Blueprints); } }

    public void AddBlueprints(Entitas.Blueprints.Unity.Blueprints newValue) {
        var index = GameComponentsLookup.Blueprints;
        var component = CreateComponent<BlueprintsComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceBlueprints(Entitas.Blueprints.Unity.Blueprints newValue) {
        var index = GameComponentsLookup.Blueprints;
        var component = CreateComponent<BlueprintsComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveBlueprints() {
        RemoveComponent(GameComponentsLookup.Blueprints);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherBlueprints;

    public static Entitas.IMatcher<GameEntity> Blueprints {
        get {
            if(_matcherBlueprints == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Blueprints);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherBlueprints = matcher;
            }

            return _matcherBlueprints;
        }
    }
}
