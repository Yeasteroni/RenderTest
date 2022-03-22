﻿namespace RenderTest.Vec

type RGB = byte Vec3

module RGB =
    let inline make r g b = {
        X = r
        Y = g
        Z = b
    }
    let b255 = byte 255
    let b0 = byte 0
    let red = make b255 b0 b0
    let green = make b0 b255 b0
    let blue = make b0 b0 b255
    let black = make b0 b0 b0
    let inline r rgb = rgb.X
    let inline g rgb = rgb.Y
    let inline b rgb = rgb.Z
    let inline int32 rgb =
        let r = r rgb |> int <<< 16
        let g = g rgb |> int <<< 8
        let b = b rgb |> int
        r ||| g ||| b