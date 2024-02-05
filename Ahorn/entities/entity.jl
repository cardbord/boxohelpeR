module boxohelpeRmoonFeather

using ..Ahorn, Maple

@mapdef Entity "boxohelpeR/moonFeather" moonFeather(
    x::Integer, y::Integer,
    sampleProperty::Integer=0
)

const placements = Ahorn.PlacementDict(
    "moonFeather (boxohelpeR)" => Ahorn.EntityPlacement(
        moonFeather,
    )
)

sprite = "objects/boxohelpeR/moonFeather/idle00"

function Ahorn.selection(entity::moonFeather)
    x, y = Ahorn.position(entity)
    return Ahorn.getSpriteRectangle(sprite, x, y)
end

Ahorn.render(ctx::Ahorn.Cairo.CairoContext, entity::moonFeather, room::Maple.Room) = Ahorn.drawSprite(ct, sprite, 0, 0)

end