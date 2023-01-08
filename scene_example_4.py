# Example 4

from draw2d import start_drawing, draw_oval, finish_drawing

def main():
    # Call the start_drawing function in the draw2d.py
    # library which will open a window and create a canvas.
    canvas = start_drawing("Rectangular Group", 600, 375)

    diameter = 15
    space = 5
    interval = diameter + space

    # Draw a rectangular series of circles.
    y = 100
    for row in range(6):
        x = 100
        for cell in range(20):
            draw_oval(canvas, x, y,
                    x + diameter, y + diameter, fill="orange")
            x += interval
        y += interval

    # Call the finish_drawing function
    # in the draw2d.py library.
    finish_drawing(canvas)

# Call the main function so that
# this program will start executing.
main()