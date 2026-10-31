using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CapaPresentacion
{
    internal class Cl_EstiloBotones
    {
        public static void Aplicar(Button boton, int radio = 16)
        {
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.Cursor = Cursors.Hand;

            GraphicsPath ruta = new GraphicsPath();

            ruta.StartFigure();

            ruta.AddArc(
                0,
                0,
                radio,
                radio,
                180,
                90);

            ruta.AddArc(
                boton.Width - radio,
                0,
                radio,
                radio,
                270,
                90);

            ruta.AddArc(
                boton.Width - radio,
                boton.Height - radio,
                radio,
                radio,
                0,
                90);

            ruta.AddArc(
                0,
                boton.Height - radio,
                radio,
                radio,
                90,
                90);

            ruta.CloseFigure();

            boton.Region = new Region(ruta);

            boton.FlatAppearance.MouseOverBackColor =
                ControlPaint.Light(boton.BackColor);

            boton.FlatAppearance.MouseDownBackColor =
                ControlPaint.Dark(boton.BackColor);
        }

        public static void AplicarVarios(
            params Button[] botones)
        {
            foreach (Button boton in botones)
            {
                Aplicar(boton);
            }
        }
    }
}