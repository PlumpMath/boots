Boots.app do
	stack :background => "mistyrose" do
		@p = self.para "Hello!"
		@p.text = @p.text + " World! \\n It is on!	\\nand on and on..."
	
		button "Push me", :width => 0.5 do
			para ask "what"
		end
		
		button "Push me too" do
			alert "smooth"
		end
	end
end

