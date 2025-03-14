# Font Assets

To use different fonts with TextMesh Pro, you need to create font assets. TextMesh Pro has its own font Asset format that is distinct from, but related to, [Unity's regular font Asset format](https://docs.unity3d.com/2019.1/Documentation/Manual/class-Font.html). You create TextMesh Pro font assets _from_ Unity font assets.

Every TextMesh Pro font Asset has two sub-Assets:

* **Font atlas:** a black and white or grayscale texture file that contains all of the characters included in the font Asset.<br/><br/>![](images/FontAtlasExample.png)<br/>_Example of a font atlas_
* **Font material:** a material that controls the appearance of TextMesh Pro text using one of the [TextMesh Pro shaders](Shaders.md).

Font assets must be in a specific folder so TextMesh Pro can find them and include them in builds. To change the default folder for font assets, got to the [TextMesh Pro settings](Settings.md) and set the **Default Font Asset > Path** option.

## Creating Font Assets

To create a TextMesh Pro font Asset, use the TexMesh Pro [Font Asset Creator](FontAssetsCreator.md).

You can also create an empty TextMesh Pro font Asset from the Unity main menu. An empty font asset does not contain any characters by default, you must add them later. To create an empty TextMesh Pro font asset, select a Unity font Asset and then select **Asset > Create > TextMeshPro > Font Asset** from the menu.

## Types of font atlas

Font Assets can have the following types of font atlas:

* **Distance Field:** This type of atlas contains [signed distance field (SDF)](FontAssetsSDF.md) information.<br/><br/>This is the recommended Font Asset type for most applications because SDF atlases produce text that is smooth when transformed.

* **Smooth/Hinted Smooth:** This type of atlas is an antialiased bitmap texture. A Hinted smooth atlas aligns glyph pixels with texture pixels to produce a smoother result.<br/><br/>Smooth atlases work well for static text that is viewed head on, in situations where there is a good correspondence between texture pixels and screen pixels. Transforming text generated from a smooth atlas blurs the text edges.

* **Raster/Raster Hinted:** Raster atlases are un-smoothed bitmap textures. They almost always produce text with jagged, pixellated edges. The Hinted rater atlases align glyph pixels with texture pixels to produce a smoother result.
