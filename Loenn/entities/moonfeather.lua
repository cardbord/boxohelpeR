local drawableSprite = require("structs.drawable_sprite")
local utils = require("utils")
local moonfeather = {}

moonfeather.name = "boxohelpeR/moonFeather"
moonfeather.depth = 0

moonfeather.placements = {}

function moonfeather.draw(room, entity)
    local x,y = entity.x or 0, entity.y or 0
    local texture = "moonfeather"

    local moonfeatherSprite = {drawableSprite.fromTexture(texture, {x=x,y=y})}
    
    if entity.shielded then
        love.graphics.circle("line",entity.x, entity.y, 12)
    end

    moonfeatherSprite::draw()
end

function moonfeather.selection(room,entity)
    return utils.rectangle(entity.x -12, entity.y - 12, 24, 24)
end

return moonfeather