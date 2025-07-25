import uno

def set_classification():
    ctx = uno.getComponentContext()
    smgr = ctx.ServiceManager
    desktop = smgr.createInstanceWithContext("com.sun.star.frame.Desktop", ctx)
    model = desktop.getCurrentComponent()
    
    if not model:
        return

    # Příklad: vložení textu do začátku dokumentu
    try:
        text = model.Text
        cursor = text.createTextCursor()
        text.insertString(cursor, "[DŮVĚRNÉ]\n", False)
    except Exception as e:
        print("LabelMate error:", e)

# Povinný pro unopkg
def writeRegistryInfo(smgr, regKey):
    return True