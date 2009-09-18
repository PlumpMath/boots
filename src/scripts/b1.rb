Boots.app do
	#stack :background => "mistyrose" do
		#@p = self.para strong("Hello!")
		#@p.text = @p.text + " World! \\n It is on!	\\n"
		#@p.text = @p.text + strong(del("and on and on..."))
	
		#button "Push me", :width => 0.5 do
			#para ask "what"
		#end
		
		#button "Push me too" do
			#alert "smooth"
		#end
	#end
	stack :background => "red", :height => 0.5, :width => 0.5 do
	end
	stack :background => "yellow", :height => 0.5, :width => 0.5 do
	end
	stack :background => "blue", :height => 0.5, :width => 0.5 do
	end
	stack :background => "green", :height => 0.5, :width => 0.5 do
	end
end