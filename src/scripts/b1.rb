require 'mscorlib' 
require 'System, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089' 
require 'C:\Dev\Projects\Boots\src\Boots.Library\bin\Debug\Boots.Library.dll'

Boots::Library::Boots.setup

@canvas = Boots::Library::Canvas.new

@p1 = Boots::Library::Elements::Para.new
@p1.text = "Hello!"
@p2 = Boots::Library::Elements::Para.new
@p2.text = "World!"

@canvas.AddControl @p1
@canvas.AddControl @p1

Boots::Library::Boots.run @canvas