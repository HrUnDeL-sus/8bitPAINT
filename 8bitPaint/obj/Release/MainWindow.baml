   M S B A M L   `   `   `  ���� D  @8bitPaint, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:_8bitPaint
_8bitPaint      _8bitPaint.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:_8bitPaint     -     �Name$  myWindow�� � Title$ 
MainWindow��$	��720��$
��1280�� � WindowState$ 	Maximized=�.��� -    �Name$ Texts�� � RowDefinitions �� $��20 ��� .+�o� $��0��.@�m� $��Файл��.@�m� -   $��Создать файл��m� -   $!��Сохранить файл��m� -   $��Отрыть файл��m� -   $��Настройки���� $��1��.@��� $��
Холст��.���  � ColumnDefinitions �� $	��400 ��� $
��845* ��� $	��300 �.+��� 
���   �$��1q�._��� -    ��Name$ LeftStackPanel��$��0��.+��� .+��� -   $��WrapPanelLayers��$��Center=�$	��112��.��� -	    �Name$ LayerWrapPanel�� � Orientation$ Vertical=�$��Center=��� -
   	 ��Name$	 AddLayer_Button��$��Добавить слой��$	��291��$��61���� -   
 ��Name$
 OptionLayer��$��71��.@��� $��Настройки��.���� -   $ LocalLayerOptions��.+���  �� Orientation$ 
Horizontal=�$��34��.+��� -   $	 DeleteLayer_Button��$��Удалить слой��
 � Tag$ layer���� -   $	 MoveLayerlicked_Button��$%��Поменять местами��$ layer���� -   $	 СoppyLayerClicked_Button��$#��Копировать слой��$ layer���� -   $	 UniteLayerClicked_Button��$#��Объединить слой��$ layer���� $#��Общие настройки��.���� -   $ GlobalLayerptions��$ Vertical=�.+��� $ 
Horizontal=�.+��� $��Прозрачность:���� -    ��Name$ OpastyLayerScrollBar�� � Maximum$ 1Q� � Minimum$ 0Q� � Value$ 0Q� �� Orientation$ 
Horizontal=�$	��286���� ���� *Value+ �� ElementName$ OpastyLayerScrollBar���� $ 
Horizontal=�.+��� $@��:Активный только выбранный слой:���� -    d� 	IsChecked$ FalseY�   _8bitPaint.MyPalytre  -     Name$ Palytre1��$	��324���� $��2��
���   �$��1q�._��� -   $ RightStackPanel��$��2��.+��� .+��� -   $��WrapPanelFrames��$��Center=�$��1��$	��384��.��� -   $ FramesWrapPanel��$ Vertical=�$��Center=��� -   $��Добавить кадр��$��50��$��Center=�$	��278��$
��10,0q��� -   $��StartBtn��$��
Старт��$��50��$	��Top=�$��Right=�$	��128��$��0,8,32,0q��� $#��Перейти к кадру:��$��
134,8,67,0q�$��20���� -    ��Name$ GotoText��$��432,-20,-134,8q�$��20���� -   $��\/��$��20��$	��Top=�$��Right=�$��20��$��	0,-28,8,0q��� -   $	��FPS��$��125,-4,46,8q�$��20���� $	��fps��$��254,-28,23,8q�$��20���� -    ��Name$ 	Animation��$��22,-112, 0,8q�$	��103��$	��103��$��Uniform=� �� EdgeMode$ Aliased=� �� BitmapScalingMode$ NearestNeighbor=�$
��Left=��� -   $
 OptionFrames��$��74��.@��� $��Настройки��.���� -   $ LocalFrameOptions��.+��� $ 
Horizontal=�$��34��.+��� -    $	 DeleteFrame_Button��$��Удалить кадр��$ frame��$��76���� -!   $	 MoveFrameClicked_Button��$%��Поменять местами��$ frame��$	��114���� -"   $	 СoppyFrameClicked_Button��$#��Копировать кадр��$ frame��$	��102���� $#��Общие настройки��.���� -#   $ GlobalFrameOptions��$ Vertical=�.+��� $ 
Horizontal=�.+��� $��Прозрачность:���� -$   $ OpastyFrameScrollBar��$ 1Q�$ 0Q�$ 0Q�$ 
Horizontal=�$	��185��$��13���� ���� *Value+$ OpastyLayerScrollBar���� -%   $ CenterStackPanel��$��1��$ Vertical=�.+��� $	��150��.+��� 
���   �$��1q�$	��150��$��-1,0,0,0q�._��� -&   $ InstrumentsStackPanel��$ Vertical=�$��	0,-1,-1,1q�.+��� $ 
Horizontal=�$��62��.+��� -'   $ pencil��$��
pencil.png��$ 0���� -(   $ erarce��$��
eraser.png��$ 1���� -)   $
 fill��$��color_fill.png��$ 2���� -*   $
 hand��$��hand.png��$ 3���� -+   $ dropper��$��pipetka.png��$ 4���� -,   $ selected��$��selected.png��$ 5���� $ 
Horizontal=�.+��� $��Пиксели:��$��24(��� --   $ CountPixels�� �� AcceptsReturn .  $��24(�$��1��$��20��$��43���� -.   $ PixelsScrool��$ 
Horizontal=�$ 1Q�$
��Left=�$	��240��$��24���� $ 
Horizontal=�.+��� -/   $ ReturnPixelsBack��$��	arrow.png��$��32��$��32�� J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� �� ��  �� Angle$	 180Q�T� �� -0   $ ReturnPixelsUp��$��	arrow.png��$��32��$��32���� -1   $��WrapPanelBackup��$��Center=�$	��720��$y�Visible=�.��R� -2    R�Name$ BackupWrapPanel��$��100000���� -3   $��WrapPanelCenterCanvas��$��1��$	��720��.���� -4   $��CenterCanvas��$y�	Collapsed=�}�. .+��� -5    ��Name$ DrawCanvasPanel��$
��1206��$	��800��.+��� -6   $ MainDrawCanvas��.+��� -7   $ 
Background��$��fon.png��$	��128��$��64��$��UniformToFill=�$ Aliased=�$ NearestNeighbor=��� -8   $ 	PrevFrame��$	��128��$��64��$��UniformToFill=�$ Aliased=�$ NearestNeighbor=��� -9   $ 	MainPanel��   _8bitPaint.MyCell  -:     Name$ CellBG��$��8��$��8�� J� IsHitTestVisible .  �� $��База данных��.��]� ��. .+��� 
���   �$��1q�._��� -;   $ LeftPanelBD��$
��Left=�$	��249��.+��� -<     ��Name$  CategoriesScrollViewer��$	��640��.��� $��10000000��.+��� -=   $ CategoriesWrapPanel��$	��232���� 
���   �$	��Top=�$��1q�._��� ->   $��ConnectionAndPublishPanel��.+��� $ 
Horizontal=�.+��� $"��Название файла:���� -?   $��TextBoxFileNamePublish��$��62���� $
��.bin���� $ 
Horizontal=�.+��� $:��4Уникальный айди файла файла:���� -@   $��TextBoxFileId��$��62���� -A   $'��!Опубликовать файл��$	��120��$
��Left=��� $��Обновить файл��$	��120��$
��Left=��� $��Удалить файл��$	��120��$
��Left=��� $ 
Horizontal=�.+��� $*��$Строка подключения:���� -B   $ Addres��$N��Hhttp://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/Service1/��$	��150��$	��250���� -C   $	 ConnectButton��$��Подключиться���� -D   $ StateConnection��! �� TextWrapping$
! Wrap=�$��12(�$��51��� -E   " �Name$" ProgressBarLoadBD��$��10���� -F   $ CenterPanelBD��$��Bottom=�.+��� -G   $  AllPictureinBD��$	��539��.��� -H   $ WrapPanelPuctiresList��$��100000��